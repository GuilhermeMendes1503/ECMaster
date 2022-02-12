/*
 * Created by SharpDevelop.
 * User: BVN
 * Date: 11/02/2022
 * Time: 20:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EPR_InternTool
{
	partial class Produtos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.lbl_title = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.var1 = new System.Windows.Forms.Label();
			this.var2 = new System.Windows.Forms.Label();
			this.var3 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_title
			// 
			this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_title.Location = new System.Drawing.Point(0, 0);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(200, 24);
			this.lbl_title.TabIndex = 0;
			this.lbl_title.Text = "Title";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Location = new System.Drawing.Point(0, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 148);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 261);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(59, 50);
			this.button1.TabIndex = 2;
			this.button1.Text = "Editar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(70, 261);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(59, 50);
			this.button2.TabIndex = 3;
			this.button2.Text = "Excluir";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(138, 261);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(59, 50);
			this.button3.TabIndex = 4;
			this.button3.Text = "Exportar";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// var1
			// 
			this.var1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.var1.Location = new System.Drawing.Point(3, 175);
			this.var1.Name = "var1";
			this.var1.Size = new System.Drawing.Size(194, 20);
			this.var1.TabIndex = 5;
			this.var1.Text = "Var1";
			this.var1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// var2
			// 
			this.var2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.var2.Location = new System.Drawing.Point(3, 195);
			this.var2.Name = "var2";
			this.var2.Size = new System.Drawing.Size(194, 20);
			this.var2.TabIndex = 6;
			this.var2.Text = "Var2";
			this.var2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// var3
			// 
			this.var3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.var3.Location = new System.Drawing.Point(3, 215);
			this.var3.Name = "var3";
			this.var3.Size = new System.Drawing.Size(194, 20);
			this.var3.TabIndex = 7;
			this.var3.Text = "Var3";
			this.var3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 235);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(194, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Codigo";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Produtos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.var3);
			this.Controls.Add(this.var2);
			this.Controls.Add(this.var1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lbl_title);
			this.Name = "Produtos";
			this.Size = new System.Drawing.Size(200, 314);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label var3;
		private System.Windows.Forms.Label var2;
		private System.Windows.Forms.Label var1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbl_title;
	}
}
