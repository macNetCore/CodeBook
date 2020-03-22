using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using DevZH.UI;

namespace UI.Thread.Sample
{
	//Threading UI
	public delegate void workerFunctionDelegate(int totalSeconds);
	public delegate void populateTextBoxDelegate(string text);



	public class MainWindow : Window
	{	
        //Var Control
		private VerticalBox _verticalBox;

		private Button button1;
		private Button button2;
		private Entry textBox1;

        
        public MainWindow(string title = "Default", int width = 500, int height = 120, bool hasMenubar = true) : base(title, width, height, hasMenubar)
		{
			InitializeComponent();
		}

		//Threading
		private void populateTextBox(string text)
		{
			textBox1.Text = textBox1.Text + " " + text;
		}

		public void workerFunction(int totalSeconds)
		{
			for (int count = 1; count <= totalSeconds; count++)
			{
                
				//.Invoke(new populateTextBoxDelegate(populateTextBox), new object[] { count.ToString() });
				//Thread.Sleep(500);
				populateTextBox(count.ToString());
				System.Threading.Thread.Sleep(500);
			}

		}

        
		//UI
		private void InitializeComponent()
		{
			
			_verticalBox = new VerticalBox { AllowPadding = true };
			this.Child = _verticalBox;
		
			//Sample Component here ...
			textBox1 = new Entry();
			_verticalBox.Children.Add(textBox1);
            			 
			button1 = new Button("Launch worker in the main thread (bad)");
			_verticalBox.Children.Add(button1);
			//events on Controls
			button1.Click += new System.EventHandler(this.Button1_Clicked);



			button2 = new Button("Launch worker in an new thread (good)");
			_verticalBox.Children.Add(button2);
			//events on Controls
			button2.Click += new System.EventHandler(this.Button2_Clicked);

		}


        //Button Events
		private void Button1_Clicked(object sender, EventArgs e)
		{
			MessageBox.Show("Threading.", "The worker task uis launch in the main thead.");
			textBox1.Text = "";
			//Not Good: Launch the worker process in the main thread
			workerFunction(10);
		}

        private void Button2_Clicked(object sender, EventArgs e)
		{
			MessageBox.Show("Threading", "The worker task is launch in a separate process.");
			textBox1.Text = "";
			//good
			workerFunctionDelegate w = workerFunction;

			Task.Run(() => w.Invoke(11));
		}
   	}
}
