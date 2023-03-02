using System;
using Models;

namespace Controllers{

    public class RotaController{


        public static void CadastrarRota(int id, string data, Caminhao idCaminhao,  Cidade partida,  Cidade chegada){
            Models.Rota novaRota = new Models.Rota(id, data, idCaminhao, partida, chegada);
        }
        public static void ListarRotas(){
            Models.Rota.ListarRotas();
        }

        public static void EditarRota(int id, string data, Caminhao idCaminhao,  Cidade partida,  Cidade chegada){
            Models.Rota.EditarRota(id, data, idCaminhao, partida, chegada);
        }
        public static void ExcluirRota(int id){
            Models.Rota.ExcluirRota(id);
        }

    }
}
