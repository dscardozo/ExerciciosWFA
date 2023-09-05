using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_POO_WFA.Classes
{
    internal class Idade
    {
        #region Propriedades
        public int Anos { get; set; }
        public int Meses { get; set; }
        public int Dias { get; set; }
        #endregion

        #region Construtores
        public Idade()
        {
                
        }

        public Idade(int dias)
        {
            Dias = dias;
        }

        public Idade(int anos, int meses, int dias)
        {
            Anos = anos;
            Meses = meses;
            Dias = dias;
        }


        #endregion

        #region Métodos
        public string RetornaTempoEmDias()
        {
            int somaAnosEmDias = Anos * 365;
            int somaMesesEmDias = Meses * 30;
            return (somaAnosEmDias + somaMesesEmDias + Dias).ToString();
        }

        public void CalculaTempoEmAMD()
        {
            Anos = Dias / 365;
            int restoDias = Dias % 365;
            Meses = restoDias / 30;
            Dias = restoDias % 30;
        }
        #endregion
    }
}
