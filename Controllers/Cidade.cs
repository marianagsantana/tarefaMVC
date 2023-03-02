using System;
using Models;

namespace Controllers{
    public class CidadeController{
        
        public static void CadastrarCidade(int id, string nome){
            Models.Cidade novaCidade = new Models.Cidade(id, nome);
        }
        public static void ListarCidades(){
            Models.Cidade.ListarCidades();
        }

        public static void EditarCidade(int id, string nome){
            Models.Cidade.EditarCidade(id, nome);
        }

        public static void ExcluirCidade(int id){
            Models.Cidade.ExcluirCidade(id);
        }
        
    }
}