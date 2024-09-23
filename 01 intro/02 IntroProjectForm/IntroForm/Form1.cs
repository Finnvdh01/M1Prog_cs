using Microsoft.VisualBasic;

namespace IntroForm
{
    public partial class Form1 : Form
    {
        //ken waardes toe aan de variabelen (assignement (=))
        int x = 69;// iets van tussen de 50 en 300
        int y = 247;// iets van tussen de 50 en 300
        string introSentence = "bram is sigma";
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            g.DrawString(introSentence, Font, Brushes.Black, x, y);
        }
    }
}
