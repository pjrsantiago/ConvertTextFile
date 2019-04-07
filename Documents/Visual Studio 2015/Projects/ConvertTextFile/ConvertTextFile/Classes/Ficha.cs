using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTextFile.Classes
{
    class Ficha
    {
        string[] cabecalho = new string[6] { "EMPRESA", "CGC", "REGISTRO", "VIGENCIA", "IMPLANTA", "OBSERVACOES" };
        public string retornaCabecalho()
        {
            string cabecalho2 = "";
            for (int i = 0; i < 6; i++)
            {
                if (i < 5)
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
            string[] arrFicha = linha_ler.Split('!');
            for (int i = 0; i < arrFicha.Length; i++)
            {
                if (i != 0 && i != 4)
                {
                    if (i != 3)
                    {
                        linha_gravar = linha_gravar + arrFicha[i].Trim() + ";";
                    }
                    else
                    {
                        linha_gravar = linha_gravar + arrFicha[i].Trim();
                    }
                }
            }
            return linha_gravar;
        }
    }
}
