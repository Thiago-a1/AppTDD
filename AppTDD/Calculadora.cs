using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTDD
{
    public class Calculadora
    {
        private List<string> ListaHistorico;

        public Calculadora ()
        {
            ListaHistorico = new List<string>();
        }

        public int somar(int num1, int num2)
        {
            var res = num1 + num2;

            ListaHistorico.Insert(0, "Res: " + res);
            return  res;
        }

        public int subtrair(int num1, int num2)
        {
            var res = num1 - num2;

            ListaHistorico.Insert(0, "Res: " + res);
            return res;
        }

        public int multiplicar(int num1, int num2)
        {
            var res = num1 * num2;

            ListaHistorico.Insert(0, "Res: " + res);
            return res;
        }

        public int dividir(int num1, int num2)
        {   
            var res = num1 / num2;

            ListaHistorico.Insert(0, "Res: " + res);
            return res;
        }

        public List<string> historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);

            return ListaHistorico;
        }
    }
}
