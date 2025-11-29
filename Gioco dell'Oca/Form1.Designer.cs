namespace Gioco_dell_Oca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pct_Logo = new PictureBox();
            btn_IniziaAGiocare = new Button();
            pnl_GestioneBottoni = new Panel();
            swt_Musica = new Controls.Switch();
            lbl_MusicaTitolo = new Label();
            btn_Esci = new Button();
            ((System.ComponentModel.ISupportInitialize)pct_Logo).BeginInit();
            pnl_GestioneBottoni.SuspendLayout();
            SuspendLayout();
            // 
            // pct_Logo
            // 
            pct_Logo.Image = Properties.Resources.gioco_dell_oca_logo_TAGLIATO;
            pct_Logo.Location = new Point(12, 20);
            pct_Logo.Name = "pct_Logo";
            pct_Logo.Size = new Size(514, 410);
            pct_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Logo.TabIndex = 0;
            pct_Logo.TabStop = false;
            // 
            // btn_IniziaAGiocare
            // 
            btn_IniziaAGiocare.BackColor = Color.White;
            btn_IniziaAGiocare.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_IniziaAGiocare.ForeColor = Color.Black;
            btn_IniziaAGiocare.Location = new Point(56, 126);
            btn_IniziaAGiocare.Name = "btn_IniziaAGiocare";
            btn_IniziaAGiocare.Size = new Size(129, 33);
            btn_IniziaAGiocare.TabIndex = 1;
            btn_IniziaAGiocare.Text = "Inizia";
            btn_IniziaAGiocare.UseVisualStyleBackColor = false;
            btn_IniziaAGiocare.Click += btn_IniziaAGiocare_Click;
            // 
            // pnl_GestioneBottoni
            // 
            pnl_GestioneBottoni.Controls.Add(swt_Musica);
            pnl_GestioneBottoni.Controls.Add(lbl_MusicaTitolo);
            pnl_GestioneBottoni.Controls.Add(btn_Esci);
            pnl_GestioneBottoni.Controls.Add(btn_IniziaAGiocare);
            pnl_GestioneBottoni.Location = new Point(539, 20);
            pnl_GestioneBottoni.Name = "pnl_GestioneBottoni";
            pnl_GestioneBottoni.Size = new Size(240, 410);
            pnl_GestioneBottoni.TabIndex = 2;
            // 
            // swt_Musica
            // 
            swt_Musica.BackColor = Color.FromArgb(211, 234, 248);
            swt_Musica.CurrentState = global::Controls.Switch.SwitchStates.On;
            swt_Musica.Location = new Point(56, 197);
            swt_Musica.Name = "swt_Musica";
            swt_Musica.Size = new Size(39, 23);
            swt_Musica.TabIndex = 6;
            swt_Musica.Text = "Musica";
            // 
            // lbl_MusicaTitolo
            // 
            lbl_MusicaTitolo.AutoSize = true;
            lbl_MusicaTitolo.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_MusicaTitolo.Location = new Point(101, 197);
            lbl_MusicaTitolo.Name = "lbl_MusicaTitolo";
            lbl_MusicaTitolo.Size = new Size(84, 23);
            lbl_MusicaTitolo.TabIndex = 5;
            lbl_MusicaTitolo.Text = "Musica";
            // 
            // btn_Esci
            // 
            btn_Esci.BackColor = Color.White;
            btn_Esci.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Esci.ForeColor = Color.Black;
            btn_Esci.Location = new Point(56, 255);
            btn_Esci.Name = "btn_Esci";
            btn_Esci.Size = new Size(129, 33);
            btn_Esci.TabIndex = 3;
            btn_Esci.Text = "Esci";
            btn_Esci.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 203, 82);
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_GestioneBottoni);
            Controls.Add(pct_Logo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pct_Logo).EndInit();
            pnl_GestioneBottoni.ResumeLayout(false);
            pnl_GestioneBottoni.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pct_Logo;
        private Button btn_IniziaAGiocare;
        private Panel pnl_GestioneBottoni;
        private Button btn_Esci;
        private Label lbl_MusicaTitolo;
        private Controls.Switch swt_Musica;
    }
}