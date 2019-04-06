namespace ConvertTextFile
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArquivoOrigem = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtArqivoOrigem = new System.Windows.Forms.TextBox();
            this.btnEscolheArquivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArquivoDestino = new System.Windows.Forms.TextBox();
            this.btnArquivoDestino = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArquivoOrigem
            // 
            this.lblArquivoOrigem.AutoSize = true;
            this.lblArquivoOrigem.Location = new System.Drawing.Point(13, 13);
            this.lblArquivoOrigem.Name = "lblArquivoOrigem";
            this.lblArquivoOrigem.Size = new System.Drawing.Size(95, 13);
            this.lblArquivoOrigem.TabIndex = 0;
            this.lblArquivoOrigem.Text = "Arquivo de origem:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txtArqivoOrigem
            // 
            this.txtArqivoOrigem.Location = new System.Drawing.Point(16, 30);
            this.txtArqivoOrigem.Name = "txtArqivoOrigem";
            this.txtArqivoOrigem.ReadOnly = true;
            this.txtArqivoOrigem.Size = new System.Drawing.Size(386, 20);
            this.txtArqivoOrigem.TabIndex = 1;
            // 
            // btnEscolheArquivo
            // 
            this.btnEscolheArquivo.Location = new System.Drawing.Point(409, 30);
            this.btnEscolheArquivo.Name = "btnEscolheArquivo";
            this.btnEscolheArquivo.Size = new System.Drawing.Size(95, 23);
            this.btnEscolheArquivo.TabIndex = 2;
            this.btnEscolheArquivo.Text = "Escolher arquivo";
            this.btnEscolheArquivo.UseVisualStyleBackColor = true;
            this.btnEscolheArquivo.Click += new System.EventHandler(this.btnEscolheArquivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arquivo de destino:";
            // 
            // txtArquivoDestino
            // 
            this.txtArquivoDestino.Location = new System.Drawing.Point(16, 85);
            this.txtArquivoDestino.Name = "txtArquivoDestino";
            this.txtArquivoDestino.ReadOnly = true;
            this.txtArquivoDestino.Size = new System.Drawing.Size(386, 20);
            this.txtArquivoDestino.TabIndex = 4;
            // 
            // btnArquivoDestino
            // 
            this.btnArquivoDestino.Location = new System.Drawing.Point(409, 85);
            this.btnArquivoDestino.Name = "btnArquivoDestino";
            this.btnArquivoDestino.Size = new System.Drawing.Size(95, 23);
            this.btnArquivoDestino.TabIndex = 5;
            this.btnArquivoDestino.Text = "Arquivo Destino";
            this.btnArquivoDestino.UseVisualStyleBackColor = true;
            this.btnArquivoDestino.Click += new System.EventHandler(this.btnArquivoDestino_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(205, 139);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(95, 23);
            this.btnConverter.TabIndex = 6;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 177);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.btnArquivoDestino);
            this.Controls.Add(this.txtArquivoDestino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEscolheArquivo);
            this.Controls.Add(this.txtArqivoOrigem);
            this.Controls.Add(this.lblArquivoOrigem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter Arquivo Texto";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArquivoOrigem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtArqivoOrigem;
        private System.Windows.Forms.Button btnEscolheArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArquivoDestino;
        private System.Windows.Forms.Button btnArquivoDestino;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnConverter;
    }
}

