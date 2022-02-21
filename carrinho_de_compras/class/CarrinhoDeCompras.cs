using System.Collections.Generic;
using Products.Struct;

namespace Products.Shopcar
{
    public class CarrinhoDeCompras
    {
        private List<Produto> produtos;

        public CarrinhoDeCompras()
        {
            produtos = new List<Produto>();
        }

        public void adiciona(Produto produto)
        {
            produtos.Add(produto);
        }

        public List<Produto> getProdutos()
        {
            return produtos;
        }

    }
}