namespace Gioco_dell_Oca
{
    partial class TavolaDaGioco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_Campo = new DataGridView();
            lbl_Giocatore1 = new Label();
            lbl_Giocatore2 = new Label();
            pct_Pedone1 = new PictureBox();
            pct_Pedone2 = new PictureBox();
            btn_Tira = new Button();
            lbl_BottoneUniversale = new Label();
            pnl_Inizio = new Panel();
            lbl_Cella0 = new Label();
            pct_Pedone1Cella0 = new PictureBox();
            pct_Pedone2Cella0 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Campo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct_Pedone1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct_Pedone2).BeginInit();
            pnl_Inizio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pct_Pedone1Cella0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct_Pedone2Cella0).BeginInit();
            SuspendLayout();
            // 
            // dgv_Campo
            // 
            dgv_Campo.AllowUserToAddRows = false;
            dgv_Campo.AllowUserToDeleteRows = false;
            dgv_Campo.AllowUserToResizeColumns = false;
            dgv_Campo.AllowUserToResizeRows = false;
            dgv_Campo.BackgroundColor = Color.FromArgb(99, 203, 82);
            dgv_Campo.BorderStyle = BorderStyle.None;
            dgv_Campo.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Campo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Campo.ColumnHeadersVisible = false;
            dgv_Campo.Enabled = false;
            dgv_Campo.GridColor = Color.FromArgb(99, 203, 82);
            dgv_Campo.Location = new Point(208, 73);
            dgv_Campo.MultiSelect = false;
            dgv_Campo.Name = "dgv_Campo";
            dgv_Campo.ReadOnly = true;
            dgv_Campo.RowHeadersVisible = false;
            dgv_Campo.RowTemplate.Height = 25;
            dgv_Campo.ScrollBars = ScrollBars.None;
            dgv_Campo.Size = new Size(548, 313);
            dgv_Campo.TabIndex = 0;
            // 
            // lbl_Giocatore1
            // 
            lbl_Giocatore1.AutoSize = true;
            lbl_Giocatore1.Location = new Point(60, 109);
            lbl_Giocatore1.Name = "lbl_Giocatore1";
            lbl_Giocatore1.Size = new Size(67, 15);
            lbl_Giocatore1.TabIndex = 1;
            lbl_Giocatore1.Text = "Giocatore 1";
            // 
            // lbl_Giocatore2
            // 
            lbl_Giocatore2.AutoSize = true;
            lbl_Giocatore2.Location = new Point(64, 259);
            lbl_Giocatore2.Name = "lbl_Giocatore2";
            lbl_Giocatore2.Size = new Size(67, 15);
            lbl_Giocatore2.TabIndex = 2;
            lbl_Giocatore2.Text = "Giocatore 2";
            // 
            // pct_Pedone1
            // 
            pct_Pedone1.ErrorImage = null;
            pct_Pedone1.Image = Properties.Resources.pedone1;
            pct_Pedone1.Location = new Point(60, 127);
            pct_Pedone1.Name = "pct_Pedone1";
            pct_Pedone1.Size = new Size(100, 50);
            pct_Pedone1.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Pedone1.TabIndex = 3;
            pct_Pedone1.TabStop = false;
            // 
            // pct_Pedone2
            // 
            pct_Pedone2.Image = Properties.Resources.pedone2;
            pct_Pedone2.Location = new Point(64, 277);
            pct_Pedone2.Name = "pct_Pedone2";
            pct_Pedone2.Size = new Size(100, 50);
            pct_Pedone2.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Pedone2.TabIndex = 4;
            pct_Pedone2.TabStop = false;
            // 
            // btn_Tira
            // 
            btn_Tira.Location = new Point(64, 381);
            btn_Tira.Name = "btn_Tira";
            btn_Tira.Size = new Size(75, 23);
            btn_Tira.TabIndex = 5;
            btn_Tira.Text = "Tira";
            btn_Tira.UseVisualStyleBackColor = true;
            btn_Tira.Click += btn_Tira_Click;
            // 
            // lbl_BottoneUniversale
            // 
            lbl_BottoneUniversale.AutoSize = true;
            lbl_BottoneUniversale.Location = new Point(51, 407);
            lbl_BottoneUniversale.Name = "lbl_BottoneUniversale";
            lbl_BottoneUniversale.Size = new Size(113, 15);
            lbl_BottoneUniversale.TabIndex = 6;
            lbl_BottoneUniversale.Text = "(Bottone universale)";
            // 
            // pnl_Inizio
            // 
            pnl_Inizio.Controls.Add(pct_Pedone2Cella0);
            pnl_Inizio.Controls.Add(pct_Pedone1Cella0);
            pnl_Inizio.Controls.Add(lbl_Cella0);
            pnl_Inizio.Location = new Point(102, 12);
            pnl_Inizio.Name = "pnl_Inizio";
            pnl_Inizio.Size = new Size(113, 55);
            pnl_Inizio.TabIndex = 7;
            // 
            // lbl_Cella0
            // 
            lbl_Cella0.AutoSize = true;
            lbl_Cella0.Location = new Point(35, 0);
            lbl_Cella0.Name = "lbl_Cella0";
            lbl_Cella0.Size = new Size(42, 15);
            lbl_Cella0.TabIndex = 0;
            lbl_Cella0.Text = "Cella 0";
            // 
            // pct_Pedone1Cella0
            // 
            pct_Pedone1Cella0.ErrorImage = null;
            pct_Pedone1Cella0.Image = Properties.Resources.pedone1;
            pct_Pedone1Cella0.Location = new Point(6, 18);
            pct_Pedone1Cella0.Name = "pct_Pedone1Cella0";
            pct_Pedone1Cella0.Size = new Size(39, 34);
            pct_Pedone1Cella0.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Pedone1Cella0.TabIndex = 4;
            pct_Pedone1Cella0.TabStop = false;
            // 
            // pct_Pedone2Cella0
            // 
            pct_Pedone2Cella0.Image = Properties.Resources.pedone2;
            pct_Pedone2Cella0.Location = new Point(68, 18);
            pct_Pedone2Cella0.Name = "pct_Pedone2Cella0";
            pct_Pedone2Cella0.Size = new Size(42, 34);
            pct_Pedone2Cella0.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Pedone2Cella0.TabIndex = 8;
            pct_Pedone2Cella0.TabStop = false;
            // 
            // TavolaDaGioco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 203, 82);
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_Inizio);
            Controls.Add(lbl_BottoneUniversale);
            Controls.Add(btn_Tira);
            Controls.Add(pct_Pedone2);
            Controls.Add(pct_Pedone1);
            Controls.Add(lbl_Giocatore2);
            Controls.Add(lbl_Giocatore1);
            Controls.Add(dgv_Campo);
            Name = "TavolaDaGioco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TavolaDaGioco";
            Load += TavolaDaGioco_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Campo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct_Pedone1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct_Pedone2).EndInit();
            pnl_Inizio.ResumeLayout(false);
            pnl_Inizio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pct_Pedone1Cella0).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct_Pedone2Cella0).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Campo;
        private Label lbl_Giocatore1;
        private Label lbl_Giocatore2;
        private PictureBox pct_Pedone1;
        private PictureBox pct_Pedone2;
        private Button btn_Tira;
        private Label lbl_BottoneUniversale;
        private Panel pnl_Inizio;
        private PictureBox pct_Pedone2Cella0;
        private PictureBox pct_Pedone1Cella0;
        private Label lbl_Cella0;
    }
}