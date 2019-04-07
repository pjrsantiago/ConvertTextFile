using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTextFile.Classes
{
    class Dependente
    {
        string[] cabecalho = new string[7] { "EMPRESA", "CGC", "REGISTRO", "DEPENDENTE", "NASCIMENTO", "PARENTESCO", "STATUS" };
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
            string[] arrDependente = linha_ler.Split('!');
            for (int i = 0; i < arrDependente.Length; i++)
            {
                if (i != 0)
                {
                    if (i != arrDependente.Length - 1)
                    {
                        linha_gravar = linha_gravar + arrDependente[i].Trim() + ";";
                    }
                    else
                    {
                        linha_gravar = linha_gravar + arrDependente[i].Trim();
                    }
                }
            }
            return linha_gravar;
        }
    }
}
