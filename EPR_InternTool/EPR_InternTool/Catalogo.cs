/*
 * Created by SharpDevelop.
 * User: BVN
 * Date: 11/02/2022
 * Time: 15:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace EPR_InternTool
{
	/// <summary>
	/// Description of Catalogo.
	/// </summary>
	public partial class Catalogo : Form
	{
		int x = 50;
		public Catalogo(string id)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			populateItems();
			comboBox1.SelectedIndex = 1;
		}

		private void populateItems()
		{
			flowLayoutPanel1.Controls.Clear();
			Produtos[] produtos = new Produtos[x];
			
			for (int i = 0; i < produtos.Length; i++) {
				produtos[i] = new Produtos();
				
				flowLayoutPanel1.Controls.Add(produtos[i]);
			}
		}
		
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			x = int.Parse(comboBox1.SelectedItem.ToString());
			populateItems();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
		}
	}
}
