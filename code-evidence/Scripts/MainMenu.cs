using Godot;
using System;

public partial class MainMenu : CanvasLayer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void _on_button_1_pressed()
	{
		GD.Print("Pess button Continue!");
	}

	private void _on_button_2_pressed()
	{
		GD.Print("Pess button Start!");

			// Ссылка на твои узлы (Node2D, Control и т.д.)
			var group1 = GetNode<CanvasGroup>("Set level");
			var group2 = GetNode<CanvasGroup>("Menu");

			// Если первая группа видна в дереве — скрываем её и показываем вторую
			if (group1.IsVisibleInTree())
			{
				group1.Visible = false;
				group2.Visible = true;
			}
			else
			{
				group1.Visible = true;
				group2.Visible = false;
			}
		}

	private void _on_button_3_pressed()
	{
		GD.Print("Pess button Things!");
	}

	private void _on_button_4_pressed()
	{
		GD.Print("Pess button Leaflets!");
	}

	private void _on_button_5_pressed()
	{
		GD.Print("Pess button Mini-game!");
	}

	private void _on_button_6_pressed()
	{
		GD.Print("Pess button Settings!");
	}

	private void _on_button_7_pressed()
	{
		GD.Print("Pess button Exit!");
		GetTree().Quit();
	}

	private void _on_button_exit_pressed()
	{
		GD.Print("Bake to menu");

			// Ссылка на твои узлы (Node2D, Control и т.д.)
			var group1 = GetNode<CanvasGroup>("Set level");
			var group2 = GetNode<CanvasGroup>("Menu");

			// Если первая группа видна в дереве — скрываем её и показываем вторую
			if (group1.IsVisibleInTree())
			{
				group1.Visible = false;
				group2.Visible = true;
			}
			else
			{
				group1.Visible = true;
				group2.Visible = false;
			}
		}

 //GetNode<Button>("Path/To/Button").Pressed += OnButtonPressed;


	private void _on_button_level_1_pressed()
	{
		GD.Print("Select level 1!");
		GetTree().ChangeSceneToFile("res://Tscn/level_1.tscn");
		
	}


}
