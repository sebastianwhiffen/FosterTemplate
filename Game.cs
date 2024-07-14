class Game : Module
{
    public const string GamePath = "FosterTemplate";
	private readonly Batcher batch = new();


	public override void Update()
	{
	}

    public override void Startup()
    {
    }

    public override void Render()
	{
		Graphics.Clear(0x44aa77);

		batch.Circle(new Circle(Input.Mouse.Position, 8), 16, Color.White);

		batch.Render();
		batch.Clear();
	}
}