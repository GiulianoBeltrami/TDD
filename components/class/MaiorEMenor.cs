using Products.Struct;
using Products.Shopcar;

namespace Products.Compare
{
    public class MaiorEMenor
    {
        private Produto menor;
        private Produto maior;

        public void find(CarrinhoDeCompras carrinho)
        {
            foreach (var produto in carrinho.getProdutos())
            {
                if (menor == null || produto.getValue() < menor.getValue())
                {
                    this.menor = produto;
                }
                if (maior == null || produto.getValue() > maior.getValue())
                {
                    this.maior = produto;
                }
            }
        }

        public Produto getMenor()
        {
            return menor;
        }

        public Produto getMaior()
        {
            return maior;
        }
    }
}