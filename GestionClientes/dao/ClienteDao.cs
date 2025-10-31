using GestionClientes.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientes.dao
{
    internal class ClienteDao
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string baseDeDatos = "clientes";
            string cadenaConexion = "Database=" + baseDeDatos + "; Data Source=" + servidor + "; User Id=" + usuario + ";Password=" + password + "";

            MySqlConnection conexionDb = new MySqlConnection(cadenaConexion);
            conexionDb.Open();
            return conexionDb;
            
            
        }
        public List<Cliente> ObtenerListadoDeClientes()
        {
            List<Cliente> lista = new List<Cliente> ();
            string consulta = "SELECT * FROM `clientes`";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();

            MySqlDataReader lectura = comando.ExecuteReader();
            while (lectura.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = lectura.GetInt32("id");
                cliente.Nombre = lectura.GetString("nombre");
                cliente.Apellido = lectura.GetString("apellido");
                cliente.Telefono = lectura.GetString("telefono");
                cliente.TarjetaDeCredito = lectura.GetString("tarjeta_de_credito");
                lista.Add(cliente);
            }
            return lista;
        }
        public void Guardar(Cliente cliente)
        {
            string consulta = "INSERT INTO `clientes` (`id`, `nombre`, `apellido`, `telefono`, `tarjeta_de_credito`) VALUES (NULL, '"
                +cliente.Nombre+"', '"+cliente.Apellido+"', '"+cliente.Telefono+"', '"+cliente.TarjetaDeCredito+"');";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            
            
          
        }

        public void Eliminar(Cliente? cliente)
        {
            string consulta = "DELETE FROM `clientes` WHERE `clientes`.`id` = "+cliente.Id+";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
    }
}
