using Godot;
using System;

public class Jugador : KinematicBody2D
{
    private Vector2 movement = Vector2.Zero;

    private float move_Speed = 400f;

    private float gravity= 20f;

    private float jump_Force = -900;

    private Vector2 up_Dir = Vector2.Up;


    private AnimatedSprite animation;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
 public override void _Process(float delta)
    {      
        PlayerMovement();
  }


  void PlayerMovement(){

            movement.y += gravity;

            if(Input.IsActionPressed("move_right")){

                movement.x = move_Speed;       

            }else if (Input.IsActionPressed("move_left")){

                movement.x = -move_Speed; 

            }else{
                movement.x = 0;
            }

            if(IsOnFloor()){

                if(Input.IsActionJustPressed("jump")){

                    movement.y = -800;

                }
            }
        MoveAndSlide(movement, up_Dir);

    }//Playermovent
}
