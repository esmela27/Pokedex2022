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
    public partial class cadenaEvolutiva : Form

    {
        Conexion miConexion = new Conexion();
        int id = 0;
        DataTable misPokemons;
        public cadenaEvolutiva(int id, DataTable misPokemons)
        {

            InitializeComponent();
            misPokemons = miConexion.getPokemonPorId(id);
            String preevolucion = misPokemons.Rows[0]["preEvolucion"].ToString();
            String posevolucion = misPokemons.Rows[0]["posEvolucion"].ToString();
            if (preevolucion == "")
            {
                primero.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                nombre1.Text = misPokemons.Rows[0]["nombre"].ToString();
                String palabra1 = misPokemons.Rows[0]["posEvolucion"].ToString();
                if (palabra1 != "")
                {
                    int evoluciones = Int32.Parse(palabra1);
                    misPokemons = miConexion.getPokemonPorId(evoluciones);
                    segundo.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                    nombre2.Text = misPokemons.Rows[0]["nombre"].ToString();
                    String palabra2 = misPokemons.Rows[0]["posEvolucion"].ToString();
                    if (palabra2 != "")
                    {

                        int evoluciones1 = Int32.Parse(palabra2);
                        misPokemons = miConexion.getPokemonPorId(evoluciones1);
                        tercero.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                        nombre3.Text = misPokemons.Rows[0]["nombre"].ToString();
                    }
                    else
                    {
                        tercero.Image = Properties.Resources.cruz;
                        nombre3.Text = "...";
                    }
                }
                else
                {
                    segundo.Image = Properties.Resources.cruz;
                    tercero.Image = Properties.Resources.cruz;
                    nombre2.Text = "...";
                    nombre3.Text = "...";
                }

            }
            else if (preevolucion != "" && posevolucion != "")
            {
                segundo.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                nombre2.Text = misPokemons.Rows[0]["nombre"].ToString();
              
                String palabra2 = misPokemons.Rows[0]["preEvolucion"].ToString();
                int evoluciones2 = Int32.Parse(palabra2);
                misPokemons = miConexion.getPokemonPorId(evoluciones2);
                primero.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                nombre1.Text = misPokemons.Rows[0]["nombre"].ToString();

                String palabra1 = misPokemons.Rows[0]["posEvolucion"].ToString();
                if (posevolucion != "")
                {
                    int evoluciones1 = Int32.Parse(palabra1);
                    misPokemons = miConexion.getPokemonPorId(evoluciones1);
                    tercero.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                    nombre3.Text = misPokemons.Rows[0]["nombre"].ToString();
                }
                else
                {
                    tercero.Image = Properties.Resources.cruz;
                    nombre3.Text = "...";
                }
            }
            else if (posevolucion == "")
            {
                

                segundo.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                nombre2.Text = misPokemons.Rows[0]["nombre"].ToString();
                String palabra1 = misPokemons.Rows[0]["preEvolucion"].ToString();
                int evoluciones = Int32.Parse(palabra1);
                misPokemons = miConexion.getPokemonPorId(evoluciones);
                primero.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                nombre1.Text = misPokemons.Rows[0]["nombre"].ToString();
                tercero.Image= Properties.Resources.cruz;
                nombre3.Text = "...";
                String palabra2 = misPokemons.Rows[0]["preEvolucion"].ToString();
                if (palabra2 != "")
                {
                    misPokemons = miConexion.getPokemonPorId(id);
                    tercero.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                    nombre3.Text = misPokemons.Rows[0]["nombre"].ToString();
                    String palabra12 = misPokemons.Rows[0]["preEvolucion"].ToString();
                    int evoluciones12 = Int32.Parse(palabra12);
                    misPokemons = miConexion.getPokemonPorId(evoluciones12);
                    segundo.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                    nombre2.Text = misPokemons.Rows[0]["nombre"].ToString();
                    String palabra121 = misPokemons.Rows[0]["preEvolucion"].ToString();
                    int evoluciones121 = Int32.Parse(palabra121);
                    misPokemons = miConexion.getPokemonPorId(evoluciones121);
                    primero.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                    nombre1.Text = misPokemons.Rows[0]["nombre"].ToString();

                }
             
            }
        }
        private Image convierteBlobAImagen(byte[] img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
