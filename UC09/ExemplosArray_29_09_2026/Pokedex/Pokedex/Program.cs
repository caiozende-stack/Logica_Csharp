using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomePokemon = { "Pikachu   ", "Bulbasaur ", "Charmander", "Squirtle  ", "Zubat        ","Meowth    ","Psyduck   ","Poliwag   ","Machop","Poliwhirl" };
            string[] tipoPokemon = { "Elétrico", " Grama/Veneno", "Fogo     ", "Água      ", "Veneno/Voador","Normal    ", "Água     ", "Água     ", "Lutador","Água   " };
            string[] pesoPokemon = {
                      "6.0kg" //Pikachu
                    , "6.9kg"  //Bulbasaur
                    , "8.5kg"  //Charmander
                    , "9.0kg"  //Squirtle
                    , "7.5kg"  //Zubat
                    , "4.2kg"  //Mewoth
                    , "19.6kg" //Psyduck
                    , "12.4kg" //Poliwag
                    , "19.5kg" //Machop
                    , "20.0kg" }; //Poliwhirl

            string[] tamanhoPokemon =
            {
                "0.4m", //Pikachu
                "0.7m", //Bulbasaur
                "0.6m", //Charmander
                "0.5m", //Squirtle
                "0.8m", //Zubat
                "0.4m", //Mewoth
                "0.8m", //Psyduck
                "0.6m", //Poliwag
                "0.8m", //Machop
                "1.0m" //Poliwhirl
            };
            int[] numeroPokemon =
            {
                25, //Pikachu
                1, //Bulbasaur
                4, //Charmander
                7, //Squirtle
                41, //Zubat
                52, //Mewoth
                54, //Psyduck
                60, //Poliwag
                56, //Machop
                61 //Poliwhirl
            };
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nListagem de Pokemons\n");
            Console.ResetColor();

            for(int i = 0; i < nomePokemon.Length; i++) // legnth -- Informa o total de itens do vetor
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("ID:     " + numeroPokemon[i]);
                Console.WriteLine("Nome:   " + nomePokemon[i]);
                Console.WriteLine("Tipo:   " + tipoPokemon[i]);
                Console.WriteLine("Altura: " + tamanhoPokemon[i]);
                Console.WriteLine("Peso:   " + pesoPokemon[i]);
                Console.WriteLine("----------------------------");

                Console.WriteLine();
            }

        }
    }
}
