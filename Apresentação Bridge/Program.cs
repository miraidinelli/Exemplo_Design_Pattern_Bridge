using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICores vermelho = new CorVermelho();
            ICores azul = new CorAzul();

            Forma circuloVm = new Circulo(vermelho);
            Forma quadradoAz = new Quadrado(azul);

            circuloVm.Desenhar();
            quadradoAz.Desenhar();
        }
    }
}
