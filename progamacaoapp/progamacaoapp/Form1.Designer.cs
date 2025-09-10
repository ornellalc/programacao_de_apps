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
            data_lacamento = new DateTimePicker();
            cbotipo = new ComboBox();
            btneditar = new Button();
            btncadastrar = new Button();
            btnexcluir = new Button();
            label8 = new Label();
            btnpesquisar = new Button();
            dataGridView1 = new DataGridView();
            txtpesquisar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 57);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 92);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 136);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 179);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 227);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Serviço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 283);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 5;
            label6.Text = "Data";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 334);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 6;
            label7.Text = "Pagamento";
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(138, 49);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(125, 27);
            txtcodigo.TabIndex = 7;
            // 
            // txtdescricao
            // 
            txtdescricao.Location = new Point(138, 91);
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(125, 27);
            txtdescricao.TabIndex = 8;
            // 
            // txtvalor
            // 
            txtvalor.Location = new Point(138, 132);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(125, 27);
            txtvalor.TabIndex = 9;
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
            chkpagamento.Location = new Point(138, 329);
            chkpagamento.Name = "chkpagamento";
            chkpagamento.Size = new Size(101, 24);
            chkpagamento.TabIndex = 14;
            chkpagamento.Text = "checkBox1";
            chkpagamento.UseVisualStyleBackColor = true;
            // 
            // data_lacamento
            // 
            data_lacamento.Location = new Point(138, 282);
            data_lacamento.Name = "data_lacamento";
            data_lacamento.Size = new Size(250, 27);
            data_lacamento.TabIndex = 15;
            // 
            // cbotipo
            // 
            cbotipo.FormattingEnabled = true;
            cbotipo.Location = new Point(138, 175);
            cbotipo.Name = "cbotipo";
            cbotipo.Size = new Size(151, 28);
            cbotipo.TabIndex = 16;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(178, 381);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(94, 29);
            btneditar.TabIndex = 17;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            // 
            // btncadastrar
            // 
            btncadastrar.Location = new Point(47, 381);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(94, 29);
            btncadastrar.TabIndex = 18;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = true;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(310, 381);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(94, 29);
            btnexcluir.TabIndex = 19;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(424, 33);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 20;
            label8.Text = "Pesquisar";
            // 
            // btnpesquisar
            // 
            btnpesquisar.Location = new Point(658, 31);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(94, 29);
            btnpesquisar.TabIndex = 21;
            btnpesquisar.Text = "Buscar";
            btnpesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(424, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(348, 217);
            dataGridView1.TabIndex = 22;
            // 
            // txtpesquisar
            // 
            txtpesquisar.Location = new Point(509, 30);
            txtpesquisar.Name = "txtpesquisar";
            txtpesquisar.Size = new Size(125, 27);
            txtpesquisar.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtpesquisar);
            Controls.Add(dataGridView1);
            Controls.Add(btnpesquisar);
            Controls.Add(label8);
            Controls.Add(btnexcluir);
            Controls.Add(btncadastrar);
            Controls.Add(btneditar);
            Controls.Add(cbotipo);
            Controls.Add(data_lacamento);
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
        private DateTimePicker data_lacamento;
        private ComboBox cbotipo;
        private Button btneditar;
        private Button btncadastrar;
        private Button btnexcluir;
        private Label label8;
        private Button btnpesquisar;
        private DataGridView dataGridView1;
        private TextBox txtpesquisar;
    }
}
