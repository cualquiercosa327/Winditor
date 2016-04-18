﻿using OpenTK;
using System.Collections.Generic;
using System;
using System.IO;
using OpenTK.Graphics.OpenGL;

namespace Editor
{
    struct WBatchedLine
    {
        public Vector3 Start;
        public Vector3 End;
        public WLinearColor Color;
        public float Thickness;
        public float RemainingLifetime;

        public WBatchedLine(Vector3 start, Vector3 end, WLinearColor color, float thickness, float lifetime)
        {
            Start = start;
            End = end;
            Color = color;
            Thickness = thickness;
            RemainingLifetime = lifetime;
        }
    }

    class WLineBatcher : PrimitiveComponent
    {
        private List<WBatchedLine> m_batchedLines;

        private Shader m_primitiveShader;
        private int m_vbo;

        public WLineBatcher()
        {
            m_batchedLines = new List<WBatchedLine>();

            m_primitiveShader = new Shader("UnlitColor");
            m_primitiveShader.CompileSource(File.ReadAllText("Editor/Shaders/UnselectedCollision.vert"), ShaderType.VertexShader);
            m_primitiveShader.CompileSource(File.ReadAllText("Editor/Shaders/UnselectedCollision.frag"), ShaderType.FragmentShader);
            m_primitiveShader.LinkShader();

            // Allocate our buffers now as they get reused a lot.
            m_vbo = GL.GenBuffer();
        }

        public void DrawLine(Vector3 start, Vector3 end, WLinearColor color, float thickness, float lifetime)
        {
            m_batchedLines.Add(new WBatchedLine(start, end, color, thickness, lifetime));

            MarkRenderStateAsDirty();
        }

        public override void Tick(float deltaTime)
        {
            bool dirty = false;
            for(int lineIndex = 0; lineIndex < m_batchedLines.Count; lineIndex++)
            {
                WBatchedLine line = m_batchedLines[lineIndex];
                if(line.RemainingLifetime > 0)
                {
                    line.RemainingLifetime -= deltaTime;
                    if(line.RemainingLifetime <= 0f)
                    {
                        // Remove the line from the array and deincrement to avoid skipping a line.
                        m_batchedLines.RemoveAt(lineIndex--);
                        dirty = true;
                        continue;
                    }
                }

                m_batchedLines[lineIndex] = line;
            }

            if (dirty)
                MarkRenderStateAsDirty();
        }

        public void Flush()
        {
            m_batchedLines.Clear();
            MarkRenderStateAsDirty();
        }

        public override void ReleaseResources()
        {
            m_primitiveShader.ReleaseResources();
            GL.DeleteBuffer(m_vbo);
        }

        public override void Render(Matrix4 viewMatrix, Matrix4 projMatrix)
        {
            if(RenderStateDirty)
            {
                // We've changed what we want to draw since we last rendered, so we'll re-calculate the mesh and upload.
                Vector3[] lineVerts = new Vector3[m_batchedLines.Count * 2];
                for (int i = 0; i < m_batchedLines.Count; i++)
                {
                    WBatchedLine batchedLine = m_batchedLines[i];
                    lineVerts[(i * 2) + 0] = batchedLine.Start;
                    lineVerts[(i * 2) + 1] = batchedLine.End;
                }

                // Upload Verts
                GL.BindBuffer(BufferTarget.ArrayBuffer, m_vbo);
                GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(12 * lineVerts.Length), lineVerts, BufferUsageHint.DynamicDraw);
                RenderStateDirty = false;
            }

            // Draw the mesh.
            GL.FrontFace(FrontFaceDirection.Cw);
            GL.Enable(EnableCap.CullFace);
            GL.Disable(EnableCap.Blend);
            GL.DepthMask(true);
            //GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);


            Matrix4 modelMatrix = Matrix4.Identity;

            m_primitiveShader.Bind();
            GL.UniformMatrix4(m_primitiveShader.UniformModelMtx, false, ref modelMatrix);
            GL.UniformMatrix4(m_primitiveShader.UniformViewMtx, false, ref viewMatrix);
            GL.UniformMatrix4(m_primitiveShader.UniformProjMtx, false, ref projMatrix);

            GL.BindBuffer(BufferTarget.ArrayBuffer, m_vbo);
            GL.EnableVertexAttribArray((int)ShaderAttributeIds.Position);
            GL.VertexAttribPointer((int)ShaderAttributeIds.Position, 3, VertexAttribPointerType.Float, false, 12, 0);

            // Draw!
            GL.DrawArrays(PrimitiveType.Lines, 0, m_batchedLines.Count * 2);
        }
    }
}
