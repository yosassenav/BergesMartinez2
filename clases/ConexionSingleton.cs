using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class ConexionSingleton
    {   //Instancia única del singleton
        private static ConexionSingleton mydbinstace = null;
        private static MySqlConnection connection;

        private ConexionSingleton(){
            connection = new MySqlConnection("Server=localhost; Database=test;Port=3306;User Id=root;Password=''");
        }

         //Para crear una única instancia
        public static ConexionSingleton InstanciarCon(){
            if (mydbinstace == null){
                mydbinstace = new ConexionSingleton();
            }
            return mydbinstace;
        }

        public void Conectar(){
            connection.Open();
        }

        public void RealizarConsulta(string consulta){
            MySqlCommand command = new MySqlCommand(consulta, connection);
            command.ExecuteNonQuery();
        }
        public void LeerResultados(string consulta){
            MySqlCommand command = new MySqlCommand(consulta, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()){
                Console.WriteLine(reader["description"]);
            }
            command.Dispose();
        }
        public void Desconectar(){
            connection.Close();
        }
    }
}