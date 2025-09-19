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



namespace progamacaoapp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
            if (!Directory.Exists(destinopdf));
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

                for(int i=0; i<cliente.Rows.Count; i++)
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
        
    }
}
