using System.Drawing.Drawing2D;


namespace Gioco_dell_Oca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BordiSmussatiAiButton();
        }
        private void btn_IniziaAGiocare_Click(object sender, EventArgs e)
        {
            TavolaDaGioco tdg = new();
            tdg.ShowDialog();
            this.Close();
        }

        //funzione per dare l'effetto bordo smussato a TUTTI i bottoni
        public void BordiSmussatiAiButton()
        {
            int radius = 15;

            foreach (Control c in pnl_GestioneBottoni.Controls)
            {
                if (c is Button btn)
                {
                    GraphicsPath path = new GraphicsPath();
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                    path.CloseFigure();
                    btn.Region = new Region(path);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
        }

    }
}