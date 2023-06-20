using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notificacao
{
    /// <summary>
    /// Formulario de notificação
    /// Cores:
    /// 
    /// Sucesso:
    ///     "Cor de Fundo" = BackColor: LightGreen
    ///     "Cor do texto" = ForeColor: SeaGreen
    /// 
    /// Erro:
    /// 	"Cor de Fundo" = BackColor: LightPink
    /// 	"Cor do texto" = ForeColor: DarkRed
    /// 
    /// Aviso:
    /// 	"Cor de Fundo" = BackColor: LightGoldenrodYellow
    /// 	"Cor do texto" = ForeColor: Goldenrod
    /// 
    /// Informação:
    /// 	"Cor de Fundo" = BackColor: LightBlue
    /// 	"Cor do texto" = ForeColor: DodgerBlue
    /// 	
    /// </summary>
    public partial class Alertas : Form
    {
        #region Variaveis/Propriedades
        public Color BackColorAlerta
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        public Color ColorLinhaAlerta
        {
            get { return this.linhaAlerta.BackColor; }
            set { this.linhaAlerta.BackColor = tituloAlerta.ForeColor = textoAlerta.ForeColor = value; }
        }

        public Image IconeAlerta
        {
            get { return pbAlerta.Image; }
            set { this.pbAlerta.Image = value; }
        }
        public string TituloAlerta
        {
            get { return tituloAlerta.Text; }
            set { this.tituloAlerta.Text = value; }
        }
        public string TextoAlerta
        {
            get { return textoAlerta.Text; }
            set { this.textoAlerta.Text = value; }
        }
        #endregion 

        #region Construtor
        public Alertas()
        {
            InitializeComponent();
        }
        #endregion 

        #region Métodos
        /// <summary>
        /// Define a posição do alerta na area de trabalho
        /// </summary>
        private void PositionAlerta()
        {
            int xPos = 0;
            int yPos = 0;

            xPos = Screen.GetWorkingArea(this).Width;
            yPos = Screen.GetWorkingArea(this).Height;
            this.Location = new Point(x: xPos - this.Width, y: yPos - this.Height);
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Evento de carregamento da barra do alerta.
        /// *** OBS: Para determinar o tempo de vida do alerta alterar "linhaAlerta.Width = linhaAlerta.Width + 5" ***
        /// *** OBS: Quanto maior o numero a ser acrescentado mais rapido será o fechamento do alerta. ***
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerAnimacao_Tick(object sender, EventArgs e)
        {
            linhaAlerta.Width = linhaAlerta.Width + 5;
            while (linhaAlerta.Width >= 500)
            {
                this.Close();
                break;
            }
        }

        private void Alertas_Load(object sender, EventArgs e)
        {
            PositionAlerta();
            for (int i = 0; i < 500; i++)
            {
                timerAnimacao.Start();
            }
        }
        #endregion Eventos

        #region Botão
        /// <summary>
        /// Método que fecha o alerta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Método para abrir o alerta 

        /// <summary>
        /// Método para abrir o alerta
        /// *** OBS: Este método deve ser criado na classe que irá consumir/chamar o alerta ***
        /// </summary>
        /// <param name="backColor"></param> Define a cor de fundo do alerta
        /// <param name="linhaAlertaColor"></param> Define a cor da linha do alerta (Utilizar a mesma cor 'ForeColor' para manter a harmonia entre as cores)
        /// <param name="titulo"></param> Define o título do alerta
        /// <param name="texto"></param> Define o texto do corpo do alerta
        /// <param name="icone"></param> Define o icone que será exibido no alerta
        /// 

        //void AbrirAlerta(Color backColor, Color linhaAlertaColor, string titulo, string texto, Image icone)
        //{
        //    Alertas alerta = new Alertas();
        //    alerta.BackColor = backColor;
        //    alerta.ColorLinhaAlerta = linhaAlertaColor;
        //    alerta.TituloAlerta = titulo;
        //    alerta.TextoAlerta = texto;
        //    alerta.IconeAlerta = icone;
        //    alerta.Show();

        //}
        #endregion

    }
}
