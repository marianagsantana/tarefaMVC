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
    }
}
