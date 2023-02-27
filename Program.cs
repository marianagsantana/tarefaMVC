/* Desenvolver um mini sistema de rastreamento de rotas.
Deve ser desenvolvido um CRUD de cada entidade, sendo que o banco de dados deve ser simulado através de uma collection.*/

using System;
using System.Collections.Generic;
using System.Linq;


namespace View
{ 
    public class Menu
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema de rastreamento de rotas!");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Cadastrar cidade");
            Console.WriteLine("2 - Cadastrar caminhão");
            Console.WriteLine("3 - Cadastrar rota");
            Console.WriteLine("4 - Listar cidades");
            Console.WriteLine("5 - Listar caminhões");
            Console.WriteLine("6 - Listar rotas");
            Console.WriteLine("7 - Sair");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o ID da cidade: ");
                    int idCidade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o nome da cidade: ");
                    string nomeCidade = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Digite o ID do caminhão: ");
                    int idCaminhao = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a placa do caminhão: ");
                    string placa = Console.ReadLine();
                    Console.WriteLine("Digite o nome do motorista: ");
                    string motorista = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Digite o ID da rota: ");
                    int idRota = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o ID do caminhão: ");
                    int Caminhao = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o horário de partida: ");
                    TimeOnly Partida = TimeOnly.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o horário de chegada: ");
                    TimeOnly Chegada = TimeOnly.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a data da rota: ");
                    DateOnly Data = DateOnly.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Listar cidades");             
                    break;
                case 5:
                    Console.WriteLine("Listar caminhões");
                    break;
                case 6:
                    Console.WriteLine("Listar rotas");
                    break;
                case 7:
                    Console.WriteLine("Sair");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}