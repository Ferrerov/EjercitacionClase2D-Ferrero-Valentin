using Entidades;
namespace Interfaz
{
    public partial class FormGuerrero : Form
    {
        Guerrero guerrero;
        public FormGuerrero()
        {
            InitializeComponent();
            this.guerrero = new Guerrero();
        }

        private void btnEspada_Click(object sender, EventArgs e)
        {
            this.guerrero.ArmaDeAtaque = new Espada(12,25);
        }

        private void btnHacha_Click(object sender, EventArgs e)
        {
            this.guerrero.ArmaDeAtaque = new Hacha(24,3);
        }

        private void btnArco_Click(object sender, EventArgs e)
        {
            this.guerrero.ArmaDeAtaque = new Arco(3,12);
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            this.lblMensajeAtaque.Text = this.guerrero.ArmaDeAtaque.MensajeDeAtaque();
        }
    }
}