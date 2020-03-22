using System;
using System.IO;
using Qml.Net;
using Qml.Net.Runtimes;


namespace QML.photoshopForm
{
    class Program
    {
        static int Main(string[] args)
        {
            RuntimeManager.DiscoverOrDownloadSuitableQtRuntime();
            
     
            using (var application = new QGuiApplication(args))
            {
                using (var qmlEngine = new QQmlApplicationEngine())
                {

					qmlEngine.Load("photoshopGUI.qml");
   
                    return application.Exec();
                }
            }
        }

		

    }

	
}
