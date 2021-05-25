using System;
using System.Globalization;

namespace ChequePorExtenso.ConsoleApp.TDD
{
    public class ValorInicial
    {
        public string ManipularValor(double valor)
        {
            ManipulaValores manipulaValores = new ManipulaValores();

            string valorPorExtenso = "";
            string valorSeparado = valor.ToString("F", CultureInfo.CreateSpecificCulture("fr-FR"));
            string[] stringDividida = valorSeparado.Split(',');
            string strValorReais = stringDividida[0];
            string strValorCentavos = stringDividida[1];
            int intValorReais = Convert.ToInt32(strValorReais);
            int intValorCentavos = Convert.ToInt32(strValorCentavos);


            if (intValorReais > 0 && intValorCentavos == 0)
                if (strValorReais == "1")
                    valorPorExtenso = manipulaValores.Manipular(strValorReais) + " real";
                else
                    valorPorExtenso += manipulaValores.Manipular(strValorReais) + " reais";

            else if (intValorReais > 0 && intValorCentavos > 0)
            {
                if (intValorReais == 1)
                {
                    valorPorExtenso = manipulaValores.Manipular(strValorReais) + " real e ";
                    if (strValorCentavos == "01")
                        valorPorExtenso += manipulaValores.Manipular(strValorCentavos) + " centavo";
                    else if (strValorCentavos == "00")
                        valorPorExtenso += manipulaValores.Manipular(strValorCentavos);
                    else
                        valorPorExtenso += manipulaValores.Manipular(strValorCentavos) + " centavos";
                }
                else
                    valorPorExtenso += manipulaValores.Manipular(strValorReais) + " reais e " + manipulaValores.Manipular(strValorCentavos) + " centavos";
            }

            else if (intValorReais == 0 && intValorCentavos == 1)
                valorPorExtenso += manipulaValores.Manipular(strValorCentavos) + " centavo de real";

            else if (intValorReais == 0 && intValorCentavos > 1)
                valorPorExtenso += manipulaValores.Manipular(strValorCentavos) + " centavos de real";
            else
                valorPorExtenso = "valor invalido";

            return valorPorExtenso;
        }               
    }
}
