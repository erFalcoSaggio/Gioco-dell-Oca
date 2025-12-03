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
        Button[] campo = new Button[63];

        public TavolaDaGioco()
        {
            InitializeComponent();
        }

        private void TavolaDaGioco_Load(object sender, EventArgs e)
        {
            CaricaCampo(); //carico il campo da gioco

        }

        private void CaricaCampo()
        {
            dgv_Campo.ClearSelection();
            int n = 8; // 8x8 = 64 celle (1 vuota)
            dgv_Campo.RowCount = n;
            dgv_Campo.ColumnCount = n;

            foreach (DataGridViewColumn col in dgv_Campo.Columns)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            //spirale
            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = n - 1;

            int value = 1;

            while (value <= 63)
            {
                for (int c = left; c <= right && value <= 63; c++)
                    dgv_Campo[c, top].Value = value++;
                top++;

                for (int r = top; r <= bottom && value <= 63; r++)
                    dgv_Campo[right, r].Value = value++;
                right--;

                for (int c = right; c >= left && value <= 63; c--)
                    dgv_Campo[c, bottom].Value = value++;
                bottom--;

                for (int r = bottom; r >= top && value <= 63; r--)
                    dgv_Campo[left, r].Value = value++;
                left++;
            }

            //celle quadrate
            int size = 35; //lato

            dgv_Campo.RowTemplate.Height = size;
            dgv_Campo.DefaultCellStyle.BackColor = Color.FromArgb(99, 203, 82);

            foreach (DataGridViewRow row in dgv_Campo.Rows)
                row.Height = size;

            foreach (DataGridViewColumn col in dgv_Campo.Columns)
                col.Width = size * 2;

            int[] oche = { 5, 9, 18, 27, 36, 45, 54 };
            foreach (int casella in oche)
                MettiImmagine(casella, Properties.Resources.oca);

            MettiImmagine(6, Properties.Resources.ponte);
            MettiImmagine(19, Properties.Resources.casa);
            MettiImmagine(31, Properties.Resources.prigione);
            MettiImmagine(42, Properties.Resources.labirinto);
            MettiImmagine(58, Properties.Resources.scheletro);



        }

        void MettiImmagine(int numeroCasella, Image img)
        {
            //trova cella con num = numeroCasella
            for (int r = 0; r < dgv_Campo.RowCount; r++)
            {
                for (int c = 0; c < dgv_Campo.ColumnCount; c++)
                {
                    //se dgv_Campo[c, r].Value è un intero lo metto nella variabile v. successivamente controlla l'uglianza tra quest'ultima e numeroCasella
                    if (dgv_Campo[c, r].Value is int v && v == numeroCasella) 
                    {
                        //trasforma da cella normale a cella immagine
                        var cell = new DataGridViewImageCell();
                        cell.Value = img;
                        cell.ImageLayout = DataGridViewImageCellLayout.Zoom;

                        dgv_Campo[c, r] = cell;  //change

                        return;
                    }
                }
            }
        }

    }
}
