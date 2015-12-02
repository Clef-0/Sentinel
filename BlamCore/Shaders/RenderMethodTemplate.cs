using System.Collections.Generic;
using Blam.Tags;
using Blam.Common;

namespace Blam.Shaders
{
    [TagDefinition(Name = "render_method_template", Group = "rmt2", Size = 0x84)]
	public class RenderMethodTemplate
	{
		public TagInstance VertexShader;
		public TagInstance PixelShader;
		public uint DrawModeBitmask;
		public List<DrawMode> DrawModes; // Entries in here correspond to an enum in the EXE
		public List<UnknownBlock2> Unknown3;
		public List<ArgumentMapping> ArgumentMappings;
		public List<Argument> Arguments;
		public List<UnknownBlock4> Unknown5;
		public List<UnknownBlock5> Unknown6;
		public List<ShaderMap> ShaderMaps;
		public uint Unknown7;
		public uint Unknown8;
		public uint Unknown9;

		[TagDefinition(Size = 0x2)]
		public class DrawMode
		{
			// rmt2 uses these pointers in both this block and UnknownBlock2.
			public ushort UnknownBlock2Pointer;
		}

		[TagDefinition(Size = 0x1C)]
		public class UnknownBlock2
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
		}

		/// <summary>
		/// Binds an argument in the render method tag to a pixel shader constant.
		/// </summary>
		[TagDefinition(Size = 0x4)]
		public class ArgumentMapping
		{
			/// <summary>
			/// The GPU register to bind the argument to.
			/// </summary>
			public ushort RegisterIndex;

			/// <summary>
			/// The index of the argument in one of the blocks in the render method tag.
			/// The block used depends on the argument type.
			/// </summary>
			public byte ArgumentIndex;

			public byte Unknown;
		}

		[TagDefinition(Size = 0x4)]
		public class Argument
		{
			public StringID Name;
		}

		[TagDefinition(Size = 0x4)]
		public class UnknownBlock4
		{
			public StringID Unknown;
		}

		[TagDefinition(Size = 0x4)]
		public class UnknownBlock5
		{
			public StringID Unknown;
		}

		[TagDefinition(Size = 0x4)]
		public class ShaderMap
		{
			public StringID Name;
		}
	}
}