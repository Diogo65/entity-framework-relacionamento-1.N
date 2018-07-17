namespace Alura.Loja.Testes.ConsoleApp
{
    public class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PrecoUnitario { get; internal set; }
        public string Unidade { get; internal set; }

        public Produto(string nome, string categoria, double precoUnitario, string unidade)
        {
            this.Nome = nome;
            this.Categoria = categoria;
            this.PrecoUnitario = precoUnitario;
            this.Unidade = unidade;
        }

        public override string ToString()
        {
            return "Produto: " + this.Nome;
        }
    }
}