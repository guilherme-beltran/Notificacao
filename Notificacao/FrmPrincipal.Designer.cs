namespace Notificacao
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            btnFechar = new PictureBox();
            btnSucesso = new Button();
            btnErro = new Button();
            btnAviso = new Button();
            btnInfo = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnFechar).BeginInit();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Image = (Image)resources.GetObject("btnFechar.Image");
            btnFechar.Location = new Point(333, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(24, 26);
            btnFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnFechar.TabIndex = 0;
            btnFechar.TabStop = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnSucesso
            // 
            btnSucesso.BackColor = Color.LightGreen;
            btnSucesso.Cursor = Cursors.Hand;
            btnSucesso.FlatAppearance.BorderSize = 0;
            btnSucesso.FlatStyle = FlatStyle.Flat;
            btnSucesso.ForeColor = Color.SeaGreen;
            btnSucesso.Location = new Point(26, 99);
            btnSucesso.Margin = new Padding(0);
            btnSucesso.Name = "btnSucesso";
            btnSucesso.Size = new Size(150, 35);
            btnSucesso.TabIndex = 1;
            btnSucesso.Text = "Sucesso";
            btnSucesso.UseVisualStyleBackColor = false;
            btnSucesso.Click += btnSucesso_Click;
            // 
            // btnErro
            // 
            btnErro.BackColor = Color.LightPink;
            btnErro.Cursor = Cursors.Hand;
            btnErro.FlatAppearance.BorderSize = 0;
            btnErro.FlatStyle = FlatStyle.Flat;
            btnErro.ForeColor = Color.DarkRed;
            btnErro.Location = new Point(191, 99);
            btnErro.Margin = new Padding(0);
            btnErro.Name = "btnErro";
            btnErro.Size = new Size(150, 35);
            btnErro.TabIndex = 2;
            btnErro.Text = "Erro";
            btnErro.UseVisualStyleBackColor = false;
            btnErro.Click += btnErro_Click;
            // 
            // btnAviso
            // 
            btnAviso.BackColor = Color.LightGoldenrodYellow;
            btnAviso.Cursor = Cursors.Hand;
            btnAviso.FlatAppearance.BorderSize = 0;
            btnAviso.FlatStyle = FlatStyle.Flat;
            btnAviso.ForeColor = Color.Goldenrod;
            btnAviso.Location = new Point(26, 154);
            btnAviso.Margin = new Padding(0);
            btnAviso.Name = "btnAviso";
            btnAviso.Size = new Size(150, 35);
            btnAviso.TabIndex = 3;
            btnAviso.Text = "Aviso";
            btnAviso.UseVisualStyleBackColor = false;
            btnAviso.Click += btnAviso_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.LightBlue;
            btnInfo.Cursor = Cursors.Hand;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.ForeColor = Color.DodgerBlue;
            btnInfo.Location = new Point(191, 154);
            btnInfo.Margin = new Padding(0);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(150, 35);
            btnInfo.TabIndex = 4;
            btnInfo.Text = "Informação";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(141, 45);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 5;
            label1.Text = "Alertas";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(369, 239);
            Controls.Add(label1);
            Controls.Add(btnInfo);
            Controls.Add(btnAviso);
            Controls.Add(btnErro);
            Controls.Add(btnSucesso);
            Controls.Add(btnFechar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)btnFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnFechar;
        private Button btnSucesso;
        private Button btnErro;
        private Button btnAviso;
        private Button btnInfo;
        private Label label1;
    }
}