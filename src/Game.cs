using System.Numerics;

class Game : Module
{
	private static readonly Batcher batch = new();
	private static readonly Texture texture = new Texture(new Image(128, 128, Color.Blue));
	private Action UpdateDelegate = () => { };
	private Action RenderDelegate = () => { };

	private static Entity TestEntity = new Entity { Position = new Vector2(0, 0) };

	public Game()
	{
		UpdateDelegate += () => MovementDelegate(TestEntity);

		RenderDelegate += SomeRenderDelegate;
	}

	private Action<Entity> MovementDelegate = (Entity entity) =>
	{
		var pos = entity.Position;

		if (KeyMap.Left.Any(key => Input.Keyboard.Down((Keys)key))) pos.X -= 4;
		if (KeyMap.Right.Any(key => Input.Keyboard.Down((Keys)key))) pos.X += 4;
		if (KeyMap.Forward.Any(key => Input.Keyboard.Down((Keys)key))) pos.Y -= 4;
		if (KeyMap.Backward.Any(key => Input.Keyboard.Down((Keys)key))) pos.Y += 4;
		// make this a switch statement

		entity.Position = pos;
	};

	private Action SomeRenderDelegate = () => batch.Image(texture, TestEntity.Position, Color.Red);

	public override void Update() => UpdateDelegate();
	public override void Render()
	{
		Graphics.Clear(0x44aa77);

		RenderDelegate();

		batch.Render();
		batch.Clear();
	}
}

public class Entity
{
	public Vector2 Position { get; set; }

}