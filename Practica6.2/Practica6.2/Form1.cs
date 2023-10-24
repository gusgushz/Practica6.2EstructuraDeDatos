using Practica6._2.Entities;
namespace Practica6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ordenador gus = new(); 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string palabra = textBox1.Text;
            gus.AgregarPalabra(palabra);
            gus.InvertirPalabra(palabra);

            foreach (Palabra pala in gus.palabrasIngresadas)
            {
                listBox1.Items.Add($"{pala._Palabra}");
            }
            foreach (Palabra pala in gus.palabrasInvertidas)
            {
                listBox2.Items.Add($"{pala._Palabra}");
            }
            textBox1.Clear();
        }
    }
}