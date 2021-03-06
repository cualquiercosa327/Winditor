﻿// 
using GameFormatReader.Common;
using OpenTK;
using System.ComponentModel;
using System.Diagnostics;
using System;
using WindEditor.ViewModel;

namespace WindEditor
{
	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class acorn_leaf : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("acorn_leaf", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 2147483648) >> 31; }
			set
			{
				Parameters = (int)(Parameters & ~2147483648 | (value << 31 & 2147483648));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public acorn_leaf(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class agbsw0 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("agbsw0", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 65535) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("agbsw0", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("agbsw0", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("agbsw0", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4294901760) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~4294901760 | (value << 16 & 4294901760));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("agbsw0", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(AuxillaryParameters1 & 65535) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("agbsw0", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public agbsw0(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class alldie : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("alldie", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public alldie(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class am : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("am", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("am", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("am", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("am", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public am(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class am2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("am2", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("am2", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("am2", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("am2", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public am2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class amiprop : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("amiprop", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("amiprop", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public amiprop(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class andsw0 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("andsw0", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("andsw0", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("andsw0", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("andsw0", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("andsw0", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("andsw0", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(AuxillaryParameters1 & 255) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("andsw0", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public andsw0(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class andsw2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("andsw2", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("andsw2", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("andsw2", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("andsw2", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("andsw2", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(AuxillaryParameters1 & 255) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("andsw2", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public andsw2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class arrow_iceeff : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public arrow_iceeff(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class arrow_lighteff : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("arrow_lighteff", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public arrow_lighteff(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class atdoor : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("atdoor", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public atdoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class att : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("att", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public att(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class auction : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public auction(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bb : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bb", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bb", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("bb", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("bb", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("bb", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public bb(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bdk : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bdk", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bdk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bdkobj : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bdkobj", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bdkobj", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public bdkobj(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class beam : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("beam", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("beam", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("beam", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("beam", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 251658240) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~251658240 | (value << 24 & 251658240));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("beam", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 268435456) >> 28; }
			set
			{
				Parameters = (int)(Parameters & ~268435456 | (value << 28 & 268435456));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("beam", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 805306368) >> 28; }
			set
			{
				Parameters = (int)(Parameters & ~805306368 | (value << 28 & 805306368));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("beam", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(Parameters & 3221225472) >> 30; }
			set
			{
				Parameters = (int)(Parameters & ~3221225472 | (value << 30 & 3221225472));
				OnPropertyChanged("Unknown_7");
			}
		}

		[WProperty("beam", "Unknown_8", true)]
		public int Unknown_8
		{ 
			get { return (int)(AuxillaryParameters1 & 65535) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_8");
			}
		}

		// Constructor
		public beam(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bflower : Actor
	{
		// Auto-Generated Properties from Templates
		public int FlowerType
		{ 
			get { return (int)(Parameters & 240) >> 4; }
			set
			{
				Parameters = (int)(Parameters & ~240 | (value << 4 & 240));
				OnPropertyChanged("FlowerType");
			}
		}

		[WProperty("bflower", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public bflower(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bgn : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bgn", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bgn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bgn2 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public bgn2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bgn3 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public bgn3(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bigelf : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bigelf", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bigelf", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("bigelf", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public bigelf(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bita : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bita", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bita", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public bita(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bk : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bk", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bk", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16) >> 4; }
			set
			{
				Parameters = (int)(Parameters & ~16 | (value << 4 & 16));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("bk", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 32) >> 5; }
			set
			{
				Parameters = (int)(Parameters & ~32 | (value << 5 & 32));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("bk", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 192) >> 6; }
			set
			{
				Parameters = (int)(Parameters & ~192 | (value << 6 & 192));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("bk", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("bk", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("bk", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_7");
			}
		}

		[WProperty("bk", "Unknown_8", true)]
		public int Unknown_8
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_8");
			}
		}

		// Constructor
		public bk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bl : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bl", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bl", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("bl", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("bl", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public bl(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bmd : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public bmd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bmdfoot : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bmdfoot", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bmdfoot(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bmdhand : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bmdhand", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 1) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~1 | (value << 0 & 1));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bmdhand", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 3) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~3 | (value << 0 & 3));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("bmdhand", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 31) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~31 | (value << 0 & 31));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public bmdhand(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bo", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bo", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public bo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class boko : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("boko", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 1073741823) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~1073741823 | (value << 0 & 1073741823));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("boko", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 4294967295) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~4294967295 | (value << 0 & 4294967295));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("boko", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(AuxillaryParameters1 & 65535) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public boko(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class boss_item : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("boss_item", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public boss_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bpw : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bpw", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bpw", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("bpw", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public bpw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class branch : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public branch(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bridge : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bridge", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bridge", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("bridge", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public bridge(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bst : Actor
	{
		// Auto-Generated Properties from Templates
		public int ComponentType
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("ComponentType");
			}
		}

		// Constructor
		public bst(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class btd : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public btd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bwd : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bwd", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bwd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bwdg : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public bwdg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bwds : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bwds", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bwds(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class canon : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("canon", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(AuxillaryParameters1 & 65535) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public canon(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class cc : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("cc", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("cc", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("cc", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("cc", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public cc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class coming2 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public coming2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class coming3 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public coming3(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dai : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("dai", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public dai(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class daiocta : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("daiocta", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("daiocta", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("daiocta", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("daiocta", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("daiocta", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public daiocta(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class daiocta_eye : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public daiocta_eye(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class deku_item : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("Deku Leaf Pickup", "Item Pickup Flag", true)]
		public int ItemPickupFlag
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("ItemPickupFlag");
			}
		}

		// Constructor
		public deku_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class demo_dk : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public demo_dk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class demo_item : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("demo_item", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("demo_item", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public demo_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class demo_kmm : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public demo_kmm(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dk : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("dk", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public dk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class door10 : TGDR
	{
		// Auto-Generated Properties from Templates
		[WProperty("Door", "Switch Bit", true)]
		public int SwitchBit
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("SwitchBit");
			}
		}

		[WProperty("Door", "Type", true)]
		public int Type
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Door", "Event ID", true)]
		public int EventID
		{ 
			get { return (int)(Parameters & 1044480) >> 12; }
			set
			{
				Parameters = (int)(Parameters & ~1044480 | (value << 12 & 1044480));
				OnPropertyChanged("EventID");
			}
		}

		[WProperty("Door", "Switch Bit 2", true)]
		public int SwitchBit2
		{ 
			get { return (int)(Parameters & 267386880) >> 20; }
			set
			{
				Parameters = (int)(Parameters & ~267386880 | (value << 20 & 267386880));
				OnPropertyChanged("SwitchBit2");
			}
		}

		[WProperty("Door", "From Room Number", true)]
		public int FromRoomNumber
		{ 
			get { return (int)(AuxillaryParameters1 & 63) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~63 | (value << 0 & 63));
				OnPropertyChanged("FromRoomNumber");
			}
		}

		[WProperty("Door", "To Room Number", true)]
		public int ToRoomNumber
		{ 
			get { return (int)(AuxillaryParameters1 & 4032) >> 6; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~4032 | (value << 6 & 4032));
				OnPropertyChanged("ToRoomNumber");
			}
		}

		[WProperty("Door", "Ship ID", true)]
		public int ShipID
		{ 
			get { return (int)(AuxillaryParameters2 & 63) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~63 | (value << 0 & 63));
				OnPropertyChanged("ShipID");
			}
		}

		[WProperty("Door", "Arg 1", true)]
		public int Arg1
		{ 
			get { return (int)(AuxillaryParameters2 & 65280) >> 8; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Arg1");
			}
		}

		// Constructor
		public door10(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class door12 : TGDR
	{
		// Auto-Generated Properties from Templates
		[WProperty("Door", "Switch Bit", true)]
		public int SwitchBit
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("SwitchBit");
			}
		}

		[WProperty("Door", "Type", true)]
		public int Type
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Door", "Event ID", true)]
		public int EventID
		{ 
			get { return (int)(Parameters & 1044480) >> 12; }
			set
			{
				Parameters = (int)(Parameters & ~1044480 | (value << 12 & 1044480));
				OnPropertyChanged("EventID");
			}
		}

		[WProperty("Door", "Switch Bit 2", true)]
		public int SwitchBit2
		{ 
			get { return (int)(Parameters & 267386880) >> 20; }
			set
			{
				Parameters = (int)(Parameters & ~267386880 | (value << 20 & 267386880));
				OnPropertyChanged("SwitchBit2");
			}
		}

		[WProperty("Door", "From Room Number", true)]
		public int FromRoomNumber
		{ 
			get { return (int)(AuxillaryParameters1 & 63) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~63 | (value << 0 & 63));
				OnPropertyChanged("FromRoomNumber");
			}
		}

		[WProperty("Door", "To Room Number", true)]
		public int ToRoomNumber
		{ 
			get { return (int)(AuxillaryParameters1 & 4032) >> 6; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~4032 | (value << 6 & 4032));
				OnPropertyChanged("ToRoomNumber");
			}
		}

		[WProperty("Door", "Ship ID", true)]
		public int ShipID
		{ 
			get { return (int)(AuxillaryParameters2 & 63) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~63 | (value << 0 & 63));
				OnPropertyChanged("ShipID");
			}
		}

		[WProperty("Door", "Arg 1", true)]
		public int Arg1
		{ 
			get { return (int)(AuxillaryParameters2 & 65280) >> 8; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Arg1");
			}
		}

		// Constructor
		public door12(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dr : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public dr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dr2 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public dr2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dummy : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public dummy(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ep : Actor
	{
		// Auto-Generated Properties from Templates
		public int Type
		{ 
			get { return (int)(Parameters & 63) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~63 | (value << 0 & 63));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Unknowns", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 64) >> 6; }
			set
			{
				Parameters = (int)(Parameters & ~64 | (value << 6 & 64));
				OnPropertyChanged("Unknown_2");
			}
		}

		public int IsWooden
		{ 
			get { return (int)(Parameters & 128) >> 7; }
			set
			{
				Parameters = (int)(Parameters & ~128 | (value << 7 & 128));
				OnPropertyChanged("IsWooden");
			}
		}

		[WProperty("Unknowns", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("Unknowns", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_5");
			}
		}

		public int OnSwitch
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("OnSwitch");
			}
		}

		// Constructor
		public ep(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fallrock : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public fallrock(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fallrock_tag : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("fallrock_tag", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public fallrock_tag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fan : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("fan", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("fan", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 768) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~768 | (value << 8 & 768));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public fan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ff : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ff", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ff", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("ff", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4294902015) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~4294902015 | (value << 0 & 4294902015));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public ff(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fganon : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("fganon", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("fganon", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 240) >> 4; }
			set
			{
				Parameters = (int)(Parameters & ~240 | (value << 4 & 240));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("fganon", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("fganon", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("fganon", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public fganon(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fgmahou : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("fgmahou", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public fgmahou(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fire : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("fire", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("fire", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("fire", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 126976) >> 12; }
			set
			{
				Parameters = (int)(Parameters & ~126976 | (value << 12 & 126976));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("fire", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 917504) >> 17; }
			set
			{
				Parameters = (int)(Parameters & ~917504 | (value << 17 & 917504));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("fire", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 15728640) >> 20; }
			set
			{
				Parameters = (int)(Parameters & ~15728640 | (value << 20 & 15728640));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public fire(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class floor : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("floor", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public floor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fm : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("fm", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("fm", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 768) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~768 | (value << 8 & 768));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("fm", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 3072) >> 10; }
			set
			{
				Parameters = (int)(Parameters & ~3072 | (value << 10 & 3072));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("fm", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("fm", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 251658240) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~251658240 | (value << 24 & 251658240));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("fm", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("fm", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(AuxillaryParameters1 & 255) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_7");
			}
		}

		[WProperty("fm", "Unknown_8", true)]
		public int Unknown_8
		{ 
			get { return (int)(AuxillaryParameters1 & 65280) >> 8; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_8");
			}
		}

		[WProperty("fm", "Unknown_9", true)]
		public int Unknown_9
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_9");
			}
		}

		// Constructor
		public fm(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class f_pc_profile_lst : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public f_pc_profile_lst(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ghostship : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ghostship", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ghostship", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public ghostship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class gm : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("gm", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("gm", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("gm", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("gm", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("gm", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public gm(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class gnd : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("gnd", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("gnd", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public gnd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class goal_flag : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("goal_flag", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("goal_flag", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public goal_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class grass : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("grass", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("grass", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 48) >> 4; }
			set
			{
				Parameters = (int)(Parameters & ~48 | (value << 4 & 48));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("grass", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4032) >> 6; }
			set
			{
				Parameters = (int)(Parameters & ~4032 | (value << 6 & 4032));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public grass(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class gy : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public gy(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class gy_ctrl : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public gy_ctrl(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class himo3 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("himo3", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("himo3", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("himo3", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("himo3", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("himo3", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 4294967295) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~4294967295 | (value << 0 & 4294967295));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public himo3(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class hitobj : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("hitobj", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public hitobj(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class hmlif : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("hmlif", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("hmlif", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("hmlif", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 983040) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~983040 | (value << 16 & 983040));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("hmlif", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 3145728) >> 20; }
			set
			{
				Parameters = (int)(Parameters & ~3145728 | (value << 20 & 3145728));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("hmlif", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 130023424) >> 22; }
			set
			{
				Parameters = (int)(Parameters & ~130023424 | (value << 22 & 130023424));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("hmlif", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 2013265920) >> 27; }
			set
			{
				Parameters = (int)(Parameters & ~2013265920 | (value << 27 & 2013265920));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("hmlif", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(Parameters & 2147483648) >> 31; }
			set
			{
				Parameters = (int)(Parameters & ~2147483648 | (value << 31 & 2147483648));
				OnPropertyChanged("Unknown_7");
			}
		}

		[WProperty("hmlif", "Unknown_8", true)]
		public int Unknown_8
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_8");
			}
		}

		// Constructor
		public hmlif(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class hot_floor : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("hot_floor", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 1) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~1 | (value << 0 & 1));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("hot_floor", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 2) >> 1; }
			set
			{
				Parameters = (int)(Parameters & ~2 | (value << 1 & 2));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public hot_floor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class hys : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("hys", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("hys", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public hys(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class icelift : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("icelift", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("icelift", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 4080) >> 4; }
			set
			{
				Parameters = (int)(Parameters & ~4080 | (value << 4 & 4080));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("icelift", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 1044480) >> 12; }
			set
			{
				Parameters = (int)(Parameters & ~1044480 | (value << 12 & 1044480));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public icelift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ikari : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ikari", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ikari", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public ikari(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class item : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("Item Pickup", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class jbo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("jbo", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public jbo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kaji : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public kaji(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kamome : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kamome", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kamome", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("kamome", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("kamome", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public kamome(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kanban : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kanban", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 4293918720) >> 20; }
			set
			{
				Parameters = (int)(Parameters & ~4293918720 | (value << 20 & 4293918720));
				OnPropertyChanged("Unknown_1");
			}
		}

		public int MessageID
		{ 
			get { return (int)(Parameters & 65535) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("MessageID");
			}
		}

		// Constructor
		public kanban(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kantera : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kantera", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kantera", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("kantera", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public kantera(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kb : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kb", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kb", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 240) >> 4; }
			set
			{
				Parameters = (int)(Parameters & ~240 | (value << 4 & 240));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("kb", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("kb", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("kb", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(AuxillaryParameters2 & 65535) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public kb(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kddoor : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public kddoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ki : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ki", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ki", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 32512) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~32512 | (value << 8 & 32512));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("ki", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 32768) >> 15; }
			set
			{
				Parameters = (int)(Parameters & ~32768 | (value << 15 & 32768));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("ki", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("ki", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public ki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kita : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kita", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kita", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public kita(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class klft : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("klft", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("klft", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("klft", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public klft(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kmon : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public kmon(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kn : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kn", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kn", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public kn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class knob00 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("knob00", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 4026531840) >> 28; }
			set
			{
				Parameters = (int)(Parameters & ~4026531840 | (value << 28 & 4026531840));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public knob00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kokiie : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kokiie", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kokiie", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public kokiie(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class komore : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public komore(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ks : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ks", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ks", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("ks", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public ks(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kt : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kt", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 4294967295) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~4294967295 | (value << 0 & 4294967295));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public kt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kui : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kui", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 240) >> 4; }
			set
			{
				Parameters = (int)(Parameters & ~240 | (value << 4 & 240));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kui", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("kui", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public kui(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag00 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kytag00", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kytag00", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("kytag00", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("kytag00", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("kytag00", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(AuxillaryParameters1 & 255) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("kytag00", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(AuxillaryParameters1 & 65280) >> 8; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("kytag00", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public kytag00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag01 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public kytag01(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag02 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kytag02", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public kytag02(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag03 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kytag03", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public kytag03(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag04 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kytag04", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kytag04", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("kytag04", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(AuxillaryParameters1 & 255) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public kytag04(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag05 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kytag05", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public kytag05(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag06 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public kytag06(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag07 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kytag07", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public kytag07(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lamp : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("lamp", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public lamp(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lbridge : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("lbridge", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public lbridge(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class leaflift : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("leaflift", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public leaflift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lod_bg : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public lod_bg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lstair : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("lstair", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public lstair(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lwood : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public lwood(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class machine : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("machine", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public machine(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class magma : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public magma(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class majuu_flag : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("majuu_flag", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("majuu_flag", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public majuu_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mant : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mant", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public mant(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mbdoor : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mbdoor", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("mbdoor", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("mbdoor", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(AuxillaryParameters2 & 63) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~63 | (value << 0 & 63));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public mbdoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mdoor : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mdoor", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("mdoor", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("mdoor", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("mdoor", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public mdoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mflft : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mflft", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("mflft", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public mflft(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mgameboard : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public mgameboard(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mmusic : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public mmusic(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mo2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mo2", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("mo2", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("mo2", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("mo2", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("mo2", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public mo2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class movie_player : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public movie_player(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mozo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mozo", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public mozo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class msw : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("msw", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public msw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mt : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mt", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("mt", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 32512) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~32512 | (value << 8 & 32512));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("mt", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 32768) >> 15; }
			set
			{
				Parameters = (int)(Parameters & ~32768 | (value << 15 & 32768));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("mt", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("mt", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("mt", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public mt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mtoge : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mtoge", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public mtoge(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ac1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ac1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_ac1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_ac1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ah : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ah", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_ah", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_ah(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_aj1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_aj1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_aj1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_aj1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_auction : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_auction(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ba1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ba1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_ba1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bj1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_bj1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_bj1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_bj1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bm1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_bm1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_bm1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_bm1", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_bm1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bmcon1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_bmcon1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_bmcon1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bms1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_bms1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_bms1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bmsw : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_bmsw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bs1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_bs1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_bs1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 15728640) >> 20; }
			set
			{
				Parameters = (int)(Parameters & ~15728640 | (value << 20 & 15728640));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_bs1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_btsw : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_btsw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_btsw2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_btsw2", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_btsw2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_cb1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_cb1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 4294967295) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~4294967295 | (value << 0 & 4294967295));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_cb1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_co1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_co1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_co1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_de1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_de1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_de1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ds1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ds1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15728640) >> 20; }
			set
			{
				Parameters = (int)(Parameters & ~15728640 | (value << 20 & 15728640));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_ds1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_gk1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_gk1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_gk1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_gp1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_gp1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_gp1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_gp1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_hi1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_hi1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_hi1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ho : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_ho(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_hr : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_hr", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_hr", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_hr", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(AuxillaryParameters1 & 65535) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_hr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_jb1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_jb1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_jb1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ji1 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_ji1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kamome : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_kamome", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(AuxillaryParameters1 & 65535) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_kamome", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(AuxillaryParameters2 & 65535) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_kamome(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kf1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_kf1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_kf1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_kf1", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("npc_kf1", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 251658240) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~251658240 | (value << 24 & 251658240));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public npc_kf1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kg1 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_kg1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kg2 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_kg2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kk1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_kk1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_kk1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_kk1", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 196608) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~196608 | (value << 16 & 196608));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("npc_kk1", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public npc_kk1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_km1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_km1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_km1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ko1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ko1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_ko1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_ko1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kp1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_kp1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_kp1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ls1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ls1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_ls1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_md : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_md", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_md", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_md", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_md(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_mk : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_mk", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_mk", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_mk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_mn : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_mn", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_mn", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_mn", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_mn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_mt : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_mt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_nz : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_nz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ob1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ob1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_ob1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_ob1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_os : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_os", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_os(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_p1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_p1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_p1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 15728640) >> 20; }
			set
			{
				Parameters = (int)(Parameters & ~15728640 | (value << 20 & 15728640));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_p1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_p2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_p2", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 3) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~3 | (value << 0 & 3));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_p2", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 1020) >> 2; }
			set
			{
				Parameters = (int)(Parameters & ~1020 | (value << 2 & 1020));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_p2", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 261120) >> 10; }
			set
			{
				Parameters = (int)(Parameters & ~261120 | (value << 10 & 261120));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_p2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_people : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_people", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_people", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_people", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 2147483648) >> 31; }
			set
			{
				Parameters = (int)(Parameters & ~2147483648 | (value << 31 & 2147483648));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_people(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_pf1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_pf1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_pf1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_pf1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_photo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_photo", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_photo", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_photo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_pm1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_pm1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_pm1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_roten : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_roten", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_roten", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_roten(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_rsh1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_rsh1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15728640) >> 20; }
			set
			{
				Parameters = (int)(Parameters & ~15728640 | (value << 20 & 15728640));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_rsh1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_rsh1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_sarace : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_sarace(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_so : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_so(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_sv : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_sv(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_tc : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_tc", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_tc", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_tc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_tt : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_tt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_uk : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_uk", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_uk", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_uk", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 983040) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~983040 | (value << 16 & 983040));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_uk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ym1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ym1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_ym1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_yw1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_yw1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_yw1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_yw1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_zk1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_zk1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_zk1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_zl1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_zl1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_zl1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class nz : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("nz", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("nz", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("nz", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public nz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class nzg : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("nzg", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("nzg", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("nzg", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("nzg", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public nzg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_adnno : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_adnno(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ajav : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ajav", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ajav(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ajavw : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_ajavw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_akabe : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_akabe", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_akabe", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 768) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~768 | (value << 8 & 768));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_akabe", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4096) >> 12; }
			set
			{
				Parameters = (int)(Parameters & ~4096 | (value << 12 & 4096));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_akabe", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 983040) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~983040 | (value << 16 & 983040));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_akabe(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_apzl : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_apzl", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_apzl(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ashut : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ashut", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_ashut", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_ashut(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_auzu : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_auzu", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_auzu", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_auzu", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65536) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~65536 | (value << 16 & 65536));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_auzu", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 15728640) >> 20; }
			set
			{
				Parameters = (int)(Parameters & ~15728640 | (value << 20 & 15728640));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_auzu(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_aygr : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_aygr", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 1) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~1 | (value << 0 & 1));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_aygr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_balancelift : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_balancelift", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_balancelift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_barrel : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_barrel", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 1879048192) >> 28; }
			set
			{
				Parameters = (int)(Parameters & ~1879048192 | (value << 28 & 1879048192));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_barrel", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(AuxillaryParameters2 & 65535) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_barrel(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_barrel2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_barrel2", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 63) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~63 | (value << 0 & 63));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_barrel2", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 256) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~256 | (value << 8 & 256));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_barrel2", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 1024) >> 10; }
			set
			{
				Parameters = (int)(Parameters & ~1024 | (value << 10 & 1024));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_barrel2", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 8323072) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~8323072 | (value << 16 & 8323072));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_barrel2", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 50331648) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~50331648 | (value << 24 & 50331648));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_barrel2", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 268435456) >> 28; }
			set
			{
				Parameters = (int)(Parameters & ~268435456 | (value << 28 & 268435456));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public obj_barrel2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_barrier : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_barrier", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 256) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~256 | (value << 8 & 256));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_barrier", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65536) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~65536 | (value << 16 & 65536));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_barrier(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_bemos : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_bemos", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_bemos", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_bemos", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_bemos", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4026531840) >> 28; }
			set
			{
				Parameters = (int)(Parameters & ~4026531840 | (value << 28 & 4026531840));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_bemos", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(AuxillaryParameters2 & 63) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~63 | (value << 0 & 63));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_bemos", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(AuxillaryParameters2 & 8128) >> 6; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~8128 | (value << 6 & 8128));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public obj_bemos(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_bscurtain : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_bscurtain", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_bscurtain(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_buoyflag : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_buoyflag", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 3) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~3 | (value << 0 & 3));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_buoyflag", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 256) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~256 | (value << 8 & 256));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_buoyflag", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 2147483648) >> 31; }
			set
			{
				Parameters = (int)(Parameters & ~2147483648 | (value << 31 & 2147483648));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_buoyflag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_buoyrace : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_buoyrace", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_buoyrace", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_buoyrace(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_cafelmp : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_cafelmp(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_canon : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_canon", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_canon", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_canon", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_canon", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_canon(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_coming : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_coming", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_coming", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 64) >> 6; }
			set
			{
				Parameters = (int)(Parameters & ~64 | (value << 6 & 64));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_coming", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 1792) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~1792 | (value << 8 & 1792));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_coming", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_coming", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 50331648) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~50331648 | (value << 24 & 50331648));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_coming", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 805306368) >> 28; }
			set
			{
				Parameters = (int)(Parameters & ~805306368 | (value << 28 & 805306368));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public obj_coming(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_correct : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_correct", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_correct", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_correct", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_correct", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 1073741824) >> 30; }
			set
			{
				Parameters = (int)(Parameters & ~1073741824 | (value << 30 & 1073741824));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_correct(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_demo_barrel : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_demo_barrel(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_dmgroom : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_dmgroom(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_doguu : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_doguu", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_doguu(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_doguu_demo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_doguu_demo", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_doguu_demo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_dragonhead : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_dragonhead", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_dragonhead(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_drift : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_drift", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 7) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~7 | (value << 0 & 7));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_drift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_eayogn : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_eayogn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ebomzo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ebomzo", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ebomzo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_eff : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_eff", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_eff(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ekskz : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ekskz", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ekskz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_eskban : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_eskban", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_eskban(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ferris : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ferris", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ferris(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_figure : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_figure", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_figure(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_firewall : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_firewall", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_firewall(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_flame : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_flame", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_flame", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 7936) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~7936 | (value << 8 & 7936));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_flame", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 24576) >> 13; }
			set
			{
				Parameters = (int)(Parameters & ~24576 | (value << 13 & 24576));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_flame", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_flame", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 805306368) >> 28; }
			set
			{
				Parameters = (int)(Parameters & ~805306368 | (value << 28 & 805306368));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_flame", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 2147483648) >> 31; }
			set
			{
				Parameters = (int)(Parameters & ~2147483648 | (value << 31 & 2147483648));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public obj_flame(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ftree : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ftree", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ftree(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ganonbed : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_ganonbed(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gaship : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_gaship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gaship2 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_gaship2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gnnbtltaki : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_gnnbtltaki", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_gnnbtltaki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gnndemotakie : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_gnndemotakie(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gnndemotakis : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_gnndemotakis(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gong : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_gong(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gryw00 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_gryw00", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_gryw00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gtaki : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_gtaki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hami2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hami2", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_hami2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hami3 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hami3", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hami3", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_hami3", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65536) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~65536 | (value << 16 & 65536));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_hami3(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hami4 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hami4", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_hami4(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hat : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hat", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_hat(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hbrf1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hbrf1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hbrf1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 256) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~256 | (value << 8 & 256));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_hbrf1", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_hbrf1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hcbh : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hcbh", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 63) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~63 | (value << 0 & 63));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hcbh", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 8128) >> 6; }
			set
			{
				Parameters = (int)(Parameters & ~8128 | (value << 6 & 8128));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_hcbh", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 2088960) >> 13; }
			set
			{
				Parameters = (int)(Parameters & ~2088960 | (value << 13 & 2088960));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_hcbh(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hfuck1 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_hfuck1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hha : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hha", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hha", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_hha(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hlift : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hlift", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 7) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~7 | (value << 0 & 7));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hlift", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16) >> 4; }
			set
			{
				Parameters = (int)(Parameters & ~16 | (value << 4 & 16));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_hlift", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_hlift", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_hlift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hole : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hole", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hole", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_hole(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_homen : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_homen", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 127) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~127 | (value << 0 & 127));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_homen", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_homen", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 258048) >> 12; }
			set
			{
				Parameters = (int)(Parameters & ~258048 | (value << 12 & 258048));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_homen", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 3932160) >> 18; }
			set
			{
				Parameters = (int)(Parameters & ~3932160 | (value << 18 & 3932160));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_homen", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public obj_homen(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_homensmoke : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_homensmoke", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 1) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~1 | (value << 0 & 1));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_homensmoke", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 2) >> 1; }
			set
			{
				Parameters = (int)(Parameters & ~2 | (value << 1 & 2));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_homensmoke(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hsehi1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hsehi1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hsehi1", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16776960) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~16776960 | (value << 8 & 16776960));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_hsehi1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_htetu1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_htetu1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_htetu1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ice : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ice", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ice(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_iceisland : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_iceisland", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_iceisland(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ikada : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ikada", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_ikada", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 1008) >> 4; }
			set
			{
				Parameters = (int)(Parameters & ~1008 | (value << 4 & 1008));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_ikada", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 261120) >> 10; }
			set
			{
				Parameters = (int)(Parameters & ~261120 | (value << 10 & 261120));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_ikada", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_ikada", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 66846720) >> 18; }
			set
			{
				Parameters = (int)(Parameters & ~66846720 | (value << 18 & 66846720));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_ikada", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(AuxillaryParameters1 & 255) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("obj_ikada", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(AuxillaryParameters1 & 65280) >> 8; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public obj_ikada(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_Itnak : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_Itnak", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_Itnak", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_Itnak(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_jump : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_jump", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 1) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~1 | (value << 0 & 1));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_jump(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_kanat : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_kanat", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_kanat(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_kanoke : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_kanoke", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 1) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~1 | (value << 0 & 1));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_kanoke", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 62) >> 1; }
			set
			{
				Parameters = (int)(Parameters & ~62 | (value << 1 & 62));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_kanoke", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 64) >> 6; }
			set
			{
				Parameters = (int)(Parameters & ~64 | (value << 6 & 64));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_kanoke", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_kanoke", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public obj_kanoke(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ladder : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ladder", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 7) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~7 | (value << 0 & 7));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_ladder", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_ladder", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_ladder(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_leaves : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_leaves", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 63) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~63 | (value << 0 & 63));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_leaves", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 8128) >> 6; }
			set
			{
				Parameters = (int)(Parameters & ~8128 | (value << 6 & 8128));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_leaves", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 2088960) >> 13; }
			set
			{
				Parameters = (int)(Parameters & ~2088960 | (value << 13 & 2088960));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_leaves(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_light : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_light(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_lpalm : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_lpalm(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_magmarock : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_magmarock", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_magmarock", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_magmarock(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_majyuu_door : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_majyuu_door", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_majyuu_door(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mkie : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_mkie", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_mkie", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 256) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~256 | (value << 8 & 256));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_mkie", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4096) >> 12; }
			set
			{
				Parameters = (int)(Parameters & ~4096 | (value << 12 & 4096));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_mkie", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 8192) >> 13; }
			set
			{
				Parameters = (int)(Parameters & ~8192 | (value << 13 & 8192));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_mkie", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public obj_mkie(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mkiek : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_mkiek", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_mkiek", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 256) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~256 | (value << 8 & 256));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_mkiek(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mknjd : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_mknjd", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_mknjd", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65536) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~65536 | (value << 16 & 65536));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_mknjd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mmrr : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_mmrr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_monument : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_monument", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 1) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~1 | (value << 0 & 1));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_monument", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_monument(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_movebox : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_movebox", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 63) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~63 | (value << 0 & 63));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_movebox", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_movebox", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 8323072) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~8323072 | (value << 16 & 8323072));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_movebox", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 251658240) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~251658240 | (value << 24 & 251658240));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_movebox", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 1073741824) >> 30; }
			set
			{
				Parameters = (int)(Parameters & ~1073741824 | (value << 30 & 1073741824));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_movebox", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 2147483648) >> 31; }
			set
			{
				Parameters = (int)(Parameters & ~2147483648 | (value << 31 & 2147483648));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public obj_movebox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_msdan : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_msdan", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_msdan", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65536) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~65536 | (value << 16 & 65536));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_msdan", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 262144) >> 18; }
			set
			{
				Parameters = (int)(Parameters & ~262144 | (value << 18 & 262144));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_msdan", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_msdan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_msdan2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_msdan2", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_msdan2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_msdan_sub : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_msdan_sub", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_msdan_sub", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_msdan_sub", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65536) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~65536 | (value << 16 & 65536));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_msdan_sub(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_msdan_sub2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_msdan_sub2", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_msdan_sub2", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_msdan_sub2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mshokki : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_mshokki", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 3) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~3 | (value << 0 & 3));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_mshokki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mtest : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_mtest", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 7) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~7 | (value << 0 & 7));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_mtest", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_mtest", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 983040) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~983040 | (value << 16 & 983040));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_mtest", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 251658240) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~251658240 | (value << 24 & 251658240));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_mtest(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_nest : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_nest(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ohatch : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ohatch", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ohatch(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ojtree : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_ojtree(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ospbox : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ospbox", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 63) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~63 | (value << 0 & 63));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_ospbox", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 1792) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~1792 | (value << 8 & 1792));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_ospbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_otble : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_otble", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_otble(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_paper : Actor
	{
		// Auto-Generated Properties from Templates
		public int MessageID
		{ 
			get { return (int)(Parameters & 65535) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("MessageID");
			}
		}

		public int Type
		{ 
			get { return (int)(Parameters & 983040) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~983040 | (value << 16 & 983040));
				OnPropertyChanged("Type");
			}
		}

		// Constructor
		public obj_paper(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_pbco : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_pbco(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_pbka : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_pbka(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_pfall : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_pfall(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_pirateship : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_pirateship", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_pirateship", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_pirateship", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_pirateship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_plant : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_plant(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_quake : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_quake", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_quake", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 1792) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~1792 | (value << 8 & 1792));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_quake", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 14336) >> 11; }
			set
			{
				Parameters = (int)(Parameters & ~14336 | (value << 11 & 14336));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_quake(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_rcloud : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_rcloud", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 1) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~1 | (value << 0 & 1));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_rcloud(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_rflw : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_rflw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_rforce : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_rforce(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_roten : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_roten", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_roten(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_shelf : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_shelf", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 1) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~1 | (value << 0 & 1));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_shelf", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(AuxillaryParameters1 & 65535) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_shelf(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_shmrgrd : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_shmrgrd", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_shmrgrd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_smplbg : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_smplbg", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_smplbg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_stair : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_stair", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_stair(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swflat : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_swflat", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 3) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~3 | (value << 0 & 3));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_swflat", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_swflat", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_swflat(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swhammer : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_swhammer", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_swhammer", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_swhammer(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swheavy : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_swheavy", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_swheavy", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 117440512) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~117440512 | (value << 24 & 117440512));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_swheavy(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swlight : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_swlight", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_swlight", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_swlight", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65536) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~65536 | (value << 16 & 65536));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_swlight(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swpush : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_swpush", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_swpush", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_swpush", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65536) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~65536 | (value << 16 & 65536));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_swpush", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 117440512) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~117440512 | (value << 24 & 117440512));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_swpush", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 1073741824) >> 30; }
			set
			{
				Parameters = (int)(Parameters & ~1073741824 | (value << 30 & 1073741824));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public obj_swpush(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_table : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_table", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_table(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tapestry : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_tapestry", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_tapestry", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_tapestry(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tenmado : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_tenmado", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_tenmado", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_tenmado(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tide : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_tide", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 458752) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~458752 | (value << 16 & 458752));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_tide", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_tide(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_timer : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_timer", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_timer", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_timer(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tntrap : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_tntrap", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_tntrap", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_tntrap", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65536) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~65536 | (value << 16 & 65536));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_tntrap", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 393216) >> 17; }
			set
			{
				Parameters = (int)(Parameters & ~393216 | (value << 17 & 393216));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_tntrap(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_toripost : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_toripost(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tousekiki : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_tousekiki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tower : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_tower(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_trap : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_trap", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_trap", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_trap(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tribox : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_tribox", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_tribox", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65536) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~65536 | (value << 16 & 65536));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_tribox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_try : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_try", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_try", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_try", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 2147483648) >> 31; }
			set
			{
				Parameters = (int)(Parameters & ~2147483648 | (value << 31 & 2147483648));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_try", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4294902015) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~4294902015 | (value << 0 & 4294902015));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_try(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_usovmc : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_usovmc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_Vds : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_Vds", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_Vds(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vfan : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_vfan", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_vfan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vgnfd : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_vgnfd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vmc : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_vmc", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_vmc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vmsdz : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_vmsdz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vmsms : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_vmsms(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_volcano : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_volcano", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_volcano(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_Vteng : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_Vteng(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vtil : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_vtil", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_vtil(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vyasi : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_vyasi", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_vyasi(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_warpt : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_warpt", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_warpt", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 240) >> 4; }
			set
			{
				Parameters = (int)(Parameters & ~240 | (value << 4 & 240));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_warpt", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4080) >> 4; }
			set
			{
				Parameters = (int)(Parameters & ~4080 | (value << 4 & 4080));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_warpt", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_warpt", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 1044480) >> 12; }
			set
			{
				Parameters = (int)(Parameters & ~1044480 | (value << 12 & 1044480));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_warpt", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("obj_warpt", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_7");
			}
		}

		[WProperty("obj_warpt", "Unknown_8", true)]
		public int Unknown_8
		{ 
			get { return (int)(AuxillaryParameters1 & 255) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_8");
			}
		}

		[WProperty("obj_warpt", "Unknown_9", true)]
		public int Unknown_9
		{ 
			get { return (int)(AuxillaryParameters1 & 65280) >> 8; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_9");
			}
		}

		[WProperty("obj_warpt", "Unknown_10", true)]
		public int Unknown_10
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_10");
			}
		}

		[WProperty("obj_warpt", "Unknown_11", true)]
		public int Unknown_11
		{ 
			get { return (int)(AuxillaryParameters2 & 65280) >> 8; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_11");
			}
		}

		// Constructor
		public obj_warpt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_wood : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_wood(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_xfuta : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_xfuta(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_Yboil : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_Yboil", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_Yboil(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ygush00 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ygush00", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 7) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~7 | (value << 0 & 7));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ygush00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_YLzou : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_YLzou", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_YLzou(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_zouK : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_zouK", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_zouK(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class oq : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("oq", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("oq", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("oq", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public oq(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class oship : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("oship", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("oship", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("oship", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 61440) >> 12; }
			set
			{
				Parameters = (int)(Parameters & ~61440 | (value << 12 & 61440));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("oship", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("oship", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("oship", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(AuxillaryParameters1 & 255) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("oship", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(AuxillaryParameters1 & 65280) >> 8; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public oship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pedestal : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("pedestal", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public pedestal(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ph : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ph", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ph", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("ph", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public ph(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pirate_flag : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public pirate_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pt : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("pt", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("pt", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16) >> 4; }
			set
			{
				Parameters = (int)(Parameters & ~16 | (value << 4 & 16));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("pt", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 224) >> 5; }
			set
			{
				Parameters = (int)(Parameters & ~224 | (value << 5 & 224));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("pt", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("pt", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("pt", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public pt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pw : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("pw", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("pw", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 256) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~256 | (value << 8 & 256));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("pw", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65024) >> 9; }
			set
			{
				Parameters = (int)(Parameters & ~65024 | (value << 9 & 65024));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("pw", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("pw", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public pw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pz : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("pz", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public pz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class race_item : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("race_item", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("race_item", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 32512) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~32512 | (value << 8 & 32512));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("race_item", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 491520) >> 15; }
			set
			{
				Parameters = (int)(Parameters & ~491520 | (value << 15 & 491520));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public race_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class rd : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("rd", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 1) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~1 | (value << 0 & 1));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("rd", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 254) >> 1; }
			set
			{
				Parameters = (int)(Parameters & ~254 | (value << 1 & 254));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("rd", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("rd", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public rd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class rectangle : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public rectangle(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sail : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public sail(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class saku : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("saku", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("saku", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 240) >> 4; }
			set
			{
				Parameters = (int)(Parameters & ~240 | (value << 4 & 240));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("saku", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("saku", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public saku(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class salvage : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public salvage(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class salvage_tbox : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("salvage_tbox", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("salvage_tbox", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public salvage_tbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sbox : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public sbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class scene_change : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public scene_change(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class seatag : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public seatag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class shand : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("shand", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public shand(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ship : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ship", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ship", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("ship", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(AuxillaryParameters1 & 65535) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public ship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class shop_item : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("shop_item", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("shop_item", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public shop_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class shutter : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("shutter", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("shutter", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public shutter(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class shutter2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("shutter2", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public shutter2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sie_flag : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public sie_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sitem : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("sitem", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("sitem", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("sitem", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("sitem", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public sitem(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sk : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("sk", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("sk", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public sk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sk2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("sk2", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("sk2", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("sk2", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public sk2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class spotbox : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("spotbox", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 1) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~1 | (value << 0 & 1));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public spotbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ss : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ss", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ss", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("ss", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public ss(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ssk : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ssk", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ssk", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("ssk", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public ssk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sss : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("sss", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("sss", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("sss", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public sss(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class st : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("st", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("st", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("st", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("st", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("st", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public st(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class steam_tag : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("steam_tag", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 1020) >> 2; }
			set
			{
				Parameters = (int)(Parameters & ~1020 | (value << 2 & 1020));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public steam_tag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class stone : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("stone", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 63) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~63 | (value << 0 & 63));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("stone", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 192) >> 6; }
			set
			{
				Parameters = (int)(Parameters & ~192 | (value << 6 & 192));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("stone", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("stone", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 8323072) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~8323072 | (value << 16 & 8323072));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("stone", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 117440512) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~117440512 | (value << 24 & 117440512));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("stone", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 1879048192) >> 28; }
			set
			{
				Parameters = (int)(Parameters & ~1879048192 | (value << 28 & 1879048192));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public stone(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class stone2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("stone2", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 63) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~63 | (value << 0 & 63));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("stone2", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("stone2", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 8323072) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~8323072 | (value << 16 & 8323072));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("stone2", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 117440512) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~117440512 | (value << 24 & 117440512));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("stone2", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 1879048192) >> 28; }
			set
			{
				Parameters = (int)(Parameters & ~1879048192 | (value << 28 & 1879048192));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("stone2", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 2147483648) >> 31; }
			set
			{
				Parameters = (int)(Parameters & ~2147483648 | (value << 31 & 2147483648));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public stone2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swattack : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("swattack", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("swattack", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public swattack(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swc00 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("swc00", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("swc00", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("swc00", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 196608) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~196608 | (value << 16 & 196608));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public swc00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swhit0 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("swhit0", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("swhit0", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("swhit0", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 983040) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~983040 | (value << 16 & 983040));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("swhit0", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 267386880) >> 20; }
			set
			{
				Parameters = (int)(Parameters & ~267386880 | (value << 20 & 267386880));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("swhit0", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(AuxillaryParameters1 & 65535) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("swhit0", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public swhit0(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class switem : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("switem", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("switem", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16128) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~16128 | (value << 8 & 16128));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("switem", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 2080768) >> 14; }
			set
			{
				Parameters = (int)(Parameters & ~2080768 | (value << 14 & 2080768));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public switem(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swpropeller : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("swpropeller", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("swpropeller", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public swpropeller(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swtact : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("swtact", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("swtact", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("swtact", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 983040) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~983040 | (value << 16 & 983040));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public swtact(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swtdoor : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("swtdoor", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("swtdoor", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public swtdoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class syan : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public syan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_attention : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_attention", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_attention", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 768) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~768 | (value << 8 & 768));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public tag_attention(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_ba1 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public tag_ba1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_etc : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_etc", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_etc", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public tag_etc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_event : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_event", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_event", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_event", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tag_event", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("tag_event", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(AuxillaryParameters2 & 65535) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public tag_event(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_evsw : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_evsw", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_evsw", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16776960) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~16776960 | (value << 8 & 16776960));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_evsw", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 50331648) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~50331648 | (value << 24 & 50331648));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public tag_evsw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_ghostship : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_ghostship", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_ghostship", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public tag_ghostship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_hint : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_hint", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 63) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~63 | (value << 0 & 63));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_hint", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 192) >> 6; }
			set
			{
				Parameters = (int)(Parameters & ~192 | (value << 6 & 192));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_hint", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tag_hint", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("tag_hint", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_5");
			}
		}

		public int MessageID
		{ 
			get { return (int)(AuxillaryParameters1 & 65535) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("MessageID");
			}
		}

		[WProperty("tag_hint", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(AuxillaryParameters2 & 65535) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public tag_hint(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_island : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_island", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_island", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_island", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public tag_island(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_kb_item : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_kb_item", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_kb_item", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_kb_item", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tag_kb_item", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public tag_kb_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_kf1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_kf1", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 251658240) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~251658240 | (value << 24 & 251658240));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tag_kf1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_kk1 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public tag_kk1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_light : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_light", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 3) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~3 | (value << 0 & 3));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_light", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 768) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~768 | (value << 8 & 768));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_light", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 1020) >> 2; }
			set
			{
				Parameters = (int)(Parameters & ~1020 | (value << 2 & 1020));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tag_light", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 15360) >> 10; }
			set
			{
				Parameters = (int)(Parameters & ~15360 | (value << 10 & 15360));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("tag_light", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 49152) >> 14; }
			set
			{
				Parameters = (int)(Parameters & ~49152 | (value << 14 & 49152));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("tag_light", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("tag_light", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public tag_light(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_md_cb : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_md_cb", "MessageID", true)]
		public int MessageID
		{ 
			get { return (int)(Parameters & 65535) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("MessageID");
			}
		}

		[WProperty("tag_md_cb", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_md_cb", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tag_md_cb", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(AuxillaryParameters1 & 255) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public tag_md_cb(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_mk : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_mk", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_mk", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_mk", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public tag_mk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_msg : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_msg", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 192) >> 6; }
			set
			{
				Parameters = (int)(Parameters & ~192 | (value << 6 & 192));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_msg", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_msg", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tag_msg", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		public int MessageID
		{ 
			get { return (int)(AuxillaryParameters1 & 65535) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("MessageID");
			}
		}

		[WProperty("tag_msg", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(AuxillaryParameters2 & 65535) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public tag_msg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_photo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_photo", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tag_photo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_ret : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_ret", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tag_ret(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_so : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_so", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_so", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_so", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public tag_so(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_volcano : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_volcano", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 63) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~63 | (value << 0 & 63));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_volcano", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 192) >> 6; }
			set
			{
				Parameters = (int)(Parameters & ~192 | (value << 6 & 192));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_volcano", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tag_volcano", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public tag_volcano(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_waterlevel : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_waterlevel", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tag_waterlevel(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tama : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tama", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(AuxillaryParameters1 & 65535) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~65535 | (value << 0 & 65535));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tama(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tbox : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tbox", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 127) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~127 | (value << 0 & 127));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tbox", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 3968) >> 7; }
			set
			{
				Parameters = (int)(Parameters & ~3968 | (value << 7 & 3968));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tbox", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 1044480) >> 12; }
			set
			{
				Parameters = (int)(Parameters & ~1044480 | (value << 12 & 1044480));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tbox", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 15728640) >> 20; }
			set
			{
				Parameters = (int)(Parameters & ~15728640 | (value << 20 & 15728640));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("tbox", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(AuxillaryParameters1 & 63) >> 0; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~63 | (value << 0 & 63));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("tbox", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("tbox", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(AuxillaryParameters2 & 65280) >> 8; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public tbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class title : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public title(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tn : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tn", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tn", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 240) >> 4; }
			set
			{
				Parameters = (int)(Parameters & ~240 | (value << 4 & 240));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tn", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tn", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("tn", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("tn", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(AuxillaryParameters1 & 224) >> 5; }
			set
			{
				AuxillaryParameters1 = (short)(AuxillaryParameters1 & ~224 | (value << 5 & 224));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("tn", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public tn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class toge : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("toge", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("toge", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public toge(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tori_flag : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public tori_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tornado : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tornado", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 4294967295) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~4294967295 | (value << 0 & 4294967295));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tornado(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tpota : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public tpota(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tsubo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tsubo", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 63) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~63 | (value << 0 & 63));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tsubo", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 16128) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~16128 | (value << 8 & 16128));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tsubo", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 49152) >> 14; }
			set
			{
				Parameters = (int)(Parameters & ~49152 | (value << 14 & 49152));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tsubo", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 8323072) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~8323072 | (value << 16 & 8323072));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("tsubo", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 251658240) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~251658240 | (value << 24 & 251658240));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("tsubo", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 1879048192) >> 28; }
			set
			{
				Parameters = (int)(Parameters & ~1879048192 | (value << 28 & 1879048192));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("tsubo", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(Parameters & 2147483648) >> 31; }
			set
			{
				Parameters = (int)(Parameters & ~2147483648 | (value << 31 & 2147483648));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public tsubo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class wall : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("wall", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("wall", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public wall(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpdm20 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("warpdm20", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public warpdm20(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpf : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("warpf", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 4026531840) >> 28; }
			set
			{
				Parameters = (int)(Parameters & ~4026531840 | (value << 28 & 4026531840));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public warpf(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpfout : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public warpfout(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpgn : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("warpgn", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("warpgn", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public warpgn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warphr : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("warphr", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 4026531840) >> 28; }
			set
			{
				Parameters = (int)(Parameters & ~4026531840 | (value << 28 & 4026531840));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public warphr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpls : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("warpls", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("warpls", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("warpls", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("warpls", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4026531840) >> 28; }
			set
			{
				Parameters = (int)(Parameters & ~4026531840 | (value << 28 & 4026531840));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public warpls(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpmj : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("warpmj", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public warpmj(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class waterfall : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("waterfall", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("waterfall", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 3840) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~3840 | (value << 8 & 3840));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public waterfall(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class wbird : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public wbird(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class windmill : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("windmill", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public windmill(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class wind_tag : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("wind_tag", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("wind_tag", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("wind_tag", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 2031616) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~2031616 | (value << 16 & 2031616));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("wind_tag", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 6291456) >> 21; }
			set
			{
				Parameters = (int)(Parameters & ~6291456 | (value << 21 & 6291456));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("wind_tag", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(Parameters & 8388608) >> 23; }
			set
			{
				Parameters = (int)(Parameters & ~8388608 | (value << 23 & 8388608));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("wind_tag", "Unknown_6", true)]
		public int Unknown_6
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("wind_tag", "Unknown_7", true)]
		public int Unknown_7
		{ 
			get { return (int)(AuxillaryParameters2 & 15) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_7");
			}
		}

		[WProperty("wind_tag", "Unknown_8", true)]
		public int Unknown_8
		{ 
			get { return (int)(AuxillaryParameters2 & 240) >> 4; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~240 | (value << 4 & 240));
				OnPropertyChanged("Unknown_8");
			}
		}

		// Constructor
		public wind_tag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class wz : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("wz", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 255) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("wz", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("wz", "Unknown_3", true)]
		public int Unknown_3
		{ 
			get { return (int)(Parameters & 16711680) >> 16; }
			set
			{
				Parameters = (int)(Parameters & ~16711680 | (value << 16 & 16711680));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("wz", "Unknown_4", true)]
		public int Unknown_4
		{ 
			get { return (int)(Parameters & 4278190080) >> 24; }
			set
			{
				Parameters = (int)(Parameters & ~4278190080 | (value << 24 & 4278190080));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("wz", "Unknown_5", true)]
		public int Unknown_5
		{ 
			get { return (int)(AuxillaryParameters2 & 255) >> 0; }
			set
			{
				AuxillaryParameters2 = (short)(AuxillaryParameters2 & ~255 | (value << 0 & 255));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public wz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ygcwp : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ygcwp", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 15) >> 0; }
			set
			{
				Parameters = (int)(Parameters & ~15 | (value << 0 & 15));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public ygcwp(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ykgr : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ykgr", "Unknown_1", true)]
		public int Unknown_1
		{ 
			get { return (int)(Parameters & 65280) >> 8; }
			set
			{
				Parameters = (int)(Parameters & ~65280 | (value << 8 & 65280));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ykgr", "Unknown_2", true)]
		public int Unknown_2
		{ 
			get { return (int)(Parameters & 15728640) >> 20; }
			set
			{
				Parameters = (int)(Parameters & ~15728640 | (value << 20 & 15728640));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public ykgr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class yougan : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public yougan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}


} // namespace WindEditor
