using System;
using System.Collections.Generic;
using System.Text;
using DevZH.UI;

namespace corelibUIForm
{
	public class MainWindow : Window
	{
		private VerticalBox _verticalBox;
		private Button _button;
		private Label _label;

		public MainWindow(string title = "MultiPlatform UI", int width = 500, int height = 200, bool hasMenubar = false) : base(title, width, height, hasMenubar)
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			//_menu = new Menu("hedmenu");
			//_menu.Add("file");

			_verticalBox = new VerticalBox { AllowPadding = true };
			this.Child = _verticalBox;
			
			//Sample Component here ...
			_label = new Label("Hello from LibUI");
			_verticalBox.Children.Add(_label);

			
			 
			_button = new Button("Sample Button");
			_verticalBox.Children.Add(_button);


			_button.Click += (sender, args) =>
			{
				MessageBox.Show("This is a message box.", "More detailed information can be shown here.");
			};
		}
	}
}
