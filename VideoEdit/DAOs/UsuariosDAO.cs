using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEdit.DAOs
{
    class UsuariosDAO
    {
        private static List<Usuario> usuarios = new List<Usuario>();
        public static void iniciar()
        {
            usuarios.Add(new Usuario("Simon", "123"));
            usuarios.Add(new Usuario("admin", "admin"));
            usuarios.Add(new Usuario("pepito", "gomez"));
        }
        

        public static bool existeUsuario(String usuario,String contraseña)
        {
            return usuarios.Find(user => user.nombreUsuario == usuario && user.contraseña == contraseña)!=null;
        }
    }
}
