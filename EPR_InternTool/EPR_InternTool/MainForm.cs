/*
 * Created by SharpDevelop.
 * User: BVN
 * Date: 10/02/2022
 * Time: 22:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EPR_InternTool
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Login : Form
	{
		public string id;
		public string UserID { get {return id;}}
		Database_Class DB_Class = new Database_Class();
		DBvar dbvar = new DBvar();
		public Login()
		{
			InitializeComponent();
			try
            {
                DB_Class.Conecte("User");
            }
            catch
            {
            	MessageBox.Show("erro na conexão");
            }
		}
		
		void CloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void Btn_entrarClick(object sender, EventArgs e)
		{
			if(textBox1.Text != "" && textBox2.Text != ""){
        		DB_Class.Abrir();
            	MySqlCommand comando = new MySqlCommand("select * from User where login = '" + textBox1.Text + "'", DB_Class.DBConection);
           		MySqlDataReader dtReader = comando.ExecuteReader();
            	if (dtReader.Read())
            	{
            		if(textBox2.Text == dtReader["Senha"].ToString()){
            			id = dtReader["idUser"].ToString();
            			            	this.Close();
            		}
            		else{
            			MessageBox.Show("Senha errada");
            		}
            	}
            	else{
            		MessageBox.Show("Login Inexistente");
            	}
            	DB_Class.Fechar();
			}
			else{
				MessageBox.Show("Prencha todos os Campos!");
			}
		}
	}
}
