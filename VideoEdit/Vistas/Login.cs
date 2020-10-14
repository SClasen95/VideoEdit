using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoEdit.DAOs;

namespace VideoEdit
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UsuariosDAO.existeUsuario(txtUsername.Text,txtPassword.Text)){
                var form = new FormPrograma(this);
                form.Show();
                this.Hide();

            }else{
                var result = MessageBox.Show("El usuario o la contraseña estan incorrectos.", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
            this.Close();
            }
        }

        public new void Show()
        {
            base.Show();
            this.txtUsername.Clear();
            this.txtPassword.Clear();
        }
        
    }
}
