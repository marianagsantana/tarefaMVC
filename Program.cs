using System;

namespace View
{
    public class Menu
    {
        public static void Show()
        {
            int opcao;
            do
            {
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
                        Console.WriteLine("Digite o id da cidade que deseja editar: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o novo nome da cidade: ");
                        string nome = Console.ReadLine();
                        Controllers.CidadeController.EditarCidade(id, nome);
                        break;
                    case 4:
                        Console.WriteLine("Digite o id da cidade que deseja excluir: ");
                        int idExcluir = int.Parse(Console.ReadLine());
                        Controllers.CidadeController.ExcluirCidade(idExcluir);
                        break;
                    case 5:
                        CaminhaoView.Show();
                        break;
                    case 6:
                        Controllers.CaminhaoController.ListarCaminhoes();
                        break;
                    case 7:
                        Console.WriteLine("Digite o id do caminhão que deseja editar: ");
                        int idCaminhao = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a nova placa do caminhão: ");
                        string placa = Console.ReadLine();
                        Console.WriteLine("Digite o novo nome do motorista: ");
                        string motorista = Console.ReadLine();
                        Controllers.CaminhaoController.EditarCaminhao(idCaminhao, placa, motorista);
                        break;
                    case 8:
                        Console.WriteLine("Digite o id do caminhão que deseja excluir: ");
                        int idExcluirCaminhao = int.Parse(Console.ReadLine());
                        Controllers.CaminhaoController.ExcluirCaminhao(idExcluirCaminhao);
                        break;
                    case 9:
                        RotaView.Show();
                        break;
                    case 10:
                        Controllers.RotaController.ListarRotas();
                        break;
                    case 11:
                        Console.WriteLine("Digite o id da rota que deseja editar: ");
                        int idRota = int.Parse(Console.ReadLine());
                        Controllers.RotaController.EditarRota(idRota);
                        break;
                    case 12:
                        Console.WriteLine("Digite o id da rota que deseja excluir: ");
                        int idExcluirRota = int.Parse(Console.ReadLine());
                        Controllers.RotaController.ExcluirRota(idExcluirRota);
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
