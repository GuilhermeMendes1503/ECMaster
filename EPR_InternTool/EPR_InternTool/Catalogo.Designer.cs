/*
 * Created by SharpDevelop.
 * User: BVN
 * Date: 11/02/2022
 * Time: 15:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EPR_InternTool
{
	partial class Catalogo
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
			this.top_panel = new System.Windows.Forms.Panel();
			this.btns = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btns.SuspendLayout();
			this.SuspendLayout();
			// 
			// top_panel
			// 
			this.top_panel.BackColor = System.Drawing.Color.LightCyan;
			this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.top_panel.Location = new System.Drawing.Point(0, 0);
			this.top_panel.Name = "top_panel";
			this.top_panel.Size = new System.Drawing.Size(830, 34);
			this.top_panel.TabIndex = 3;
			// 
			// btns
			// 
			this.btns.Controls.Add(this.button1);
			this.btns.Controls.Add(this.comboBox1);
			this.btns.Controls.Add(this.label1);
			this.btns.Dock = System.Windows.Forms.DockStyle.Top;
			this.btns.Location = new System.Drawing.Point(0, 34);
			this.btns.Name = "btns";
			this.btns.Size = new System.Drawing.Size(830, 34);
			this.btns.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(229, 7);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 21);
			this.button1.TabIndex = 3;
			this.button1.Text = "Modo tabela";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DisplayMember = "50";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"25",
									"50",
									"75",
									"100"});
			this.comboBox1.Location = new System.Drawing.Point(143, 7);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(80, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Qantidade de Itens:";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 68);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(830, 317);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// Catalogo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(830, 385);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.btns);
			this.Controls.Add(this.top_panel);
			this.Name = "Catalogo";
			this.Text = "Catalogo";
			this.btns.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel btns;
		private System.Windows.Forms.Panel top_panel;
	}
}
