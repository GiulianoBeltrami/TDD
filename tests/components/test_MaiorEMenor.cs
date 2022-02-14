using Xunit;
using Products.Struct;
using Products.Compare;
using Products.Shopcar;

namespace tests
{
    public class TestaMaiorEMenor
    {
        [Fact]
        public void ordemDecrescente()
        {
            var carrinhoDeCompras = new CarrinhoDeCompras();

            var produtoMaior = new Produto("geladeira", 450.50);
            carrinhoDeCompras.adiciona(produtoMaior);

            carrinhoDeCompras.adiciona(new Produto("liquidificador", 250.00));

            var produtoMenor = new Produto("jogo de pratos", 70.00);
            carrinhoDeCompras.adiciona(produtoMenor);

            var algoritmo = new MaiorEMenor();
            algoritmo.find(carrinhoDeCompras);

            Assert.Equal<Produto>(produtoMaior, algoritmo.getMaior());
            Assert.Equal<Produto>(produtoMenor, algoritmo.getMenor());
        }

        [Fact]
        public void ordemCrescente()
        {
            var carrinhoDeCompras = new CarrinhoDeCompras();

            var produtoMenor = new Produto("jogo de pratos", 70.00);
            carrinhoDeCompras.adiciona(produtoMenor);

            carrinhoDeCompras.adiciona(new Produto("liquidificador", 250.00));

            var produtoMaior = new Produto("geladeira", 450.50);
            carrinhoDeCompras.adiciona(produtoMaior);

            var algoritmo = new MaiorEMenor();
            algoritmo.find(carrinhoDeCompras);

            Assert.Equal<Produto>(produtoMaior, algoritmo.getMaior());
            Assert.Equal<Produto>(produtoMenor, algoritmo.getMenor());
        }

        [Fact]
        public void ordemVariada()
        {
            var carrinhoDeCompras = new CarrinhoDeCompras();

            var produtoMenor = new Produto("jogo de pratos", 70.00);
            carrinhoDeCompras.adiciona(produtoMenor);

            var produtoMaior = new Produto("geladeira", 450.50);
            carrinhoDeCompras.adiciona(produtoMaior);

            carrinhoDeCompras.adiciona(new Produto("liquidificador", 250.00));



            var algoritmo = new MaiorEMenor();
            algoritmo.find(carrinhoDeCompras);

            Assert.Equal<Produto>(produtoMaior, algoritmo.getMaior());
            Assert.Equal<Produto>(produtoMenor, algoritmo.getMenor());
        }

        [Fact]
        public void unicoProduto()
        {
            var carrinhoDeCompras = new CarrinhoDeCompras();
            var produto = new Produto("jogo de pratos", 70.00);
            carrinhoDeCompras.adiciona(produto);

            var algoritmo = new MaiorEMenor();
            algoritmo.find(carrinhoDeCompras);

            Assert.Equal<Produto>(produto, algoritmo.getMaior());
            Assert.Equal<Produto>(produto, algoritmo.getMaior());
        }
    }
}
