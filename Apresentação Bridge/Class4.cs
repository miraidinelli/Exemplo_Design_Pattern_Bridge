using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentação
{
    public class Circulo : Forma
    {
        public Circulo(ICores cor) : base(cor) { }
        public override void Desenhar()
        {
            Console.Write("Desenhando um círculo.");
            cor.AplicarCores();
        }
    }
    public class Quadrado : Forma
    {
        public Quadrado(ICores cor) : base(cor) { }
        public override void Desenhar()
        {
            Console.Write("Desenhando um quadrado. ");
            cor.AplicarCores();
        }
    }
}
