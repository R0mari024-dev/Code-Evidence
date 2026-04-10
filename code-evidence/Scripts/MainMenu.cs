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

	// Кнопки гавного Меню
	private void _on_button_1_pressed()
	{
		GD.Print("Pess button Continue!");
	}
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

		var group1 = GetNode<CanvasGroup>("Things");
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
	private void _on_button_4_pressed()
	{
		GD.Print("Pess button Leaflets!");

		var group1 = GetNode<CanvasGroup>("Leaflets");
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
	private void _on_button_5_pressed()
	{
		GD.Print("Pess button Mini-game!");

		var group1 = GetNode<CanvasGroup>("Mini Games");
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
	private void _on_button_6_pressed()
	{
		GD.Print("Pess button Settings!");

		var group1 = GetNode<CanvasGroup>("Settings");
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
	private void _on_button_7_pressed()
	{
		GD.Print("Pess button Exit!");
		GetTree().Quit();
	}


	// Кнопки выбора уровня Меню уровней
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


	// Кнопки настроек Меню настроек
	private void _on_buttonSettings_exit_pressed()
	{
		GD.Print("Bake to menu");
		var group1 = GetNode<CanvasGroup>("Settings");
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


	// Меню Things
	private void _on_button_exit_things_pressed()
	{
		GD.Print("Bake to menu");
		var group1 = GetNode<CanvasGroup>("Things");
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


	// Кнопки листовок Меню Настроек
	private void _on_button_exit_leaflets_pressed()
	{
		GD.Print("Bake to menu");
		var group1 = GetNode<CanvasGroup>("Leaflets");
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


	// кнопки мини игр Меню Мини игр
	private void _on_button_exit_mini_games_pressed()
	{
		GD.Print("Bake to menu");
		var group1 = GetNode<CanvasGroup>("Mini Games");
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

}
