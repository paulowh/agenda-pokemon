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
        // Lista feita para utilizar com o DGV
        BindingList<Pokemon> listaPokemon = new BindingList<Pokemon>();
        public FmCadastroPokemon()
        {
            InitializeComponent();
            // DataGridView Visualizador organlizdo de dados

            Pokemon p1 = new Pokemon("Pikachu", "Elétrico", 5);
            Pokemon p2 = new Pokemon("Charmander", "Fogo", 9);
            Pokemon p3 = new Pokemon("Bulbasaur", "Grama", 15);
            Pokemon p4 = new Pokemon("Squirtle", "Água", 29);

            listaPokemon.Add(p1);
            listaPokemon.Add(p2);
            listaPokemon.Add(p3);
            listaPokemon.Add(p4);

            dgvListaPokemon.DataSource = listaPokemon;
        }

        // disponibilidade retorno nome (funções) a função serve para reaproveitar codigos, definindo uma função eu posso reutilizar o codigo
        private void fnLimpar()
        {
            txtNome.Clear();
            cbTipo.SelectedIndex = -1;
            numNivel.Value = 1;

            txtNome.Focus();

        }
        /* objetivo da aula: aprender a criar e utilizar objetos
         * mini game pokemon 
         * 1- montar meu time pokemon (6 pokemon) -> listas
         * 2- treinar esse meu time pokemon (a cada treinamento ele recebe 2 nivel)
         * 3- batalhar com esse pokemon de forma randonica
         * sistema vai sortear 1 a 6 pokemon (somente os 151 primeiros)
        */
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string nomePokemon = txtNome.Text; //textBox
            string tipoPokemon = cbTipo.Text; //comboBox
            int nivelPokemon = (int)numNivel.Value; //numericUpDown

            Pokemon poke = new Pokemon(nomePokemon, tipoPokemon, nivelPokemon);

            listaPokemon.Add(poke);

            //poke.fnDescricao();
            //MessageBox.Show(poke.fnLinkImg());

            //MessageBox.Show($"o Pokémon {nomePokemon} do tipo {tipoPokemon} " +
            //    $"foi cadastrado com o nivel {nivelPokemon}");

            fnLimpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fnLimpar();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            // erica
            // luiz
            // fabio
            // leandro
            // natanael

            // variaveis primitivas
            //string aluno1 = "erica";
            //string aluno2 = "luiz";
            //string aluno3 = "ana";
            //string aluno4 = "kaio";
            //string aluno5 = "iori";

            //arrays

            string[] nomesAlunos = new string[5];

            nomesAlunos[0] = "erica";
            nomesAlunos[2] = "ana";
            nomesAlunos[3] = "kaio";

            // List <tipo da variavel>
            List<string> listaNomes = new List<string>();

            listaNomes.Add("Erica");
            listaNomes.Add("Ana");
            listaNomes.Add("kaio");
            listaNomes.Add("iori");
            listaNomes.Add("laysla");


            MessageBox.Show($"Valor da lista: {listaNomes[4]}");

            MessageBox.Show($"Valor da lista: {listaNomes.Count}");

        }

 

        private void FmCadastroPokemon_Load(object sender, EventArgs e)
        {

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            //valida se a linha foi selecionada
            if (dgvListaPokemon.CurrentRow != null) 
            { 
                //                           (ConverteParaoTipo)pegar linha selecionada do DGV
                Pokemon PokemonSelecionado = (Pokemon)dgvListaPokemon.CurrentRow.DataBoundItem;

                //PokemonSelecionado.fnDescricao();

                FormDetalhesPokemon formD = new FormDetalhesPokemon();
                formD.pokemonRecebido = PokemonSelecionado;

                // ShowDialog() 'forço' usuario a focar na nova tela
                // Show() usuario pode usar qualquer tela ao mesmo tempo
                formD.ShowDialog();

            } else
            {
                MessageBox.Show("Selecione um dos Pokemon na lista");
            }
        }

        private void btnTreinar_Click(object sender, EventArgs e)
        {
            if (dgvListaPokemon.CurrentRow != null)
            {
                Pokemon pokemonParaTreinar = (Pokemon)dgvListaPokemon.CurrentRow.DataBoundItem;

                pokemonParaTreinar.fnTreinar();

                dgvListaPokemon.Refresh();

                MessageBox.Show($"o Pokemon {pokemonParaTreinar.Nome} subiu 1 nivel", "Alerta de treinamento");



            }
        }
    }
}
