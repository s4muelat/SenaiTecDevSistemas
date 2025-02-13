namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = btnEmail.Text;
            string senha = btnSenha.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Verique os campos e-mail e/ou senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else

            if (email == "aluno@senai.com.br" && senha == "12345678") {

                //MessageBox.Show("Login realizado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Hide();

                Form2 novoFormulario = new Form2();
                novoFormulario.Show();
                

            }
            else
            {
                MessageBox.Show("E-mail e/ou senha inválidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
