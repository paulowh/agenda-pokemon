using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_agenda
{

    // public
    // intern
    // private
    public class Pokemon
    {
        // nome do pokemon
        // tipo do pokemon
        // nivel do pokemon
        // vida do pokemon
        // dano do pokemon


        // get set
        public string Nome { get;  set; }
        public string Tipo { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int Dano { get; set; }


        /// <summary>
        /// Inicializa o construtor da minha classe padrão de <c>Pokemon</c>
        /// (<paramref name="nomePokemon"/>, <paramref name="tipoPokemon"/>, <paramref name="nivelPokemon"/>)
        /// 
        /// <list type="bullet">
        /// <item>nomePokemon: variavel para saber o nome</item>
        /// <item>tipoPokemon: variavel para saber o nome</item>
        /// <item>nivelPokemon: variavel para saber o nome</item>
        /// </list>
        /// </summary>
        /// <returns>
        /// A Class Pokemon retorna um objeto com todas as funções que tem relação ao treinamento do pokemon
        /// </returns>
        /// <param name="nomePokemon">Vai ser o nome que o pokemon vai ser chamado</param>
        /// <param name="tipoPokemon">Define o tipo do elemento que o pokemon tem afinidade</param>
        /// <param name="nivelPokemon">O nivel que o pokemon foi encontrado</param>
        public Pokemon(string nomePokemon, string tipoPokemon, int nivelPokemon)
        {

            // Nome = "Pikachu";
            // Tipo = "Elétrico";
            // Nivel = 5;

            Nome = nomePokemon;
            Tipo = tipoPokemon;
            Nivel = nivelPokemon;

            Vida = nivelPokemon * 70;
            Dano = nivelPokemon * 15;
        }

        /// <summary>
        /// Exibe a descrição dos dados de informação dos pokemon, nome, tipo, nivel, vida, dano
        /// </summary>
        /// <returns>
        /// a função <see cref="fnDescricao"/> não retorna nada
        /// </returns>
        public void fnDescricao()
        {
            MessageBox.Show($"pokemon: {Nome}, Tipo: {Tipo}, " +
                $"Nivel: {Nivel}, Vida: {Vida}, Dano: {Dano}");
        }


        public string fnLinkImg()
        {

            string nomeTratado = Nome.Replace(" ", "-").Replace(".", "").ToLower();

            return $"https://img.pokemondb.net/artwork/{nomeTratado}.jpg";
        }

        public void fnTreinar()
        {
            Nivel++;

            Vida = Nivel * 70;
            Dano = Nivel * 15;
        }

    }
}
