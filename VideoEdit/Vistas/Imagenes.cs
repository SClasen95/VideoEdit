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
    public partial class Imagenes : Form
    {
        public Imagenes()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var result = this.numScroll.Text;
            Ffmpeg.extraerImagenes(result);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
