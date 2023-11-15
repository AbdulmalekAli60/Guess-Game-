namespace GueseGame
{
    public partial class Form1 : Form
    {
        public static int selctNumber = 0;
        public static int guesNumber = 0;
        Random random = new Random();
        int timeLeft = 45;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            selctNumber = random.Next(1, 201);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guesNumber = Int32.Parse(textBox1.Text);

            if (guesNumber > selctNumber)
            {
                textBox1.Text = "";
                MessageBox.Show("too big");
            }
            else if (guesNumber < selctNumber)
            {

                textBox1.Text = "";
                MessageBox.Show("too small");
            }
            else
            {
                textBox1.Enabled = false;
                timer1.Enabled = false;
                textBox1.Text = "";
                MessageBox.Show("you won");
                label2.Text = score.ToString();
            }
            score++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                label1.Text = timeLeft + "Seconds";
            }
            else
            {
                this.Hide();
                timer1.Enabled = false;
                MessageBox.Show("too slow");
            }
        }
    }
}