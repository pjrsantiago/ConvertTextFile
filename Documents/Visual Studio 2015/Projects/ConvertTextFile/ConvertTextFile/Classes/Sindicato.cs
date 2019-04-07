using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTextFile.Classes
{
    class Sindicato
    {
        string[] cabecalho = new string[7] { "EMPRESA", "CGC", "REGISTRO", "MESANO", "VALOR", "SINDICATO", "EXERCICIO" };
        public string retornaCabecalho()
        {
            string cabecalho2 = "";
            for (int i = 0; i < 7; i++)
            {
                if (i < 6)
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

        public string montaLinhaGravar(string linha_gravar, string linha_ler)
        {
            string[] arrSindicato = linha_ler.Split('!');
            for (int i = 0; i < arrSindicato.Length; i++)
            {
                if (i != 0 && i != 4 && i != 6)
                {
                    if (i != 5)
                    {
                        linha_gravar = linha_gravar + arrSindicato[i].Trim() + ";";
                    }
                    else
                    {
                        linha_gravar = linha_gravar + arrSindicato[i].Trim();
                    }
                }
            }
            return linha_gravar;
        }
    }
}
