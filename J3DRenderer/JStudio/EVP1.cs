﻿using System.Collections.Generic;
using GameFormatReader.Common;
using System.Diagnostics;
using OpenTK;
using WindEditor;

namespace J3DRenderer.JStudio
{
    public class EVP1
    {
        public List<byte> NumBoneInfluences;
        public List<ushort> IndexRemap;
        public List<float> WeightList;
        public List<Matrix3x4> InverseBindPose;

        public void LoadEVP1FromStream(EndianBinaryReader reader, long tagStart)
        {
            ushort envelopeCount = reader.ReadUInt16();
            Trace.Assert(reader.ReadUInt16() == 0xFFFF); // Padding

            uint boneInfluenceCountOffset = reader.ReadUInt32(); // envelopeCount many uint8 indicating how many bones influence an index.
            uint indexDataOffset = reader.ReadUInt32(); // ???
            uint weightDataOffset = reader.ReadUInt32(); // Bone Weights (as many floats here as there are ushorts at indexDataOffset
            uint boneMatrixOffset = reader.ReadUInt32(); // Matrix Table (3x4 float array) - Skeleton Inverse Bind Pose


            NumBoneInfluences = new List<byte>();
            IndexRemap = new List<ushort>();
            WeightList = new List<float>();
            InverseBindPose = new List<Matrix3x4>();

            // How many bones influence the given index
            reader.BaseStream.Position = tagStart + boneInfluenceCountOffset;
            for (int i = 0; i < envelopeCount; i++)
                NumBoneInfluences.Add(reader.ReadByte());

            // For each influence, an index remap?
            reader.BaseStream.Position = tagStart + indexDataOffset;
            for(int m = 0; m < envelopeCount; m++)
            {
                for(int j =0; j < NumBoneInfluences[m]; j++)
                {
                    IndexRemap.Add(reader.ReadUInt16());
                }
            }

            // For each influence, how much does that influence have an affect.
            reader.BaseStream.Position = tagStart + weightDataOffset;
            for(int m = 0; m < envelopeCount; m++)
            {
                for(int j = 0; j < NumBoneInfluences[m]; j++)
                {
                    WeightList.Add(reader.ReadSingle());
                }
            }

            // For each envelope index, what is the Inverse Bind Pose matrix? The Inverse Bind Pose matrix will transform
            // a vertex from being in model space into local space around its bone.
            reader.BaseStream.Position = tagStart + boneMatrixOffset;
            for(int m = 0; m < envelopeCount; m++)
            {
                Matrix3x4 matrix = new Matrix3x4();
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                        matrix[j, k] = reader.ReadSingle();
                }

                InverseBindPose.Add(matrix);
            }
        }
    }
}