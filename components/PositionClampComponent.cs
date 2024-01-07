using Godot;
using System;

[GlobalClass]
public partial class PositionClampComponent : Node2D
{
	[Export]
	private Node2D _actor;
	[Export]
	private int _margin = 10;
	private int _leftBorder;
	private int _rightBorder = (int)ProjectSettings.GetSetting("display/window/size/viewport_width");

	public override void _Process(double delta)
	{
		var position = _actor.GlobalPosition;
		position = new Vector2(Math.Clamp(position.X, _leftBorder + _margin, _rightBorder - _margin), position.Y);
		_actor.GlobalPosition = position;
	}
}
