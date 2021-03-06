﻿// 
using GameFormatReader.Common;
using OpenTK;
using System.ComponentModel;
using System.Diagnostics;
using System;
using WindEditor.ViewModel;

namespace WindEditor
{
	public abstract class SerializableDOMNode : WDOMNode
	{
		public readonly FourCC FourCC;
		public MapLayer Layer { get { return m_layer; } set { m_layer = value; OnPropertyChanged("Layer"); } }

		private MapLayer m_layer;

		public SerializableDOMNode(FourCC fourCC, WWorld world) : base(world)
		{
			FourCC = fourCC;
			OnConstruction();
		}

		// Called by the constructor, override this if you want to put things in your own constructor in a partial class.
		public virtual void OnConstruction() {}

		// This is called after the data is loaded out of the disk. Use this if you need to post-process the loaded data.
		public virtual void PostLoad() {}

		// This is called before writing data to the disk. Use this if you need to pre-process the data to be saved.
		public virtual void PreSave() {}

		public virtual void Load(EndianBinaryReader stream) {}
		public virtual void Save(EndianBinaryWriter stream) {}
	}

	public partial class VisibleDOMNode : SerializableDOMNode
	{
		public VisibleDOMNode(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
		}
	}
	 

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class MinimapSettings_Unused : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private Vector2 m_FullMapImageScale;

		[WProperty("Misc.", "Full Map Image Scale", false)]
		 public Vector2 FullMapImageScale
		{ 
			get { return m_FullMapImageScale; }
			set
			{
				m_FullMapImageScale = value;
				OnPropertyChanged("FullMapImageScale");
			}
		}
				

		private Vector2 m_FullMapSpaceScale;

		[WProperty("Misc.", "Full Map Space Scale", false)]
		 public Vector2 FullMapSpaceScale
		{ 
			get { return m_FullMapSpaceScale; }
			set
			{
				m_FullMapSpaceScale = value;
				OnPropertyChanged("FullMapSpaceScale");
			}
		}
				

		private Vector2 m_FullMapTranslation;

		[WProperty("Misc.", "Full Map Translation", false)]
		 public Vector2 FullMapTranslation
		{ 
			get { return m_FullMapTranslation; }
			set
			{
				m_FullMapTranslation = value;
				OnPropertyChanged("FullMapTranslation");
			}
		}
				

		private Vector2 m_ZoomedMapScrolling1;

		[WProperty("Misc.", "Zoomed Map Scrolling 1", false)]
		 public Vector2 ZoomedMapScrolling1
		{ 
			get { return m_ZoomedMapScrolling1; }
			set
			{
				m_ZoomedMapScrolling1 = value;
				OnPropertyChanged("ZoomedMapScrolling1");
			}
		}
				

		private Vector2 m_ZoomedMapScrolling2;

		[WProperty("Misc.", "Zoomed Map Scrolling 2", false)]
		 public Vector2 ZoomedMapScrolling2
		{ 
			get { return m_ZoomedMapScrolling2; }
			set
			{
				m_ZoomedMapScrolling2 = value;
				OnPropertyChanged("ZoomedMapScrolling2");
			}
		}
				

		private Vector2 m_ZoomedMapTranslation;

		[WProperty("Misc.", "Zoomed Map Translation", false)]
		 public Vector2 ZoomedMapTranslation
		{ 
			get { return m_ZoomedMapTranslation; }
			set
			{
				m_ZoomedMapTranslation = value;
				OnPropertyChanged("ZoomedMapTranslation");
			}
		}
				

		private float m_ZoomedMapScale;

		[WProperty("Misc.", "Zoomed Map Scale", false)]
		 public float ZoomedMapScale
		{ 
			get { return m_ZoomedMapScale; }
			set
			{
				m_ZoomedMapScale = value;
				OnPropertyChanged("ZoomedMapScale");
			}
		}
				

		private byte m_Unknown;

		[WProperty("Misc.", "Unknown", false)]
		 public byte Unknown
		{ 
			get { return m_Unknown; }
			set
			{
				m_Unknown = value;
				OnPropertyChanged("Unknown");
			}
		}
				

		private byte m_MapImageIndex;

		[WProperty("Misc.", "Map Image Index", false)]
		 public byte MapImageIndex
		{ 
			get { return m_MapImageIndex; }
			set
			{
				m_MapImageIndex = value;
				OnPropertyChanged("MapImageIndex");
			}
		}
				

		private byte m_Unknown2;

		[WProperty("Misc.", "Unknown 2", false)]
		 public byte Unknown2
		{ 
			get { return m_Unknown2; }
			set
			{
				m_Unknown2 = value;
				OnPropertyChanged("Unknown2");
			}
		}
				

		private byte m_Padding;

		[WProperty("Misc.", "Padding", false)]
		 public byte Padding
		{ 
			get { return m_Padding; }
			set
			{
				m_Padding = value;
				OnPropertyChanged("Padding");
			}
		}
				


