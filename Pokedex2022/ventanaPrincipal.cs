using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex2022
{
    public partial class ventanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1;// Guarda el id del pokemon principal
        int evoluciones = 0;
        public ventanaPrincipal()
        {
            InitializeComponent();
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePantalla.Text = "#" + idActual + " " + misPokemons.Rows[0]["nombre"].ToString();//Fila 0
            altura.Text = "Altura: " + misPokemons.Rows[0]["altura"].ToString();
            peso.Text = "Peso: " + misPokemons.Rows[0]["peso"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            Console.WriteLine(misPokemons.Rows[0]["preEvolucion"].ToString());
        }

        private void izquierda_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual == 0)
            {
                idActual = 151;
            }
            if (idActual == 152)
            {
                idActual = 1;
            }

            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePantalla.Text = "#" + idActual + " " + misPokemons.Rows[0]["nombre"].ToString();//Fila 0
            altura.Text = "Altura: " + misPokemons.Rows[0]["altura"].ToString();
            peso.Text = "Peso: " + misPokemons.Rows[0]["peso"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            evolucion.Image = null;
        }

        private void derecha_Click(object sender, EventArgs e)
        { idActual++;
            if (idActual == 0)
            {
                idActual = 151;
            }
            if (idActual == 152)
            {
                idActual = 1;
            }

            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePantalla.Text = "#" + idActual + " " + misPokemons.Rows[0]["nombre"].ToString();//Fila 0
            pantalla.Text = "|...";
            altura.Text = "Altura: " + misPokemons.Rows[0]["altura"].ToString();
            peso.Text = "Peso: " + misPokemons.Rows[0]["peso"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            evolucion.Image = null;
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void descripcion_Click(object sender, EventArgs e)
        {
            misPokemons = miConexion.getPokemonPorId(idActual);
            pantalla.Text = misPokemons.Rows[0]["descripcion"].ToString();
        }

        private void posevolucion(object sender, EventArgs e)
        { String palabra = misPokemons.Rows[0]["posEvolucion"].ToString();
            if (palabra == "")
            {
                pantalla.Text = "no tiene POSEVOLUCION";
                evolucion.Image = null;
            }

            else { 
                evoluciones = Int32.Parse(palabra);
            misPokemons = miConexion.getPokemonPorId(evoluciones);

            evolucion.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            pantalla.Text = "Su posevolución es: " + misPokemons.Rows[0]["nombre"].ToString();
            misPokemons = miConexion.getPokemonPorId(idActual);
           }
          
            
        } 
            

        private void preevolucion(object sender, EventArgs e)
        {
            String palabra = misPokemons.Rows[0]["preEvolucion"].ToString();
            if (palabra == "")
            {
                pantalla.Text = "No tiene PREEVOLUCION";
                evolucion.Image = null;
            }

            else
            {
                evoluciones = Int32.Parse(palabra);

                misPokemons = miConexion.getPokemonPorId(evoluciones);

                evolucion.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                pantalla.Text = "Su preevolución es: " + misPokemons.Rows[0]["nombre"].ToString();
                misPokemons = miConexion.getPokemonPorId(idActual);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ventana2 ventana = new ventana2(idActual, misPokemons);
            ventana.Show();
        }
    }
}
