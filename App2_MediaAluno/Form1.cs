namespace App2_MediaAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Lê as notas do Componente 1
            double n1C1 = Convert.ToDouble(txtNota1C1.Text);
            double n2C1 = Convert.ToDouble(txtNota2C1.Text);
            double n3C1 = Convert.ToDouble(txtNota3C1.Text);
            double n4C1 = Convert.ToDouble(txtNota4C1.Text);

            // Lê as notas do Componente 2
            double n1C2 = Convert.ToDouble(txtNota1C2.Text);
            double n2C2 = Convert.ToDouble(txtNota2C2.Text);
            double n3C2 = Convert.ToDouble(txtNota3C2.Text);
            double n4C2 = Convert.ToDouble(txtNota4C2.Text);

            // Calcula a média de cada componente
            double mediaC1 = (n1C1 + n2C1 + n3C1 + n4C1) / 4;
            double mediaC2 = (n1C2 + n2C2 + n3C2 + n4C2) / 4;

            // Calcula a média anual (das duas matérias)
            double mediaAnual = (mediaC1 + mediaC2) / 2;

            // Mostra o resultado
            lblResultado.Text = "Aluno: " + txtNome.Text + "\n" +
                                txtComponente1.Text + ": " + mediaC1.ToString("N2") + "\n" +
                                txtComponente2.Text + ": " + mediaC2.ToString("N2") + "\n" +
                                "Média Anual: " + mediaAnual.ToString("N2");
        }

    }
}
