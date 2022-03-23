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
    public partial class ventana2 : Form
    {

        Conexion miConexion = new Conexion();
        int id = 0;
        DataTable misPokemons;


        public ventana2(int idActual, DataTable misPokemons)
        {
            id = idActual;
            InitializeComponent();
            misPokemons = miConexion.getPokemonPorId(idActual);
            label1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            movimiento2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
            movimiento3.Text= misPokemons.Rows[0]["movimiento3"].ToString();
            movimiento4.Text= misPokemons.Rows[0]["movimiento4"].ToString();
            foto.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            nombre.Text = misPokemons.Rows[0]["nombre"].ToString();
            especie.Text = "Especie: "+misPokemons.Rows[0]["especie"].ToString();
            habitad.Text ="Habitat: "+ misPokemons.Rows[0]["habitat"].ToString();
            numero.Text ="# " + misPokemons.Rows[0]["id"].ToString();
            tipo.Text = "Es de tipo "+ misPokemons.Rows[0]["tipo1"].ToString() +" "+ misPokemons.Rows[0]["tipo2"].ToString();
            String tipo1 = misPokemons.Rows[0]["tipo1"].ToString();
            
            switch (tipo1)
            {
                case "Planta": this.BackgroundImage = Properties.Resources.carta_planta; break;
                case "Volador": this.BackgroundImage = Properties.Resources.carta_planta; break;
                case "Fuego": this.BackgroundImage = Properties.Resources.carta; break;
                case "Electrico": this.BackgroundImage = Properties.Resources.carta_electrico1; break;
                case "Agua": this.BackgroundImage = Properties.Resources.carta_agua; break;
                case "Hielo": this.BackgroundImage = Properties.Resources.carta_agua; break;
                case "Lucha": this.BackgroundImage = Properties.Resources.carta_lucha; break;
                case "Roca": this.BackgroundImage = Properties.Resources.carta_lucha; break;
                case "Tierra": this.BackgroundImage = Properties.Resources.carta_lucha; break;
                case "Bicho": this.BackgroundImage = Properties.Resources.carta_planta; break;
                case "Normal": this.BackgroundImage = Properties.Resources.tipo_normal; break;
                case "Psiquico": this.BackgroundImage = Properties.Resources.carta_psiqui; break;
                case "Veneno": this.BackgroundImage = Properties.Resources.carta_psiqui; break;
                case "Fantasma": this.BackgroundImage = Properties.Resources.carta_psiqui; break;
                case "Dragon": this.BackgroundImage = Properties.Resources.carta_dragon1; break;

            }
        }
        private Image convierteBlobAImagen(byte[] img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void movimiento1(object sender, EventArgs e)
        {

        }

        private void ventana2_Load(object sender, EventArgs e)
        {

        }

        private void movimiento3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadenaEvolutiva ventana = new cadenaEvolutiva(id, misPokemons);
            ventana.Show();
        }
    }
}
