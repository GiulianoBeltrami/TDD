using System.Collections.Generic;

namespace NumeroRomano.Conversor
{
    public class ConversorDeNumeroRomano
    {

        private static Dictionary<string, int> tabelaConversora = new Dictionary<string, int>()
        {
            {"I",1},
            {"V",5},
            {"X",10},
            {"L",50},
            {"C",100},
            {"D",500},
            {"M",1000}
        };
        public int converter(string numeroRomano)
        {
            return tabelaConversora.GetValueOrDefault(numeroRomano);
        }
    }
}