using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_POO_WFA.Classes
{
    internal class Pessoa
    {
        #region Propriedades
        public string Nome { get; set; }
        public int Anos { get; set; }
        public int Meses { get; set; }
        public int Dias { get; set; }
        public int AnosInverso { get; set; }
        public int MesesInverso { get; set; }
        public int DiasInverso { get; set; }


        #endregion

        #region Construtores
        public Pessoa()
        {

        }

        public Pessoa(int diasInverso)
        {
            DiasInverso = diasInverso;
        }

        public Pessoa(string nome, int anos, int meses, int dias)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Anos = anos;
            Meses = meses;
            Dias = dias;
        }

        #endregion

        #region Métodos
        public int totalDias;
        public string RetornaDias()
        {
            int somaAnosEmDias = Anos * 365;
            int somaMesesEmDias = Meses * 30;
            totalDias = (somaAnosEmDias + somaMesesEmDias + Dias);
            return Convert.ToString(totalDias);
        }
        
        public void MostrarResultadoInverso()
        {
            AnosInverso = totalDias;
            AnosInverso = Dias / 365;
            int restoDias = Dias % 365;
            MesesInverso = restoDias / 30;
            DiasInverso = restoDias % 30;

        }

        #endregion
    }
}