		// Constructor
		public MinimapSettings_Unused(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Full Map Image Scale", TargetProperties = new string[] { "FullMapImageScale"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Full Map Space Scale", TargetProperties = new string[] { "FullMapSpaceScale"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Full Map Translation", TargetProperties = new string[] { "FullMapTranslation"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Zoomed Map Scrolling 1", TargetProperties = new string[] { "ZoomedMapScrolling1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Zoomed Map Scrolling 2", TargetProperties = new string[] { "ZoomedMapScrolling2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Zoomed Map Translation", TargetProperties = new string[] { "ZoomedMapTranslation"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Zoomed Map Scale", TargetProperties = new string[] { "ZoomedMapScale"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown", TargetProperties = new string[] { "Unknown"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Map Image Index", TargetProperties = new string[] { "MapImageIndex"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 2", TargetProperties = new string[] { "Unknown2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding", TargetProperties = new string[] { "Padding"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_FullMapImageScale = new OpenTK.Vector2(stream.ReadSingle(), stream.ReadSingle()); 
			m_FullMapSpaceScale = new OpenTK.Vector2(stream.ReadSingle(), stream.ReadSingle()); 
			m_FullMapTranslation = new OpenTK.Vector2(stream.ReadSingle(), stream.ReadSingle()); 
			m_ZoomedMapScrolling1 = new OpenTK.Vector2(stream.ReadSingle(), stream.ReadSingle()); 
			m_ZoomedMapScrolling2 = new OpenTK.Vector2(stream.ReadSingle(), stream.ReadSingle()); 
			m_ZoomedMapTranslation = new OpenTK.Vector2(stream.ReadSingle(), stream.ReadSingle()); 
			m_ZoomedMapScale = stream.ReadSingle(); 
			m_Unknown = stream.ReadByte(); 
			m_MapImageIndex = stream.ReadByte(); 
			m_Unknown2 = stream.ReadByte(); 
			m_Padding = stream.ReadByte(); Trace.Assert(m_Padding == 0xFF || m_Padding== 0); // Padding
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((float)FullMapImageScale.X); stream.Write((float)FullMapImageScale.Y);
			stream.Write((float)FullMapSpaceScale.X); stream.Write((float)FullMapSpaceScale.Y);
			stream.Write((float)FullMapTranslation.X); stream.Write((float)FullMapTranslation.Y);
			stream.Write((float)ZoomedMapScrolling1.X); stream.Write((float)ZoomedMapScrolling1.Y);
			stream.Write((float)ZoomedMapScrolling2.X); stream.Write((float)ZoomedMapScrolling2.Y);
			stream.Write((float)ZoomedMapTranslation.X); stream.Write((float)ZoomedMapTranslation.Y);
			stream.Write((float)ZoomedMapScale);
			stream.Write((byte)Unknown);
			stream.Write((byte)MapImageIndex);
			stream.Write((byte)Unknown2);
			stream.Write((byte)0); // Padding
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class MinimapSettings : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private Vector2 m_FullMapImageScale;

		[WProperty("Misc.", "Full Map Image Scale", false)]
		 public Vector2 FullMapImageScale
		{ 
			get { return m_FullMapImageScale; }
			set
			{
				m_FullMapImageScale = value;
				OnPropertyChanged("FullMapImageScale");
			}
		}
				

		private Vector2 m_FullMapSpaceScale;

		[WProperty("Misc.", "Full Map Space Scale", false)]
		 public Vector2 FullMapSpaceScale
		{ 
			get { return m_FullMapSpaceScale; }
			set
			{
				m_FullMapSpaceScale = value;
				OnPropertyChanged("FullMapSpaceScale");
			}
		}
				

		private Vector2 m_FullMapTranslation;

		[WProperty("Misc.", "Full Map Translation", false)]
		 public Vector2 FullMapTranslation
		{ 
			get { return m_FullMapTranslation; }
			set
			{
				m_FullMapTranslation = value;
				OnPropertyChanged("FullMapTranslation");
			}
		}
				

		private Vector2 m_ZoomedMapScrolling1;

		[WProperty("Misc.", "Zoomed Map Scrolling 1", false)]
		 public Vector2 ZoomedMapScrolling1
		{ 
			get { return m_ZoomedMapScrolling1; }
			set
			{
				m_ZoomedMapScrolling1 = value;
				OnPropertyChanged("ZoomedMapScrolling1");
			}
		}
				

		private Vector2 m_ZoomedMapScrolling2;

		[WProperty("Misc.", "Zoomed Map Scrolling 2", false)]
		 public Vector2 ZoomedMapScrolling2
		{ 
			get { return m_ZoomedMapScrolling2; }
			set
			{
				m_ZoomedMapScrolling2 = value;
				OnPropertyChanged("ZoomedMapScrolling2");
			}
		}
				

		private Vector2 m_ZoomedMapTranslation;

		[WProperty("Misc.", "Zoomed Map Translation", false)]
		 public Vector2 ZoomedMapTranslation
		{ 
			get { return m_ZoomedMapTranslation; }
			set
			{
				m_ZoomedMapTranslation = value;
				OnPropertyChanged("ZoomedMapTranslation");
			}
		}
				

		private float m_ZoomedMapScale;

		[WProperty("Misc.", "Zoomed Map Scale", false)]
		 public float ZoomedMapScale
		{ 
			get { return m_ZoomedMapScale; }
			set
			{
				m_ZoomedMapScale = value;
				OnPropertyChanged("ZoomedMapScale");
			}
		}
				

		private byte m_Unknown;

		[WProperty("Misc.", "Unknown", false)]
		 public byte Unknown
		{ 
			get { return m_Unknown; }
			set
			{
				m_Unknown = value;
				OnPropertyChanged("Unknown");
			}
		}
				

		private byte m_MapImageIndex;

		[WProperty("Misc.", "Map Image Index", false)]
		 public byte MapImageIndex
		{ 
			get { return m_MapImageIndex; }
			set
			{
				m_MapImageIndex = value;
				OnPropertyChanged("MapImageIndex");
			}
		}
				

		private byte m_Unknown2;

		[WProperty("Misc.", "Unknown 2", false)]
		 public byte Unknown2
		{ 
			get { return m_Unknown2; }
			set
			{
				m_Unknown2 = value;
				OnPropertyChanged("Unknown2");
			}
		}
				

		private byte m_Padding;

		[WProperty("Misc.", "Padding", false)]
		 public byte Padding
		{ 
			get { return m_Padding; }
			set
			{
				m_Padding = value;
				OnPropertyChanged("Padding");
			}
		}
				


		// Constructor
		public MinimapSettings(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Full Map Image Scale", TargetProperties = new string[] { "FullMapImageScale"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Full Map Space Scale", TargetProperties = new string[] { "FullMapSpaceScale"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Full Map Translation", TargetProperties = new string[] { "FullMapTranslation"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Zoomed Map Scrolling 1", TargetProperties = new string[] { "ZoomedMapScrolling1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Zoomed Map Scrolling 2", TargetProperties = new string[] { "ZoomedMapScrolling2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Zoomed Map Translation", TargetProperties = new string[] { "ZoomedMapTranslation"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Zoomed Map Scale", TargetProperties = new string[] { "ZoomedMapScale"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown", TargetProperties = new string[] { "Unknown"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Map Image Index", TargetProperties = new string[] { "MapImageIndex"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 2", TargetProperties = new string[] { "Unknown2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding", TargetProperties = new string[] { "Padding"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_FullMapImageScale = new OpenTK.Vector2(stream.ReadSingle(), stream.ReadSingle()); 
			m_FullMapSpaceScale = new OpenTK.Vector2(stream.ReadSingle(), stream.ReadSingle()); 
			m_FullMapTranslation = new OpenTK.Vector2(stream.ReadSingle(), stream.ReadSingle()); 
			m_ZoomedMapScrolling1 = new OpenTK.Vector2(stream.ReadSingle(), stream.ReadSingle()); 
			m_ZoomedMapScrolling2 = new OpenTK.Vector2(stream.ReadSingle(), stream.ReadSingle()); 
			m_ZoomedMapTranslation = new OpenTK.Vector2(stream.ReadSingle(), stream.ReadSingle()); 
			m_ZoomedMapScale = stream.ReadSingle(); 
			m_Unknown = stream.ReadByte(); 
			m_MapImageIndex = stream.ReadByte(); 
			m_Unknown2 = stream.ReadByte(); 
			m_Padding = stream.ReadByte(); Trace.Assert(m_Padding == 0xFF || m_Padding== 0); // Padding
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((float)FullMapImageScale.X); stream.Write((float)FullMapImageScale.Y);
			stream.Write((float)FullMapSpaceScale.X); stream.Write((float)FullMapSpaceScale.Y);
			stream.Write((float)FullMapTranslation.X); stream.Write((float)FullMapTranslation.Y);
			stream.Write((float)ZoomedMapScrolling1.X); stream.Write((float)ZoomedMapScrolling1.Y);
			stream.Write((float)ZoomedMapScrolling2.X); stream.Write((float)ZoomedMapScrolling2.Y);
			stream.Write((float)ZoomedMapTranslation.X); stream.Write((float)ZoomedMapTranslation.Y);
			stream.Write((float)ZoomedMapScale);
			stream.Write((byte)Unknown);
			stream.Write((byte)MapImageIndex);
			stream.Write((byte)Unknown2);
			stream.Write((byte)0); // Padding
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class Actor : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private string m_Name;

		[WProperty("Misc.", "Name", false)]
		override public string Name
		{ 
			get { return m_Name; }
			set
			{
				m_Name = value;
				OnPropertyChanged("Name");
			}
		}
				

		private int m_Parameters;

		[WProperty("Misc.", "Parameters", false)]
		 public int Parameters
		{ 
			get { return m_Parameters; }
			set
			{
				m_Parameters = value;
				OnPropertyChanged("Parameters");
			}
		}
				

		private short m_AuxillaryParameters1;

		[WProperty("Misc.", "Auxillary Parameters 1", false)]
		 public short AuxillaryParameters1
		{ 
			get { return m_AuxillaryParameters1; }
			set
			{
				m_AuxillaryParameters1 = value;
				OnPropertyChanged("AuxillaryParameters1");
			}
		}
				

		private short m_AuxillaryParameters2;

		[WProperty("Misc.", "Auxillary Parameters 2", false)]
		 public short AuxillaryParameters2
		{ 
			get { return m_AuxillaryParameters2; }
			set
			{
				m_AuxillaryParameters2 = value;
				OnPropertyChanged("AuxillaryParameters2");
			}
		}
				

		private short m_EnemyNumber;

		[WProperty("Misc.", "Enemy Number", false)]
		 public short EnemyNumber
		{ 
			get { return m_EnemyNumber; }
			set
			{
				m_EnemyNumber = value;
				OnPropertyChanged("EnemyNumber");
			}
		}
				


		// Constructor
		public Actor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Name", TargetProperties = new string[] { "Name"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Parameters", TargetProperties = new string[] { "Parameters"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Auxillary Parameters 1", TargetProperties = new string[] { "AuxillaryParameters1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Auxillary Parameters 2", TargetProperties = new string[] { "AuxillaryParameters2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Enemy Number", TargetProperties = new string[] { "EnemyNumber"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Name = stream.ReadString(8).Trim(new[] { '\0' }); 
			m_Parameters = stream.ReadInt32(); 
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			m_AuxillaryParameters1 = stream.ReadInt16(); 
			float yRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion yRotQ = Quaternion.FromAxisAngle(new Vector3(0, 1, 0), WMath.DegreesToRadians(yRot));Transform.Rotation = Transform.Rotation * yRotQ; 
			m_AuxillaryParameters2 = stream.ReadInt16(); 
			m_EnemyNumber = stream.ReadInt16(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write(Name.PadRight(8, '\0').ToCharArray());
			stream.Write((int)Parameters);
			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
			stream.Write((short)AuxillaryParameters1);
			stream.Write(WMath.RotationFloatToShort(originalRot.Y));
			stream.Write((short)AuxillaryParameters2);
			stream.Write((short)EnemyNumber);

            if (FourCC >= FourCC.SCOB && FourCC <= FourCC.SCOb)
            {
                stream.Write((byte)(Transform.LocalScale.X * 10f));
                stream.Write((byte)(Transform.LocalScale.Y * 10f));
                stream.Write((byte)(Transform.LocalScale.Z * 10f));
                stream.Write((sbyte)-1);
            }
        }
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class CameraViewpoint_v1 : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private short m_Padding;
				


		// Constructor
		public CameraViewpoint_v1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
		}

		override public void Load(EndianBinaryReader stream)
		{
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			float xRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion xRotQ = Quaternion.FromAxisAngle(new Vector3(1, 0, 0), WMath.DegreesToRadians(xRot));Transform.Rotation = Transform.Rotation * xRotQ; 
			float yRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion yRotQ = Quaternion.FromAxisAngle(new Vector3(0, 1, 0), WMath.DegreesToRadians(yRot));Transform.Rotation = Transform.Rotation * yRotQ; 
			float zRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion zRotQ = Quaternion.FromAxisAngle(new Vector3(0, 0, 1), WMath.DegreesToRadians(zRot));Transform.Rotation = Transform.Rotation * zRotQ; 
			m_Padding = stream.ReadInt16(); Trace.Assert((ushort)m_Padding == 0xFFFF || m_Padding== 0); // Padding
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
			stream.Write(WMath.RotationFloatToShort(originalRot.X));
			stream.Write(WMath.RotationFloatToShort(originalRot.Y));
			stream.Write(WMath.RotationFloatToShort(originalRot.Z));
			stream.Write((short)0); // Padding
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class CameraViewpoint_v2 : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private short m_Padding;
				


		// Constructor
		public CameraViewpoint_v2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
		}

		override public void Load(EndianBinaryReader stream)
		{
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			float xRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion xRotQ = Quaternion.FromAxisAngle(new Vector3(1, 0, 0), WMath.DegreesToRadians(xRot));Transform.Rotation = Transform.Rotation * xRotQ; 
			float yRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion yRotQ = Quaternion.FromAxisAngle(new Vector3(0, 1, 0), WMath.DegreesToRadians(yRot));Transform.Rotation = Transform.Rotation * yRotQ; 
			float zRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion zRotQ = Quaternion.FromAxisAngle(new Vector3(0, 0, 1), WMath.DegreesToRadians(zRot));Transform.Rotation = Transform.Rotation * zRotQ; 
			m_Padding = stream.ReadInt16(); Trace.Assert((ushort)m_Padding == 0xFFFF || m_Padding== 0); // Padding
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
			stream.Write(WMath.RotationFloatToShort(originalRot.X));
			stream.Write(WMath.RotationFloatToShort(originalRot.Y));
			stream.Write(WMath.RotationFloatToShort(originalRot.Z));
			stream.Write((short)0); // Padding
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class CameraType_v1 : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private string m_CameraType;

		[WProperty("Misc.", "Camera Type", false)]
		 public string CameraType
		{ 
			get { return m_CameraType; }
			set
			{
				m_CameraType = value;
				OnPropertyChanged("CameraType");
			}
		}
				

		private short m_CameraPointIndex;

		[WProperty("Misc.", "Camera Point Index", false)]
		 public short CameraPointIndex
		{ 
			get { return m_CameraPointIndex; }
			set
			{
				m_CameraPointIndex = value;
				OnPropertyChanged("CameraPointIndex");
			}
		}
				

		private byte m_Padding1;

		[WProperty("Misc.", "Padding 1", false)]
		 public byte Padding1
		{ 
			get { return m_Padding1; }
			set
			{
				m_Padding1 = value;
				OnPropertyChanged("Padding1");
			}
		}
				

		private byte m_Unknown1;

		[WProperty("Misc.", "Unknown 1", false)]
		 public byte Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				


		// Constructor
		public CameraType_v1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Camera Type", TargetProperties = new string[] { "CameraType"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Camera Point Index", TargetProperties = new string[] { "CameraPointIndex"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding 1", TargetProperties = new string[] { "Padding1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_CameraType = stream.ReadString(16).Trim(new[] { '\0' }); 
			m_CameraPointIndex = stream.ReadInt16(); 
			m_Padding1 = stream.ReadByte(); Trace.Assert(m_Padding1 == 0xFF || m_Padding1== 0); // Padding
			m_Unknown1 = stream.ReadByte(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write(CameraType.PadRight(16, '\0').ToCharArray());
			stream.Write((short)CameraPointIndex);
			stream.Write((byte)0); // Padding
			stream.Write((byte)Unknown1);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class CameraType_v2 : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private string m_CameraType;

		[WProperty("Misc.", "Camera Type", false)]
		 public string CameraType
		{ 
			get { return m_CameraType; }
			set
			{
				m_CameraType = value;
				OnPropertyChanged("CameraType");
			}
		}
				

		private byte m_CameraPointIndex;

		[WProperty("Misc.", "Camera Point Index", false)]
		 public byte CameraPointIndex
		{ 
			get { return m_CameraPointIndex; }
			set
			{
				m_CameraPointIndex = value;
				OnPropertyChanged("CameraPointIndex");
			}
		}
				

		private byte m_Padding1;

		[WProperty("Misc.", "Padding 1", false)]
		 public byte Padding1
		{ 
			get { return m_Padding1; }
			set
			{
				m_Padding1 = value;
				OnPropertyChanged("Padding1");
			}
		}
				

		private byte m_Unknown1;

		[WProperty("Misc.", "Unknown 1", false)]
		 public byte Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				

		private byte m_Padding3;

		[WProperty("Misc.", "Padding 3", false)]
		 public byte Padding3
		{ 
			get { return m_Padding3; }
			set
			{
				m_Padding3 = value;
				OnPropertyChanged("Padding3");
			}
		}
				


		// Constructor
		public CameraType_v2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Camera Type", TargetProperties = new string[] { "CameraType"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Camera Point Index", TargetProperties = new string[] { "CameraPointIndex"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding 1", TargetProperties = new string[] { "Padding1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding 3", TargetProperties = new string[] { "Padding3"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_CameraType = stream.ReadString(16).Trim(new[] { '\0' }); 
			m_CameraPointIndex = stream.ReadByte(); 
			m_Padding1 = stream.ReadByte(); Trace.Assert(m_Padding1 == 0xFF || m_Padding1== 0); // Padding
			m_Unknown1 = stream.ReadByte(); 
			m_Padding3 = stream.ReadByte(); Trace.Assert(m_Padding3 == 0xFF || m_Padding3== 0); // Padding
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write(CameraType.PadRight(16, '\0').ToCharArray());
			stream.Write((byte)CameraPointIndex);
			stream.Write((byte)0); // Padding
			stream.Write((byte)Unknown1);
			stream.Write((byte)0); // Padding
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class Door_DOOR : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private string m_Name;

		[WProperty("Misc.", "Name", false)]
		override public string Name
		{ 
			get { return m_Name; }
			set
			{
				m_Name = value;
				OnPropertyChanged("Name");
			}
		}
				

		private int m_Parameters;

		[WProperty("Misc.", "Parameters", false)]
		 public int Parameters
		{ 
			get { return m_Parameters; }
			set
			{
				m_Parameters = value;
				OnPropertyChanged("Parameters");
			}
		}
				

		private short m_AuxiliaryParameters;

		[WProperty("Misc.", "Auxiliary Parameters", false)]
		 public short AuxiliaryParameters
		{ 
			get { return m_AuxiliaryParameters; }
			set
			{
				m_AuxiliaryParameters = value;
				OnPropertyChanged("AuxiliaryParameters");
			}
		}
				

		private short m_Unknown1;

		[WProperty("Misc.", "Unknown 1", false)]
		 public short Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				

		private short m_Unknown2;

		[WProperty("Misc.", "Unknown 2", false)]
		 public short Unknown2
		{ 
			get { return m_Unknown2; }
			set
			{
				m_Unknown2 = value;
				OnPropertyChanged("Unknown2");
			}
		}
				

		private byte m_ScaleX;

		[WProperty("Misc.", "Scale X", false)]
		 public byte ScaleX
		{ 
			get { return m_ScaleX; }
			set
			{
				m_ScaleX = value;
				OnPropertyChanged("ScaleX");
			}
		}
				

		private byte m_ScaleY;

		[WProperty("Misc.", "Scale Y", false)]
		 public byte ScaleY
		{ 
			get { return m_ScaleY; }
			set
			{
				m_ScaleY = value;
				OnPropertyChanged("ScaleY");
			}
		}
				

		private byte m_ScaleZ;

		[WProperty("Misc.", "Scale Z", false)]
		 public byte ScaleZ
		{ 
			get { return m_ScaleZ; }
			set
			{
				m_ScaleZ = value;
				OnPropertyChanged("ScaleZ");
			}
		}
				

		private byte m_Padding;
				


		// Constructor
		public Door_DOOR(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Name", TargetProperties = new string[] { "Name"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Parameters", TargetProperties = new string[] { "Parameters"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Auxiliary Parameters", TargetProperties = new string[] { "AuxiliaryParameters"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 2", TargetProperties = new string[] { "Unknown2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Scale X", TargetProperties = new string[] { "ScaleX"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Scale Y", TargetProperties = new string[] { "ScaleY"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Scale Z", TargetProperties = new string[] { "ScaleZ"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Name = stream.ReadString(8).Trim(new[] { '\0' }); 
			m_Parameters = stream.ReadInt32(); 
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			m_AuxiliaryParameters = stream.ReadInt16(); 
			float yRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion yRotQ = Quaternion.FromAxisAngle(new Vector3(0, 1, 0), WMath.DegreesToRadians(yRot));Transform.Rotation = Transform.Rotation * yRotQ; 
			m_Unknown1 = stream.ReadInt16(); 
			m_Unknown2 = stream.ReadInt16(); 
			m_ScaleX = stream.ReadByte(); 
			m_ScaleY = stream.ReadByte(); 
			m_ScaleZ = stream.ReadByte(); 
			m_Padding = stream.ReadByte(); Trace.Assert(m_Padding == 0xFF || m_Padding== 0); // Padding
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write(Name.PadRight(8, '\0').ToCharArray());
			stream.Write((int)Parameters);
			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
			stream.Write((short)AuxiliaryParameters);
			stream.Write(WMath.RotationFloatToShort(originalRot.Y));
			stream.Write((short)Unknown1);
			stream.Write((short)Unknown2);
			stream.Write((byte)ScaleX);
			stream.Write((byte)ScaleY);
			stream.Write((byte)ScaleZ);
			stream.Write((byte)0); // Padding
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class DungeonFloorSettings : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private float m_LowerBoundaryYHeight;

		[WProperty("Misc.", "Lower Boundary YHeight", false)]
		 public float LowerBoundaryYHeight
		{ 
			get { return m_LowerBoundaryYHeight; }
			set
			{
				m_LowerBoundaryYHeight = value;
				OnPropertyChanged("LowerBoundaryYHeight");
			}
		}
				

		private byte m_FloorNumber;

		[WProperty("Misc.", "Floor Number", false)]
		 public byte FloorNumber
		{ 
			get { return m_FloorNumber; }
			set
			{
				m_FloorNumber = value;
				OnPropertyChanged("FloorNumber");
			}
		}
				

		private byte m_IncludedRoom0;

		[WProperty("Misc.", "Included Room 0", false)]
		 public byte IncludedRoom0
		{ 
			get { return m_IncludedRoom0; }
			set
			{
				m_IncludedRoom0 = value;
				OnPropertyChanged("IncludedRoom0");
			}
		}
				

		private byte m_IncludedRoom1;

		[WProperty("Misc.", "Included Room 1", false)]
		 public byte IncludedRoom1
		{ 
			get { return m_IncludedRoom1; }
			set
			{
				m_IncludedRoom1 = value;
				OnPropertyChanged("IncludedRoom1");
			}
		}
				

		private byte m_IncludedRoom2;

		[WProperty("Misc.", "Included Room 2", false)]
		 public byte IncludedRoom2
		{ 
			get { return m_IncludedRoom2; }
			set
			{
				m_IncludedRoom2 = value;
				OnPropertyChanged("IncludedRoom2");
			}
		}
				

		private byte m_IncludedRoom3;

		[WProperty("Misc.", "Included Room 3", false)]
		 public byte IncludedRoom3
		{ 
			get { return m_IncludedRoom3; }
			set
			{
				m_IncludedRoom3 = value;
				OnPropertyChanged("IncludedRoom3");
			}
		}
				

		private byte m_IncludedRoom4;

		[WProperty("Misc.", "Included Room 4", false)]
		 public byte IncludedRoom4
		{ 
			get { return m_IncludedRoom4; }
			set
			{
				m_IncludedRoom4 = value;
				OnPropertyChanged("IncludedRoom4");
			}
		}
				

		private byte m_IncludedRoom5;

		[WProperty("Misc.", "Included Room 5", false)]
		 public byte IncludedRoom5
		{ 
			get { return m_IncludedRoom5; }
			set
			{
				m_IncludedRoom5 = value;
				OnPropertyChanged("IncludedRoom5");
			}
		}
				

		private byte m_IncludedRoom6;

		[WProperty("Misc.", "Included Room 6", false)]
		 public byte IncludedRoom6
		{ 
			get { return m_IncludedRoom6; }
			set
			{
				m_IncludedRoom6 = value;
				OnPropertyChanged("IncludedRoom6");
			}
		}
				

		private byte m_IncludedRoom7;

		[WProperty("Misc.", "Included Room 7", false)]
		 public byte IncludedRoom7
		{ 
			get { return m_IncludedRoom7; }
			set
			{
				m_IncludedRoom7 = value;
				OnPropertyChanged("IncludedRoom7");
			}
		}
				

		private byte m_IncludedRoom8;

		[WProperty("Misc.", "Included Room 8", false)]
		 public byte IncludedRoom8
		{ 
			get { return m_IncludedRoom8; }
			set
			{
				m_IncludedRoom8 = value;
				OnPropertyChanged("IncludedRoom8");
			}
		}
				

		private byte m_IncludedRoom9;

		[WProperty("Misc.", "Included Room 9", false)]
		 public byte IncludedRoom9
		{ 
			get { return m_IncludedRoom9; }
			set
			{
				m_IncludedRoom9 = value;
				OnPropertyChanged("IncludedRoom9");
			}
		}
				

		private byte m_IncludedRoom10;

		[WProperty("Misc.", "Included Room 10", false)]
		 public byte IncludedRoom10
		{ 
			get { return m_IncludedRoom10; }
			set
			{
				m_IncludedRoom10 = value;
				OnPropertyChanged("IncludedRoom10");
			}
		}
				

		private byte m_IncludedRoom11;

		[WProperty("Misc.", "Included Room 11", false)]
		 public byte IncludedRoom11
		{ 
			get { return m_IncludedRoom11; }
			set
			{
				m_IncludedRoom11 = value;
				OnPropertyChanged("IncludedRoom11");
			}
		}
				

		private byte m_IncludedRoom12;

		[WProperty("Misc.", "Included Room 12", false)]
		 public byte IncludedRoom12
		{ 
			get { return m_IncludedRoom12; }
			set
			{
				m_IncludedRoom12 = value;
				OnPropertyChanged("IncludedRoom12");
			}
		}
				

		private byte m_IncludedRoom13;

		[WProperty("Misc.", "Included Room 13", false)]
		 public byte IncludedRoom13
		{ 
			get { return m_IncludedRoom13; }
			set
			{
				m_IncludedRoom13 = value;
				OnPropertyChanged("IncludedRoom13");
			}
		}
				

		private byte m_IncludedRoom14;

		[WProperty("Misc.", "Included Room 14", false)]
		 public byte IncludedRoom14
		{ 
			get { return m_IncludedRoom14; }
			set
			{
				m_IncludedRoom14 = value;
				OnPropertyChanged("IncludedRoom14");
			}
		}
				


		// Constructor
		public DungeonFloorSettings(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Lower Boundary YHeight", TargetProperties = new string[] { "LowerBoundaryYHeight"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Floor Number", TargetProperties = new string[] { "FloorNumber"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 0", TargetProperties = new string[] { "IncludedRoom0"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 1", TargetProperties = new string[] { "IncludedRoom1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 2", TargetProperties = new string[] { "IncludedRoom2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 3", TargetProperties = new string[] { "IncludedRoom3"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 4", TargetProperties = new string[] { "IncludedRoom4"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 5", TargetProperties = new string[] { "IncludedRoom5"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 6", TargetProperties = new string[] { "IncludedRoom6"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 7", TargetProperties = new string[] { "IncludedRoom7"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 8", TargetProperties = new string[] { "IncludedRoom8"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 9", TargetProperties = new string[] { "IncludedRoom9"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 10", TargetProperties = new string[] { "IncludedRoom10"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 11", TargetProperties = new string[] { "IncludedRoom11"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 12", TargetProperties = new string[] { "IncludedRoom12"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 13", TargetProperties = new string[] { "IncludedRoom13"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Included Room 14", TargetProperties = new string[] { "IncludedRoom14"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_LowerBoundaryYHeight = stream.ReadSingle(); 
			m_FloorNumber = stream.ReadByte(); 
			m_IncludedRoom0 = stream.ReadByte(); 
			m_IncludedRoom1 = stream.ReadByte(); 
			m_IncludedRoom2 = stream.ReadByte(); 
			m_IncludedRoom3 = stream.ReadByte(); 
			m_IncludedRoom4 = stream.ReadByte(); 
			m_IncludedRoom5 = stream.ReadByte(); 
			m_IncludedRoom6 = stream.ReadByte(); 
			m_IncludedRoom7 = stream.ReadByte(); 
			m_IncludedRoom8 = stream.ReadByte(); 
			m_IncludedRoom9 = stream.ReadByte(); 
			m_IncludedRoom10 = stream.ReadByte(); 
			m_IncludedRoom11 = stream.ReadByte(); 
			m_IncludedRoom12 = stream.ReadByte(); 
			m_IncludedRoom13 = stream.ReadByte(); 
			m_IncludedRoom14 = stream.ReadByte(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((float)LowerBoundaryYHeight);
			stream.Write((byte)FloorNumber);
			stream.Write((byte)IncludedRoom0);
			stream.Write((byte)IncludedRoom1);
			stream.Write((byte)IncludedRoom2);
			stream.Write((byte)IncludedRoom3);
			stream.Write((byte)IncludedRoom4);
			stream.Write((byte)IncludedRoom5);
			stream.Write((byte)IncludedRoom6);
			stream.Write((byte)IncludedRoom7);
			stream.Write((byte)IncludedRoom8);
			stream.Write((byte)IncludedRoom9);
			stream.Write((byte)IncludedRoom10);
			stream.Write((byte)IncludedRoom11);
			stream.Write((byte)IncludedRoom12);
			stream.Write((byte)IncludedRoom13);
			stream.Write((byte)IncludedRoom14);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class DungeonMapSettings : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private float m_MapSizeX;

		[WProperty("Misc.", "Map Size X", false)]
		 public float MapSizeX
		{ 
			get { return m_MapSizeX; }
			set
			{
				m_MapSizeX = value;
				OnPropertyChanged("MapSizeX");
			}
		}
				

		private float m_MapSizeY;

		[WProperty("Misc.", "Map Size Y", false)]
		 public float MapSizeY
		{ 
			get { return m_MapSizeY; }
			set
			{
				m_MapSizeY = value;
				OnPropertyChanged("MapSizeY");
			}
		}
				

		private float m_MapScaleInverse;

		[WProperty("Misc.", "Map Scale Inverse", false)]
		 public float MapScaleInverse
		{ 
			get { return m_MapScaleInverse; }
			set
			{
				m_MapScaleInverse = value;
				OnPropertyChanged("MapScaleInverse");
			}
		}
				

		private float m_Unknown1;

		[WProperty("Misc.", "Unknown 1", false)]
		 public float Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				


		// Constructor
		public DungeonMapSettings(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Map Size X", TargetProperties = new string[] { "MapSizeX"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Map Size Y", TargetProperties = new string[] { "MapSizeY"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Map Scale Inverse", TargetProperties = new string[] { "MapScaleInverse"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_MapSizeX = stream.ReadSingle(); 
			m_MapSizeY = stream.ReadSingle(); 
			m_MapScaleInverse = stream.ReadSingle(); 
			m_Unknown1 = stream.ReadSingle(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((float)MapSizeX);
			stream.Write((float)MapSizeY);
			stream.Write((float)MapScaleInverse);
			stream.Write((float)Unknown1);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class LightSource : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private Vector3 m_Radius;

		[WProperty("Misc.", "Radius", false)]
		 public Vector3 Radius
		{ 
			get { return m_Radius; }
			set
			{
				m_Radius = value;
				OnPropertyChanged("Radius");
			}
		}
				

		private WLinearColor m_Color;

		[WProperty("Misc.", "Color", false)]
		 public WLinearColor Color
		{ 
			get { return m_Color; }
			set
			{
				m_Color = value;
				OnPropertyChanged("Color");
			}
		}
				


		// Constructor
		public LightSource(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Radius", TargetProperties = new string[] { "Radius"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Color", TargetProperties = new string[] { "Color"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			m_Radius = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			m_Color = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f, stream.ReadByte()/255f); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
			stream.Write((float)Radius.X); stream.Write((float)Radius.Y); stream.Write((float)Radius.Z);
			stream.Write((byte)(Color.R*255)); stream.Write((byte)(Color.G*255)); stream.Write((byte)(Color.B*255)); stream.Write((byte)(Color.A*255));
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class EnvironmentLightingConditions : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private byte m_ClearIndex;
				

		private byte m_RainingIndex;
				

		private byte m_SnowingIndex;
				

		private byte m_ForestParticlesIndex;
				

		private byte m_Unknown1;

		[WProperty("Unknowns", "Unknown 1", true)]
		 public byte Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				

		private byte m_Unknown2;

		[WProperty("Unknowns", "Unknown 2", true)]
		 public byte Unknown2
		{ 
			get { return m_Unknown2; }
			set
			{
				m_Unknown2 = value;
				OnPropertyChanged("Unknown2");
			}
		}
				

		private byte m_Unknown3;

		[WProperty("Unknowns", "Unknown 3", true)]
		 public byte Unknown3
		{ 
			get { return m_Unknown3; }
			set
			{
				m_Unknown3 = value;
				OnPropertyChanged("Unknown3");
			}
		}
				

		private byte m_Unknown4;

		[WProperty("Unknowns", "Unknown 4", true)]
		 public byte Unknown4
		{ 
			get { return m_Unknown4; }
			set
			{
				m_Unknown4 = value;
				OnPropertyChanged("Unknown4");
			}
		}
				


		// Constructor
		public EnvironmentLightingConditions(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 2", TargetProperties = new string[] { "Unknown2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 3", TargetProperties = new string[] { "Unknown3"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 4", TargetProperties = new string[] { "Unknown4"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_ClearIndex = stream.ReadByte(); 
			m_RainingIndex = stream.ReadByte(); 
			m_SnowingIndex = stream.ReadByte(); 
			m_ForestParticlesIndex = stream.ReadByte(); 
			m_Unknown1 = stream.ReadByte(); 
			m_Unknown2 = stream.ReadByte(); 
			m_Unknown3 = stream.ReadByte(); 
			m_Unknown4 = stream.ReadByte(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((byte)m_ClearIndex);
			stream.Write((byte)m_RainingIndex);
			stream.Write((byte)m_SnowingIndex);
			stream.Write((byte)m_ForestParticlesIndex);
			stream.Write((byte)Unknown1);
			stream.Write((byte)Unknown2);
			stream.Write((byte)Unknown3);
			stream.Write((byte)Unknown4);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class EnvironmentLightingPalette : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private WLinearColor m_ShadowColor;

		[WProperty("Misc.", "Shadow Color", true)]
		 public WLinearColor ShadowColor
		{ 
			get { return m_ShadowColor; }
			set
			{
				m_ShadowColor = value;
				OnPropertyChanged("ShadowColor");
			}
		}
				

		private WLinearColor m_ActorAmbientColor;

		[WProperty("Misc.", "Actor Ambient Color", true)]
		 public WLinearColor ActorAmbientColor
		{ 
			get { return m_ActorAmbientColor; }
			set
			{
				m_ActorAmbientColor = value;
				OnPropertyChanged("ActorAmbientColor");
			}
		}
				

		private WLinearColor m_RoomLightColor;

		[WProperty("Misc.", "Room Light Color", true)]
		 public WLinearColor RoomLightColor
		{ 
			get { return m_RoomLightColor; }
			set
			{
				m_RoomLightColor = value;
				OnPropertyChanged("RoomLightColor");
			}
		}
				

		private WLinearColor m_RoomAmbientColor;

		[WProperty("Misc.", "Room Ambient Color", true)]
		 public WLinearColor RoomAmbientColor
		{ 
			get { return m_RoomAmbientColor; }
			set
			{
				m_RoomAmbientColor = value;
				OnPropertyChanged("RoomAmbientColor");
			}
		}
				

		private WLinearColor m_WaveColor;

		[WProperty("Misc.", "Wave Color", true)]
		 public WLinearColor WaveColor
		{ 
			get { return m_WaveColor; }
			set
			{
				m_WaveColor = value;
				OnPropertyChanged("WaveColor");
			}
		}
				

		private WLinearColor m_OceanColor;

		[WProperty("Misc.", "Ocean Color", true)]
		 public WLinearColor OceanColor
		{ 
			get { return m_OceanColor; }
			set
			{
				m_OceanColor = value;
				OnPropertyChanged("OceanColor");
			}
		}
				

		private WLinearColor m_UnknownWhite1;

		[WProperty("Misc.", "Unknown White 1", true)]
		 public WLinearColor UnknownWhite1
		{ 
			get { return m_UnknownWhite1; }
			set
			{
				m_UnknownWhite1 = value;
				OnPropertyChanged("UnknownWhite1");
			}
		}
				

		private WLinearColor m_UnknownWhite2;

		[WProperty("Misc.", "Unknown White 2", true)]
		 public WLinearColor UnknownWhite2
		{ 
			get { return m_UnknownWhite2; }
			set
			{
				m_UnknownWhite2 = value;
				OnPropertyChanged("UnknownWhite2");
			}
		}
				

		private WLinearColor m_DoorBackfill;

		[WProperty("Misc.", "Door Backfill", true)]
		 public WLinearColor DoorBackfill
		{ 
			get { return m_DoorBackfill; }
			set
			{
				m_DoorBackfill = value;
				OnPropertyChanged("DoorBackfill");
			}
		}
				

		private WLinearColor m_Unknown3;

		[WProperty("Misc.", "Unknown 3", true)]
		 public WLinearColor Unknown3
		{ 
			get { return m_Unknown3; }
			set
			{
				m_Unknown3 = value;
				OnPropertyChanged("Unknown3");
			}
		}
				

		private WLinearColor m_FogColor;

		[WProperty("Misc.", "Fog Color", true)]
		 public WLinearColor FogColor
		{ 
			get { return m_FogColor; }
			set
			{
				m_FogColor = value;
				OnPropertyChanged("FogColor");
			}
		}
				

		private byte m_SkyboxPaletteIndex;
				

		private byte m_Padding1;

		[WProperty("Misc.", "Padding 1", true)]
		 public byte Padding1
		{ 
			get { return m_Padding1; }
			set
			{
				m_Padding1 = value;
				OnPropertyChanged("Padding1");
			}
		}
				

		private byte m_Padding2;

		[WProperty("Misc.", "Padding 2", true)]
		 public byte Padding2
		{ 
			get { return m_Padding2; }
			set
			{
				m_Padding2 = value;
				OnPropertyChanged("Padding2");
			}
		}
				

		private float m_FogFarPlane;

		[WProperty("Misc.", "Fog Far Plane", true)]
		 public float FogFarPlane
		{ 
			get { return m_FogFarPlane; }
			set
			{
				m_FogFarPlane = value;
				OnPropertyChanged("FogFarPlane");
			}
		}
				

		private float m_FogNearPlane;

		[WProperty("Misc.", "Fog Near Plane", true)]
		 public float FogNearPlane
		{ 
			get { return m_FogNearPlane; }
			set
			{
				m_FogNearPlane = value;
				OnPropertyChanged("FogNearPlane");
			}
		}
				


		// Constructor
		public EnvironmentLightingPalette(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Shadow Color", TargetProperties = new string[] { "ShadowColor"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Actor Ambient Color", TargetProperties = new string[] { "ActorAmbientColor"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Room Light Color", TargetProperties = new string[] { "RoomLightColor"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Room Ambient Color", TargetProperties = new string[] { "RoomAmbientColor"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Wave Color", TargetProperties = new string[] { "WaveColor"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Ocean Color", TargetProperties = new string[] { "OceanColor"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown White 1", TargetProperties = new string[] { "UnknownWhite1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown White 2", TargetProperties = new string[] { "UnknownWhite2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Door Backfill", TargetProperties = new string[] { "DoorBackfill"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 3", TargetProperties = new string[] { "Unknown3"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Fog Color", TargetProperties = new string[] { "FogColor"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding 1", TargetProperties = new string[] { "Padding1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding 2", TargetProperties = new string[] { "Padding2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Fog Far Plane", TargetProperties = new string[] { "FogFarPlane"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Fog Near Plane", TargetProperties = new string[] { "FogNearPlane"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_ShadowColor = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f); 
			m_ActorAmbientColor = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f); 
			m_RoomLightColor = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f); 
			m_RoomAmbientColor = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f); 
			m_WaveColor = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f); 
			m_OceanColor = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f); 
			m_UnknownWhite1 = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f); 
			m_UnknownWhite2 = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f); 
			m_DoorBackfill = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f); 
			m_Unknown3 = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f); 
			m_FogColor = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f); 
			m_SkyboxPaletteIndex = stream.ReadByte(); 
			m_Padding1 = stream.ReadByte(); Trace.Assert(m_Padding1 == 0xFF || m_Padding1== 0); // Padding
			m_Padding2 = stream.ReadByte(); Trace.Assert(m_Padding2 == 0xFF || m_Padding2== 0); // Padding
			m_FogFarPlane = stream.ReadSingle(); 
			m_FogNearPlane = stream.ReadSingle(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((byte)(ShadowColor.R*255)); stream.Write((byte)(ShadowColor.G*255)); stream.Write((byte)(ShadowColor.B*255));
			stream.Write((byte)(ActorAmbientColor.R*255)); stream.Write((byte)(ActorAmbientColor.G*255)); stream.Write((byte)(ActorAmbientColor.B*255));
			stream.Write((byte)(RoomLightColor.R*255)); stream.Write((byte)(RoomLightColor.G*255)); stream.Write((byte)(RoomLightColor.B*255));
			stream.Write((byte)(RoomAmbientColor.R*255)); stream.Write((byte)(RoomAmbientColor.G*255)); stream.Write((byte)(RoomAmbientColor.B*255));
			stream.Write((byte)(WaveColor.R*255)); stream.Write((byte)(WaveColor.G*255)); stream.Write((byte)(WaveColor.B*255));
			stream.Write((byte)(OceanColor.R*255)); stream.Write((byte)(OceanColor.G*255)); stream.Write((byte)(OceanColor.B*255));
			stream.Write((byte)(UnknownWhite1.R*255)); stream.Write((byte)(UnknownWhite1.G*255)); stream.Write((byte)(UnknownWhite1.B*255));
			stream.Write((byte)(UnknownWhite2.R*255)); stream.Write((byte)(UnknownWhite2.G*255)); stream.Write((byte)(UnknownWhite2.B*255));
			stream.Write((byte)(DoorBackfill.R*255)); stream.Write((byte)(DoorBackfill.G*255)); stream.Write((byte)(DoorBackfill.B*255));
			stream.Write((byte)(Unknown3.R*255)); stream.Write((byte)(Unknown3.G*255)); stream.Write((byte)(Unknown3.B*255));
			stream.Write((byte)(FogColor.R*255)); stream.Write((byte)(FogColor.G*255)); stream.Write((byte)(FogColor.B*255));
			stream.Write((byte)m_SkyboxPaletteIndex);
			stream.Write((byte)0); // Padding
			stream.Write((byte)0); // Padding
			stream.Write((float)FogFarPlane);
			stream.Write((float)FogNearPlane);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class EnvironmentLightingSkyboxPalette : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private WLinearColor m_Unknown1;

		[WProperty("Misc.", "Unknown 1", true)]
		 public WLinearColor Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				

		private WLinearColor m_Unknown2;

		[WProperty("Misc.", "Unknown 2", true)]
		 public WLinearColor Unknown2
		{ 
			get { return m_Unknown2; }
			set
			{
				m_Unknown2 = value;
				OnPropertyChanged("Unknown2");
			}
		}
				

		private WLinearColor m_Unknown3;

		[WProperty("Misc.", "Unknown 3", true)]
		 public WLinearColor Unknown3
		{ 
			get { return m_Unknown3; }
			set
			{
				m_Unknown3 = value;
				OnPropertyChanged("Unknown3");
			}
		}
				

		private WLinearColor m_Unknown4;

		[WProperty("Misc.", "Unknown 4", true)]
		 public WLinearColor Unknown4
		{ 
			get { return m_Unknown4; }
			set
			{
				m_Unknown4 = value;
				OnPropertyChanged("Unknown4");
			}
		}
				

		private WLinearColor m_HorizonCloudColor;

		[WProperty("Misc.", "Horizon Cloud Color", true)]
		 public WLinearColor HorizonCloudColor
		{ 
			get { return m_HorizonCloudColor; }
			set
			{
				m_HorizonCloudColor = value;
				OnPropertyChanged("HorizonCloudColor");
			}
		}
				

		private WLinearColor m_CenterCloudColor;

		[WProperty("Misc.", "Center Cloud Color", true)]
		 public WLinearColor CenterCloudColor
		{ 
			get { return m_CenterCloudColor; }
			set
			{
				m_CenterCloudColor = value;
				OnPropertyChanged("CenterCloudColor");
			}
		}
				

		private WLinearColor m_SkyColor;

		[WProperty("Misc.", "Sky Color", true)]
		 public WLinearColor SkyColor
		{ 
			get { return m_SkyColor; }
			set
			{
				m_SkyColor = value;
				OnPropertyChanged("SkyColor");
			}
		}
				

		private WLinearColor m_FalseSeaColor;

		[WProperty("Misc.", "False Sea Color", true)]
		 public WLinearColor FalseSeaColor
		{ 
			get { return m_FalseSeaColor; }
			set
			{
				m_FalseSeaColor = value;
				OnPropertyChanged("FalseSeaColor");
			}
		}
				

		private WLinearColor m_HorizonColor;

		[WProperty("Misc.", "Horizon Color", true)]
		 public WLinearColor HorizonColor
		{ 
			get { return m_HorizonColor; }
			set
			{
				m_HorizonColor = value;
				OnPropertyChanged("HorizonColor");
			}
		}
				

		private byte m_Padding1;

		[WProperty("Misc.", "Padding 1", false)]
		 public byte Padding1
		{ 
			get { return m_Padding1; }
			set
			{
				m_Padding1 = value;
				OnPropertyChanged("Padding1");
			}
		}
				

		private byte m_Padding2;

		[WProperty("Misc.", "Padding 2", false)]
		 public byte Padding2
		{ 
			get { return m_Padding2; }
			set
			{
				m_Padding2 = value;
				OnPropertyChanged("Padding2");
			}
		}
				

		private byte m_Padding3;

		[WProperty("Misc.", "Padding 3", false)]
		 public byte Padding3
		{ 
			get { return m_Padding3; }
			set
			{
				m_Padding3 = value;
				OnPropertyChanged("Padding3");
			}
		}
				


		// Constructor
		public EnvironmentLightingSkyboxPalette(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 2", TargetProperties = new string[] { "Unknown2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 3", TargetProperties = new string[] { "Unknown3"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 4", TargetProperties = new string[] { "Unknown4"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Horizon Cloud Color", TargetProperties = new string[] { "HorizonCloudColor"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Center Cloud Color", TargetProperties = new string[] { "CenterCloudColor"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Sky Color", TargetProperties = new string[] { "SkyColor"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "False Sea Color", TargetProperties = new string[] { "FalseSeaColor"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Horizon Color", TargetProperties = new string[] { "HorizonColor"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding 1", TargetProperties = new string[] { "Padding1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding 2", TargetProperties = new string[] { "Padding2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding 3", TargetProperties = new string[] { "Padding3"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Unknown1 = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f, stream.ReadByte()/255f); 
			m_Unknown2 = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f, stream.ReadByte()/255f); 
			m_Unknown3 = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f, stream.ReadByte()/255f); 
			m_Unknown4 = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f, stream.ReadByte()/255f); 
			m_HorizonCloudColor = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f, stream.ReadByte()/255f); 
			m_CenterCloudColor = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f, stream.ReadByte()/255f); 
			m_SkyColor = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f); 
			m_FalseSeaColor = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f); 
			m_HorizonColor = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f); 
			m_Padding1 = stream.ReadByte(); Trace.Assert(m_Padding1 == 0xFF || m_Padding1== 0); // Padding
			m_Padding2 = stream.ReadByte(); Trace.Assert(m_Padding2 == 0xFF || m_Padding2== 0); // Padding
			m_Padding3 = stream.ReadByte(); Trace.Assert(m_Padding3 == 0xFF || m_Padding3== 0); // Padding
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((byte)(Unknown1.R*255)); stream.Write((byte)(Unknown1.G*255)); stream.Write((byte)(Unknown1.B*255)); stream.Write((byte)(Unknown1.A*255));
			stream.Write((byte)(Unknown2.R*255)); stream.Write((byte)(Unknown2.G*255)); stream.Write((byte)(Unknown2.B*255)); stream.Write((byte)(Unknown2.A*255));
			stream.Write((byte)(Unknown3.R*255)); stream.Write((byte)(Unknown3.G*255)); stream.Write((byte)(Unknown3.B*255)); stream.Write((byte)(Unknown3.A*255));
			stream.Write((byte)(Unknown4.R*255)); stream.Write((byte)(Unknown4.G*255)); stream.Write((byte)(Unknown4.B*255)); stream.Write((byte)(Unknown4.A*255));
			stream.Write((byte)(HorizonCloudColor.R*255)); stream.Write((byte)(HorizonCloudColor.G*255)); stream.Write((byte)(HorizonCloudColor.B*255)); stream.Write((byte)(HorizonCloudColor.A*255));
			stream.Write((byte)(CenterCloudColor.R*255)); stream.Write((byte)(CenterCloudColor.G*255)); stream.Write((byte)(CenterCloudColor.B*255)); stream.Write((byte)(CenterCloudColor.A*255));
			stream.Write((byte)(SkyColor.R*255)); stream.Write((byte)(SkyColor.G*255)); stream.Write((byte)(SkyColor.B*255));
			stream.Write((byte)(FalseSeaColor.R*255)); stream.Write((byte)(FalseSeaColor.G*255)); stream.Write((byte)(FalseSeaColor.B*255));
			stream.Write((byte)(HorizonColor.R*255)); stream.Write((byte)(HorizonColor.G*255)); stream.Write((byte)(HorizonColor.B*255));
			stream.Write((byte)0); // Padding
			stream.Write((byte)0); // Padding
			stream.Write((byte)0); // Padding
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class EnvironmentLightingTimesOfDay : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private byte m_DawnIndex;
				

		private byte m_MorningIndex;
				

		private byte m_NoonIndex;
				

		private byte m_AfternoonIndex;
				

		private byte m_DuskIndex;
				

		private byte m_NightIndex;
				

		private short m_Unknown1;
				

		private float m_Unknown2;

		[WProperty("Misc.", "Unknown 2", false)]
		 public float Unknown2
		{ 
			get { return m_Unknown2; }
			set
			{
				m_Unknown2 = value;
				OnPropertyChanged("Unknown2");
			}
		}
				


		// Constructor
		public EnvironmentLightingTimesOfDay(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 2", TargetProperties = new string[] { "Unknown2"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_DawnIndex = stream.ReadByte(); 
			m_MorningIndex = stream.ReadByte(); 
			m_NoonIndex = stream.ReadByte(); 
			m_AfternoonIndex = stream.ReadByte(); 
			m_DuskIndex = stream.ReadByte(); 
			m_NightIndex = stream.ReadByte(); 
			m_Unknown1 = stream.ReadInt16(); 
			m_Unknown2 = stream.ReadSingle(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((byte)m_DawnIndex);
			stream.Write((byte)m_MorningIndex);
			stream.Write((byte)m_NoonIndex);
			stream.Write((byte)m_AfternoonIndex);
			stream.Write((byte)m_DuskIndex);
			stream.Write((byte)m_NightIndex);
			stream.Write((short)m_Unknown1);
			stream.Write((float)Unknown2);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class MapEvent : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private byte m_Unknown1;

		[WProperty("Misc.", "Unknown 1", false)]
		 public byte Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				

		private string m_Name;

		[WProperty("Misc.", "Name", false)]
		override public string Name
		{ 
			get { return m_Name; }
			set
			{
				m_Name = value;
				OnPropertyChanged("Name");
			}
		}
				

		private byte m_Unknown2;

		[WProperty("Misc.", "Unknown 2", false)]
		 public byte Unknown2
		{ 
			get { return m_Unknown2; }
			set
			{
				m_Unknown2 = value;
				OnPropertyChanged("Unknown2");
			}
		}
				

		private byte m_Unknown3;

		[WProperty("Misc.", "Unknown 3", false)]
		 public byte Unknown3
		{ 
			get { return m_Unknown3; }
			set
			{
				m_Unknown3 = value;
				OnPropertyChanged("Unknown3");
			}
		}
				

		private byte m_Unknown4;

		[WProperty("Misc.", "Unknown 4", false)]
		 public byte Unknown4
		{ 
			get { return m_Unknown4; }
			set
			{
				m_Unknown4 = value;
				OnPropertyChanged("Unknown4");
			}
		}
				

		private byte m_Unknown5;

		[WProperty("Misc.", "Unknown 5", false)]
		 public byte Unknown5
		{ 
			get { return m_Unknown5; }
			set
			{
				m_Unknown5 = value;
				OnPropertyChanged("Unknown5");
			}
		}
				

		private byte m_RoomNumber;

		[WProperty("Misc.", "Room Number", false)]
		 public byte RoomNumber
		{ 
			get { return m_RoomNumber; }
			set
			{
				m_RoomNumber = value;
				OnPropertyChanged("RoomNumber");
			}
		}
				

		private byte m_Padding1;

		[WProperty("Misc.", "Padding 1", false)]
		 public byte Padding1
		{ 
			get { return m_Padding1; }
			set
			{
				m_Padding1 = value;
				OnPropertyChanged("Padding1");
			}
		}
				

		private byte m_Padding2;

		[WProperty("Misc.", "Padding 2", false)]
		 public byte Padding2
		{ 
			get { return m_Padding2; }
			set
			{
				m_Padding2 = value;
				OnPropertyChanged("Padding2");
			}
		}
				

		private byte m_Padding3;

		[WProperty("Misc.", "Padding 3", false)]
		 public byte Padding3
		{ 
			get { return m_Padding3; }
			set
			{
				m_Padding3 = value;
				OnPropertyChanged("Padding3");
			}
		}
				


		// Constructor
		public MapEvent(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Name", TargetProperties = new string[] { "Name"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 2", TargetProperties = new string[] { "Unknown2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 3", TargetProperties = new string[] { "Unknown3"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 4", TargetProperties = new string[] { "Unknown4"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 5", TargetProperties = new string[] { "Unknown5"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Room Number", TargetProperties = new string[] { "RoomNumber"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding 1", TargetProperties = new string[] { "Padding1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding 2", TargetProperties = new string[] { "Padding2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding 3", TargetProperties = new string[] { "Padding3"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Unknown1 = stream.ReadByte(); 
			m_Name = stream.ReadString(15).Trim(new[] { '\0' }); 
			m_Unknown2 = stream.ReadByte(); 
			m_Unknown3 = stream.ReadByte(); 
			m_Unknown4 = stream.ReadByte(); 
			m_Unknown5 = stream.ReadByte(); 
			m_RoomNumber = stream.ReadByte(); 
			m_Padding1 = stream.ReadByte(); Trace.Assert(m_Padding1 == 0xFF || m_Padding1== 0); // Padding
			m_Padding2 = stream.ReadByte(); Trace.Assert(m_Padding2 == 0xFF || m_Padding2== 0); // Padding
			m_Padding3 = stream.ReadByte(); Trace.Assert(m_Padding3 == 0xFF || m_Padding3== 0); // Padding
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((byte)Unknown1);
			stream.Write(Name.PadRight(15, '\0').ToCharArray());
			stream.Write((byte)Unknown2);
			stream.Write((byte)Unknown3);
			stream.Write((byte)Unknown4);
			stream.Write((byte)Unknown5);
			stream.Write((byte)RoomNumber);
			stream.Write((byte)0); // Padding
			stream.Write((byte)0); // Padding
			stream.Write((byte)0); // Padding
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ExitData : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private string m_MapName;

		[WProperty("Misc.", "Map Name", false)]
		 public string MapName
		{ 
			get { return m_MapName; }
			set
			{
				m_MapName = value;
				OnPropertyChanged("MapName");
			}
		}
				

		private byte m_SpawnIndex;

		[WProperty("Misc.", "Spawn Index", false)]
		 public byte SpawnIndex
		{ 
			get { return m_SpawnIndex; }
			set
			{
				m_SpawnIndex = value;
				OnPropertyChanged("SpawnIndex");
			}
		}
				

		private byte m_RoomIndex;

		[WProperty("Misc.", "Room Index", false)]
		 public byte RoomIndex
		{ 
			get { return m_RoomIndex; }
			set
			{
				m_RoomIndex = value;
				OnPropertyChanged("RoomIndex");
			}
		}
				

		private byte m_FadeOutType;

		[WProperty("Misc.", "Fade Out Type", false)]
		 public byte FadeOutType
		{ 
			get { return m_FadeOutType; }
			set
			{
				m_FadeOutType = value;
				OnPropertyChanged("FadeOutType");
			}
		}
				

		private byte m_Padding;

		[WProperty("Misc.", "Padding", false)]
		 public byte Padding
		{ 
			get { return m_Padding; }
			set
			{
				m_Padding = value;
				OnPropertyChanged("Padding");
			}
		}
				


		// Constructor
		public ExitData(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Map Name", TargetProperties = new string[] { "MapName"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Spawn Index", TargetProperties = new string[] { "SpawnIndex"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Room Index", TargetProperties = new string[] { "RoomIndex"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Fade Out Type", TargetProperties = new string[] { "FadeOutType"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding", TargetProperties = new string[] { "Padding"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_MapName = stream.ReadString(8).Trim(new[] { '\0' }); 
			m_SpawnIndex = stream.ReadByte(); 
			m_RoomIndex = stream.ReadByte(); 
			m_FadeOutType = stream.ReadByte(); 
			m_Padding = stream.ReadByte(); Trace.Assert(m_Padding == 0xFF || m_Padding== 0); // Padding
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write(MapName.PadRight(8, '\0').ToCharArray());
			stream.Write((byte)SpawnIndex);
			stream.Write((byte)RoomIndex);
			stream.Write((byte)FadeOutType);
			stream.Write((byte)0); // Padding
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class CutsceneIndexBank : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private byte m_Unknown;

		[WProperty("Misc.", "Unknown", false)]
		 public byte Unknown
		{ 
			get { return m_Unknown; }
			set
			{
				m_Unknown = value;
				OnPropertyChanged("Unknown");
			}
		}
				


		// Constructor
		public CutsceneIndexBank(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown", TargetProperties = new string[] { "Unknown"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Unknown = stream.ReadByte(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((byte)Unknown);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class LightVector : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private Vector3 m_Radius;

		[WProperty("Misc.", "Radius", false)]
		 public Vector3 Radius
		{ 
			get { return m_Radius; }
			set
			{
				m_Radius = value;
				OnPropertyChanged("Radius");
			}
		}
				

		private WLinearColor m_Color;

		[WProperty("Misc.", "Color", false)]
		 public WLinearColor Color
		{ 
			get { return m_Color; }
			set
			{
				m_Color = value;
				OnPropertyChanged("Color");
			}
		}
				


		// Constructor
		public LightVector(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Radius", TargetProperties = new string[] { "Radius"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Color", TargetProperties = new string[] { "Color"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			m_Radius = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			m_Color = new WLinearColor(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte()/255f, stream.ReadByte()/255f); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
			stream.Write((float)Radius.X); stream.Write((float)Radius.Y); stream.Write((float)Radius.Z);
			stream.Write((byte)(Color.R*255)); stream.Write((byte)(Color.G*255)); stream.Write((byte)(Color.B*255)); stream.Write((byte)(Color.A*255));
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class MemoryCO : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private byte m_Room;

		[WProperty("Misc.", "Room", false)]
		 public byte Room
		{ 
			get { return m_Room; }
			set
			{
				m_Room = value;
				OnPropertyChanged("Room");
			}
		}
				

		private byte m_Entry;

		[WProperty("Misc.", "Entry", false)]
		 public byte Entry
		{ 
			get { return m_Entry; }
			set
			{
				m_Entry = value;
				OnPropertyChanged("Entry");
			}
		}
				


		// Constructor
		public MemoryCO(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Room", TargetProperties = new string[] { "Room"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Entry", TargetProperties = new string[] { "Entry"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Room = stream.ReadByte(); 
			m_Entry = stream.ReadByte(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((byte)Room);
			stream.Write((byte)Entry);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class RoomMemoryManagement : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private int m_SizeInBytes;

		[WProperty("Misc.", "SizeInBytes", false)]
		 public int SizeInBytes
		{ 
			get { return m_SizeInBytes; }
			set
			{
				m_SizeInBytes = value;
				OnPropertyChanged("SizeInBytes");
			}
		}
				


		// Constructor
		public RoomMemoryManagement(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "SizeInBytes", TargetProperties = new string[] { "SizeInBytes"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_SizeInBytes = stream.ReadInt32(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((int)SizeInBytes);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class SpawnPoint : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private string m_Name;

		[WProperty("Spawn Properties", "Name", false)]
		override public string Name
		{ 
			get { return m_Name; }
			set
			{
				m_Name = value;
				OnPropertyChanged("Name");
			}
		}
				

		private byte m_EventIndex;

		[WProperty("Spawn Properties", "Event Index", true)]
		 public byte EventIndex
		{ 
			get { return m_EventIndex; }
			set
			{
				m_EventIndex = value;
				OnPropertyChanged("EventIndex");
			}
		}
				

		private byte m_Unknown1;

		[WProperty("Unknowns", "Unknown 1", false)]
		 public byte Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				

		private byte m_SpawnType;

		[WProperty("Spawn Properties", "Spawn Type", true)]
		 public byte SpawnType
		{ 
			get { return m_SpawnType; }
			set
			{
				m_SpawnType = value;
				OnPropertyChanged("SpawnType");
			}
		}
				

		private byte m_Room;

		[WProperty("Spawn Properties", "Room", true)]
		 public byte Room
		{ 
			get { return m_Room; }
			set
			{
				m_Room = value;
				OnPropertyChanged("Room");
			}
		}
				

		private short m_Unknown2;

		[WProperty("Unknowns", "Unknown 2", false)]
		 public short Unknown2
		{ 
			get { return m_Unknown2; }
			set
			{
				m_Unknown2 = value;
				OnPropertyChanged("Unknown2");
			}
		}
				

		private byte m_Unknown3;

		[WProperty("Unknowns", "Unknown 3", false)]
		 public byte Unknown3
		{ 
			get { return m_Unknown3; }
			set
			{
				m_Unknown3 = value;
				OnPropertyChanged("Unknown3");
			}
		}
				

		private byte m_SpawnIndex;

		[WProperty("Spawn Properties", "Spawn Index", true)]
		 public byte SpawnIndex
		{ 
			get { return m_SpawnIndex; }
			set
			{
				m_SpawnIndex = value;
				OnPropertyChanged("SpawnIndex");
			}
		}
				

		private short m_Unknown4;

		[WProperty("Unknowns", "Unknown 4", false)]
		 public short Unknown4
		{ 
			get { return m_Unknown4; }
			set
			{
				m_Unknown4 = value;
				OnPropertyChanged("Unknown4");
			}
		}
				


		// Constructor
		public SpawnPoint(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Name", TargetProperties = new string[] { "Name"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Event Index", TargetProperties = new string[] { "EventIndex"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Spawn Type", TargetProperties = new string[] { "SpawnType"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Room", TargetProperties = new string[] { "Room"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 2", TargetProperties = new string[] { "Unknown2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 3", TargetProperties = new string[] { "Unknown3"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Spawn Index", TargetProperties = new string[] { "SpawnIndex"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 4", TargetProperties = new string[] { "Unknown4"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Name = stream.ReadString(8).Trim(new[] { '\0' }); 
			m_EventIndex = stream.ReadByte(); 
			m_Unknown1 = stream.ReadByte(); 
			m_SpawnType = stream.ReadByte(); 
			m_Room = stream.ReadByte(); 
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			m_Unknown2 = stream.ReadInt16(); 
			float yRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion yRotQ = Quaternion.FromAxisAngle(new Vector3(0, 1, 0), WMath.DegreesToRadians(yRot));Transform.Rotation = Transform.Rotation * yRotQ; 
			m_Unknown3 = stream.ReadByte(); 
			m_SpawnIndex = stream.ReadByte(); 
			m_Unknown4 = stream.ReadInt16(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write(Name.PadRight(8, '\0').ToCharArray());
			stream.Write((byte)EventIndex);
			stream.Write((byte)Unknown1);
			stream.Write((byte)SpawnType);
			stream.Write((byte)Room);
			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
			stream.Write((short)Unknown2);
			stream.Write(WMath.RotationFloatToShort(originalRot.Y));
			stream.Write((byte)Unknown3);
			stream.Write((byte)SpawnIndex);
			stream.Write((short)Unknown4);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class RoomProperties : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private int m_Parameters;

		[WProperty("Misc.", "Parameters", false)]
		 public int Parameters
		{ 
			get { return m_Parameters; }
			set
			{
				m_Parameters = value;
				OnPropertyChanged("Parameters");
			}
		}
				

		private float m_SkyboxYHeight;

		[WProperty("Misc.", "Skybox Y Height", false)]
		 public float SkyboxYHeight
		{ 
			get { return m_SkyboxYHeight; }
			set
			{
				m_SkyboxYHeight = value;
				OnPropertyChanged("SkyboxYHeight");
			}
		}
				


		// Constructor
		public RoomProperties(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Parameters", TargetProperties = new string[] { "Parameters"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Skybox Y Height", TargetProperties = new string[] { "SkyboxYHeight"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Parameters = stream.ReadInt32(); 
			m_SkyboxYHeight = stream.ReadSingle(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((int)Parameters);
			stream.Write((float)SkyboxYHeight);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class RoomModelTranslation : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private Vector2 m_Translation;

		[WProperty("Misc.", "Translation", false)]
		 public Vector2 Translation
		{ 
			get { return m_Translation; }
			set
			{
				m_Translation = value;
				OnPropertyChanged("Translation");
			}
		}
				

		private byte m_Room;

		[WProperty("Misc.", "Room", false)]
		 public byte Room
		{ 
			get { return m_Room; }
			set
			{
				m_Room = value;
				OnPropertyChanged("Room");
			}
		}
				

		private byte m_WaveHeightAddition;

		[WProperty("Misc.", "Wave Height Addition", false)]
		 public byte WaveHeightAddition
		{ 
			get { return m_WaveHeightAddition; }
			set
			{
				m_WaveHeightAddition = value;
				OnPropertyChanged("WaveHeightAddition");
			}
		}
				


		// Constructor
		public RoomModelTranslation(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Translation", TargetProperties = new string[] { "Translation"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Room", TargetProperties = new string[] { "Room"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Wave Height Addition", TargetProperties = new string[] { "WaveHeightAddition"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Translation = new OpenTK.Vector2(stream.ReadSingle(), stream.ReadSingle()); 
			float yRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion yRotQ = Quaternion.FromAxisAngle(new Vector3(0, 1, 0), WMath.DegreesToRadians(yRot));Transform.Rotation = Transform.Rotation * yRotQ; 
			m_Room = stream.ReadByte(); 
			m_WaveHeightAddition = stream.ReadByte(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((float)Translation.X); stream.Write((float)Translation.Y);
			stream.Write(WMath.RotationFloatToShort(originalRot.Y));
			stream.Write((byte)Room);
			stream.Write((byte)WaveHeightAddition);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class RoomTable : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private int m_Offset;

		[WProperty("Misc.", "Offset", false)]
		 public int Offset
		{ 
			get { return m_Offset; }
			set
			{
				m_Offset = value;
				OnPropertyChanged("Offset");
			}
		}
				


		// Constructor
		public RoomTable(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Offset", TargetProperties = new string[] { "Offset"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Offset = stream.ReadInt32(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((int)Offset);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ScaleableObject : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private string m_Name;

		[WProperty("Misc.", "Name", false)]
		override public string Name
		{ 
			get { return m_Name; }
			set
			{
				m_Name = value;
				OnPropertyChanged("Name");
			}
		}
				

		private byte m_Parameter1;

		[WProperty("Misc.", "Parameter 1", false)]
		 public byte Parameter1
		{ 
			get { return m_Parameter1; }
			set
			{
				m_Parameter1 = value;
				OnPropertyChanged("Parameter1");
			}
		}
				

		private byte m_Parameter2;

		[WProperty("Misc.", "Parameter 2", false)]
		 public byte Parameter2
		{ 
			get { return m_Parameter2; }
			set
			{
				m_Parameter2 = value;
				OnPropertyChanged("Parameter2");
			}
		}
				

		private byte m_Parameter3;

		[WProperty("Misc.", "Parameter 3", false)]
		 public byte Parameter3
		{ 
			get { return m_Parameter3; }
			set
			{
				m_Parameter3 = value;
				OnPropertyChanged("Parameter3");
			}
		}
				

		private byte m_Parameter4;

		[WProperty("Misc.", "Parameter 4", false)]
		 public byte Parameter4
		{ 
			get { return m_Parameter4; }
			set
			{
				m_Parameter4 = value;
				OnPropertyChanged("Parameter4");
			}
		}
				

		private short m_AuxiliaryParameter;

		[WProperty("Misc.", "Auxiliary Parameter", false)]
		 public short AuxiliaryParameter
		{ 
			get { return m_AuxiliaryParameter; }
			set
			{
				m_AuxiliaryParameter = value;
				OnPropertyChanged("AuxiliaryParameter");
			}
		}
				

		private short m_Unknown1;

		[WProperty("Misc.", "Unknown 1", false)]
		 public short Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				

		private short m_Unknown2;

		[WProperty("Misc.", "Unknown 2", false)]
		 public short Unknown2
		{ 
			get { return m_Unknown2; }
			set
			{
				m_Unknown2 = value;
				OnPropertyChanged("Unknown2");
			}
		}
				

		private byte m_Padding;
				


		// Constructor
		public ScaleableObject(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Name", TargetProperties = new string[] { "Name"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Parameter 1", TargetProperties = new string[] { "Parameter1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Parameter 2", TargetProperties = new string[] { "Parameter2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Parameter 3", TargetProperties = new string[] { "Parameter3"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Parameter 4", TargetProperties = new string[] { "Parameter4"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Auxiliary Parameter", TargetProperties = new string[] { "AuxiliaryParameter"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 2", TargetProperties = new string[] { "Unknown2"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Name = stream.ReadString(8).Trim(new[] { '\0' }); 
			m_Parameter1 = stream.ReadByte(); 
			m_Parameter2 = stream.ReadByte(); 
			m_Parameter3 = stream.ReadByte(); 
			m_Parameter4 = stream.ReadByte(); 
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			m_AuxiliaryParameter = stream.ReadInt16(); 
			float yRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion yRotQ = Quaternion.FromAxisAngle(new Vector3(0, 1, 0), WMath.DegreesToRadians(yRot));Transform.Rotation = Transform.Rotation * yRotQ; 
			m_Unknown1 = stream.ReadInt16(); 
			m_Unknown2 = stream.ReadInt16(); 
			float xScale = stream.ReadByte() / 10f;Transform.LocalScale = new Vector3(xScale, Transform.LocalScale.Y, Transform.LocalScale.Z); 
			float yScale = stream.ReadByte() / 10f;Transform.LocalScale = new Vector3(Transform.LocalScale.X, yScale, Transform.LocalScale.Z); 
			float zScale = stream.ReadByte() / 10f;Transform.LocalScale = new Vector3(Transform.LocalScale.X, Transform.LocalScale.Y, zScale); 
			m_Padding = stream.ReadByte(); Trace.Assert(m_Padding == 0xFF || m_Padding== 0); // Padding
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write(Name.PadRight(8, '\0').ToCharArray());
			stream.Write((byte)Parameter1);
			stream.Write((byte)Parameter2);
			stream.Write((byte)Parameter3);
			stream.Write((byte)Parameter4);
			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
			stream.Write((short)AuxiliaryParameter);
			stream.Write(WMath.RotationFloatToShort(originalRot.Y));
			stream.Write((short)Unknown1);
			stream.Write((short)Unknown2);
			stream.Write((byte)(Transform.LocalScale.X * 10));
			stream.Write((byte)(Transform.LocalScale.Y * 10));
			stream.Write((byte)(Transform.LocalScale.Z * 10));
			stream.Write((byte)0); // Padding
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ShipSpawnPoint : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private float /*single axis rotation */ m_Rotation;

		[WProperty("Misc.", "Rotation", false)]
		 public float /*single axis rotation */ Rotation
		{ 
			get { return m_Rotation; }
			set
			{
				m_Rotation = value;
				OnPropertyChanged("Rotation");
			}
		}
				

		private byte m_ShipId;

		[WProperty("Misc.", "Ship Id", false)]
		 public byte ShipId
		{ 
			get { return m_ShipId; }
			set
			{
				m_ShipId = value;
				OnPropertyChanged("ShipId");
			}
		}
				

		private byte m_Unknown1;

		[WProperty("Misc.", "Unknown 1", false)]
		 public byte Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				


		// Constructor
		public ShipSpawnPoint(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Rotation", TargetProperties = new string[] { "Rotation"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Ship Id", TargetProperties = new string[] { "ShipId"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			m_Rotation = stream.ReadInt16(); 
			m_ShipId = stream.ReadByte(); 
			m_Unknown1 = stream.ReadByte(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
			stream.Write((short)Rotation);
			stream.Write((byte)ShipId);
			stream.Write((byte)Unknown1);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class SoundEffect : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private string m_Name;

		[WProperty("Misc.", "Name", false)]
		override public string Name
		{ 
			get { return m_Name; }
			set
			{
				m_Name = value;
				OnPropertyChanged("Name");
			}
		}
				

		private byte m_Unknown1;

		[WProperty("Misc.", "Unknown 1", false)]
		 public byte Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				

		private byte m_Unknown2;

		[WProperty("Misc.", "Unknown 2", false)]
		 public byte Unknown2
		{ 
			get { return m_Unknown2; }
			set
			{
				m_Unknown2 = value;
				OnPropertyChanged("Unknown2");
			}
		}
				

		private byte m_Unknown3;

		[WProperty("Misc.", "Unknown 3", false)]
		 public byte Unknown3
		{ 
			get { return m_Unknown3; }
			set
			{
				m_Unknown3 = value;
				OnPropertyChanged("Unknown3");
			}
		}
				

		private byte m_SoundID;

		[WProperty("Misc.", "Sound ID", false)]
		 public byte SoundID
		{ 
			get { return m_SoundID; }
			set
			{
				m_SoundID = value;
				OnPropertyChanged("SoundID");
			}
		}
				

		private byte m_PathIndex;

		[WProperty("Misc.", "Path Index", false)]
		 public byte PathIndex
		{ 
			get { return m_PathIndex; }
			set
			{
				m_PathIndex = value;
				OnPropertyChanged("PathIndex");
			}
		}
				

		private byte m_Padding1;

		[WProperty("Misc.", "Padding 1", false)]
		 public byte Padding1
		{ 
			get { return m_Padding1; }
			set
			{
				m_Padding1 = value;
				OnPropertyChanged("Padding1");
			}
		}
				

		private byte m_Padding2;

		[WProperty("Misc.", "Padding 2", false)]
		 public byte Padding2
		{ 
			get { return m_Padding2; }
			set
			{
				m_Padding2 = value;
				OnPropertyChanged("Padding2");
			}
		}
				

		private byte m_Padding3;

		[WProperty("Misc.", "Padding 3", false)]
		 public byte Padding3
		{ 
			get { return m_Padding3; }
			set
			{
				m_Padding3 = value;
				OnPropertyChanged("Padding3");
			}
		}
				


		// Constructor
		public SoundEffect(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Name", TargetProperties = new string[] { "Name"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 2", TargetProperties = new string[] { "Unknown2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 3", TargetProperties = new string[] { "Unknown3"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Sound ID", TargetProperties = new string[] { "SoundID"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Path Index", TargetProperties = new string[] { "PathIndex"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding 1", TargetProperties = new string[] { "Padding1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding 2", TargetProperties = new string[] { "Padding2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding 3", TargetProperties = new string[] { "Padding3"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Name = stream.ReadString(8).Trim(new[] { '\0' }); 
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			m_Unknown1 = stream.ReadByte(); 
			m_Unknown2 = stream.ReadByte(); 
			m_Unknown3 = stream.ReadByte(); 
			m_SoundID = stream.ReadByte(); 
			m_PathIndex = stream.ReadByte(); 
			m_Padding1 = stream.ReadByte(); Trace.Assert(m_Padding1 == 0xFF || m_Padding1== 0); // Padding
			m_Padding2 = stream.ReadByte(); Trace.Assert(m_Padding2 == 0xFF || m_Padding2== 0); // Padding
			m_Padding3 = stream.ReadByte(); Trace.Assert(m_Padding3 == 0xFF || m_Padding3== 0); // Padding
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write(Name.PadRight(8, '\0').ToCharArray());
			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
			stream.Write((byte)Unknown1);
			stream.Write((byte)Unknown2);
			stream.Write((byte)Unknown3);
			stream.Write((byte)SoundID);
			stream.Write((byte)PathIndex);
			stream.Write((byte)0); // Padding
			stream.Write((byte)0); // Padding
			stream.Write((byte)0); // Padding
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class StageProperties : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private float m_ZDepthMin;

		[WProperty("Misc.", "Z Depth Min", false)]
		 public float ZDepthMin
		{ 
			get { return m_ZDepthMin; }
			set
			{
				m_ZDepthMin = value;
				OnPropertyChanged("ZDepthMin");
			}
		}
				

		private float m_ZDepthMax;

		[WProperty("Misc.", "Z Depth Max", false)]
		 public float ZDepthMax
		{ 
			get { return m_ZDepthMax; }
			set
			{
				m_ZDepthMax = value;
				OnPropertyChanged("ZDepthMax");
			}
		}
				

		private short m_StageID;

		[WProperty("Misc.", "Stage ID", false)]
		 public short StageID
		{ 
			get { return m_StageID; }
			set
			{
				m_StageID = value;
				OnPropertyChanged("StageID");
			}
		}
				

		private short m_Unk_ParticleBank;

		[WProperty("Misc.", "Unk_Particle Bank", false)]
		 public short Unk_ParticleBank
		{ 
			get { return m_Unk_ParticleBank; }
			set
			{
				m_Unk_ParticleBank = value;
				OnPropertyChanged("Unk_ParticleBank");
			}
		}
				

		private short m_Unk_PropertyIndex;

		[WProperty("Misc.", "Unk_Property Index", false)]
		 public short Unk_PropertyIndex
		{ 
			get { return m_Unk_PropertyIndex; }
			set
			{
				m_Unk_PropertyIndex = value;
				OnPropertyChanged("Unk_PropertyIndex");
			}
		}
				

		private byte m_Unknown1;

		[WProperty("Misc.", "Unknown 1", false)]
		 public byte Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				

		private byte m_Unknown2;

		[WProperty("Misc.", "Unknown 2", false)]
		 public byte Unknown2
		{ 
			get { return m_Unknown2; }
			set
			{
				m_Unknown2 = value;
				OnPropertyChanged("Unknown2");
			}
		}
				

		private byte m_Unknown3;

		[WProperty("Misc.", "Unknown 3", false)]
		 public byte Unknown3
		{ 
			get { return m_Unknown3; }
			set
			{
				m_Unknown3 = value;
				OnPropertyChanged("Unknown3");
			}
		}
				

		private byte m_Unknown4;

		[WProperty("Misc.", "Unknown 4", false)]
		 public byte Unknown4
		{ 
			get { return m_Unknown4; }
			set
			{
				m_Unknown4 = value;
				OnPropertyChanged("Unknown4");
			}
		}
				

		private short m_Unk_DrawRange;

		[WProperty("Misc.", "Unk_Draw Range", false)]
		 public short Unk_DrawRange
		{ 
			get { return m_Unk_DrawRange; }
			set
			{
				m_Unk_DrawRange = value;
				OnPropertyChanged("Unk_DrawRange");
			}
		}
				


		// Constructor
		public StageProperties(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Z Depth Min", TargetProperties = new string[] { "ZDepthMin"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Z Depth Max", TargetProperties = new string[] { "ZDepthMax"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Stage ID", TargetProperties = new string[] { "StageID"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unk_Particle Bank", TargetProperties = new string[] { "Unk_ParticleBank"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unk_Property Index", TargetProperties = new string[] { "Unk_PropertyIndex"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 2", TargetProperties = new string[] { "Unknown2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 3", TargetProperties = new string[] { "Unknown3"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 4", TargetProperties = new string[] { "Unknown4"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unk_Draw Range", TargetProperties = new string[] { "Unk_DrawRange"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_ZDepthMin = stream.ReadSingle(); 
			m_ZDepthMax = stream.ReadSingle(); 
			m_StageID = stream.ReadInt16(); 
			m_Unk_ParticleBank = stream.ReadInt16(); 
			m_Unk_PropertyIndex = stream.ReadInt16(); 
			m_Unknown1 = stream.ReadByte(); 
			m_Unknown2 = stream.ReadByte(); 
			m_Unknown3 = stream.ReadByte(); 
			m_Unknown4 = stream.ReadByte(); 
			m_Unk_DrawRange = stream.ReadInt16(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((float)ZDepthMin);
			stream.Write((float)ZDepthMax);
			stream.Write((short)StageID);
			stream.Write((short)Unk_ParticleBank);
			stream.Write((short)Unk_PropertyIndex);
			stream.Write((byte)Unknown1);
			stream.Write((byte)Unknown2);
			stream.Write((byte)Unknown3);
			stream.Write((byte)Unknown4);
			stream.Write((short)Unk_DrawRange);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class TGDR : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private string m_Name;

		[WProperty("Misc.", "Name", false)]
		override public string Name
		{ 
			get { return m_Name; }
			set
			{
				m_Name = value;
				OnPropertyChanged("Name");
			}
		}
				

		private int m_Parameters;

		[WProperty("Misc.", "Parameters", false)]
		 public int Parameters
		{ 
			get { return m_Parameters; }
			set
			{
				m_Parameters = value;
				OnPropertyChanged("Parameters");
			}
		}
				

		private short m_AuxillaryParameters1;

		[WProperty("Misc.", "Auxillary Parameters 1", false)]
		 public short AuxillaryParameters1
		{ 
			get { return m_AuxillaryParameters1; }
			set
			{
				m_AuxillaryParameters1 = value;
				OnPropertyChanged("AuxillaryParameters1");
			}
		}
				

		private short m_AuxillaryParameters2;

		[WProperty("Misc.", "Auxillary Parameters 2", false)]
		 public short AuxillaryParameters2
		{ 
			get { return m_AuxillaryParameters2; }
			set
			{
				m_AuxillaryParameters2 = value;
				OnPropertyChanged("AuxillaryParameters2");
			}
		}
				

		private short m_Unknown1;

		[WProperty("Misc.", "Unknown 1", false)]
		 public short Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				

		private byte m_Padding;

		[WProperty("Misc.", "Padding", false)]
		 public byte Padding
		{ 
			get { return m_Padding; }
			set
			{
				m_Padding = value;
				OnPropertyChanged("Padding");
			}
		}
				


		// Constructor
		public TGDR(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Name", TargetProperties = new string[] { "Name"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Parameters", TargetProperties = new string[] { "Parameters"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Auxillary Parameters 1", TargetProperties = new string[] { "AuxillaryParameters1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Auxillary Parameters 2", TargetProperties = new string[] { "AuxillaryParameters2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding", TargetProperties = new string[] { "Padding"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Name = stream.ReadString(8).Trim(new[] { '\0' }); 
			m_Parameters = stream.ReadInt32(); 
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			m_AuxillaryParameters1 = stream.ReadInt16(); 
			float yRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion yRotQ = Quaternion.FromAxisAngle(new Vector3(0, 1, 0), WMath.DegreesToRadians(yRot));Transform.Rotation = Transform.Rotation * yRotQ; 
			m_AuxillaryParameters2 = stream.ReadInt16(); 
			m_Unknown1 = stream.ReadInt16(); 
			float xScale = stream.ReadByte() / 10f;Transform.LocalScale = new Vector3(xScale, Transform.LocalScale.Y, Transform.LocalScale.Z); 
			float yScale = stream.ReadByte() / 10f;Transform.LocalScale = new Vector3(Transform.LocalScale.X, yScale, Transform.LocalScale.Z); 
			float zScale = stream.ReadByte() / 10f;Transform.LocalScale = new Vector3(Transform.LocalScale.X, Transform.LocalScale.Y, zScale); 
			m_Padding = stream.ReadByte(); Trace.Assert(m_Padding == 0xFF || m_Padding== 0); // Padding
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write(Name.PadRight(8, '\0').ToCharArray());
			stream.Write((int)Parameters);
			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
			stream.Write((short)AuxillaryParameters1);
			stream.Write(WMath.RotationFloatToShort(originalRot.Y));
			stream.Write((short)AuxillaryParameters2);
			stream.Write((short)Unknown1);
			stream.Write((byte)(Transform.LocalScale.X * 10));
			stream.Write((byte)(Transform.LocalScale.Y * 10));
			stream.Write((byte)(Transform.LocalScale.Z * 10));
			stream.Write((byte)0); // Padding
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class TagObject : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private string m_Name;

		[WProperty("Misc.", "Name", false)]
		override public string Name
		{ 
			get { return m_Name; }
			set
			{
				m_Name = value;
				OnPropertyChanged("Name");
			}
		}
				

		private int m_Parameters;

		[WProperty("Misc.", "Parameters", false)]
		 public int Parameters
		{ 
			get { return m_Parameters; }
			set
			{
				m_Parameters = value;
				OnPropertyChanged("Parameters");
			}
		}
				

		private short m_Padding;

		[WProperty("Misc.", "Padding", false)]
		 public short Padding
		{ 
			get { return m_Padding; }
			set
			{
				m_Padding = value;
				OnPropertyChanged("Padding");
			}
		}
				


		// Constructor
		public TagObject(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Name", TargetProperties = new string[] { "Name"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Parameters", TargetProperties = new string[] { "Parameters"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Padding", TargetProperties = new string[] { "Padding"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Name = stream.ReadString(8).Trim(new[] { '\0' }); 
			m_Parameters = stream.ReadInt32(); 
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			float xRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion xRotQ = Quaternion.FromAxisAngle(new Vector3(1, 0, 0), WMath.DegreesToRadians(xRot));Transform.Rotation = Transform.Rotation * xRotQ; 
			float yRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion yRotQ = Quaternion.FromAxisAngle(new Vector3(0, 1, 0), WMath.DegreesToRadians(yRot));Transform.Rotation = Transform.Rotation * yRotQ; 
			float zRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion zRotQ = Quaternion.FromAxisAngle(new Vector3(0, 0, 1), WMath.DegreesToRadians(zRot));Transform.Rotation = Transform.Rotation * zRotQ; 
			m_Padding = stream.ReadInt16(); Trace.Assert((ushort)m_Padding == 0xFFFF || m_Padding== 0); // Padding
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write(Name.PadRight(8, '\0').ToCharArray());
			stream.Write((int)Parameters);
			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
			stream.Write(WMath.RotationFloatToShort(originalRot.X));
			stream.Write(WMath.RotationFloatToShort(originalRot.Y));
			stream.Write(WMath.RotationFloatToShort(originalRot.Z));
			stream.Write((short)0); // Padding
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class TagScaleableObject : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private string m_Name;

		[WProperty("Misc.", "Name", false)]
		override public string Name
		{ 
			get { return m_Name; }
			set
			{
				m_Name = value;
				OnPropertyChanged("Name");
			}
		}
				

		private int m_Params1;

		[WProperty("Misc.", "Params 1", false)]
		 public int Params1
		{ 
			get { return m_Params1; }
			set
			{
				m_Params1 = value;
				OnPropertyChanged("Params1");
			}
		}
				

		private short m_RoomLoadingParams;

		[WProperty("Misc.", "RoomLoadingParams", false)]
		 public short RoomLoadingParams
		{ 
			get { return m_RoomLoadingParams; }
			set
			{
				m_RoomLoadingParams = value;
				OnPropertyChanged("RoomLoadingParams");
			}
		}
				

		private int m_Params2;

		[WProperty("Misc.", "Params 2", false)]
		 public int Params2
		{ 
			get { return m_Params2; }
			set
			{
				m_Params2 = value;
				OnPropertyChanged("Params2");
			}
		}
				


		// Constructor
		public TagScaleableObject(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Name", TargetProperties = new string[] { "Name"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Params 1", TargetProperties = new string[] { "Params1"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "RoomLoadingParams", TargetProperties = new string[] { "RoomLoadingParams"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Params 2", TargetProperties = new string[] { "Params2"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Name = stream.ReadString(8).Trim(new[] { '\0' }); 
			m_Params1 = stream.ReadInt32(); 
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			m_RoomLoadingParams = stream.ReadInt16(); 
			float xRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion xRotQ = Quaternion.FromAxisAngle(new Vector3(1, 0, 0), WMath.DegreesToRadians(xRot));Transform.Rotation = Transform.Rotation * xRotQ; 
			float yRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion yRotQ = Quaternion.FromAxisAngle(new Vector3(0, 1, 0), WMath.DegreesToRadians(yRot));Transform.Rotation = Transform.Rotation * yRotQ; 
			float zRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion zRotQ = Quaternion.FromAxisAngle(new Vector3(0, 0, 1), WMath.DegreesToRadians(zRot));Transform.Rotation = Transform.Rotation * zRotQ; 
			m_Params2 = stream.ReadInt32(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write(Name.PadRight(8, '\0').ToCharArray());
			stream.Write((int)Params1);
			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
			stream.Write((short)RoomLoadingParams);
			stream.Write(WMath.RotationFloatToShort(originalRot.X));
			stream.Write(WMath.RotationFloatToShort(originalRot.Y));
			stream.Write(WMath.RotationFloatToShort(originalRot.Z));
			stream.Write((int)Params2);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class TreasureChest : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private string m_Name;

		[WProperty("Treasure Chest", "Name", false)]
		override public string Name
		{ 
			get { return m_Name; }
			set
			{
				m_Name = value;
				OnPropertyChanged("Name");
			}
		}
				

		private int m_Parameters;
				

		private short m_AuxParameters1;
				

		private short m_AuxParameters2;
				

		private short m_Padding;
				


		// Constructor
		public TreasureChest(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Name", TargetProperties = new string[] { "Name"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Name = stream.ReadString(8).Trim(new[] { '\0' }); 
			m_Parameters = stream.ReadInt32(); 
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
			m_AuxParameters1 = stream.ReadInt16(); 
			float yRot = WMath.RotationShortToFloat(stream.ReadInt16());Quaternion yRotQ = Quaternion.FromAxisAngle(new Vector3(0, 1, 0), WMath.DegreesToRadians(yRot));Transform.Rotation = Transform.Rotation * yRotQ; 
			m_AuxParameters2 = stream.ReadInt16(); 
			m_Padding = stream.ReadInt16(); Trace.Assert((ushort)m_Padding == 0xFFFF || m_Padding== 0); // Padding
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write(Name.PadRight(8, '\0').ToCharArray());
			stream.Write((int)m_Parameters);
			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
			stream.Write((short)m_AuxParameters1);
			stream.Write(WMath.RotationFloatToShort(originalRot.Y));
			stream.Write((short)m_AuxParameters2);
			stream.Write((short)0); // Padding
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class Path_v1 : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private short m_NumberofPoints;
				

		private short m_NextPathIndex;
				

		private byte m_Unknown2;

		[WProperty("Unknowns", "Unknown 2", false)]
		 public byte Unknown2
		{ 
			get { return m_Unknown2; }
			set
			{
				m_Unknown2 = value;
				OnPropertyChanged("Unknown2");
			}
		}
				

		private byte m_PathLoops;

		[WProperty("Path Properties", "Path Loops", false)]
		 public byte PathLoops
		{ 
			get { return m_PathLoops; }
			set
			{
				m_PathLoops = value;
				OnPropertyChanged("PathLoops");
			}
		}
				

		private short m_Unknown4;

		[WProperty("Unknowns", "Unknown 4", false)]
		 public short Unknown4
		{ 
			get { return m_Unknown4; }
			set
			{
				m_Unknown4 = value;
				OnPropertyChanged("Unknown4");
			}
		}
				

		private int m_FirstEntryOffset;
				


		// Constructor
		public Path_v1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 2", TargetProperties = new string[] { "Unknown2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Path Loops", TargetProperties = new string[] { "PathLoops"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 4", TargetProperties = new string[] { "Unknown4"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_NumberofPoints = stream.ReadInt16(); 
			m_NextPathIndex = stream.ReadInt16(); 
			m_Unknown2 = stream.ReadByte(); 
			m_PathLoops = stream.ReadByte(); 
			m_Unknown4 = stream.ReadInt16(); 
			m_FirstEntryOffset = stream.ReadInt32(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((short)m_NumberofPoints);
			stream.Write((short)m_NextPathIndex);
			stream.Write((byte)Unknown2);
			stream.Write((byte)PathLoops);
			stream.Write((short)Unknown4);
			stream.Write((int)m_FirstEntryOffset);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class Path_v2 : SerializableDOMNode
	{
		// Auto-Generated Properties from Templates
		private short m_NumberofPoints;

		[WProperty("Misc.", "Number of Points", false)]
		 public short NumberofPoints
		{ 
			get { return m_NumberofPoints; }
			set
			{
				m_NumberofPoints = value;
				OnPropertyChanged("NumberofPoints");
			}
		}
				

		private short m_NextPathIndex;

		[WProperty("Misc.", "Next Path Index", false)]
		 public short NextPathIndex
		{ 
			get { return m_NextPathIndex; }
			set
			{
				m_NextPathIndex = value;
				OnPropertyChanged("NextPathIndex");
			}
		}
				

		private byte m_Unknown2;

		[WProperty("Misc.", "Unknown 2", false)]
		 public byte Unknown2
		{ 
			get { return m_Unknown2; }
			set
			{
				m_Unknown2 = value;
				OnPropertyChanged("Unknown2");
			}
		}
				

		private byte m_PathLoops;

		[WProperty("Misc.", "Path Loops", false)]
		 public byte PathLoops
		{ 
			get { return m_PathLoops; }
			set
			{
				m_PathLoops = value;
				OnPropertyChanged("PathLoops");
			}
		}
				

		private short m_Unknown4;

		[WProperty("Misc.", "Unknown 4", false)]
		 public short Unknown4
		{ 
			get { return m_Unknown4; }
			set
			{
				m_Unknown4 = value;
				OnPropertyChanged("Unknown4");
			}
		}
				

		private int m_FirstEntryOffset;

		[WProperty("Misc.", "First Entry Offset", false)]
		 public int FirstEntryOffset
		{ 
			get { return m_FirstEntryOffset; }
			set
			{
				m_FirstEntryOffset = value;
				OnPropertyChanged("FirstEntryOffset");
			}
		}
				


		// Constructor
		public Path_v2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Number of Points", TargetProperties = new string[] { "NumberofPoints"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Next Path Index", TargetProperties = new string[] { "NextPathIndex"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 2", TargetProperties = new string[] { "Unknown2"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Path Loops", TargetProperties = new string[] { "PathLoops"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 4", TargetProperties = new string[] { "Unknown4"} });
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "First Entry Offset", TargetProperties = new string[] { "FirstEntryOffset"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_NumberofPoints = stream.ReadInt16(); 
			m_NextPathIndex = stream.ReadInt16(); 
			m_Unknown2 = stream.ReadByte(); 
			m_PathLoops = stream.ReadByte(); 
			m_Unknown4 = stream.ReadInt16(); 
			m_FirstEntryOffset = stream.ReadInt32(); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((short)NumberofPoints);
			stream.Write((short)NextPathIndex);
			stream.Write((byte)Unknown2);
			stream.Write((byte)PathLoops);
			stream.Write((short)Unknown4);
			stream.Write((int)FirstEntryOffset);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class PathPoint_v1 : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private int m_Unknown1;

		[WProperty("Unknowns", "Unknown 1", true)]
		 public int Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				


		// Constructor
		public PathPoint_v1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Unknown1 = stream.ReadInt32(); 
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((int)Unknown1);
			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class PathPoint_v2 : VisibleDOMNode
	{
		// Auto-Generated Properties from Templates
		private int m_Unknown1;

		[WProperty("Misc.", "Unknown 1", false)]
		 public int Unknown1
		{ 
			get { return m_Unknown1; }
			set
			{
				m_Unknown1 = value;
				OnPropertyChanged("Unknown1");
			}
		}
				


		// Constructor
		public PathPoint_v2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			VisibleProperties.Add(new Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition() { DisplayName = "Unknown 1", TargetProperties = new string[] { "Unknown1"} });
		}

		override public void Load(EndianBinaryReader stream)
		{
			m_Unknown1 = stream.ReadInt32(); 
			Transform.Position = new OpenTK.Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); 
		}

		override public void Save(EndianBinaryWriter stream)
		{
			// Just convert their rotation to Euler Angles now instead of doing it in parts later.
            Vector3 eulerRot = Transform.Rotation.ToEulerAngles();
			Vector3 originalRot = new Vector3(Transform.Rotation.FindQuaternionTwist(Vector3.UnitX) * Math.Sign(eulerRot.X),Transform.Rotation.FindQuaternionTwist(Vector3.UnitY) * Math.Sign(eulerRot.Y), Transform.Rotation.FindQuaternionTwist(Vector3.UnitZ) * Math.Sign(eulerRot.Z)); 

			stream.Write((int)Unknown1);
			stream.Write((float)Transform.Position.X); stream.Write((float)Transform.Position.Y); stream.Write((float)Transform.Position.Z);
		}
	}


} // namespace WindEditor

