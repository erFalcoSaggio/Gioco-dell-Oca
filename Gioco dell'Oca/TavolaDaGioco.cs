using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gioco_dell_Oca
{
    public partial class TavolaDaGioco : Form
    {
        Point[] posizioni = new Point[64]; // indice 1–63

        int pos1 = 0;   // pos giocatore 1
        int pos2 = 0;   // pos giocatore 2

        bool turnoGiocatore1 = true;

        int blocco1 = 0; // turni di blocco
        int blocco2 = 0;

        bool prigione1 = false;
        bool prigione2 = false;

        Random rnd = new Random();
        int tiriFatti = 0;

        public event Action<int, int, string> CasellaSpeciale;

        public TavolaDaGioco()
        {
            InitializeComponent();
            CasellaSpeciale += (giocatore, casella, messaggio) =>
            {
                MessageBox.Show($"Giocatore {giocatore} è fermo nella casella {casella}!\n\n{messaggio}");
            };
        }

        private void TavolaDaGioco_Load(object sender, EventArgs e)
        {
            CaricaCampo(); // carico il campo da gioco

            // immagini ped
            AggiornaPedina(0, pos1, Properties.Resources.pedone1);
            AggiornaPedina(0, pos2, Properties.Resources.pedone2);
        }

        private void CaricaCampo()
        {
            int n = 8; // 8x8 = 64 celle (1 vuota)
            dgv_Campo.RowCount = n;
            dgv_Campo.ColumnCount = n;

            foreach (DataGridViewColumn col in dgv_Campo.Columns)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // SPIRALE + salvataggio coordinate in posizioni[]
            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = n - 1;

            int value = 1;

            while (value <= 63)
            {
                // da sx a dxx
                for (int c = left; c <= right && value <= 63; c++)
                {
                    dgv_Campo[c, top].Value = value;
                    posizioni[value] = new Point(c, top);
                    value++;
                }
                top++;

                // alto->basso
                for (int r = top; r <= bottom && value <= 63; r++)
                {
                    dgv_Campo[right, r].Value = value;
                    posizioni[value] = new Point(right, r);
                    value++;
                }
                right--;

                // dx_sx
                for (int c = right; c >= left && value <= 63; c--)
                {
                    dgv_Campo[c, bottom].Value = value;
                    posizioni[value] = new Point(c, bottom);
                    value++;
                }
                bottom--;

                // basso->alto
                for (int r = bottom; r >= top && value <= 63; r--)
                {
                    dgv_Campo[left, r].Value = value;
                    posizioni[value] = new Point(left, r);
                    value++;
                }
                left++;
            }

            // celle quadrate
            int size = 35; // lato
            dgv_Campo.RowTemplate.Height = size;
            dgv_Campo.DefaultCellStyle.BackColor = Color.FromArgb(99, 203, 82);

            foreach (DataGridViewRow row in dgv_Campo.Rows)
                row.Height = size;

            foreach (DataGridViewColumn col in dgv_Campo.Columns)
                col.Width = size*2;

            dgv_Campo.ReadOnly = true;
            dgv_Campo.MultiSelect = false;
            dgv_Campo.SelectionChanged += (s, e2) =>
            {
                dgv_Campo.ClearSelection();
                dgv_Campo.CurrentCell = null;
            }; //ogni volta che il dgv (utente) prova a selezionare una cella… la deseleziona subito
            dgv_Campo.ClearSelection();
            // CASELLE SPECIALI!!!
            int[] oche = { 5, 9, 18, 27, 36, 45, 54 };
            foreach (int casella in oche)
                MettiImmagine(casella, Properties.Resources.oca);

            MettiImmagine(6, Properties.Resources.ponte);
            MettiImmagine(19, Properties.Resources.casa);
            MettiImmagine(31, Properties.Resources.prigione);
            MettiImmagine(42, Properties.Resources.labirinto);
            MettiImmagine(58, Properties.Resources.scheletro);
        }

        //metti una immagine in una casella nota
        void MettiImmagine(int numeroCasella, Image img)
        {
            Point p = posizioni[numeroCasella];

            var cell = new DataGridViewImageCell();
            cell.Value = img;
            cell.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgv_Campo[p.X, p.Y] = cell;
        }

        //helper per caselle oca, perchè sono più di una cella di conseguenza sarebbe superr ripetitvo
        bool Oca(int pos)
        {
            int[] oche = { 5, 9, 18, 27, 36, 45, 54 };
            return oche.Contains(pos);
        }

        //ripristina cosa deve esserci in una casella (numero o immagine speciale) per rimettere dopo che la pedina va via
        void RipristinaCasella(int pos)
        {
            if (pos < 1 || pos > 63) return;

            Point p = posizioni[pos];

            if (Oca(pos))
            {
                var cell = new DataGridViewImageCell();
                cell.Value = Properties.Resources.oca;
                cell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Campo[p.X, p.Y] = cell;
            }
            else if (pos == 6)
            {
                var cell = new DataGridViewImageCell();
                cell.Value = Properties.Resources.ponte;
                cell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Campo[p.X, p.Y] = cell;
            }
            else if (pos == 19)
            {
                var cell = new DataGridViewImageCell();
                cell.Value = Properties.Resources.casa;
                cell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Campo[p.X, p.Y] = cell;
            }
            else if (pos == 31)
            {
                var cell = new DataGridViewImageCell();
                cell.Value = Properties.Resources.prigione;
                cell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Campo[p.X, p.Y] = cell;
            }
            else if (pos == 42)
            {
                var cell = new DataGridViewImageCell();
                cell.Value = Properties.Resources.labirinto;
                cell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Campo[p.X, p.Y] = cell;
            }
            else if (pos == 58)
            {
                var cell = new DataGridViewImageCell();
                cell.Value = Properties.Resources.scheletro;
                cell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Campo[p.X, p.Y] = cell;
            }
            else
            {
                //cella nel chill normale ci rimetto il num
                var cell = new DataGridViewTextBoxCell();
                cell.Value = pos;
                dgv_Campo[p.X, p.Y] = cell;
                dgv_Campo[p.X, p.Y].Style.BackColor = Color.FromArgb(99, 203, 82);
            }
        }

        //sposto la pedina
        void AggiornaPedina(int vecchiaPos, int nuovaPos, Image pedina)
        {
            if (vecchiaPos >= 1 && vecchiaPos <= 63)
                RipristinaCasella(vecchiaPos);

            if (nuovaPos < 1 || nuovaPos > 63) return;

            Point p = posizioni[nuovaPos];

            var cell = new DataGridViewImageCell();
            cell.Value = pedina;
            cell.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_Campo[p.X, p.Y] = cell;
        }

        private void LanciaDadi()
        {
            //da 1 a 6
            int dado1 = rnd.Next(1, 7);
            int dado2 = rnd.Next(1, 7);
            int tiro = dado1 + dado2;
            tiriFatti++;

            // Mostra la somma, come richiesto
            MessageBox.Show($"Hai tirato: {dado1} + {dado2} = {tiro}");

            if (turnoGiocatore1)
                MuoviGiocatore(ref pos1, ref pos2, ref blocco1, ref prigione1, tiro, 1);//uso ref per cambiare EFFETTIVFAMENTE la pos
            else
                MuoviGiocatore(ref pos2, ref pos1, ref blocco2, ref prigione2, tiro, 2);

            if (tiriFatti == 1)
                pct_Pedone1Cella0.Visible = false;
            
            else if (tiriFatti == 2)
            {
                pnl_Inizio.Visible = false;
            }


            turnoGiocatore1 = !turnoGiocatore1; // cambio turno
        }

        void MuoviGiocatore(ref int pos, ref int posAltro,
                            ref int blocco, ref bool prigione,
                            int tiro, int numeroGiocatore)
        {
            int vecchiaPos = pos;

            // CASA (blocchi)
            if (blocco > 0)
            {
                MessageBox.Show($"Giocatore {numeroGiocatore} è bloccato per altri {blocco} turni!");
                blocco--;
                return;
            }

            // PRIGIONE
            if (prigione)
            {
                MessageBox.Show($"Giocatore {numeroGiocatore} è in prigione!");
                // esce solo se l'altro arriva
                return;
            }

            //movimento normale
            pos += tiro;

            //rimbalzi nella cella 63
            if (pos > 63)
                pos = 63 - (pos - 63);

            //controlla casella speciale
            pos = EffettoCasella(pos, tiro, ref blocco, ref prigione, numeroGiocatore);

            //se finisce sopra l'altro → lo manda all'inizio
            if (pos == posAltro)
            {
                posAltro = 1;
                MessageBox.Show($"Giocatore {numeroGiocatore} ha mandato l'altro alla casella 1!");
            }

            // aggiorna pedina graficamente
            Image imgPedina = (numeroGiocatore == 1)
                                ? Properties.Resources.pedone1
                                : Properties.Resources.pedone2;

            AggiornaPedina(vecchiaPos, pos, imgPedina);

            //vittoria
            if (pos == 63)
            {
                MessageBox.Show($"HA VINTO IL GIOCATORE {numeroGiocatore} !!!");
            }
        }

        int EffettoCasella(int pos, int tiro, ref int blocco, ref bool prigione, int numG)
        {
            switch (pos)
            {
                // CASELLE DELL’OCA
                case 5:
                case 9:
                case 18:
                case 27:
                case 36:
                case 45:
                case 54:
                    CasellaSpeciale?.Invoke(numG, pos, $"OCA! Avanza di nuovo di {tiro} caselle!");
                    pos += tiro;
                    while (Oca(pos))
                        pos += tiro;


                    return pos;

                // PONTE
                case 6:
                    CasellaSpeciale?.Invoke(numG, pos, $"PONTE! Ripeti il movimento!");
                    return pos + tiro;

                // CASA
                case 19:
                    blocco = 3;
                    CasellaSpeciale?.Invoke(numG, pos, $"CASA! Rimani fermo per 3 turni!");
                    return pos;

                // PRIGIONE
                case 31:
                    prigione = true;
                    CasellaSpeciale?.Invoke(numG, pos, $"PRIGIONE! Rimani finché l'altro non arriva!");
                    return pos;

                // LABIRINTO
                case 42:
                    CasellaSpeciale?.Invoke(numG, pos, $"LABIRINTO! Torna alla casella 39!");
                    return 39;

                // MORTE (scheletro)
                case 58:
                    CasellaSpeciale?.Invoke(numG, pos, $"SCHELETRO! Torna alla casella 1!");
                    return 1;
            }

            return pos;
        }

        private void btn_Tira_Click(object sender, EventArgs e)
        {
            LanciaDadi();
        }
    }
}
