namespace Notificacao
{
    public partial class FrmPrincipal : Form
    {

        #region Construtor
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Botões
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSucesso_Click(object sender, EventArgs e)
        {
            AbrirAlerta(backColor: Color.LightGreen, linhaAlertaColor: Color.SeaGreen, titulo: "Sucesso", texto: "Operação realizada com sucesso!", icone: Properties.Resources.sucesso);
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            AbrirAlerta(backColor: Color.LightPink, linhaAlertaColor: Color.DarkRed, titulo: "Erro", texto: "Ocorreu um erro nessa operação.", icone: Properties.Resources.erro);
        }

        private void btnAviso_Click(object sender, EventArgs e)
        {
            AbrirAlerta(backColor: Color.LightGoldenrodYellow, linhaAlertaColor: Color.Goldenrod, titulo: "Aviso", texto: "Tem certeza de que deseja realizar essa operação?", icone: Properties.Resources.aviso);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            AbrirAlerta(backColor: Color.LightBlue, linhaAlertaColor: Color.DodgerBlue, titulo: "Informação", texto: "Operação em progresso.", icone: Properties.Resources.informacoes);
        }
        #endregion

        #region Métodos

        void AbrirAlerta(Color backColor, Color linhaAlertaColor, string titulo, string texto, Image icone)
        {
            Alertas alerta = new Alertas();
            alerta.BackColor = backColor;
            alerta.ColorLinhaAlerta = linhaAlertaColor;
            alerta.TituloAlerta = titulo;
            alerta.TextoAlerta = texto;
            alerta.IconeAlerta = icone;
            alerta.Show();

        }
        #endregion

    }
}