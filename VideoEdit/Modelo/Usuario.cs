using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEdit.DAOs {
    class Usuario {
        public String nombreUsuario { get; set; }
        public String contraseña { get; set; }

        public Usuario(String usuario, String contraseña) {
            nombreUsuario = usuario;
            this.contraseña = contraseña;
        }
    }
}
