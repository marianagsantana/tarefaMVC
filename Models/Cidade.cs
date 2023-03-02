
namespace Models
{
    public class Cidade{
      
      public  int id {get; set; }
      public  string nome {get; set; }

      public static List<Cidade> cidades = new List<Cidade>();

      public Cidade(int id, string nome)
      {
            this.id = id;
            this.nome = nome;
            cidades.Add(this);
      }

      public static void ListarCidades(){
          foreach(Models.Cidade cidade in Models.Cidade.cidades){
              Console.WriteLine($"Id: {cidade.id} - nome: {cidade.nome}");
          }
      }

      public static void EditarCidade(int id, string nome){
            foreach(Models.Cidade cidade in Models.Cidade.cidades){
                if(cidade.id == id){
                    cidade.nome = nome;
                }
            }
      }


      public static void ExcluirCidade(int id){
          foreach(Models.Cidade cidade in Models.Cidade.cidades){
              if(cidade.id == id){
                  Models.Cidade.cidades.Remove(cidade);
                  break;
              }
          }
      }

        public static Cidade BuscarCidade(int id){
            foreach(Models.Cidade cidade in Models.Cidade.cidades){
                if(cidade.id == id){
                    return cidade;
                }
            }
            return null;
        }
    }
}