using MySql.Data.MySqlClient;
using progamacaoapp.objeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using PageSize = iTextSharp.text.PageSize;
using Font = System.Drawing.Font;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Net.Http.Json;
using System.Diagnostics;
using Document = iTextSharp.text.Document;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Text;
using Org.BouncyCastle.Crypto;




namespace progamacaoapp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ConfigureChart();
        }


        private void ConfigureChart()
        {
            fluxocaixa.Titles.Clear();
            fluxocaixa.Series.Clear();
            fluxocaixa.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("MainArea");
            fluxocaixa.ChartAreas.Add(chartArea);

            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineColor = Color.Aquamarine;
            chartArea.AxisY.LabelStyle.Format = "C2";
            chartArea.AxisY.Title = "Valor (R$)";
            chartArea.AxisX.Title = "Período";

            Series seriesEntrada = new Series("Entrada");
            seriesEntrada.ChartType = SeriesChartType.Line;
            seriesEntrada.Color = Color.Blue;
            seriesEntrada.IsValueShownAsLabel = true;
            seriesEntrada.LabelFormat = "C2";
            fluxocaixa.Series.Add(seriesEntrada);
            Series seriessaida = new Series("Saida");
            seriessaida.ChartType = SeriesChartType.Line;
            seriessaida.Color = Color.Blue;
            seriessaida.IsValueShownAsLabel = true;
            seriessaida.LabelFormat = "C2";
            fluxocaixa.Series.Add(seriessaida);
        }

        private void GerarRelatorio()
        {
            DataTable dtMoviemntacao = new DataTable();



            conexao com = new conexao();
            try
            {
                com.getConexao();
                string query = "Select data_lancamento,valor,tipo from financeiro";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, com.conexaoProjeto);
                adapter.Fill(dtMoviemntacao);

                ProcessarDadosGraficos(dtMoviemntacao);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório");
            }
        }

        private void ProcessarDadosGraficos(DataTable dados)
        {
            foreach (var series in fluxocaixa.Series)
            {
                series.Points.Clear();
            }
            decimal totalentrada = 0;
            decimal totalsaida = 0;
            var grupos = dados.AsEnumerable().GroupBy(row =>
            {
                DateTime data = row.Field<DateTime>("data_lancamento");
                return data.Date;
            }).OrderBy(g => g.Key);

            foreach (var grupo in grupos)
            {

                string label;
                label = grupo.Key.ToString("dd/MM"); // Ex: 01/07
                decimal entradas = grupo.Where(r => r.Field<string>
                ("tipo") == "entrada").Sum(r => r.Field<decimal>("valor"));
                decimal saidas = grupo.Where(r => r.Field<string>
                ("tipo") == "saida").Sum(r => r.Field<decimal>
                ("valor"));
                decimal saldo = entradas - saidas;
                fluxocaixa.Series["Entrada"].Points.AddXY(label, entradas);
                fluxocaixa.Series["Saida"].Points.AddXY(label,
                saidas);
                fluxocaixa.Series["Saldo"].Points.AddXY(label, saldo);

                string tituloGrafico = "Fluxo de caixa diario";
                fluxocaixa.Titles.Clear();
                fluxocaixa.Titles.Add(tituloGrafico);
            }
        }


        private void btnexcel_Click(object sender, EventArgs e)
        {
            string endereco = "RelatorioExcel.csv";
            string pastadestino = Path.Combine(Application.StartupPath, "Relatorio");
            if (!Directory.Exists(pastadestino))
            {
                Directory.CreateDirectory(pastadestino);
            }
            string caminhodestino = Path.Combine(pastadestino, endereco);

            using (StreamWriter writer = new StreamWriter(caminhodestino, false, Encoding.GetEncoding("iso-8859-15")))
            {
                conexao conexao = new conexao();
                MySqlConnection cone = conexao.getConexao();

                writer.WriteLine("Relatorio  Financeiro");
                writer.WriteLine("data;valor;tipo");
                string entrada = @"select data_lancamento, valor, tipo from financeiro";
                MySqlCommand cmd = new MySqlCommand(entrada, cone);

                cone.Open();

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        writer.WriteLine(Convert.ToString(reader["data_lancamento"]) + ";"
                            + Convert.ToString(reader["valor"] + ";"
                            + Convert.ToString(reader["tipo"]))
                            );

                    }
                }
                cone.Close();
                MessageBox.Show("Relatorio gerado com sucesso!", "Atenção");
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            string destinopdf = Path.Combine(Application.StartupPath, "pdf");
            if (!Directory.Exists(destinopdf)) ;
            {
                Directory.CreateDirectory(destinopdf);
            }


            string caminhopdf = Path.Combine(destinopdf, "relatoriocliente.pdf");

            Document document = new Document(PageSize.A4);
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(caminhopdf, FileMode.Create));
                document.Open();
                Font fonte = new Font("microsoft sans serif", 9f);
                Paragraph titulo = new Paragraph("relatorio cliente");
                titulo.Alignment = Element.ALIGN_CENTER;
                document.Add(titulo);
                document.Add(new Paragraph(" "));
                conexao conexao = new conexao();
                conexao.getConexao();
                DataTable cliente = new DataTable();

                cliente = conexao.obterdados("select * from financeiro");
                PdfPTable table = new PdfPTable(5);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 40f, 15f, 20, 25f, 15f });
                table.AddCell(new Phrase("descricao"));
                table.AddCell(new Phrase("valor"));
                table.AddCell(new Phrase("tipo"));
                table.AddCell(new Phrase("data_lancamento"));
                table.AddCell(new Phrase("pgo"));

                for (int i = 0; i < cliente.Rows.Count; i++)
                {
                    table.AddCell(new Phrase(cliente.Rows[i][1].ToString()));
                    table.AddCell(new Phrase(cliente.Rows[i][2].ToString()));
                    table.AddCell(new Phrase(cliente.Rows[i][3].ToString()));
                    table.AddCell(new Phrase(cliente.Rows[i][4].ToString()));
                    table.AddCell(new Phrase(cliente.Rows[i][5].ToString()));
                }
                document.Add(table);

                document.Close();
                MessageBox.Show("relatorio foi gerado com sucesso!");
                Process.Start(caminhopdf);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao  gerar o PDF", ex.Message);

            }
        }

        private void btngrafico_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
        }
    }
}
