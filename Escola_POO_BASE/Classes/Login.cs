using Escola_POO_BASE.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_POO_BASE.Classes
{
    internal class Login
    {
        #region Propriedades
        public string Email { get; set; }
        public string Senha { get; set; }
        #endregion

        #region Construtores
        public Login()
        {
            
        }

        public Login(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }


        #endregion

        #region Métodos

        public void BtnLogin()
        {
            Login login = new Login();  
            
            if (Email == "admin@admin" && Senha == "123")
            {
                //MessageBox.Show("Login realizado com êxito!");
                TelaPrincipal tlPrincipal = new TelaPrincipal();
                
                tlPrincipal.Show();
            }
            else
            {
                
                MessageBox.Show("Login negado. Verifique o e-mail e a senha.");

            }
            
        }

        #endregion
    }
}
