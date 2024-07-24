using Foster.Framework;
using System.Net.NetworkInformation;
using System.Numerics;

class Game : Module
{
	private readonly IServiceCollection services = new ServiceCollection();
	private readonly Batcher batch = new();
	private readonly Texture texture = new Texture(new Image(128, 128, Color.Blue));

	public Game()
	{

	}

	public override void Update()
	{
	}

	public override void Render()
	{
		Graphics.Clear(0x44aa77);

		if (KeyMap.Forward.Any(key => Input.Keyboard.Down((Keys)key))) batch.Image(texture, Vector2.Zero, Color.White);
		
		else if (KeyMap.Backward.Any(key => Input.Keyboard.Down((Keys)key))) batch.Image(texture, Vector2.Zero, Color.Red);

		// batch.PopMatrix();

		batch.Render();
		batch.Clear();
	}
}
