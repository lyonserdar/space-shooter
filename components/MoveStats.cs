using Godot;
using System;

[GlobalClass]
public partial class MoveStats : Resource
{
    [Export]
    public float Speed { get; private set; } = 100.0f;
}
