/*
 * Created by SharpDevelop.
 * User: BVN
 * Date: 11/02/2022
 * Time: 01:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EPR_InternTool
{
	partial class Stock
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_Clo = new System.Windows.Forms.Button();
			this.top_panel = new System.Windows.Forms.Panel();
			this.btn_Cat = new System.Windows.Forms.Button();
			this.btn_Ped = new System.Windows.Forms.Button();
			this.top_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_Clo
			// 
			this.btn_Clo.Dock = System.Windows.Forms.DockStyle.Right;
			this.btn_Clo.FlatAppearance.BorderSize = 0;
			this.btn_Clo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Clo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.btn_Clo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btn_Clo.Location = new System.Drawing.Point(543, 0);
			this.btn_Clo.Name = "btn_Clo";
			this.btn_Clo.Size = new System.Drawing.Size(23, 28);
			this.btn_Clo.TabIndex = 0;
			this.btn_Clo.Text = "X";
			this.btn_Clo.UseVisualStyleBackColor = true;
			this.btn_Clo.Click += new System.EventHandler(this.Btn_CloClick);
			// 
			// top_panel
			// 
			this.top_panel.BackColor = System.Drawing.Color.LightCyan;
			this.top_panel.Controls.Add(this.btn_Clo);
			this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.top_panel.Location = new System.Drawing.Point(0, 0);
			this.top_panel.Name = "top_panel";
			this.top_panel.Size = new System.Drawing.Size(566, 28);
			this.top_panel.TabIndex = 6;
			// 
			// btn_Cat
			// 
			this.btn_Cat.Location = new System.Drawing.Point(35, 63);
			this.btn_Cat.Name = "btn_Cat";
			this.btn_Cat.Size = new System.Drawing.Size(77, 24);
			this.btn_Cat.TabIndex = 7;
			this.btn_Cat.Text = "Ver Catalogo";
			this.btn_Cat.UseVisualStyleBackColor = true;
			this.btn_Cat.Click += new System.EventHandler(this.Btn_CatClick);
			// 
			// btn_Ped
			// 
			this.btn_Ped.Location = new System.Drawing.Point(35, 133);
			this.btn_Ped.Name = "btn_Ped";
			this.btn_Ped.Size = new System.Drawing.Size(86, 36);
			this.btn_Ped.TabIndex = 9;
			this.btn_Ped.Text = "Gerar Pedido Manualmente";
			this.btn_Ped.UseVisualStyleBackColor = true;
			// 
			// Stock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 332);
			this.Controls.Add(this.btn_Ped);
			this.Controls.Add(this.btn_Cat);
			this.Controls.Add(this.top_panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Stock";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stock Manager";
			this.top_panel.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_Ped;
		private System.Windows.Forms.Button btn_Cat;
		private System.Windows.Forms.Panel top_panel;
		private System.Windows.Forms.Button btn_Clo;
	}
}
