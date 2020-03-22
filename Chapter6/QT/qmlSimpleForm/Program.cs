using System;
using System.IO;
using Qml.Net;
using Qml.Net.Runtimes;

namespace qmlSimpleForm
{
    class Program
    {
        static int Main(string[] args)
        {
            RuntimeManager.DiscoverOrDownloadSuitableQtRuntime();
            
            QQuickStyle.SetStyle("Universal");


            using (var application = new QGuiApplication(args))
            {
                using (var qmlEngine = new QQmlApplicationEngine())
                {

					Qml.Net.Qml.RegisterType<MinimalModel>("Mini", 1, 0);

					qmlEngine.Load("Main.qml");
                    

                    return application.Exec();
                }
            }
        }

		

    }

	//Should be in a separate file
	public class MinimalModel
	{	
		//Sample Dotnet method called from QML
		public string buttonNET_clicked()
		{
			return "Hello from .NET Core 3";
		}
	}
}
