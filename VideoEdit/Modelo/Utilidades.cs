using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEdit.Modelo
{
    class Utilidades
    {
        public static String extraerFormato(String archivo)
        {
            return archivo.Split('.').Last();
        }
        public static String removerFormato(String archivo)
        {
            return archivo.Split('.')[0];
        }
        public static String cambiarNombre(String archivo, String nombreNuevo)
        {
            return $"{conseguirRuta(archivo)}{nombreNuevo}.{extraerFormato(archivo)}";
        }
        public static String extraerNombre(String archivo)
        {
            return archivo.Split('\\').Last().Split('.')[0];
        }
        public static String conseguirRuta(String archivo)
        {
            return archivo.TrimEnd('\\').Remove(archivo.LastIndexOf('\\') + 1);
        }
        public static String reemplazarCaracter(String res, char viejo, char nuevo)
        {
            return res.Replace(viejo, nuevo);
        }
    }
}
