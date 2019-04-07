using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTextFile.Classes
{
    class Escala
    {
        string[] cabecalho = new string[5] { "EMPRESA", "CGC", "REGISTRO", "DATA", "HORARIO" };
        public string retornaCabecalho()
        {
            string cabecalho2 = "";
            for (int i = 0; i < 5; i++)
            {
                if (i < 4)
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
            string[] arrEscala = linha_ler.Split('!');
            for (int i = 0; i < arrEscala.Length; i++)
            {
                if (i != 0 && i != 3)
                {
                    if (i != 2)
                    {
                        linha_gravar = linha_gravar + arrEscala[i].Trim() + ";";
                    }
                    else
                    {
                        linha_gravar = linha_gravar + arrEscala[i].Trim();
                    }
                }
            }
            return linha_gravar;
        }
    }
}
