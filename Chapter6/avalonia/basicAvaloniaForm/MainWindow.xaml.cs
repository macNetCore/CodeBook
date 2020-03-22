using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace basicAvaloniaForm
{
	public class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

			this.FindControl<Button>("Win").Click += delegate
			{
				var window = new Window();
				window.Height = 100;
				window.Width = 200;
				window.Content = new TextBlock { Text = "Hello From dialog Window." };
				window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
				window.ShowDialog(this);
			};
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}

		
	}
}
