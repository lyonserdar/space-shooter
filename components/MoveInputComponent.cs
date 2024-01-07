using Godot;
using System;

[GlobalClass]
public partial class MoveInputComponent : Node
{
	[Export]
	private MoveComponent _moveComponent;
	[Export]
	private MoveStats _moveStats;


	public override void _UnhandledInput(InputEvent @event)
	{
		var inputAxis = Input.GetAxis("ui_left", "ui_right");
		_moveComponent.Velocity = new Vector2(inputAxis * _moveStats.Speed, 0);
	}
}
