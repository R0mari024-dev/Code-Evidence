using Godot;
using System;

public partial class GlobalInput : Node
{

    public override void _Input(InputEvent @event)
    {
       if (@event.IsActionPressed("exit_game"))
        {
            GetTree().Quit();
        }
    }

    
}
