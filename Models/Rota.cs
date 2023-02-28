namespace Models
{
    public class Rota 
    {
        public int Id {get; set; }

        public int idCaminhao {get; set; }
        public string Partida {get; set; }
        public string Chegada {get; set; }
        public string Data {get; set; }
        //create a collection to store the rota
        public static List<Rota> Rotas = new List<Rota>();


        public Rota(int id, int idCaminhao, string partida, string chegada, string data)
        {
            Id = id;
            Partida = partida;
            Chegada = chegada;
            Data = data;
            Rotas.Add(this);
        }

        public static void ListarRotas(){
            foreach(Models.Rota rota in Models.Rota.Rotas){
                Console.WriteLine($"Id: {rota.Id} - Id do caminhão: {rota.idCaminhao} - Partida: {rota.Partida} - Chegada: {rota.Chegada} - Data: {rota.Data}");
            }
        }

        public static void EditarRota(int id, int idCaminhao,  string partida,  string chegada, string data){
            foreach(Models.Rota rota in Models.Rota.Rotas){
                if(rota.Id == id){
                    rota.idCaminhao = idCaminhao;
                    rota.Partida = partida;
                    rota.Chegada = chegada;
                    rota.Data = data;
                }
            }
        }

        public static void ExcluirRota(int id){
            foreach(Models.Rota rota in Models.Rota.Rotas){
                if(rota.Id == id){
                    Models.Rota.Rotas.Remove(rota);
                    break;
                }
            }
        }
    }
}
