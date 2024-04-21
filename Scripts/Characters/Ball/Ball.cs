
using Godot;
using System;

public partial class Ball : CharacterBody2D
{
  [ExportGroup("Required Nodes")]
  [Export] private AnimationPlayer animBallNode;
  [Export] private Sprite2D spriteNode;

  private Vector2 direction = new();

  public override void _Ready()
  {
    animBallNode.Play("Movement");
  }

  public override void _PhysicsProcess(double delta)
  {
    Velocity = new(direction.X, direction.Y);

    Velocity *= 50;

    MoveAndSlide();
  }

  public override void _Input(InputEvent @event)
  {
    direction = Input.GetVector(
      "MoveLeft",
      "MoveRight",
      "MoveUp",
      "MoveDown"
    );


    animBallNode.Play("Movement");
  }
}
