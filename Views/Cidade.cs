namespace View
{
    class CidadeView
    {
        internal static void Show()
        {
            Console.WriteLine("Digite o id da cidade: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da cidade: ");
            string nome = Console.ReadLine();
            Controllers.CidadeController.CadastrarCidade(id, nome);
        } 

        internal static void ListarCidades()
        {
            Controllers.CidadeController.ListarCidades();
        }

        internal static void EditarCidade()
        {
            Console.WriteLine("Digite o id da cidade que deseja editar: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o novo nome da cidade: ");
            string nome = Console.ReadLine();
            Controllers.CidadeController.EditarCidade(id, nome);
        }

        internal static void ExcluirCidade()
        {
            Console.WriteLine("Digite o id da cidade que deseja excluir: ");
            int idExcluir = int.Parse(Console.ReadLine());
            Controllers.CidadeController.ExcluirCidade(idExcluir);
        }

    }
}