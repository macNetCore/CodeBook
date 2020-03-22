using System;
using DevZH.UI;
using DevZH.UI.Drawing;

namespace UI.Thread.Sample
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			var app = new Application();
			var window = new MainWindow("UI Thead Sample", 320, 120, true);
			window.AllowMargins = true;
			app.Run(window);
		}
	}
}
