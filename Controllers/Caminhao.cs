using System;
using Models;

namespace Controllers{

    public class CaminhaoController{

        public static void CadastrarCaminhao(int id, string placa, string motorista){
            Models.Caminhao novoCaminhao = new Models.Caminhao(id, placa, motorista);
            }
        public static void ListarCaminhoes(){
            Models.Caminhao.ListarCaminhoes();
        }

        public static void EditarCaminhao(int id, string placa, string motorista){
            Models.Caminhao.EditarCaminhao(id, placa, motorista);
        }

        public static void ExcluirCaminhao(int id){
            Models.Caminhao.ExcluirCaminhao(id);
        }
    }
}