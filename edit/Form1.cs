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
                MessageBox.Show("L�tfen bo� alanlar� doldurunuz.", "Program");
            }
            else
            {
                if (username == "KULLANCI ADI BURAYA" && password == "��FREN�Z BURAYA")
                {
                    MessageBox.Show("Giri� Ba�ar�l�");
                }
                else
                {
                    MessageBox.Show("Hatal� Giri�");
                }
            }
        }
    }
}