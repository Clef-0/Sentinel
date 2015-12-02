using Blam.Tags;

namespace Blam.Effects
{
    [TagDefinition(Name = "wind", Group = "wind", Size = 0x7C)]
	public class Wind
	{
		public byte[] Function;
		public byte[] Function2;
		public byte[] Function3;
		public byte[] Function4;
		public byte[] Function5;
		public uint Unknown;
		public TagInstance WarpBitmap;
		public uint Unknown2;
	}
}