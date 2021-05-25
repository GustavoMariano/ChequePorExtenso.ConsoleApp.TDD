
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

            if (valor.Length == 7)
            {
                valorExtenso = UnidadeDeMilhao(valor.ToCharArray()[0], valor.ToCharArray()[1], valor.ToCharArray()[2], valor.ToCharArray()[3], valor.ToCharArray()[4], valor.ToCharArray()[5], valor.ToCharArray()[6]);
                return valorExtenso;
            }

            if (valor.Length == 8)
            {
                valorExtenso = DezenaDeMilhao(valor.ToCharArray()[0], valor.ToCharArray()[1], valor.ToCharArray()[2], valor.ToCharArray()[3], valor.ToCharArray()[4], valor.ToCharArray()[5], valor.ToCharArray()[6], valor.ToCharArray()[7]);
                return valorExtenso;
            }

            if (valor.Length == 9)
            {
                valorExtenso = CentenaDeMilhao(valor.ToCharArray()[0], valor.ToCharArray()[1], valor.ToCharArray()[2], valor.ToCharArray()[3], valor.ToCharArray()[4], valor.ToCharArray()[5], valor.ToCharArray()[6], valor.ToCharArray()[7], valor.ToCharArray()[8]);
                return valorExtenso;
            }

            if (valor.Length == 10)
            {
                valorExtenso = UnidadeDeBilhao(valor.ToCharArray()[0], valor.ToCharArray()[1], valor.ToCharArray()[2], valor.ToCharArray()[3], valor.ToCharArray()[4], valor.ToCharArray()[5], valor.ToCharArray()[6], valor.ToCharArray()[7], valor.ToCharArray()[8], valor.ToCharArray()[9]);
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
                return DezenaUnidade(casaDezena, casaUnidade);
            else if (casaDezena == '0' && casaUnidade != '0')
                return ValoresEmExtenso.Centenas(casaCentena) + " e " + ValoresEmExtenso.Unidades(casaUnidade); ///////////////////
            else
                return ValoresEmExtenso.Centenas(casaCentena) + " e " + DezenaUnidade(casaDezena, casaUnidade);
        }

        public string UnidadeDeMilhar(char unidadeMilhar, char centena, char dezena, char unidade)
        {
            if (unidadeMilhar == '0')
                return Centenas(centena) + " e " + DezenaUnidade(dezena, unidade);
            else if (centena == '0' && dezena == '0' && unidade == '0')
                return Unidades(unidadeMilhar) + " mil ";
            else if (centena == '0' && dezena == '0' && unidade != '0')
                return Unidades(unidadeMilhar) + " mil e" + Unidades(unidade);
            else if (centena != '0' && dezena != '0' && unidade == '0')
                return Unidades(unidadeMilhar) + " mil " + Centenas(centena) + " e " + Dezenas(dezena);
            else if (centena != '0' && dezena == '0' && unidade != '0')
                return Unidades(unidadeMilhar) + " mil " + Centenas(centena) + " e " + Unidades(unidade);
            else if (centena == '0' && dezena != '0' && unidade != '0')
                return Unidades(unidadeMilhar) + " mil " + DezenaUnidade(dezena, unidade);
            else if (centena == '0' && dezena != '0' && unidade == '0')
                return Unidades(unidadeMilhar) + " mil e" + Dezenas(dezena);
            else
                return Unidades(unidadeMilhar) + " mil " + CentenaDezenaUnidade(centena, dezena, unidade);
        }

        public string DezenaDeMilhar(char dezenaMilhar, char unidadeMilhar, char centena, char dezena, char unidade)
        {
            if (dezenaMilhar == '0' && unidadeMilhar == '0')
                return DezenaUnidade(dezenaMilhar, unidadeMilhar) + " mil e " + Centenas(centena);
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

        public string UnidadeDeMilhao(char unidadeMilhao, char centenaMilhar, char dezenaMilhar, char unidadeMilhar, char centena, char dezena, char unidade)
        {
            if (unidadeMilhao == '1' && centenaMilhar == '0' && dezenaMilhar == '0' && unidadeMilhar == '0' && centena == '0' && dezena == '0' && unidade == '0')
                return "um milhão de";
            else if (unidadeMilhao == '1' && (centenaMilhar != '0' || dezenaMilhar != ('0') || unidadeMilhar != '0'))
                return Unidades(unidadeMilhao) + " milhão " + CentenaDeMilhar(centenaMilhar, dezenaMilhar, unidadeMilhar, centena, dezena, unidade);
            else if (centenaMilhar == '0' && dezenaMilhar == '0' && unidadeMilhar == '0' && centena == '0' && dezena == '0' && unidade == '0')
                return Unidades(unidadeMilhao) + " milhões de";
            else if (centenaMilhar != '0' || dezenaMilhar != '0' || unidadeMilhar != '0')
                return Unidades(unidadeMilhao) + " milhões " + CentenaDeMilhar(centenaMilhar, dezenaMilhar, unidadeMilhar, centena, dezena, unidade);
            else
                return Unidades(unidadeMilhao) + " milhões " + Centenas(centenaMilhar) + Dezenas(dezenaMilhar) + Unidades(unidadeMilhar) + Centenas(centena) + Dezenas(dezena) + Unidades(unidade);
        }

        public string DezenaDeMilhao(char dezenaMilhao, char unidadeMilhao, char centenaMilhar, char dezenaMilhar, char unidadeMilhar, char centena, char dezena, char unidade)
        {
            if (centenaMilhar == '0' && dezenaMilhar == '0' && unidadeMilhar == '0' && centena == '0' && dezena == '0' && unidade == '0')
                return DezenaUnidade(dezenaMilhao, unidadeMilhao) + " milhões de";
            else if (centenaMilhar == '0' && dezenaMilhar == '0' && unidadeMilhar == '0')
                return DezenaUnidade(dezenaMilhao, unidadeMilhao) + " milhões " + CentenaDezenaUnidade(centena, dezena, unidade);
            else
                return DezenaUnidade(dezenaMilhao, unidadeMilhao) + " milhões " + CentenaDeMilhar(centenaMilhar, dezenaMilhar, unidadeMilhar, centena, dezena, unidade);
        }

        public string CentenaDeMilhao(char centenaMilhao, char dezenaMilhao, char unidadeMilhao, char centenaMilhar, char dezenaMilhar, char unidadeMilhar, char centena, char dezena, char unidade)
        {
            if (centenaMilhao == '1' && dezenaMilhao == '0' && unidadeMilhao == '0' && centenaMilhar == '0' && dezenaMilhar == '0' && unidadeMilhar == '0' && centena == '0' && dezena == '0' && unidade == '0')
                return "cem milhões de";
            else if (centenaMilhar == '0' && dezenaMilhar == '0' && unidadeMilhar == '0' && centena == '0' && dezena == '0' && unidade == '0')
                return DezenaUnidade(dezenaMilhao, unidadeMilhao) + " milhões de";
            else if (centenaMilhar == '0' && dezenaMilhar == '0' && unidadeMilhar == '0')
                return CentenaDezenaUnidade(centenaMilhao, dezenaMilhao, unidadeMilhao) + " milhões " + CentenaDezenaUnidade(centena, dezena, unidade);
            else
                return CentenaDezenaUnidade(centenaMilhao, dezenaMilhao, unidadeMilhao) + " milhão " + CentenaDeMilhar(centenaMilhar, dezenaMilhar, unidadeMilhar, centena, dezena, unidade);
        }

        public string UnidadeDeBilhao(char unidadeBilhao, char centenaMilhao, char dezenaMilhao, char unidadeMilhao, char centenaMilhar, char dezenaMilhar, char unidadeMilhar, char centena, char dezena, char unidade)
        {
            if (unidadeBilhao == '1' && centenaMilhao == '0' && dezenaMilhao == '0' && unidadeMilhao == '0' && centenaMilhar == '0' && dezenaMilhar == '0' && unidadeMilhar == '0' && centena == '0' && dezena == '0' && unidade == '0')
                return "um bilhão de";
            else if (unidadeBilhao == '1' && (centenaMilhao != '0' || dezenaMilhao != ('0') || unidadeMilhao != '0'))
                return Unidades(unidadeBilhao) + CentenaDeMilhao(centenaMilhao, dezenaMilhao, unidadeMilhao, centenaMilhar, dezenaMilhar, unidadeMilhar, centena, dezena, unidade);
            else if (unidadeBilhao != '1' && centenaMilhao == '0' && dezenaMilhao == '0' && unidadeMilhao == '0' && centenaMilhar == '0' && dezenaMilhar == '0' && unidadeMilhar == '0' && centena == '0' && dezena == '0' && unidade == '0')
                return Unidades(unidadeBilhao) + " bilhões de";
            else if (centenaMilhao != '0' || dezenaMilhao != '0' || unidadeMilhao != '0')
                return Unidades(unidadeBilhao) + " bilhões " + CentenaDeMilhao(centenaMilhao, dezenaMilhao, unidadeMilhao, centenaMilhar, dezenaMilhar, unidadeMilhar, centena, dezena, unidade);
            else
                return Unidades(unidadeBilhao) + " bilhões " + Centenas(centenaMilhao) + Dezenas(dezenaMilhao) + Unidades(unidadeMilhao) + Centenas(centenaMilhar) + Dezenas(dezenaMilhar) + Unidades(unidadeMilhar) + Centenas(centena) + Dezenas(dezena) + Unidades(unidade);
        }
    }
}
