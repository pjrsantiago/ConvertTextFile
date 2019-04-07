using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTextFile.Classes
{
    class Afastamento
    {
        string[] cabecalho = new string[7] { "EMPRESA", "CGC", "REGISTRO", "TIPO", "INICIO", "TERMINO", "MOTIVO" };
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
            string[] arrAfastamento = linha_ler.Split('!');
            for (int i = 0; i < arrAfastamento.Length; i++)
            {
                if (i != 4 && i != 5)
                {
                    if (i != 3)
                    {
                        linha_gravar = linha_gravar + arrAfastamento[i].Trim() + ";";
                    }
                    else
                    {
                        linha_gravar = linha_gravar + arrAfastamento[i].Trim();
                    }
                }
            }
            return linha_gravar;
        }
    }
}
