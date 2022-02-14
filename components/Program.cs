using System;
using Products.Struct;
using Products.Compare;
using Products.Shopcar;

namespace components
{
    class Program
    {
        static void Main(string[] args)
        {
            var carrinhoDeCompras = new CarrinhoDeCompras();

            carrinhoDeCompras.adiciona(new Produto("geladeira", 450.50));
            carrinhoDeCompras.adiciona(new Produto("liquidificador", 250.00));
            carrinhoDeCompras.adiciona(new Produto("jogo de pratos", 70.00));
            
            var algoritmo = new MaiorEMenor();
            algoritmo.find(carrinhoDeCompras);

            Console.WriteLine("Menor: "+algoritmo.getMenor().getNome());
            Console.WriteLine("Maior: "+algoritmo.getMaior().getNome());
        }
    }
}
