using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models
{
    class Cidade{
      
      public  int id {get; set; }
      public  string nome {get; set; }

      public static List<Cidade> Cidades = new List<Cidade>();

      public Cidade(int id, string nome)
      {
            this.id = id;
            this.nome = nome;
          Cidades.Add(this);
      }

      public static void ListarCidades(){
          foreach(Models.Cidade cidade in Models.Cidade.Cidades){
              Console.WriteLine($"Id: {cidade.id} - nome: {cidade.nome}");
          }
      }

      public static void EditarCidade(int id, string nome){
          foreach(Models.Cidade cidade in Models.Cidade.Cidades){
              if(cidade.id == id){
                  cidade.nome = nome;
              }
          }
      }


      public static void ExcluirCidade(int id){
          foreach(Models.Cidade cidade in Models.Cidade.Cidades){
              if(cidade.id == id){
                  Models.Cidade.Cidades.Remove(cidade);
                  break;
              }
          }
      }
    }
}

