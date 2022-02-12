/*
 * Created by SharpDevelop.
 * User: BVN
 * Date: 11/02/2022
 * Time: 20:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EPR_InternTool
{
	/// <summary>
	/// Description of Produtos.
	/// </summary>
	public partial class Produtos : UserControl
	{
		public Produtos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		#region Propeties
		private string _message;
		
		[Category("Custom Props")]
		public string Message {
			get { return _message; }
			set { _message = value; lbl_title.Text = value; }
		}
		
		#endregion
	}
}
