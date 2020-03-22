using Avalonia;
using Avalonia.Logging.Serilog;

namespace basicAvaloniaForm
{
	class Program
	{
		public static void Main(string[] args) => BuildAvaloniaApp().Start(AppMain, args);

		
		public static AppBuilder BuildAvaloniaApp()
			=> AppBuilder.Configure<App>()
				.UsePlatformDetect()
				.LogToDebug();

		
		private static void AppMain(Application app, string[] args)
		{
			var main = new MainWindow();
			main.Width = 300;
			main.Height = 200;
			app.Run(main);
		}
	}
}
