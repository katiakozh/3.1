namespace _10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Math.Pow(n, 3).ToString();
                textBox3.Text = (Math.Pow(n,2)*4).ToString();
            }
            catch(Exception ex)
            {
                textBox1.Text = ex.Message;
            }

        }
    }
}
