namespace progamacaoapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtcodigo = new TextBox();
            txtdescricao = new TextBox();
            txtvalor = new TextBox();
            cboservico = new ComboBox();
            chkpagamento = new CheckBox();
            data_lancamento = new DateTimePicker();
            cbotipo = new ComboBox();
            btneditar = new Button();
            btncadastrar = new Button();
            btnexcluir = new Button();
            label8 = new Label();
            btnpesquisar = new Button();
            dataGridView1 = new DataGridView();
            txtpesquisar = new TextBox();
            btnrelatorio = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 10.2F);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(42, 38);
            label1.Name = "label1";
            label1.Size = new Size(62, 29);
            label1.TabIndex = 0;
            label1.Text = "Código";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 10.2F);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(41, 81);
            label2.Name = "label2";
            label2.Size = new Size(80, 29);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Dubai", 10.2F);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(41, 123);
            label3.Name = "label3";
            label3.Size = new Size(51, 29);
            label3.TabIndex = 2;
            label3.Text = "Valor";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Dubai", 10.2F);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(42, 168);
            label4.Name = "label4";
            label4.Size = new Size(45, 29);
            label4.TabIndex = 3;
            label4.Text = "Tipo";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Dubai", 10.2F);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(42, 223);
            label5.Name = "label5";
            label5.Size = new Size(64, 29);
            label5.TabIndex = 4;
            label5.Text = "Serviço";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Dubai", 10.2F);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(40, 279);
            label6.Name = "label6";
            label6.Size = new Size(46, 29);
            label6.TabIndex = 5;
            label6.Text = "Data";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Dubai", 10.2F);
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(40, 319);
            label7.Name = "label7";
            label7.Size = new Size(92, 29);
            label7.TabIndex = 6;
            label7.Text = "Pagamento";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtcodigo
            // 
            txtcodigo.BackColor = SystemColors.HighlightText;
            txtcodigo.Location = new Point(138, 40);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(125, 27);
            txtcodigo.TabIndex = 7;
            // 
            // txtdescricao
            // 
            txtdescricao.BackColor = SystemColors.HighlightText;
            txtdescricao.Location = new Point(138, 83);
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(125, 27);
            txtdescricao.TabIndex = 8;
            // 
            // txtvalor
            // 
            txtvalor.BackColor = SystemColors.HighlightText;
            txtvalor.Location = new Point(138, 125);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(125, 27);
            txtvalor.TabIndex = 9;
            txtvalor.TextChanged += txtvalor_TextChanged;
            // 
            // cboservico
            // 
            cboservico.FormattingEnabled = true;
            cboservico.Location = new Point(138, 224);
            cboservico.Name = "cboservico";
            cboservico.Size = new Size(151, 28);
            cboservico.TabIndex = 13;
            // 
            // chkpagamento
            // 
            chkpagamento.AutoSize = true;
            chkpagamento.Location = new Point(138, 321);
            chkpagamento.Name = "chkpagamento";
            chkpagamento.Size = new Size(47, 24);
            chkpagamento.TabIndex = 14;
            chkpagamento.Text = "ok";
            chkpagamento.UseVisualStyleBackColor = true;
            // 
            // data_lancamento
            // 
            data_lancamento.Location = new Point(138, 277);
            data_lancamento.Name = "data_lancamento";
            data_lancamento.Size = new Size(250, 27);
            data_lancamento.TabIndex = 15;
            // 
            // cbotipo
            // 
            cbotipo.FormattingEnabled = true;
            cbotipo.Location = new Point(138, 168);
            cbotipo.Name = "cbotipo";
            cbotipo.Size = new Size(151, 28);
            cbotipo.TabIndex = 16;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.PaleVioletRed;
            btneditar.Cursor = Cursors.Hand;
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.Font = new Font("Dubai", 10.2F);
            btneditar.ForeColor = SystemColors.InactiveBorder;
            btneditar.Location = new Point(178, 381);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(92, 37);
            btneditar.TabIndex = 17;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // btncadastrar
            // 
            btncadastrar.BackColor = Color.PaleVioletRed;
            btncadastrar.Cursor = Cursors.Hand;
            btncadastrar.FlatStyle = FlatStyle.Flat;
            btncadastrar.Font = new Font("Dubai", 10.2F);
            btncadastrar.ForeColor = SystemColors.InactiveBorder;
            btncadastrar.Location = new Point(47, 381);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(92, 37);
            btncadastrar.TabIndex = 18;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = false;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.BackColor = Color.PaleVioletRed;
            btnexcluir.Cursor = Cursors.Hand;
            btnexcluir.FlatStyle = FlatStyle.Flat;
            btnexcluir.Font = new Font("Dubai", 10.2F);
            btnexcluir.ForeColor = SystemColors.InactiveBorder;
            btnexcluir.Location = new Point(310, 381);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(92, 37);
            btnexcluir.TabIndex = 19;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = false;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(512, 38);
            label8.Name = "label8";
            label8.Size = new Size(84, 29);
            label8.TabIndex = 20;
            label8.Text = "Pesquisar:";
            // 
            // btnpesquisar
            // 
            btnpesquisar.BackColor = Color.PaleVioletRed;
            btnpesquisar.Cursor = Cursors.Hand;
            btnpesquisar.FlatStyle = FlatStyle.Flat;
            btnpesquisar.Font = new Font("Dubai", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpesquisar.ForeColor = SystemColors.InactiveBorder;
            btnpesquisar.Location = new Point(755, 38);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(68, 31);
            btnpesquisar.TabIndex = 21;
            btnpesquisar.Text = "Buscar";
            btnpesquisar.UseVisualStyleBackColor = false;
            btnpesquisar.Click += btnpesquisar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PeachPuff;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(521, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(378, 264);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtpesquisar
            // 
            txtpesquisar.Location = new Point(599, 42);
            txtpesquisar.Name = "txtpesquisar";
            txtpesquisar.Size = new Size(125, 27);
            txtpesquisar.TabIndex = 23;
            txtpesquisar.TextChanged += txtpesquisar_TextChanged;
            // 
            // btnrelatorio
            // 
            btnrelatorio.BackColor = Color.DarkViolet;
            btnrelatorio.Cursor = Cursors.Hand;
            btnrelatorio.FlatStyle = FlatStyle.Flat;
            btnrelatorio.Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnrelatorio.ForeColor = SystemColors.ButtonHighlight;
            btnrelatorio.Location = new Point(755, 469);
            btnrelatorio.Name = "btnrelatorio";
            btnrelatorio.Size = new Size(144, 36);
            btnrelatorio.TabIndex = 24;
            btnrelatorio.Text = "Gerar Relatório";
            btnrelatorio.UseVisualStyleBackColor = false;
            btnrelatorio.Click += btnrelatorio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(934, 530);
            Controls.Add(btnrelatorio);
            Controls.Add(txtpesquisar);
            Controls.Add(dataGridView1);
            Controls.Add(btnpesquisar);
            Controls.Add(label8);
            Controls.Add(btnexcluir);
            Controls.Add(btncadastrar);
            Controls.Add(btneditar);
            Controls.Add(cbotipo);
            Controls.Add(data_lancamento);
            Controls.Add(chkpagamento);
            Controls.Add(cboservico);
            Controls.Add(txtvalor);
            Controls.Add(txtdescricao);
            Controls.Add(txtcodigo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtcodigo;
        private TextBox txtdescricao;
        private TextBox txtvalor;
        private ComboBox cboservico;
        private CheckBox chkpagamento;
        private DateTimePicker data_lancamento;
        private ComboBox cbotipo;
        private Button btneditar;
        private Button btncadastrar;
        private Button btnexcluir;
        private Label label8;
        private Button btnpesquisar;
        private DataGridView dataGridView1;
        private TextBox txtpesquisar;
        private Button btnrelatorio;
    }
}
