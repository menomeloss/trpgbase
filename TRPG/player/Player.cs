using Godot;
using System;

public class Player : KinematicBody2D
{
    int _move_speed = 200;
    int health = 100;
    public override void _PhysicsProcess(float delta)
    {
        Vector2 motion = new Vector2();
        motion.x = Input.GetActionRawStrength("move_right") - Input.GetActionRawStrength("move_left");
        motion.y = Input.GetActionRawStrength("move_down") - Input.GetActionRawStrength("move_up");

        MoveAndCollide(motion.Normalized() * _move_speed * delta);
    }


}
