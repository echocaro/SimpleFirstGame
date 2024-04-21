
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
    animBallNode.Play("Idle");
  }

  public override void _PhysicsProcess(double delta)
  {
    Velocity = new(direction.X, direction.Y);

    Velocity *= 5;

    MoveAndSlide();
  }

  public override void _Input(InputEvent @event)
  {
    direction = Input.GetVector(
      "MoveLeft",
      "MoveRight",
      "MoveDown",
      "MoveUp"
    );

    if (direction == Vector2.Zero)
    {
      animBallNode.Play("Idle");
    }
    else
    {
      // need to create a different animation
      animBallNode.Play("Idle");
    }
  }
}
