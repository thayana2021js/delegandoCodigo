using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class ProgramDelegado
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            //operacao op = Calculadora.Somar;
            Operacao op = new Operacao(Calculadora.Somar);
            op.Invoke(10, 10);

            //op(10, 10);  

        }
    }
}
