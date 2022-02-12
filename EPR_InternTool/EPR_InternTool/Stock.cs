/*
 * Created by SharpDevelop.
 * User: BVN
 * Date: 11/02/2022
 * Time: 01:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EPR_InternTool
{
	/// <summary>
	/// Description of Stock.
	/// </summary>
	public partial class Stock : Form
	{
		public string Userid;
		public Stock(string tes)
		{
			InitializeComponent();
			Userid = tes;
		}
		
		void Btn_CloClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Btn_CatClick(object sender, EventArgs e)
		{
			Catalogo cat = new Catalogo(Userid);
			cat.Show();
//			for(int i=0;i<50;i++){
//			Catalogo cat = new Catalogo(Userid);
//			cat.Show();
//			}
		}
	}
}
