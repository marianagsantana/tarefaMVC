
namespace Models
{
    public class Rota 
    {
        public int id {get; set; }
        public string data {get; set; }

        public Caminhao caminhao {get; set; }
        
        public Cidade cidadePartida {get; set; }

        public Cidade cidadeChegada {get; set; }
        //create a collection to store the rota
        public static List<Rota> rotas = new List<Rota>();


        public Rota(int id, string data, Caminhao caminhao, Cidade partida, Cidade chegada)
        {
            this.id = id;
            this.data = data;
            this.caminhao = caminhao;
            this.cidadePartida = partida;
            this.cidadeChegada = chegada;
            rotas.Add(this);
        }

        public static void ListarRotas(){
            foreach(Models.Rota rota in Models.Rota.rotas){
                Console.WriteLine($"Id: {rota.id} - Data: {rota.data} - Caminhao: {rota.caminhao.placa} - Partida: {rota.cidadePartida.nome} - Chegada: {rota.cidadeChegada.nome}");
            }
        }

        public static void EditarRota(int id, string data, Caminhao caminhao, Cidade partida, Cidade chegada){
            foreach(Models.Rota rota in Models.Rota.rotas){
                if(rota.id == id){
                    rota.data = data;
                    rota.caminhao = caminhao;
                    rota.cidadePartida = partida;
                    rota.cidadeChegada = chegada;
                }
            }
        }

        public static void ExcluirRota(int id){
            foreach(Models.Rota rota in Models.Rota.rotas){
                if(rota.id == id){
                    Models.Rota.rotas.Remove(rota);
                    break;
                }
            }
        }

        public static Rota BuscarRota(int id){
            foreach(Models.Rota rota in Models.Rota.rotas){
                if(rota.id == id){
                    return rota;
                }
            }
            return null;
        }
    }
}