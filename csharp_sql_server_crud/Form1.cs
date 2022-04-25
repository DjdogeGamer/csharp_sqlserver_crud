using System.Data.SqlClient;
using System.Data;

namespace csharp_sql_server_crud
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        string strSQL;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Server=GUSTAVO-PC; Database=crud_db;User Id=sa;Password=123");

                strSQL = "select * from pessoas";

                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(strSQL,conn);

                conn.Open();

                adapter.Fill(ds);

                dgvDados.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn = null;
                cmd = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NovoBotao_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Server=GUSTAVO-PC; Database=crud_db;User Id=sa;Password=123");
                strSQL = "insert into pessoas (nome,idade) values (@NOME, @IDADE)";
                cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.AddWithValue("@NOME", CampoNome.Text);
                cmd.Parameters.AddWithValue("@IDADE", CampoIdade.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn = null;
                cmd = null;
            }
        }

        private void EditarBotao_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Server=GUSTAVO-PC; Database=crud_db;User Id=sa;Password=123");
                strSQL = "update pessoas set nome = @NOME, idade = @idade where id = @ID";
                cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.AddWithValue("@ID", CampoID.Text);
                cmd.Parameters.AddWithValue("@NOME", CampoNome.Text);
                cmd.Parameters.AddWithValue("@IDADE", CampoIdade.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn = null;
                cmd = null;
            }
        }

        private void ExcluirBotao_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Server=GUSTAVO-PC; Database=crud_db;User Id=sa;Password=123");
                strSQL = "delete from pessoas where id = @ID";
                cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.AddWithValue("@ID", CampoID.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn = null;
                cmd = null;
            }
        }

        private void ConsultarBotao_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Server=GUSTAVO-PC; Database=crud_db;User Id=sa;Password=123");
                strSQL = "select * from pessoas where id = @ID";
                cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.AddWithValue("@ID", CampoID.Text);
                conn.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CampoNome.Text = (string)reader["Nome"];
                    CampoIdade.Text = Convert.ToString(reader["Idade"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn = null;
                cmd = null;
            }
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}