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
    public partial class FmCadastroPokemon : Form
    {
        public FmCadastroPokemon()
        {
            InitializeComponent();
        }

        // disponibilidade retorno nome (funções) a função serve para reaproveitar codigos, definindo uma função eu posso reutilizar o codigo
        private void fnLimpar()
        {
            txtNome.Clear();
            cbTipo.SelectedIndex = -1;
            numNivel.Value = 1;


            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomePokemon = txtNome.Text; //textBox
            string tipoPokemon = cbTipo.Text; //comboBox
            int nivelPokemon =  (int)numNivel.Value; //numericUpDown

            MessageBox.Show($"o Pokémon {nomePokemon} do tipo {tipoPokemon} " +
                $"foi cadastrado com o nivel {nivelPokemon}");

            fnLimpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fnLimpar();
        }
    }
}
