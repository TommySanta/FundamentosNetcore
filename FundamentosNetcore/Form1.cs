namespace FundamentosNetcore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Algo aquí....";
            this.SuspendLayout();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.nombre.Location = new Point(20,10);
            this.nombre.Text = "Soy un string de Prueba 2";
            this.nombre.Width = 220;
            this.nombre.TextAlign = HorizontalAlignment.Right;
            this.button1.BackColor = Color.Azure;
        }
    }
}
