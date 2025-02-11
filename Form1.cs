namespace CrudOperationProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Databasecrud;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");
            con.Open();
            sqlCommand cmd = new sqlCommand("insert into UserTab values (@id,@Name,@Age)",con);
            cmd.parameter.AddWithValue("@ID",int.Parse(textBox1.Text));
            cmd.parameter.AddWithValue("@Name",textBox2.Text);
            cmd.parameter.AddWithValue("@Age", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Saved");
        }

 
    }
}
