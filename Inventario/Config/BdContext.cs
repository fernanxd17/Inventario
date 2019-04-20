﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Models.Dao
{
    public class BdContext {
        private static string server = "arquitecturabd.mysql.database.azure.com";
        private static string database = "inventario";
        private static string user = "adminbd@arquitecturabd";
        private static string pass = "Arquitecturabd2019";
        private static string port = "3306";
        private MySqlConnection conexionBd; //realiza la conexion a la BD
        private MySqlCommand cmd; //Ejecuta las sentencias o declaraciones a la BD
        private MySqlDataReader reader; //Obtiene los resultados de las declaraciones


        public BdContext()
        {
           
            this.cmd = null;
            this.reader = null;
            conectarBD();
        }

        private void conectarBD()
        {
            string cadenaConexion = "server=" + server + "; port=" + port + "; userid=" + user + "; password=" + pass + "; database=" + database + ";";
            conexionBd = new MySqlConnection(cadenaConexion);
            conexionBd.Open();
        }
        public MySqlConnection ConexionBd
        {
            get
            {
                return this.conexionBd;

            }
        }

        /* Este metodo es para eliminacion, actualizacion, insertar, es decir para ALTERAR una tabla de la BD */
        public void alterar(string declaracion)
        {
            this.cmd = new MySqlCommand(declaracion, this.conexionBd);
        }

        public MySqlDataReader consultar(string declaracion)
        {
            
            this.cmd = new MySqlCommand(declaracion,this.conexionBd);
            this.reader = cmd.ExecuteReader();
            return reader;
        }
        

    }
}


