using Models;
using System;

namespace View
{
    class RotaView
    {
        public static void Show()
        {
            Console.WriteLine("Digite o id da rota: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o id do caminhão: ");
            int idCaminhao = int.Parse(Console.ReadLine());
            Caminhao buscaCaminhao = Models.Caminhao.BuscarCaminhao(idCaminhao);
            Console.WriteLine("Digite a cidade de partida: ");
            string partida = Console.ReadLine();
            Cidade buscaCidadePartida = Models.Cidade.BuscarCidade(idCaminhao);
            Console.WriteLine("Digite a cidade de chegada: ");
            string chegada = Console.ReadLine();
            Cidade buscaCidadeChegada = Models.Cidade.BuscarCidade(idCaminhao);
            Console.WriteLine("Digite a data da rota: ");
            string data = Console.ReadLine();
            Console.WriteLine("Digite o preço da rota: ");
            double preco = double.Parse(Console.ReadLine());
            Controllers.RotaController.CadastrarRota(id, data, preco, buscaCaminhao, buscaCidadePartida, buscaCidadeChegada);

        }

        public static void ListarRotas()
        {
            Controllers.RotaController.ListarRotas();
        }

        public static void EditarRota()
        {
            Console.WriteLine("Digite o id da rota que deseja editar: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o id do caminhão: ");
            int idCaminhao = int.Parse(Console.ReadLine());
            Caminhao buscaCaminhao = Models.Caminhao.BuscarCaminhao(idCaminhao);
            Console.WriteLine("Digite a cidade de partida: ");
            string partida = Console.ReadLine();
            Cidade buscaCidadePartida = Models.Cidade.BuscarCidade(idCaminhao);
            Console.WriteLine("Digite a cidade de chegada: ");
            string chegada = Console.ReadLine();
            Cidade buscaCidadeChegada = Models.Cidade.BuscarCidade(idCaminhao);
            Console.WriteLine("Digite a data da rota: ");
            string data = Console.ReadLine();
            Console.WriteLine("Digite o preço da rota: ");
            double preco = double.Parse(Console.ReadLine());
            Controllers.RotaController.EditarRota(id, data, preco, buscaCaminhao, buscaCidadePartida, buscaCidadeChegada);
        }

        public static void ExcluirRota()
        {
            Console.WriteLine("Digite o id da rota que deseja excluir: ");
            int idExcluir = int.Parse(Console.ReadLine());
            Controllers.RotaController.ExcluirRota(idExcluir);
        }
    }
}