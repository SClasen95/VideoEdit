using Microsoft.VisualBasic;
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
using VideoEdit.Modelo;
using VideoEdit.Vistas;
using WMPLib;

namespace VideoEdit {
    public partial class FormPrograma : Form {
        FormLogin formularioCreador;
        public FormPrograma(FormLogin f) {
            this.formularioCreador = f;
            InitializeComponent();
        }


        private void cargarVideo(string archivo) {
            Ffmpeg.cargarVideo(archivo);
            this.lblVideoCargado.Text = $"El video cargado es: {Utilidades.extraerNombre(archivo)}.{Utilidades.extraerFormato(archivo)}";
            this.wmpReproductor.URL = archivo;
            prepararVista(true);
        }

        private void cambiarFormato() {
            var form = new FormFormat(this);
            form.Show();
        }

        private void extraerAudio() {
            Ffmpeg.extraerAudio();
            MessageBox.Show("Se Extrajo el audio con exito!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void removerAudio() {
            Ffmpeg.removerAudio();
            MessageBox.Show("Se removio el audio con exito!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "Video files |*.wmv; *.3g2; *.3gp; *.3gp2; *.3gpp; *.amv; *.asf;  *.avi; *.bin; *.cue; *.divx; *.dv; *.flv; *.gxf; *.iso; *.m1v; *.m2v; *.m2t; *.m2ts; *.m4v; " +
                          " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2; *.mts; *.nsv; *.nuv; *.ogg; *.ogm; *.ogv; *.ogx; *.ps; *.rec; *.rm; *.rmvb; *.tod; *.ts; *.tts; *.vob; *.vro; *.webm; *.dat; ";
            buscador.InitialDirectory = "C:\\Users\\Simon\\Desktop\\Pruebas Editor de video";
            String archivo = "";
            buscador.ShowDialog();
            archivo = buscador.FileName;
            if (archivo != "") {
                this.cargarVideo(archivo);
            }
        }

        private void btnCambiarFormato_Click(object sender, EventArgs e) {
            cambiarFormato();
        }

        private void btnExtractAudio_Click(object sender, EventArgs e) {
            extraerAudio();
        }

        private void btnRemoveAudio_Click(object sender, EventArgs e) {
            removerAudio();
        }

        // WIP
        /*private void FormPrograma_KeyDown(object sender, KeyEventArgs e)
        {
            var caseSwitch = e.KeyCode;
            switch (caseSwitch)
            {
                case Keys.R:
                    removerAudio();
                    Console.WriteLine("E");
                    break;
                case Keys.E:
                    extraerAudio();
                    break;
                case Keys.F:
                    cambiarFormato();
                    break;
                default:
                    break;                    
            }
        }*/

        private void quitarVideoToolStripMenuItem_Click(object sender, EventArgs e) {
            this.lblVideoCargado.Text = "No se encontraron videos cargados.";
            Ffmpeg.rutaVideoCargado = "";
            this.wmpReproductor.URL = null;
            prepararVista(false);
        }

        private void prepararVista(bool prep) {
            this.btnCambiarFormato.Enabled = prep;
            this.btnExtractAudio.Enabled = prep;
            this.btnRemoveAudio.Enabled = prep;
            this.btnResolution.Enabled = prep;
            this.btnExtractFrames.Enabled = prep;
            this.quitarVideoToolStripMenuItem.Enabled = prep;
        }


        //WIP
        /*private void habilitarForm(bool prep)
        {
            this.Enabled = prep;
        }*/


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            formularioCreador.Show();
            this.Close();
        }

        private void btnResolution_Click(object sender, EventArgs e) {
            var form = new Resolution(this);
            form.Show();
        }

        private void btnExtractFrames_Click(object sender, EventArgs e) {
            var form = new Imagenes();
            form.Show();
        }

    }
}
