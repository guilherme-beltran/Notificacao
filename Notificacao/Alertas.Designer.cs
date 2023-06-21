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
            linhaAlerta = new Panel();
            timerAnimacao = new System.Windows.Forms.Timer(components);
            btnFechar = new PictureBox();
            imageList1 = new ImageList(components);
            textoAlerta = new Label();
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
            // linhaAlerta
            // 
            linhaAlerta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linhaAlerta.BackColor = Color.Black;
            linhaAlerta.Location = new Point(0, 99);
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
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "detalhes.png");
            // 
            // textoAlerta
            // 
            textoAlerta.AutoSize = true;
            textoAlerta.Location = new Point(77, 53);
            textoAlerta.Name = "textoAlerta";
            textoAlerta.Size = new Size(110, 21);
            textoAlerta.TabIndex = 6;
            textoAlerta.Text = "Texto do alerta";
            // 
            // Alertas
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(500, 105);
            Controls.Add(btnFechar);
            Controls.Add(linhaAlerta);
            Controls.Add(tituloAlerta);
            Controls.Add(pbAlerta);
            Controls.Add(textoAlerta);
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
        private Panel linhaAlerta;
        private System.Windows.Forms.Timer timerAnimacao;
        private PictureBox btnFechar;
        private ImageList imageList1;
        private Label textoAlerta;
    }
}