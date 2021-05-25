
using System;

namespace ChequePorExtenso.ConsoleApp.TDD
{
    public class ManipulaValores : ValoresEmExtenso
    {
        string valorExtenso = null;

        ValoresEmExtenso ValoresEmExtenso = new ValoresEmExtenso();
        public string Manipular(string valor)
        {
            if (valor.Length == 1)
            {
                valorExtenso = ValoresEmExtenso.Unidades(valor.ToCharArray()[0]);
                if (valorExtenso == "um")
                    valorExtenso = ValoresEmExtenso.Unidades(valor.ToCharArray()[0]);
                else
                    valorExtenso = ValoresEmExtenso.Unidades(valor.ToCharArray()[0]);

                return valorExtenso;
            }

            if (valor.Length == 2)
            {
                valorExtenso = DezenaUnidade(valor.ToCharArray()[0], valor.ToCharArray()[1]);
                return valorExtenso;
            }

            if (valor.Length == 3)
            {
                valorExtenso = CentenaDezenaUnidade(valor.ToCharArray()[0], valor.ToCharArray()[1], valor.ToCharArray()[2]);
                return valorExtenso;
            }

            if (valor.Length == 4)
            {
                valorExtenso = UnidadeDeMilhar(valor.ToCharArray()[0], valor.ToCharArray()[1], valor.ToCharArray()[2], valor.ToCharArray()[3]);
                return valorExtenso;
            }

            if (valor.Length == 5)
            {
                valorExtenso = DezenaDeMilhar(valor.ToCharArray()[0], valor.ToCharArray()[1], valor.ToCharArray()[2], valor.ToCharArray()[3], valor.ToCharArray()[4]);
                return valorExtenso;
            }

            if (valor.Length == 6)
            {
                valorExtenso = CentenaDeMilhar(valor.ToCharArray()[0], valor.ToCharArray()[1], valor.ToCharArray()[2], valor.ToCharArray()[3], valor.ToCharArray()[4], valor.ToCharArray()[5]);
                return valorExtenso;
            }

            return valorExtenso;
        }

        public string DezenaUnidade(char casaDezena, char casaUnidade)
        {
            if (casaDezena == '0')
                return ValoresEmExtenso.Unidades(casaUnidade);

            else if (casaDezena == '1')
            {
                switch (casaUnidade)
                {
                    case '0': return "dez";
                    case '1': return "onze";
                    case '2': return "doze";
                    case '3': return "treze";
                    case '4': return "quatorze";
                    case '5': return "quinze";
                    case '6': return "dezesseis";
                    case '7': return "dezesete";
                    case '8': return "dezoito";
                    case '9': return "dezenove";
                    default: return "";
                }
            }
            else
            {
                if (casaUnidade == '0')
                    return ValoresEmExtenso.Dezenas(casaDezena);
                else
                    return ValoresEmExtenso.Dezenas(casaDezena) + " e " + ValoresEmExtenso.Unidades(casaUnidade);
            }
        }

        public string CentenaDezenaUnidade(char casaCentena, char casaDezena, char casaUnidade)
        {
            if (casaCentena == '1' && casaDezena == '0' && casaUnidade == '0')
                return "cem";
            else if (casaDezena == '0' && casaUnidade == '0')
                return ValoresEmExtenso.Centenas(casaCentena);
            else if (casaCentena == '0')
                return "e " + DezenaUnidade(casaDezena, casaUnidade);
            else if (casaDezena == '0' && casaUnidade != '0')
                return ValoresEmExtenso.Centenas(casaCentena) + " e " + ValoresEmExtenso.Unidades(casaUnidade);
            else
                return ValoresEmExtenso.Centenas(casaCentena) + " e " + DezenaUnidade(casaDezena, casaUnidade);
        }

        public string UnidadeDeMilhar(char unidadeMilhar, char centena, char dezena, char unidade)
        {
            if (unidadeMilhar == '0')
            {
                return Centenas(centena) + " e " + DezenaUnidade(dezena, unidade);
            }
            else if (centena == '0' && dezena == '0' && unidade == '0')
            {
                return Unidades(unidadeMilhar) + " mil";
            }

            else if (centena == '0' && dezena == '0' && unidade != '0')
            {
                return Unidades(unidadeMilhar) + " mil e " + Unidades(unidade);
            }

            else if (centena != '0' && dezena != '0' && unidade == '0')
            {
                return Unidades(unidadeMilhar) + " mil " + Centenas(centena) + " e " + Dezenas(dezena);
            }

            else if (centena != '0' && dezena == '0' && unidade != '0')
            {
                return Unidades(unidadeMilhar) + " mil " + Centenas(centena) + " e " + Unidades(unidade);
            }

            else if (centena == '0' && dezena != '0' && unidade != '0')
            {
                return Unidades(unidadeMilhar) + " mil " + DezenaUnidade(dezena, unidade);
            }

            else if (centena == '0' && dezena != '0' && unidade == '0')
            {
                return Unidades(unidadeMilhar) + " mil e " + Dezenas(dezena);
            }
            else
            {
                return Unidades(unidadeMilhar) + " mil " + CentenaDezenaUnidade(centena, dezena, unidade);
            }
        }

        public string DezenaDeMilhar(char dezenaMilhar, char unidadeMilhar, char centena, char dezena, char unidade)
        {
            if (dezenaMilhar == '0' && unidadeMilhar == '0')
                return DezenaUnidade(dezenaMilhar, unidadeMilhar) + " mil " + "e " + Centenas(centena);
            else
                return DezenaUnidade(dezenaMilhar, unidadeMilhar) + " mil " + CentenaDezenaUnidade(centena, dezena, unidade);
        }

        public string CentenaDeMilhar(char centenaMilhar, char dezenaMilhar, char unidadeMilhar, char centena, char dezena, char unidade)
        {
            if (centenaMilhar == '0' && dezenaMilhar == '0' && unidadeMilhar == '0')
                return CentenaDezenaUnidade(centenaMilhar, dezenaMilhar, unidadeMilhar) + " mil " + "e " + Centenas(centena);
            else
                return CentenaDezenaUnidade(centenaMilhar, dezenaMilhar, unidadeMilhar) + " mil " + CentenaDezenaUnidade(centena, dezena, unidade);
        }
    }
}
