﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
  public  class Conexao
    {
      
        //conexão com o banco de dados local
        string conec = "SERVER=localhostt; DATABASE=hotel; UID=root;PWD=;PORT=;";

        public MySqlConnection con = null;
        
        public void AbrirCon() {

            try
            {

                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show( " Favor entra em contato com Administrador " + ex.Message);
            }
        }

        public void FecharCon()
        {
            try
            {

                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            //declaração de outras variaveis

        }
    }
}
