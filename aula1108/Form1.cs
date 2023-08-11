namespace aula1108
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            string QtMens = Mens.Text;
            string QtWoman = Womans.Text;
            string QtKids = Kids.Text;
            int QtMensInt = Convert.ToInt32(QtMens);
            int QtWomansInt = Convert.ToInt32(QtWoman);
            int QtKidsInt = Convert.ToInt32(QtKids);

            //Calculos 

            int qtCarne = (QtMensInt * 500) + (QtWomansInt * 300) + (QtKidsInt * 150);

            int QtSalada = (QtMensInt * 100) + (QtWomansInt * 100) + (QtKidsInt * 50);

            int QtFarofa = (QtMensInt * 100) + (QtWomansInt * 100) + (QtKidsInt * 50);

            int QtCerveja = (QtMensInt * 2) + (QtWomansInt * 2);

            int QtRefri = (QtMensInt * 1) + (QtWomansInt * 1) + (QtKidsInt * 1);

            double QtCarvao = (qtCarne / 1000) * 1.5;

            carneLB.Text = Convert.ToString(qtCarne);
            farofaLB.Text = Convert.ToString(QtFarofa);
            saladaLB.Text = Convert.ToString(QtSalada);
            cervejaLB.Text = Convert.ToString(QtCerveja);
            refriLB.Text = Convert.ToString(QtRefri);
            CarvaoLB.Text = Convert.ToString(QtCarvao);
            //int.Parse(Console.ReadKey(Mens));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void kids_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cervejaLB_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}