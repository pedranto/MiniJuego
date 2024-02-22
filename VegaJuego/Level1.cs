using System.Media;

namespace VegaJuego
{
    public partial class LabelVida : Form
    {
        Link Player;
        Broncas Enemigo1;
        SoundPlayer musica;
        Boolean haySonido=false;
        public LabelVida(CheckBox onOff)
        {
            InitializeComponent();
            IniciarPersonajes();
            IniciarOpcionesDelMapa(onOff);
        }

        private void IniciarOpcionesDelMapa(CheckBox onOff)
        {
            if (onOff.Checked==true)
            {
                musica = new SoundPlayer(global::VegaJuego.Properties.Resources.sonido);
            }
            labelViida.Text = "Salud->" + Player.Salud;
            labelEscudo.Text="Escudo->"+Player.Escudo;
            labelArma.Text = "Arma->" + Player.Arma;
        }
        private void IniciarPersonajes()
        {
            // Lienzo, coordenadaX, coordenadaY, salud, escudo, arma
            Player = new Link(this, 0, 0, 30, 0, 0);
            Enemigo1 = new Broncas(this, 0, 300);
        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Player.mover(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelViida.Text = "Salud->" + Player.Salud;
            labelEscudo.Text = "Escudo->" + Player.Escudo;
            labelArma.Text = "Arma->" + Player.Arma;
            if (Player.Caja.Bounds.IntersectsWith(Enemigo1.Caja.Bounds))
            {
                Player.Salud = Player.Salud - 1;
            }

            Enemigo1.mover();

            if(Player.Salud <= 0) 
            {
                this.Hide();
                if (haySonido == true)
                {
                    musica.Stop();
                }
                Final end = new Final();
                // Paramos el temporizador
                MovEnemigoss.Stop();
                end.Show();

            }
        }

    }
}
