Alerta de sucesso:

![Alerta sucesso](https://github.com/guiconkerz/Notificacao/assets/14238319/afccdde7-0378-4f68-b278-905e6143e2bf)

Alerta de Erro:

![Alerta erro](https://github.com/guiconkerz/Notificacao/assets/14238319/3069330e-c503-4e66-a11d-fdc500b8a4c5)

Alerta de Aviso:

![Alerta aviso](https://github.com/guiconkerz/Notificacao/assets/14238319/d0d172a1-1895-4040-9112-2d152e27a5aa)

Alerta de Informação:

![Alerta info](https://github.com/guiconkerz/Notificacao/assets/14238319/63f996f9-bec5-446d-8103-f235a47bfa81)


# Como utilizar?
Para utilizar o alerta deve-se criar um método na classe principal (consumidor do alerta) 

Copiar este código na classe que irá consumir o alerta:

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
  
  Por fim, quando necessário abrir o alerta, deve-se chamar o método AbrirAlerta() passando por parâmetro as informações do alerta.
Exemplo:

        AbrirAlerta(backColor: Color.LightGreen, linhaAlertaColor: Color.SeaGreen, titulo: "Sucesso", texto: "Operação realizada com sucesso!", icone: Properties.Resources.sucesso);

# O que preciso saber?
Este projeto possui um padrão de cores e um padrão de icones. Os ícones estão associados aos recursos do aplicativo, porém podem ser apontados para uma imagem em uma pasta específica.

O padrão de cores é:

    "Sucesso":
        "Cor de Fundo":"BackColor": "LightGreen"
        "Cor do texto":""ForeColor: "SeaGreen",    
    "Erro":
        "Cor de Fundo":"BackColor": "LightPink"
        "Cor do texto":"ForeColor": "DarkRed",        
    "Aviso":
        "Cor de Fundo":"BackColor": "LightGoldenrodYellow"
        "Cor do texto":"ForeColor": "Goldenrod",    
    "Informação":
        "Cor de Fundo":"BackColor": "LightBlue"
        "Cor do texto":"ForeColor": "DodgerBlue"
        
  Os icones encontram-se na pasta "icones" e caso desejar alterar o icone de uma notificação pode-se apontar para uma imagem dentro de uma pasta específica ou vincular sua imagem escolhida nos recursos do aplicativo.
  
  *OBS: Caso a imagem não apareça se estiver sendo utilizado o Properties.Resources, verifique se o SizeMode do PictureBox "pbAlerta" está como StretchImage*
# Posso personaliza-lo?
  Claro! Fique a vontade para personalizar o alerta conforme desejar!
 
# O que posso personalizar?
É possível alterar o tempo de exibição do alerta. Para isso é preciso alterar o evento timerAnimacao_Tick e alterar a linha "*linhaAlerta.Width = linhaAlerta.Width + 5*". Quanto maior o numero, mais tempo ficará sendo exibido.

*OBS: Lembre-se que o width é inteiro, caso deseje utilizar numeros quebrados é necessário converter para double*
