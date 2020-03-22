using System;
using DevZH.UI;
using DevZH.UI.Drawing;

namespace corelibUIForm
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			var app = new Application();
			var window = new MainWindow("coreUIForm", 320, 240, true);
			window.AllowMargins = true;
			app.Run(window);
		}
	}
}
