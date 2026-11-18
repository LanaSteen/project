using Spectre.Console;

namespace project
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			/// axali
			/// 


			//var password = new TextPrompt<string>("Enter your [green]password[/]:").Secret();

			//var result = AnsiConsole.Prompt(password);



			//Console.WriteLine(result);


			User user = new();
			user.Id = 1;
			var rame = new TextPrompt<string>("Enter your [green] name[/]:");

			user.Name = AnsiConsole.Prompt(rame);
			var password  = new TextPrompt<string>("Enter your [green]password[/]:").Secret();
			user.Password = AnsiConsole.Prompt(password);


			var role = AnsiConsole.Prompt(new SelectionPrompt<string>()
		.Title("Select your [green]role[/]")
		.WrapAround()
		.AddChoices("Admin", "Customer"));

			user.Role = role;


			var table = new Table();
			table.Border(TableBorder.Rounded);
			table.AddColumn("Id");
			table.AddColumn("Name");
			table.AddColumn("Password");
			table.AddRow(user.Id.ToString(), user.Name, user.Password, user.Role);
			AnsiConsole.Write(table);
		}
	}
}
