namespace Gestion_Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //fuction button ajouter
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
        //CLICK DU TABLEAU
        int a;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[a];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();

        }
        

        //modifier function
        private void button2_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[a];
            newdata.Cells[0].Value = textBox1.Text;
            newdata.Cells[1].Value = textBox2.Text;
            newdata.Cells[2].Value = textBox3.Text;
            newdata.Cells[3].Value = textBox4.Text;

        }

        //function supprimer
        private void button3_Click_1(object sender, EventArgs e)
        {
            a = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(a);

        }
       
        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

       
    }
}
