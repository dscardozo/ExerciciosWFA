using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampadasWFA.Classes
{
    internal class Comodo
    {
        #region Propriedades

        
        public Double Potencia {get;set;}
        public Double Largura {get; set;}
        public Double Comprimento {get; set;}
        public Double Area {get; set;}
        public Double NumLampadas {get; set;}

        #endregion

        #region Construtores

        #endregion

        #region Metodos

        // Declaração de um método
        // público
        // 1ª versão sem retorno
        public void CalcularQtdLampadas()
        {
            Area = Largura * Comprimento;
            NumLampadas = Convert.ToDouble(Area * 18) / Potencia;
        }

        // M´todo para retornar a frase de saida
        // Público
        // Com retorno String
        public string MostrarResultado()
        {
            string frase;
            frase = $"O nº de lâmpadas necessárias para iluminar um cômodo de {Area}m²" +
                $" são de {Math.Ceiling(NumLampadas)} lampadas de {Potencia} Watts de potência.";
            return frase;
        }

        #endregion
    }
}
