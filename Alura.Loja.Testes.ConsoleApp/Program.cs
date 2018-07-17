using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Relacionamentos Um para Muitos no Entity
            //    Uma Compra pode conter vários produtos

            //compra de 6 pães franceses
            Produto paoFrances = new Produto("Pão Francês","Padaria", 0.40, "Unidade");

            Compra compra = new Compra();
            compra.Quantidade = 6;
            compra.Produto = paoFrances;
            compra.Preco = paoFrances.PrecoUnitario * compra.Quantidade;

            //Inserindo objetos relacionados
            using (var contexto = new LojaContext())
            {
                contexto.Compras.Add(compra);

                contexto.SaveChanges();
            }
        }
    }
}
