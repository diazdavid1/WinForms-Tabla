namespace WinFormsTabla
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVerTabla_Click(object sender, EventArgs e)
        {
            this.muestraTabla();
        }

        private void muestraTabla()
        {
            int n = Convert.ToInt32(this.textBoxNum.Text);
            string tabla = "";
            for (int i = 0; i < 10; i++)
            {
                tabla = tabla + n + "x" + i + "=" + (i * n) + "\n";
            }
            this.richTextBoxResultado.AppendText(tabla);
        }
    }
}
