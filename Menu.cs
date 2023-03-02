using System;
using View;

namespace Menu
{
    class Menu
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("==================================");
                Console.WriteLine("1 - Cadastrar Cidade");
                Console.WriteLine("2 - Listar Cidades");
                Console.WriteLine("3 - Editar Cidade");
                Console.WriteLine("4 - Excluir Cidade");
                Console.WriteLine("5 - Cadastrar Caminhão");
                Console.WriteLine("6 - Listar Caminhões");
                Console.WriteLine("7 - Editar Caminhão");
                Console.WriteLine("8 - Excluir Caminhão");
                Console.WriteLine("9 - Cadastrar Rota");
                Console.WriteLine("10 - Listar Rotas");
                Console.WriteLine("11 - Editar Rota");
                Console.WriteLine("12 - Excluir Rota");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Digite a opção desejada: ");

                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {

                    case 1:
                        CidadeView.Show();
                        break;
                    case 2:
                        Controllers.CidadeController.ListarCidades();
                        break;
                    case 3:
                        CidadeView.EditarCidade();
                        break;
                    case 4:
                        CidadeView.ExcluirCidade();
                        break;
                    case 5:
                        CaminhaoView.Show();
                        break;
                    case 6:
                        Controllers.CaminhaoController.ListarCaminhoes();
                        break;
                    case 7:
                        CaminhaoView.EditarCaminhao();
                        break;
                    case 8:
                        CaminhaoView.ExcluirCaminhao();
                        break;
                    case 9:
                        RotaView.Show();
                        break;
                    case 10:
                        Controllers.RotaController.ListarRotas();
                        break;
                    case 11:
                        RotaView.EditarRota();
                        break;
                    case 12:
                        RotaView.ExcluirRota();
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por utilizar nosso sistema!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 0);
        }
    }
}