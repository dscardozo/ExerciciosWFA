using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberPOO_WFA.Classes
{
    internal class Uber
    {

        #region Propriedade

        
        public double KmInicio { get; set; }
        public double KmFimDia { get; set; }
        public double LitrosCombustivel { get; set; }
        public double ValorRecebido { get; set; }
        public double PrecoCombustivel { get; set; }
        public double KmDia { get; set; }
        public double MediaConsumo { get; set; }
        public double Lucro { get; set; }
        #endregion

        #region Construtores

        public Uber()
        {

        }
        
        public Uber(double kmInicio, double kmFimDia, double litrosCombustivel, double valorRecebido)
        {
            KmInicio = kmInicio;
            KmFimDia = kmFimDia;
            LitrosCombustivel = litrosCombustivel;
            ValorRecebido = valorRecebido;
            
        }



        #endregion

        #region Métodos

        public void CalcularKm() 
        {
       // PrecoCombustivel = 5.79;

        KmDia = KmFimDia - KmInicio;
        MediaConsumo = KmDia/LitrosCombustivel;
        Lucro = ValorRecebido - (LitrosCombustivel*5.79);
        
        }

        public string MostrarResultado()
        {
            
            string frase;
            frase = $"A média foi de {MediaConsumo:F2} Km por Litro consumido.\n" +
                    $"O Valor recebido no fim do dia foi de R$ {ValorRecebido:F2}\n" +
                    $"Tendo um lucro de R$ {Lucro:F2}";
            return frase;
        }
        #endregion
    }
}
