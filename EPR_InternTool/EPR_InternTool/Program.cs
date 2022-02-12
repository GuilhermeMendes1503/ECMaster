/*
 * Created by SharpDevelop.
 * User: BVN
 * Date: 10/02/2022
 * Time: 22:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace EPR_InternTool
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
//			Catalogo cat = new Catalogo("1");
//			cat.ShowDialog();
			Login login = new Login();
			login.ShowDialog();
			Stock stock = new Stock(login.UserID);
			if(login.UserID != null){
			stock.ShowDialog();	
			}
		}
		
	}
}
