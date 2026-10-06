namespace Bireau_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("oujda");
            comboBox1.Items.Add("fes");
            comboBox1.Items.Add("meknas");
            comboBox1.Items.Add("barkan");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string ville = comboBox1.Text;


            if (nom.Length < 8 || nom.Length > 13)
            {

                MessageBox.Show("le nom doit contenir antre 8 et 13 ");
            }
            else
            {
                label3.Text = " Client pret : " + nom + " ville : " + ville + ".";
            }

            foreach (CheckBox check in panel1.Controls.OfType<CheckBox>())
            {
                if (check.Checked)
                    label3.Text +="\n"+ check.Text ;
            }

            if (radioButton1.Checked)
            {
                MessageBox.Show("Homme");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Femme");
            }
            else
            {
                MessageBox.Show("Choisissez Homme ou Femme");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            label3.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
