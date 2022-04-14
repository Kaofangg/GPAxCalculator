namespace GPAxCalculator
{
    public partial class Form1 : Form
    {
        GPAxCalculator oGPAcal = new GPAxCalculator();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string GPA = this.textBoxinputGPA.Text;
            string name = this.textBoxinputName.Text;

            double dInput = Convert.ToDouble(GPA);
            oGPAcal.addGPA(dInput, name);

            double gpax = oGPAcal.getGPAx();
            textBoxGPA.Text = gpax.ToString();

            double max = oGPAcal.getMax();
            textBoxMaxGPA.Text = max.ToString();
            textBoxMaxName.Text = oGPAcal.getMaxName().ToString();

            double min = oGPAcal.getMin();
            textBoxMinGPA.Text = min.ToString();
            textBoxMinName.Text = oGPAcal.getMinName().ToString();

            textBoxinputGPA.Text = "";
            textBoxinputName.Text = string.Empty;
            textBoxallData.Text = oGPAcal.getAlldata();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPA.Text = "";
            textBoxinputGPA.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxMinGPA.Text = "";
            textBoxinputName.Text = "";
            textBoxMaxName.Text = "";
            textBoxMinName.Text = "";
            textBoxallData.Text = "";
        }
    }
}