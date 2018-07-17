namespace Alura.Loja.Testes.ConsoleApp
{
    public class Compra
    {
        //Essa propriedade irá representar a chave primária da compra.
        public int Id { get; set; }
        //o entity interpreta que essa propriedade é obrigatória através do tipo que é 
        //atribuido pra ela, sendo assim ela não pode ser nula (ProdutoId)
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }//é o mesmo que ProdutoId
        //o Entity usa na coluna a convenção[nome da classe] Id.
        public int Quantidade { get; set; }
        public double Preco { get; set; }
    }
}