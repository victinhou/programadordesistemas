using System.Windows.Forms;

namespace forms_aula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no label")
             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Confirma?", "mesmo?",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("AIAIAI Tá querendo");
            }
            else
            {
                MessageBox.Show("KKKKKKKKKKKK Burrão");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome1 = text_nome.Text;
            MessageBox.Show(nome1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ecivil = lista_ecivil.SelectedItem.ToString();
            MessageBox.Show("O seu é " + ecivil);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adicionando itens


            //Adicionando itens
            lista_ecivil.Items.Add("Selecione uma opção");
            lista_ecivil.Items.Add("Solteiro");
            lista_ecivil.Items.Add("Casado");
            lista_ecivil.Items.Add("Viúvo");
            lista_ecivil.Items.Add("Divorciado");
            lista_ecivil.Items.Add("Enrolando");
            lista_ecivil.Items.Add("Deixei pra Jesus");
            lista_ecivil.Items.Add("Tia dos Gatos");

            lista_ecivil.SelectedIndex = 0;

            //Caso precise deixar a lista dinâmica
            /* lista_ecivil.Items.AddRange(new string[] */

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lista_ecivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked && checkBox3.Checked && checkBox1.Checked)
            {
                MessageBox.Show("O Usuario é brabo");

            }

            else if (checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("Carro e moto");
            }

            else if (checkBox1.Checked && checkBox3.Checked)
            {
                MessageBox.Show("Carro e Metro");
            }

            else if (checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("O Usuario tem moto e Metro");
            }

            else if (checkBox1.Checked)
            {
                MessageBox.Show("O Usuario Possui carro");
            }

            else if (checkBox2.Checked)

            {
                MessageBox.Show("O usuario Possui MOTO");
            }

            else if (checkBox3.Checked)
            {
                MessageBox.Show("O Usuario é um fodido");
            }

           
            
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
