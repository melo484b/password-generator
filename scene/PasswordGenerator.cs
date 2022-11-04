using Godot;
using System;

public class PasswordGenerator : MarginContainer
{
	private const int MAX_LENGTH = 20;
	private const string LOWER_CASE_LETTERS = "abcdefghijklmnopqrstuvwxyz"; 
	private const string UPPER_CASE_LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	private const string NUMBERS = "1234567890";
	private const string SYMBOLS = "~`!@#$%^&*()_-+={[}]|:;'<,>.?/";
	
	private string[] characterStrings = {LOWER_CASE_LETTERS, UPPER_CASE_LETTERS, NUMBERS, SYMBOLS};
	
	LineEdit textBox;
	
	public override void _Ready()
	{
		textBox = (LineEdit) GetNode("PanelContainer/MarginContainer/VBoxContainer/TextBox");
		GeneratePassword();
	}

	private void OnGenerateButtonPressed()
	{
		GeneratePassword();
	}
	
	private void GeneratePassword()
	{
		Random random = new Random();
		string password = "";
		for (int i = 0; i <= MAX_LENGTH; i++)
		{
			int stringIndex = random.Next(characterStrings.Length);
			int characterIndex = random.Next(characterStrings[stringIndex].Length);
			password += characterStrings[stringIndex][characterIndex];
		}
		textBox.Text = password;
		textBox.SelectAll();
		textBox.GrabFocus();
	}
	
}
