public static class KeyMap
{
	public static List<int> Forward { get; private set; } = [(int)Keys.W, (int)Keys.Up];
	public static List<int> Backward { get; private set; } = [(int)Keys.S, (int)Keys.Down];
	public static List<int> Left { get; private set; } = [(int)Keys.A, (int)Keys.Left];
	public static List<int> Right { get; private set; } = [(int)Keys.D, (int)Keys.Right];

}