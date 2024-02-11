using Godot;
using System;

public partial class CameraController : Node3D
{
	// Called when the node enters the scene tree for the first time.
	Node3D cameraMount,player,camera;
	public override void _Ready()
	{
		player=GetTree().GetNodesInGroup("Player")[0] as Node3D;
		cameraMount = player.GetNode<Node3D>("CameraMount");
		camera=cameraMount.GetNode<Node3D>("Camera3D");
		Input.MouseMode=Input.MouseModeEnum.Captured;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//global_position
	}

	public override void _Input(InputEvent inputEvent)
	{
		if(inputEvent is InputEventMouseMotion)
		{
			cameraMount.RotateY(-(inputEvent as InputEventMouseMotion).Relative.X*Mathf.Pi/180);
			camera.RotateX((inputEvent as InputEventMouseMotion).Relative.Y*Mathf.Pi/180);
		}
	}
}
