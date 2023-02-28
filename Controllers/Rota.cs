using System;

namespace Controllers{

    public class RotaController{


        public static void CadastrarRota(int id, int idCaminhao,  string partida,  string chegada, string data){
            Models.Rota novaRota = new Models.Rota(id, idCaminhao, partida, chegada, data);
            Models.Rota.Rotas.Add(novaRota);
        }
        public static void ListarRotas(){
            Models.Rota.ListarRotas();
        }

        public static void EditarRota(int id, int idCaminhao,  string partida,  string chegada, string data){
            Models.Rota.EditarRota(id, idCaminhao, partida, chegada, data);
        }

        public static void ExcluirRota(int id){
            Models.Rota.ExcluirRota(id);
        }

        internal static void EditarRota(int idRota)
        {
            throw new NotImplementedException();
        }
    }
}

