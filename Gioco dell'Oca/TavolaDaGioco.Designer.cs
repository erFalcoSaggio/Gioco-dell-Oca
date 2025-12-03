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
            ((System.ComponentModel.ISupportInitialize)dgv_Campo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct_Pedone1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct_Pedone2).BeginInit();
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
            pct_Pedone1.Location = new Point(60, 127);
            pct_Pedone1.Name = "pct_Pedone1";
            pct_Pedone1.Size = new Size(100, 50);
            pct_Pedone1.TabIndex = 3;
            pct_Pedone1.TabStop = false;
            // 
            // pct_Pedone2
            // 
            pct_Pedone2.Location = new Point(64, 277);
            pct_Pedone2.Name = "pct_Pedone2";
            pct_Pedone2.Size = new Size(100, 50);
            pct_Pedone2.TabIndex = 4;
            pct_Pedone2.TabStop = false;
            // 
            // TavolaDaGioco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 203, 82);
            ClientSize = new Size(800, 450);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Campo;
        private Label lbl_Giocatore1;
        private Label lbl_Giocatore2;
        private PictureBox pct_Pedone1;
        private PictureBox pct_Pedone2;
    }
}