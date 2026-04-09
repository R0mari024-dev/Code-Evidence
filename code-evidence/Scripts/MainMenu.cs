using Godot;
using System;

public partial class MainMenu : CanvasLayer
{
	public override void _Ready()
	{
	}
	public override void _Process(double delta)
	{
	}

	// 
	private void _on_button_1_pressed()
	{
		GD.Print("Pess button Continue!");
	
	private void _on_button_2_pressed()
	{
		GD.Print("Pess button Start!");

		var group1 = GetNode<CanvasGroup>("Set level");
		var group2 = GetNode<CanvasGroup>("Menu");

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

		var group1 = GetNode<CanvasGroup>("Set level");
		var group2 = GetNode<CanvasGroup>("Menu");
		
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



	private void _on_button_level_1_pressed()
	{
		GD.Print("Select level 1!");
		GetTree().ChangeSceneToFile("res://Tscn/level_1.tscn");
		
	}


}
