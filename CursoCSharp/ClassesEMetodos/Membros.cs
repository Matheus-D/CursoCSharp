using System;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {

            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Matheus";
            sicrano.Idade = 26;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 22;

            var apresentacaoDoFulano = fulano.Apresentar();

        }
    }
}
