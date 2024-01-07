using Godot;
using System;

[GlobalClass]
public partial class MoveComponent : Node
{
	[Export]
	private Node2D _actor;
	[Export]
	public Vector2 Velocity { get; set; }

	public override void _Process(double delta)
	{
		_actor.Translate(Velocity * (float)delta);
	}
}
