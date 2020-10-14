using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoEdit.FFMPEG;

namespace VideoEdit.Vistas
{
    public partial class Resolution : Form
    {
        Form formularioCreador;
        public Resolution(FormPrograma f)
        {
            formularioCreador = f;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var result = this.cbxResolution.Text;
            Ffmpeg.cambiarResolucion(result);
            this.Close();
        }
    }
}
