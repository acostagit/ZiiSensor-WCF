using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZiiSensor.UI.Autenticacao
{
    public partial class Login : System.Web.UI.Page
    {
        Negocio.Usuario usuarioBus = new Negocio.Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var login = txtLogin.Text.Trim();
            var senha = "1234";
            var usuario = usuarioBus.ObterPorLoginSenha(login, senha);

            if (!string.IsNullOrEmpty(usuario.Login) || (string.IsNullOrEmpty(usuario.Senha)))
            {
                Response.Redirect("../Dashboard.aspx");
            }

        }
    }
}