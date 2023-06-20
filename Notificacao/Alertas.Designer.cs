namespace Notificacao
{
    partial class Alertas
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alertas));
            pbAlerta = new PictureBox();
            tituloAlerta = new Label();
            textoAlerta = new Label();
            linhaAlerta = new Panel();
            timerAnimacao = new System.Windows.Forms.Timer(components);
            btnFechar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbAlerta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnFechar).BeginInit();
            SuspendLayout();
            // 
            // pbAlerta
            // 
            pbAlerta.Location = new Point(21, 23);
            pbAlerta.Name = "pbAlerta";
            pbAlerta.Size = new Size(50, 50);
            pbAlerta.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAlerta.TabIndex = 0;
            pbAlerta.TabStop = false;
            // 
            // tituloAlerta
            // 
            tituloAlerta.AutoSize = true;
            tituloAlerta.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            tituloAlerta.Location = new Point(77, 23);
            tituloAlerta.Name = "tituloAlerta";
            tituloAlerta.Size = new Size(71, 30);
            tituloAlerta.TabIndex = 1;
            tituloAlerta.Text = "Titulo";
            // 
            // textoAlerta
            // 
            textoAlerta.AutoSize = true;
            textoAlerta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textoAlerta.Location = new Point(77, 52);
            textoAlerta.Name = "textoAlerta";
            textoAlerta.Size = new Size(110, 21);
            textoAlerta.TabIndex = 2;
            textoAlerta.Text = "Texto do alerta";
            // 
            // linhaAlerta
            // 
            linhaAlerta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linhaAlerta.BackColor = Color.Black;
            linhaAlerta.Location = new Point(0, 94);
            linhaAlerta.Name = "linhaAlerta";
            linhaAlerta.Size = new Size(5, 6);
            linhaAlerta.TabIndex = 3;
            // 
            // timerAnimacao
            // 
            timerAnimacao.Interval = 10;
            timerAnimacao.Tick += timerAnimacao_Tick;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Image = (Image)resources.GetObject("btnFechar.Image");
            btnFechar.Location = new Point(472, 9);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(19, 22);
            btnFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnFechar.TabIndex = 4;
            btnFechar.TabStop = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // Alertas
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(500, 100);
            Controls.Add(btnFechar);
            Controls.Add(linhaAlerta);
            Controls.Add(textoAlerta);
            Controls.Add(tituloAlerta);
            Controls.Add(pbAlerta);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Alertas";
            Load += Alertas_Load;
            ((System.ComponentModel.ISupportInitialize)pbAlerta).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbAlerta;
        private Label tituloAlerta;
        private Label textoAlerta;
        private Panel linhaAlerta;
        private System.Windows.Forms.Timer timerAnimacao;
        private PictureBox btnFechar;
    }
}