using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTextFile.Classes
{
    class Salario
    {
        string[] cabecalho = new string[8] { "EMPRESA", "CGC", "REGISTRO", "DATA", "TIPOSALARIO", "SALARIO", "PERCENTUAL", "MOTIVO" };
        public string retornaCabecalho()
        {
            string cabecalho2 = "";
            for (int i = 0; i < 8; i++)
            {
                if (i < 7)
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
            string[] arrSalario = linha_ler.Split('!');
            for (int i = 0; i < arrSalario.Length; i++)
            {
                if (i != 0 && i != 6 && i != 7 && i != 8 && i != 9 && i != 10 && i != 11 && i != 12)
                {
                    if (i != 5)
                    {
                        linha_gravar = linha_gravar + arrSalario[i].Trim() + ";";
                    }
                    else
                    {
                        linha_gravar = linha_gravar + arrSalario[i].Trim();
                    }
                }
            }
            return linha_gravar;
        }
    }
}
