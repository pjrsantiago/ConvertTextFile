using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTextFile.Classes
{
    class Ferias
    {
        string[] cabecalho = new string[8] { "EMPRESA", "CGC", "REGISTRO", "INICIO", "TERMINO", "DIAS", "ABONO", "PERIODO" };
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
            string[] arrFerias = linha_ler.Split('!');
            for (int i = 0; i < arrFerias.Length; i++)
            {
                if(i != 0 && i != 6)
                {
                    if (i != 5)
                    {
                        linha_gravar = linha_gravar + arrFerias[i].Trim() + ";";
                    }
                    else
                    {
                        linha_gravar = linha_gravar + arrFerias[i].Trim();
                    }
                }   
            }
            return linha_gravar;
        }
    }
}
