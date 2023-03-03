using System;
using Models;

namespace Controllers{

    public class RotaController{


        public static void CadastrarRota(int id, string data, double preco, Caminhao idCaminhao,  Cidade partida,  Cidade chegada){
            Models.Rota novaRota = new Models.Rota(id, data, preco, idCaminhao, partida, chegada);
            if(Caminhao.totalRotas(novaRota.caminhao.id) != 0){
                novaRota.caminhao.totalRota++;
            }
            if(Caminhao.faturaTotal(novaRota.caminhao.id) != 0){
                novaRota.caminhao.valorFaturado += preco;
            }
        }
        public static void ListarRotas(){
            Models.Rota.ListarRotas();
        }

        public static void EditarRota(int id, string data, double preco, Caminhao idCaminhao,  Cidade partida,  Cidade chegada){
            Models.Rota.EditarRota(id, data, preco, idCaminhao, partida, chegada);
        }
        public static void ExcluirRota(int id){
            Models.Rota.ExcluirRota(id);
        }

    }
}
