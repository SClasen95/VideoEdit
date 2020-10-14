using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoEdit.Modelo;

namespace VideoEdit.FFMPEG {
    class Ffmpeg {
        public static String rutaVideoCargado { get; set; }
        private static ProcessStartInfo procStartInfo;
        public static void abrirConsola(String cmd) {
            procStartInfo = new ProcessStartInfo("cmd.exe", "/c " + cmd);
            procStartInfo.CreateNoWindow = true;
            procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(procStartInfo);
        }
        public static void cargarVideo(String ruta) {
            //abrirConsola($"copy {ruta} C:\\Users\\Simon\\source\\repos\\VideoEdit\\VideoEdit\\Videos\\input.{extraerFormato(ruta)}");
            rutaVideoCargado = ruta;
        }

        public static void cambiarResolucion(string resolucionNueva) {
            var cmd = $"ffmpeg -i \"{rutaVideoCargado}\" -vf scale={Utilidades.reemplazarCaracter(resolucionNueva, 'x', ':')} \"{Utilidades.conseguirRuta(rutaVideoCargado)}\\{Utilidades.extraerNombre(rutaVideoCargado)} ({resolucionNueva}).{Utilidades.extraerFormato(rutaVideoCargado)}\"";
            abrirConsola(cmd);
        }

        public static void cambiarFormato(String formatoNuevo) {
            var cmd = $"ffmpeg -i \"{rutaVideoCargado}\" \"{Utilidades.removerFormato(rutaVideoCargado)}.{formatoNuevo}\"";
            abrirConsola(cmd);
        }

        public static void extraerAudio() {
            var cmd = $"ffmpeg -i \"{rutaVideoCargado}\" -vn -acodec copy \"{Utilidades.conseguirRuta(rutaVideoCargado)}\\{Utilidades.extraerNombre(rutaVideoCargado)}.aac\"";
            abrirConsola(cmd);
        }
        public static void removerAudio() {
            var cmd = $"ffmpeg -i \"{rutaVideoCargado}\" -c copy -an \"{Utilidades.cambiarNombre(rutaVideoCargado, Utilidades.extraerNombre(rutaVideoCargado) + " (sin audio)")}\"";
            abrirConsola(cmd);
        }

        public static void extraerImagenes(string t) {

            var cmd = $"ffmpeg -i \"{rutaVideoCargado}\" -r {Utilidades.reemplazarCaracter(t, ',', '.')} \"{Utilidades.conseguirRuta(rutaVideoCargado)}\\{Utilidades.extraerNombre(rutaVideoCargado)} (%04d).png\"";
            abrirConsola(cmd);
        }





    }
}
