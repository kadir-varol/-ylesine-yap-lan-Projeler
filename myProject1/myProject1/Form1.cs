namespace myProject1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public static string gdveri;
        public void button1_Click(object sender, EventArgs e)
        {
            gdveri = textBox1.Text;
            new Form2().ShowDialog();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}