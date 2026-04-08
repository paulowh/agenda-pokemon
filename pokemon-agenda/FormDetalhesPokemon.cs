using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_agenda
{
    public partial class FormDetalhesPokemon : Form
    {
        public Pokemon pokemonRecebido { get; set; }

        public FormDetalhesPokemon()
        {
            InitializeComponent();

            lbNome.Text = pokemonRecebido.Nome;
            lbTipo.Text = pokemonRecebido.Tipo;
            lbNivel.Text = pokemonRecebido.Nivel.ToString();


        }

        private void FormDetalhesPokemon_Load(object sender, EventArgs e)
        {

        }
    }
}
