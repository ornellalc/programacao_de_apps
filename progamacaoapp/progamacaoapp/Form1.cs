using progamacaoapp.objeto;

namespace progamacaoapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            con.getConexao();

            financeiro fin =new financeiro();
            fin.data_lancamento = data_lacamento.Text;
            fin.descricao=txtdescricao.Text;
            fin.servico=cboservico.Text;
            fin.valor=Convert.ToDecimal(txtvalor.Text);
            fin.tipo=cbotipo.Text;
            fin.pgto=chkpagamento.Checked;
            if (fin.cadastrar(con) == true)
            {
                MessageBox.Show("Cadastrado com sucesso");
            }

        }
    }
}
