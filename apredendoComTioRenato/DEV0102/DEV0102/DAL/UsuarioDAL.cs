using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEV0102.DAL
{
    public class UsuarioDAL
    {
        public tabUsuario consultarUsuarioPorEmail(string email)
        {
            try
            {
                using (DEV0102Entities ctx = new DEV0102Entities())
                {
                    return ctx.tabUsuario.Where(x => x.email == email).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void cadastrarUsuario(tabUsuario objU)
        {
            using (DEV0102Entities ctx = new DEV0102Entities())
            {

                ctx.tabUsuario.Add(objU);
                ctx.SaveChanges();
            }
        }
    }
}