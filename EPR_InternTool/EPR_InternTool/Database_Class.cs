/*
 * Created by SharpDevelop.
 * User: BVN
 * Date: 10/02/2022
 * Time: 23:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace EPR_InternTool
{
	    public class DBvar
    {
	    //login vars
        public string ok;
        
        //other
        public string nome;
        public string Fabricante;
        public decimal Preco;
        public int Estoque;
        public int Min_estoque;
        public string nome2;
        public string id2;
    }
	    
	public class Database_Class
	{
		public Database_Class()
		{
			
		}
		
		public DBvar dbvar = new DBvar();
		
		public MySqlConnection DBConection;
        public string UserDB = "sql10471980";
        public string PassDB = "jeD8MMPTHd";
        public string Server = "sql10.freemysqlhosting.net";
        public string NameDB = "sql10471980";
		
        public void Conecte(string Table)
        {
            DBConection = new MySqlConnection("server=" + Server + ";database=" + NameDB +
                                               "; uid=" + UserDB + "; password=" + PassDB);
        }
        public void Abrir()
        {
            DBConection.Open();
        }

        public void Fechar()
        {
            DBConection.Close();
        }
        public void Consulta(string login){
        	Abrir();
            MySqlCommand comando = new MySqlCommand("select * from User where login = '" + login + "'", DBConection);
            MySqlDataReader dtReader = comando.ExecuteReader();
            if (dtReader.Read())
            {
                dbvar.ok = dtReader["Senha"].ToString();
            }
            Fechar();
        }
	}
}
