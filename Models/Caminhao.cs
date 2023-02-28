namespace Models
{
    public class Caminhao 
    {
        public int Id {get; set; }

        public string Placa {get; set; }

        public string Motorista { get; set;}

        public static List<Caminhao> Caminhoes = new List<Caminhao>();

        public Caminhao(int id, string placa, string motorista)
        {
            Id = id;
            Placa = placa;
            Motorista = motorista;
            Caminhoes.Add(this);
        }
        public static void ListarCaminhoes(){
            foreach(Models.Caminhao caminhao in Models.Caminhao.Caminhoes){
                Console.WriteLine($"Id: {caminhao.Id} - Placa: {caminhao.Placa} - Motorista: {caminhao.Motorista}");
            }
        }

        public static void EditarCaminhao(int id, string placa, string motorista){
            foreach(Models.Caminhao caminhao in Models.Caminhao.Caminhoes){
                if(caminhao.Id == id){
                    caminhao.Placa = placa;
                    caminhao.Motorista = motorista;
                }
            }
        }

        public static void ExcluirCaminhao(int id){
            foreach(Models.Caminhao caminhao in Models.Caminhao.Caminhoes){
                if(caminhao.Id == id){
                    Models.Caminhao.Caminhoes.Remove(caminhao);
                    break;
                }
            }
        }
    }
}