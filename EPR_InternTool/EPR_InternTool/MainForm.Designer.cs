/*
 * Created by SharpDevelop.
 * User: BVN
 * Date: 10/02/2022
 * Time: 22:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EPR_InternTool
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.btn_entrar = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.top_panel = new System.Windows.Forms.Panel();
			this.btn_Clo = new System.Windows.Forms.Button();
			this.top_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_entrar
			// 
			this.btn_entrar.BackColor = System.Drawing.Color.LightCyan;
			this.btn_entrar.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btn_entrar, "btn_entrar");
			this.btn_entrar.Name = "btn_entrar";
			this.btn_entrar.UseVisualStyleBackColor = false;
			this.btn_entrar.Click += new System.EventHandler(this.Btn_entrarClick);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.LightCyan;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.textBox1, "textBox1");
			this.textBox1.Name = "textBox1";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.LightCyan;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.textBox2, "textBox2");
			this.textBox2.Name = "textBox2";
			// 
			// top_panel
			// 
			this.top_panel.BackColor = System.Drawing.Color.LightCyan;
			this.top_panel.Controls.Add(this.btn_Clo);
			resources.ApplyResources(this.top_panel, "top_panel");
			this.top_panel.Name = "top_panel";
			// 
			// btn_Clo
			// 
			resources.ApplyResources(this.btn_Clo, "btn_Clo");
			this.btn_Clo.FlatAppearance.BorderSize = 0;
			this.btn_Clo.Name = "btn_Clo";
			this.btn_Clo.UseVisualStyleBackColor = true;
			this.btn_Clo.Click += new System.EventHandler(this.CloseClick);
			// 
			// Login
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.top_panel);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btn_entrar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Login";
			this.top_panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_Clo;
		private System.Windows.Forms.Panel top_panel;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btn_entrar;
	}
}
