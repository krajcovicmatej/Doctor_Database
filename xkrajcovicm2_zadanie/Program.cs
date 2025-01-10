using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xkrajcovicm2_zadanie
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// this application is school project, which has to be done in C# language and connect to Oracle database (made in sqldeveloper).
		/// project is to connect to databaze as admin user. admin user can add, delete, update and select data from database. it is software which is used in hospital to save data abou doctors name surname, specialization, phone number email attendance etc.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
