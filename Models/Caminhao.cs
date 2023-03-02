namespace Models
{
    public class Caminhao 
    {
        public int id {get; set; }

        public string placa {get; set; }

        public string motorista { get; set;}
        public int totalRota {get; set;}
        public double valorFaturado {get; set;}
        public static List<Caminhao> caminhoes = new List<Caminhao>();

        public Caminhao(int id, string placa, string motorista)
        {
            this.id = id;
            this.placa = placa;
            this.motorista = motorista;
            this.totalRota = 0;
            this.valorFaturado = 0;
            caminhoes.Add(this);
        }
        public static void ListarCaminhoes(){
            foreach(Models.Caminhao caminhao in Models.Caminhao.caminhoes){
                Console.WriteLine($"id: {caminhao.id} - placa: {caminhao.placa} - motorista: {caminhao.motorista} - total de rotas: {caminhao.totalRota} - Valor faturado: {caminhao.valorFaturado}");
            }
        }

        public static void EditarCaminhao(int id, string placa, string motorista){
            foreach(Models.Caminhao caminhao in Models.Caminhao.caminhoes){
                if(caminhao.id == id){
                    caminhao.placa = placa;
                    caminhao.motorista = motorista;
                }
            }
        }

        public static void ExcluirCaminhao(int id){
            foreach(Models.Caminhao caminhao in Models.Caminhao.caminhoes){
                if(caminhao.id == id){
                    Models.Caminhao.caminhoes.Remove(caminhao);
                    break;
                }
            }
        }

        public static Caminhao BuscarCaminhao(int id){
            foreach(Models.Caminhao caminhao in Models.Caminhao.caminhoes){
                if(caminhao.id == id){
                    return caminhao;
                }
            }
            return null;
        }
        public static int totalRotas(int id) {
            int total = 0;
            foreach (Rota rota in Rota.rotas) {
                if (rota.caminhao.id == id) {
                    total++;
                }
            }
            return total;
        }

        public static double faturaTotal(int id) {
            double total = 0;
            foreach (Rota rota in Rota.rotas) {
                if (rota.caminhao.id == id) {
                    total += rota.preco;
                }
            }
            return total;
        }
    }
}