namespace VegaJuego
{
    public partial class Level1 : Form
    {
        Link Player;
        public Level1()
        {
            InitializeComponent();
            IniciarPersonajes();
        }

        private void IniciarPersonajes()
        {
            // Lienzo, coordenadaX, coordenadaY, salud, escudo, arma
            Player = new Link(this, 0, 0, 30, 0, 0);
        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Player.mover(e);
        }
    }
}
