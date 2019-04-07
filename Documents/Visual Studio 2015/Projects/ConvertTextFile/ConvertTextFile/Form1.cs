using ConvertTextFile.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertTextFile
{
    public partial class frmHome : Form
    {
        public string empresa { get; set; }
        public string cgc { get; set; }
        public string registro { get; set; }

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void btnEscolheArquivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtArqivoOrigem.Text = openFileDialog1.FileName;
        }

        private void btnArquivoDestino_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtArquivoDestino.Text = saveFileDialog1.FileName;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                executaArquivoFuncionario();
            }else
            {
                MessageBox.Show("Informe os arquivos de origem e destino!", "Erro ao gerar arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //executaArquivoFuncionario();
}

        private bool valida()
        {
            if((txtArqivoOrigem.Text != "") & (txtArquivoDestino.Text != ""))
            {
                return true;
            }else
            {
                return false;
            }

        }

        private void executaArquivoFuncionario()
        {

            try
            {
                string CaminhoOrigem = txtArqivoOrigem.Text;
                string CaminhoDestino = txtArquivoDestino.Text;
                //string CaminhoOrigem = "E:\\Pedro Barboza\\Downloads\\Ficha Resgistro_iliane.txt";
                //string CaminhoDestino = "E:\\Pedro Barboza\\Downloads\\Teste.txt";
                
                StreamReader str = new StreamReader(CaminhoOrigem, Encoding.GetEncoding(CultureInfo.GetCultureInfo("pt-BR").TextInfo.ANSICodePage));
                StreamWriter stw = new StreamWriter(File.Open(CaminhoDestino, FileMode.CreateNew), Encoding.Default);

                StreamWriter stwReg = new StreamWriter(File.Open(CaminhoDestino.Substring(0, CaminhoDestino.Length - 4) + "-Registro.txt", FileMode.CreateNew), Encoding.Default);
                StreamWriter stwSal = new StreamWriter(File.Open(CaminhoDestino.Substring(0, CaminhoDestino.Length - 4) + "-Salario.txt", FileMode.CreateNew), Encoding.Default);
                StreamWriter stwFer = new StreamWriter(File.Open(CaminhoDestino.Substring(0, CaminhoDestino.Length - 4) + "-Ferias.txt", FileMode.CreateNew), Encoding.Default);
                StreamWriter stwAfa = new StreamWriter(File.Open(CaminhoDestino.Substring(0, CaminhoDestino.Length - 4) + "-Afastamento.txt", FileMode.CreateNew), Encoding.Default);
                StreamWriter stwSin = new StreamWriter(File.Open(CaminhoDestino.Substring(0, CaminhoDestino.Length - 4) + "-Sindicato.txt", FileMode.CreateNew), Encoding.Default);
                StreamWriter stwEsc = new StreamWriter(File.Open(CaminhoDestino.Substring(0, CaminhoDestino.Length - 4) + "-Escala.txt", FileMode.CreateNew), Encoding.Default);
                StreamWriter stwFic = new StreamWriter(File.Open(CaminhoDestino.Substring(0, CaminhoDestino.Length - 4) + "-Ficha.txt", FileMode.CreateNew), Encoding.Default);
                StreamWriter stwFun = new StreamWriter(File.Open(CaminhoDestino.Substring(0, CaminhoDestino.Length - 4) + "-Funcao.txt", FileMode.CreateNew), Encoding.Default);
                StreamWriter stwDep = new StreamWriter(File.Open(CaminhoDestino.Substring(0, CaminhoDestino.Length - 4) + "-Dependente.txt", FileMode.CreateNew), Encoding.Default);

                string[] cabecalho = new string[80] { "HESCHOR_ADMISSAO", "EMPRESA", "NOME", "ORDEM", "REGISTRO", "IMPRIMEFOTO", "END", "TELEFONE",
                "CEP","MUNIC","UF","ESTCIVIL","DATNASC","SEXO","INSTRUCAO","NAC","ANO","CTPS","SERIE","MOD","RG","ORGAO",
                "ESTEMIS","DATA","VINCFGTS","PIS","CIC","DATADM","TITULO","CNH","FUNCAO","CBO","PAGTO","TIP","SAL","HORARIO",
                "INTERVALO","PAI","MAE","REL - F","NACPAI","NACMAE","CERTRES","OBS","ISENTOPONTO","BRANCO","DATFICHA",
                "CR","HABPROF","NOM - CONREG","NUM - CONREG","REG - CONREG","SIG - CONREG","OCIPA","TESTE",
                "CNPJ - CAR","NOMCOMER - CAR","END - CAR","BAIRRO - CAR","CEP - CAR","CIDADE - CAR","CIDADE - ASSINATURA",
                "DEMISSAO - ASSINATURA","UF - CAR","CARIMBO","BAIRRO","MUNIC - NASC","UFNASC","DOCIDENTIFRNE",
                "DTVALIDRNE","TPVISTO","DTVALIDCTPS","DATCARTRABALHO","DATPIS","CARGO","ADICINS","ADICPER","ASSINA",
                "PFISICA","REGEMP"};
                
                string cabecalho2 = "";
                for (int i = 0; i < 80; i++)
                {
                    if (i < 79)
                    {
                        cabecalho2 = cabecalho2 + cabecalho[i] + ";";
                    }
                    else
                    {
                        cabecalho2 = cabecalho2 + cabecalho[i];
                    }

                }

                Registro reg = new Registro();
                Afastamento afa = new Afastamento();
                Dependente dep = new Dependente();
                Escala esc = new Escala();
                Ferias fer = new Ferias();
                Ficha fic = new Ficha();
                Funcao fun = new Funcao();
                Salario sal = new Salario();
                Sindicato sin = new Sindicato();

                //str = File.OpenText(CaminhoOrigem);
                //stw = File.CreateText(CaminhoDestino);

                stw.WriteLine(cabecalho2);          
                stwReg.WriteLine(reg.retornaCabecalho());
                stwAfa.WriteLine(afa.retornaCabecalho());
                stwDep.WriteLine(dep.retornaCabecalho());
                stwEsc.WriteLine(esc.retornaCabecalho());
                stwFer.WriteLine(fer.retornaCabecalho());
                stwFic.WriteLine(fic.retornaCabecalho());
                stwFun.WriteLine(fun.retornaCabecalho());
                stwSal.WriteLine(sal.retornaCabecalho());
                stwSin.WriteLine(sin.retornaCabecalho());

                string linha_ler = "";
                string linha_gravar = "";
                int posicao;
                int contador = 0;
                bool ativador = true;
                string linha_anterior = "0!0";

                while (str.EndOfStream != true)
                {
                    linha_ler = str.ReadLine();
                    if(linha_ler != "")
                    {
                        posicao = linha_ler.IndexOf("!");
                        if (posicao > 0)
                        {
                            if (linha_ler == "FIM_VISUALIZADOR!")
                            {
                                ativador = false;
                            }
                            else if (linha_anterior == "FIM!")
                            {
                                ativador = true;
                                contador = 0;
                            }
                        }
                        if (ativador)
                        {
                            if (posicao < 0 || linha_ler.Substring(0, posicao) == cabecalho[contador])
                            {
                                if (contador < 79)
                                {
                                    linha_gravar = linha_gravar + linha_ler.Substring(posicao + 1).Trim() + ";";
                                    contador = contador + 1;
                                }
                                else
                                {
                                    linha_gravar = linha_gravar + linha_ler.Substring(posicao + 1).Trim();
                                    stw.WriteLine(linha_gravar);
                                    linha_gravar = "";
                                    contador = 0;
                                }
                            }
                            else
                            {
                                if (contador < 79)
                                {
                                    linha_gravar = linha_gravar + ";";
                                    contador = contador + 1;
                                }

                            }
                        }
                        else
                        {
                            if (posicao > 0)
                            {
                                if (linha_ler != "FIM_VISUALIZADOR!")
                                {
                                    if (contador > 24)
                                    {
                                        switch (linha_ler.Substring(0, posicao))
                                        {
                                            case "HSAL":
                                                linha_gravar = empresa + ";" + cgc + ";" + registro + ";";
                                                linha_gravar = sal.montaLinhaGravar(linha_gravar, linha_ler);
                                                stwSal.WriteLine(linha_gravar);
                                                linha_gravar = "";
                                                break;

                                            case "AFAST":
                                                linha_gravar = empresa + ";" + cgc + ";" + registro + ";";
                                                linha_gravar = afa.montaLinhaGravar(linha_gravar, linha_ler);
                                                stwAfa.WriteLine(linha_gravar);
                                                linha_gravar = "";
                                                break;

                                            case "AFAST_OUTROS":
                                                linha_gravar = empresa + ";" + cgc + ";" + registro + ";";
                                                linha_gravar = afa.montaLinhaGravar(linha_gravar, linha_ler);
                                                stwAfa.WriteLine(linha_gravar);
                                                linha_gravar = "";
                                                break;

                                            case "DEPENDENTE":
                                                linha_gravar = empresa + ";" + cgc + ";" + registro + ";";
                                                linha_gravar = dep.montaLinhaGravar(linha_gravar, linha_ler);
                                                stwDep.WriteLine(linha_gravar);
                                                linha_gravar = "";
                                                break;

                                            case "HESCHOR":
                                                linha_gravar = empresa + ";" + cgc + ";" + registro + ";";
                                                linha_gravar = esc.montaLinhaGravar(linha_gravar, linha_ler);
                                                stwEsc.WriteLine(linha_gravar);
                                                linha_gravar = "";
                                                break;

                                            case "FERIAS":
                                                linha_gravar = empresa + ";" + cgc + ";" + registro + ";";
                                                linha_gravar = fer.montaLinhaGravar(linha_gravar, linha_ler);
                                                stwFer.WriteLine(linha_gravar);
                                                linha_gravar = "";
                                                break;

                                            case "FICHAANOT":
                                                linha_gravar = empresa + ";" + cgc + ";" + registro + ";";
                                                linha_gravar = fic.montaLinhaGravar(linha_gravar, linha_ler);
                                                stwFic.WriteLine(linha_gravar);
                                                linha_gravar = "";
                                                break;

                                            case "HFUNCAO":
                                                linha_gravar = empresa + ";" + cgc + ";" + registro + ";";
                                                linha_gravar = fun.montaLinhaGravar(linha_gravar, linha_ler);
                                                stwFun.WriteLine(linha_gravar);
                                                linha_gravar = "";
                                                break;

                                            case "SINDIC":
                                                linha_gravar = empresa + ";" + cgc + ";" + registro + ";";
                                                linha_gravar = sin.montaLinhaGravar(linha_gravar, linha_ler);
                                                stwSin.WriteLine(linha_gravar);
                                                linha_gravar = "";
                                                break;

                                            default:
                                                break;

                                        }
                                    }
                                    else
                                    {
                                        if (contador == 0)
                                        {
                                            empresa = linha_ler.Substring(posicao + 1).Trim();
                                        }
                                        else if (contador == 3)
                                        {
                                            cgc = linha_ler.Substring(posicao + 1).Trim();
                                        }
                                        else if (contador == 7)
                                        {
                                            registro = linha_ler.Substring(posicao + 1).Trim();
                                        }

                                        linha_gravar = reg.montaLinhaGravar(linha_gravar, linha_ler, contador, posicao);
                                        if (contador == 24)
                                        {
                                            stwReg.WriteLine(linha_gravar);
                                            linha_gravar = "";
                                            //contador = 0;
                                        }
                                        contador = contador + 1;
                                    }
                                }
                            }
                            
                        }
                        linha_anterior = linha_ler;
                    }
                    
                }

                str.Close();
                stw.Close();
                stwReg.Close();
                stwSal.Close();
                stwFer.Close();
                stwAfa.Close();
                stwSin.Close();
                stwEsc.Close();
                stwFic.Close();
                stwFun.Close();
                stwDep.Close();

                MessageBox.Show("A geração do arquivo foi concluída com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a geração do arquivo! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
