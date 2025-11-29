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
        }
    }
}
