namespace progamacaoapp
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnexcel = new Button();
            label1 = new Label();
            btnpdf = new Button();
            btngrafico = new Button();
            fluxocaixa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)fluxocaixa).BeginInit();
            SuspendLayout();
            // 
            // btnexcel
            // 
            btnexcel.BackColor = Color.Chartreuse;
            btnexcel.FlatStyle = FlatStyle.Flat;
            btnexcel.ForeColor = Color.DarkOliveGreen;
            btnexcel.Location = new Point(37, 102);
            btnexcel.Name = "btnexcel";
            btnexcel.Size = new Size(119, 36);
            btnexcel.TabIndex = 0;
            btnexcel.Text = "Gerar Excel";
            btnexcel.UseVisualStyleBackColor = false;
            btnexcel.Click += btnexcel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 48);
            label1.Name = "label1";
            label1.Size = new Size(546, 34);
            label1.TabIndex = 1;
            label1.Text = "Escolha em qual formato você deseja gerar seu relatório:";
            // 
            // btnpdf
            // 
            btnpdf.BackColor = Color.DeepPink;
            btnpdf.Cursor = Cursors.Hand;
            btnpdf.FlatStyle = FlatStyle.Flat;
            btnpdf.ForeColor = Color.LavenderBlush;
            btnpdf.Location = new Point(246, 102);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new Size(119, 36);
            btnpdf.TabIndex = 2;
            btnpdf.Text = "Gerar PDF";
            btnpdf.UseVisualStyleBackColor = false;
            btnpdf.Click += btnpdf_Click;
            // 
            // btngrafico
            // 
            btngrafico.BackColor = Color.PaleTurquoise;
            btngrafico.Cursor = Cursors.Hand;
            btngrafico.FlatStyle = FlatStyle.Flat;
            btngrafico.ForeColor = Color.MidnightBlue;
            btngrafico.Location = new Point(460, 102);
            btngrafico.Name = "btngrafico";
            btngrafico.Size = new Size(119, 36);
            btngrafico.TabIndex = 3;
            btngrafico.Text = "Gerar Gráfico";
            btngrafico.UseVisualStyleBackColor = false;
            btngrafico.Click += btngrafico_Click;
            // 
            // fluxocaixa
            // 
            chartArea1.Name = "ChartArea1";
            fluxocaixa.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            fluxocaixa.Legends.Add(legend1);
            fluxocaixa.Location = new Point(37, 168);
            fluxocaixa.Name = "fluxocaixa";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            fluxocaixa.Series.Add(series1);
            fluxocaixa.Size = new Size(731, 283);
            fluxocaixa.TabIndex = 4;
            fluxocaixa.Text = "chart1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(800, 450);
            Controls.Add(fluxocaixa);
            Controls.Add(btngrafico);
            Controls.Add(btnpdf);
            Controls.Add(label1);
            Controls.Add(btnexcel);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)fluxocaixa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnexcel;
        private Label label1;
        private Button btnpdf;
        private Button btngrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart fluxocaixa;
    }
}