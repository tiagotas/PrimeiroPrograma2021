using System;

namespace PrimeiroPrograma2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  Declaração da variável nome cujo tipo é string (caracter).
             */ 
            string nome;
            string cidade;

            /**
             * Declaração da variável idade cujo tipo é int (número inteiro).
             */ 
            int idade;

            /**
             * Declaração da variável peso cujo tipo é double (número decimal).
             */ 
            double peso;


            /**
             * Console = "Telinha Preta" para apresentar e digitar dados.
             * WriteLine = Escreve uma linha no console.
             */
            Console.WriteLine("Bem-vindo a Disciplina de Linguagem de Programação");
            Console.WriteLine("Fatec Mococa - Primeiro Semestre 2021");

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();


            /**
             * "Tudo que é digitado pelo usuário no console é considerado texto, inclusive
             *  numerais, datas, etc".
             * Convert = "ferramenta" para converter um dado para outro tipo, ex: string para int.
             * ToInt16( ... ) faz a conversão específica de algo para número inteiro.
             */ 
            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua cidade de origem: ");
            cidade = Console.ReadLine();

            Console.WriteLine("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

           

            /**
             * Mostrando o conteúdo das variáveis usando marcadores.
             */ 
            Console.WriteLine("Olá {0} sua idade é {1}", nome, idade);
            Console.WriteLine("você é de {0} e está pesando {1} kilos", cidade, peso);

            /**
             * Mostrando conteúdo das variáveis usando concatenação.
             */
            // Console.WriteLine("Olá " + nome + " sua idade é " + idade + " e você é de " + cidade);

            Console.WriteLine("Nome em letras maiúsculas: {0} ", nome.ToUpper() );
            Console.WriteLine("Nome em letras minúsculas: {0}", nome.ToLower() );

            // Tiago = 5 Caracteres.
            Console.WriteLine("Seu nome tem {0} caracteres. ", nome.Length );

            /**
             * Corta um string de uma posição a outra:
             * 0 1 2 3 4
             * T I A G O
             * 
             */
            Console.WriteLine("Nome até 3 caracteres {0}", nome.Substring(0, 3) );
            Console.WriteLine("Tranformando em Iago: {0}", nome.Substring(1, 4));

            Console.ReadKey();
        }
    }
}
