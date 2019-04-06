using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertTextFile
{
    public partial class frmHome : Form
    {
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

                StreamReader str;
                StreamWriter stw = new StreamWriter(File.Open(CaminhoDestino, FileMode.CreateNew), Encoding.Default);

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

                str = File.OpenText(CaminhoOrigem);
                //stw = File.CreateText(CaminhoDestino);

                stw.WriteLine(cabecalho2);

                string linha_ler = "";
                string linha_gravar = "";
                int posicao;
                int contador = 0;
                bool ativador = true;
                string linha_anterior = "0!0";

                while (str.EndOfStream != true)
                {
                    linha_ler = str.ReadLine();
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
                        }
                    }
                    if (ativador)
                    {
                        if (posicao < 0 || linha_ler.Substring(0, posicao) == cabecalho[contador])
                        {
                            if (contador < 79)
                            {
                                linha_gravar = linha_gravar + linha_ler.Substring(posicao + 1) + ";";
                                contador = contador + 1;
                            }
                            else
                            {
                                linha_gravar = linha_gravar + linha_ler.Substring(posicao + 1);
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
                    linha_anterior = linha_ler;
                }

                str.Close();
                stw.Close();

                MessageBox.Show("A geração do arquivo foi concluída com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a geração do arquivo! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

    }
}
