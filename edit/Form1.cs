namespace edit
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Lütfen boþ alanlarý doldurunuz.", "Program");
            }
            else
            {
                if (username == "KULLANCI ADI BURAYA" && password == "ÞÝFRENÝZ BURAYA")
                {
                    MessageBox.Show("Giriþ Baþarýlý");
                }
                else
                {
                    MessageBox.Show("Hatalý Giriþ");
                }
            }
        }
    }
}