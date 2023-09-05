using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacasPOO_IF_WFA.Classes
{
    internal class Produto
    {
        #region Propriedades
        public int NumMacas { get; set; }
        public double ValorMacas { get; set; }
        #endregion

        #region Construtores

        public Produto()
        {

        }

        public Produto(int numMacas)
        {
            NumMacas = numMacas;
        }



        #endregion

        #region Métodos

        public void ValorTotal()
        {
            if (NumMacas < 12)
            {
                ValorMacas = NumMacas * 0.30;
            }
            else
            {
                ValorMacas = NumMacas * 0.25;
            }

        }
        public string MostrarResultado()
        {

            string frase;
            frase = $"O valor total é {ValorMacas:C2}";
            return frase;

        }
        #endregion
    }



}
