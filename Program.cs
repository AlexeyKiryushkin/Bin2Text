using System;
using System.Threading;
using System.Windows.Forms;

namespace Bin2Text
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Thread.CurrentThread.Name = "Main";

			Application.Run(new MainForm());
		}

		static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
		{
			MessageBox.Show(e.ExceptionObject.ToString(), "Ошибка в программе", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
