namespace View
{
    class CaminhaoView
    {
        public static void Show()
        {
            Console.WriteLine("Digite o id do caminhão: ");
            int idCaminhao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a placa do caminhão: ");
            string placa = Console.ReadLine();
            Console.WriteLine("Digite o nome do motorista: ");
            string motorista = Console.ReadLine();
            Controllers.CaminhaoController.CadastrarCaminhao(idCaminhao, placa, motorista);
        }

        public static void ListarCaminhoes()
        {
            Controllers.CaminhaoController.ListarCaminhoes();
        }

        public static void EditarCaminhao()
        {
            Console.WriteLine("Digite o id do caminhão que deseja editar: ");
            int idCaminhao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nova placa do caminhão: ");
            string placa = Console.ReadLine();
            Console.WriteLine("Digite o novo nome do motorista: ");
            string motorista = Console.ReadLine();
            Controllers.CaminhaoController.EditarCaminhao(idCaminhao, placa, motorista);
        
        }

        public static void ExcluirCaminhao()
        {
            Console.WriteLine("Digite o id do caminhão que deseja excluir: ");
            int idExcluirCaminhao = int.Parse(Console.ReadLine());
            Controllers.CaminhaoController.ExcluirCaminhao(idExcluirCaminhao);
        }


    }
}