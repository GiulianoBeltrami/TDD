namespace Products.Struct
{
    public class Produto
    {
        private string name;
        private double value;

        public Produto(string name, double value)
        {
            this.name = name;
            this.value = value;
        }

        public double getValue()
        {
            return this.value;
        }

        public string getNome()
        {
            return name;
        }
    }
}