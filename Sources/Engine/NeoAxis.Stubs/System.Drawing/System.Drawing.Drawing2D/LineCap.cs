namespace System.Drawing.Drawing2D
{
	public enum LineCap
	{
		Flat = 0,
		Square = 1,
		Round = 2,
		Triangle = 3,
		NoAnchor = 0x10,
		SquareAnchor = 17,
		RoundAnchor = 18,
		DiamondAnchor = 19,
		ArrowAnchor = 20,
		Custom = 0xFF,
		AnchorMask = 240
	}
}
