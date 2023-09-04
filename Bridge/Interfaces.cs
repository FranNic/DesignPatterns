namespace Bridge
{
	public interface IPaitingFactory
	{
		string PaintType { get; }
	}

	public class MatePaintingFactory : IPaitingFactory
	{
		public string PaintType { get; } = "mate";
	}

	public class MetallicPaintingFactory : IPaitingFactory
	{
		public string PaintType { get; } = "metallic";
	}
}