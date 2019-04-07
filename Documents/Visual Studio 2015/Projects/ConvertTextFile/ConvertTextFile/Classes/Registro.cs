using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTextFile.Classes
{
    class Registro
    {
        string[] cabecalho = new string[25] { "EMPRESA", "NOME", "REL-A", "CGC", "REF", "FILIAL", "ORDEM", "REGISTRO",
                "LOCAL","PERIODO","CARTEIRA","PIS","CIC","RG","DATADM","DEMISSAO","MOTIVO","BRANCO","TESTE","SALARIO-SEL",
                "FUNCAO-SEL","FERIAS-SEL","AFASTAMENTO-SEL","SINDICATO-SEL","SALARIO-SEL"};

        public string retornaCabecalho()
        {

            string cabecalho2 = "";
            for (int i = 0; i < 25; i++)
            {
                if (i < 24)
                {
                    cabecalho2 = cabecalho2 + cabecalho[i] + ";";
                }
                else
                {
                    cabecalho2 = cabecalho2 + cabecalho[i];
                }

            }

            return cabecalho2;
        }

        public string montaLinhaGravar(string linha_gravar, string linha_ler, int contador, int posicao)
        {
            if (posicao < 0 || linha_ler.Substring(0, posicao) == cabecalho[contador])
            {
                if (contador < 24)
                {
                    linha_gravar = linha_gravar + linha_ler.Substring(posicao + 1).Trim() + ";";
                }
                else
                {
                    linha_gravar = linha_gravar + linha_ler.Substring(posicao + 1).Trim();
                }
            }
            else
            {
                if (contador < 24)
                {
                    linha_gravar = linha_gravar + ";";
                }

            }

            return linha_gravar;
        }
    }
}
