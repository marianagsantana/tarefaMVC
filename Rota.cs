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
            Console.WriteLine("Digite a cidade de partida: ");
            string partida = Console.ReadLine();
            Console.WriteLine("Digite a cidade de chegada: ");
            string chegada = Console.ReadLine();
            Console.WriteLine("Digite a data da rota: ");
            string data = Console.ReadLine();
            Controllers.RotaController.CadastrarRota( id,idCaminhao, partida, chegada, data);
        }
    }
}