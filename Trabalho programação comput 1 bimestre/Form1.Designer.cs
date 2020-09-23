namespace Trabalho_programação_comput_1_bimestre
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.dataalterar = new System.Windows.Forms.DateTimePicker();
            this.nupprecoalterar = new System.Windows.Forms.NumericUpDown();
            this.txtnomealterar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblnomealterar = new System.Windows.Forms.Label();
            this.lblalterar = new System.Windows.Forms.Label();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.dtvalidade = new System.Windows.Forms.DateTimePicker();
            this.nuppreco = new System.Windows.Forms.NumericUpDown();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnfechar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupprecoalterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuppreco)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnexcluir);
            this.tabPage1.Controls.Add(this.btnalterar);
            this.tabPage1.Controls.Add(this.btnadicionar);
            this.tabPage1.Controls.Add(this.dataalterar);
            this.tabPage1.Controls.Add(this.nupprecoalterar);
            this.tabPage1.Controls.Add(this.txtnomealterar);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lblnomealterar);
            this.tabPage1.Controls.Add(this.lblalterar);
            this.tabPage1.Controls.Add(this.txtpesquisa);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.list);
            this.tabPage1.Controls.Add(this.dtvalidade);
            this.tabPage1.Controls.Add(this.nuppreco);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1078, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar/Editar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(959, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Limpar filtros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(879, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(904, 466);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(130, 35);
            this.btnexcluir.TabIndex = 22;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterar.Location = new System.Drawing.Point(628, 466);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(126, 35);
            this.btnalterar.TabIndex = 21;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionar.Location = new System.Drawing.Point(96, 294);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(140, 32);
            this.btnadicionar.TabIndex = 20;
            this.btnadicionar.Text = "Adicionar produto";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // dataalterar
            // 
            this.dataalterar.Location = new System.Drawing.Point(776, 411);
            this.dataalterar.Name = "dataalterar";
            this.dataalterar.Size = new System.Drawing.Size(258, 20);
            this.dataalterar.TabIndex = 19;
            // 
            // nupprecoalterar
            // 
            this.nupprecoalterar.DecimalPlaces = 2;
            this.nupprecoalterar.Location = new System.Drawing.Point(776, 372);
            this.nupprecoalterar.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.nupprecoalterar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupprecoalterar.Name = "nupprecoalterar";
            this.nupprecoalterar.Size = new System.Drawing.Size(258, 20);
            this.nupprecoalterar.TabIndex = 18;
            this.nupprecoalterar.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // txtnomealterar
            // 
            this.txtnomealterar.Location = new System.Drawing.Point(776, 332);
            this.txtnomealterar.Name = "txtnomealterar";
            this.txtnomealterar.Size = new System.Drawing.Size(258, 20);
            this.txtnomealterar.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(628, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Validade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(625, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Preço do produto:";
            // 
            // lblnomealterar
            // 
            this.lblnomealterar.AutoSize = true;
            this.lblnomealterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomealterar.Location = new System.Drawing.Point(624, 332);
            this.lblnomealterar.Name = "lblnomealterar";
            this.lblnomealterar.Size = new System.Drawing.Size(136, 20);
            this.lblnomealterar.TabIndex = 14;
            this.lblnomealterar.Text = "Nome do produto:";
            // 
            // lblalterar
            // 
            this.lblalterar.AutoSize = true;
            this.lblalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalterar.Location = new System.Drawing.Point(732, 269);
            this.lblalterar.Name = "lblalterar";
            this.lblalterar.Size = new System.Drawing.Size(189, 20);
            this.lblalterar.TabIndex = 13;
            this.lblalterar.Text = "Alterar dados do produto:";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(709, 58);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(164, 20);
            this.txtpesquisa.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(625, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pesquisar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(752, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Produtos cadastrados:";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(628, 90);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(406, 147);
            this.list.TabIndex = 9;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // dtvalidade
            // 
            this.dtvalidade.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtvalidade.CustomFormat = "";
            this.dtvalidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtvalidade.Location = new System.Drawing.Point(161, 217);
            this.dtvalidade.Name = "dtvalidade";
            this.dtvalidade.Size = new System.Drawing.Size(232, 20);
            this.dtvalidade.TabIndex = 8;
            // 
            // nuppreco
            // 
            this.nuppreco.DecimalPlaces = 2;
            this.nuppreco.Location = new System.Drawing.Point(161, 158);
            this.nuppreco.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.nuppreco.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nuppreco.Name = "nuppreco";
            this.nuppreco.Size = new System.Drawing.Size(232, 20);
            this.nuppreco.TabIndex = 7;
            this.nuppreco.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(161, 90);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(232, 20);
            this.txtnome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Validade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço do produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo produto:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnfechar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1078, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sair";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnfechar
            // 
            this.btnfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(456, 230);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(111, 34);
            this.btnfechar.TabIndex = 1;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(406, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fechar programa:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 559);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupprecoalterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuppreco)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dataalterar;
        private System.Windows.Forms.NumericUpDown nupprecoalterar;
        private System.Windows.Forms.TextBox txtnomealterar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblnomealterar;
        private System.Windows.Forms.Label lblalterar;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.DateTimePicker dtvalidade;
        private System.Windows.Forms.NumericUpDown nuppreco;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

