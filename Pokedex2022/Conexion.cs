using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //esto para conectarse a la base de datos de sql, hay que conectarse a la base de datos que en este caso es mySQL..

namespace Pokedex2022
{
    internal class Conexion
    {
        public MySqlConnection conexion;
        public Conexion()
        {
            conexion = new MySqlConnection("Server=127.0.0.1; Database=listapokemons; Uid = root; Pwd = ; Port = 3306");//pwd no se rellena porque no hay contraseña

        }

        public DataTable getPokemonPorId(int id)
        {
            //DataTable es una 'arrray' y hay que importar la libreria obligatoriamente

            try
            {
                conexion.Open();//abrir la conexion que tengo definida
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon WHERE id='" + id + "'", conexion);// revibe la consulta y la conexion al servidor que lo hemos llamado "conexion"
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;    
            }
            catch(MySqlException e)
            {
                throw e;
            }//Un try/ catch el programa va a ejecutar lo que esta dentro del try y si el try no se ejecuta correctamente pues se ejecuta el catch , si se ejecuta correctaamente ignora el catch
        }
    }
}
