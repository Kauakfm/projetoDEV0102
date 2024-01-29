using DEV0102.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEV0102.DAL
{
    public class VendasNFDAL
    {
        public bool InserirVendasNF(TB_VENDAS_NF vendasNF)
        {
            bool isSalvo = false;
            using (DEV0102Entities ctx = new DEV0102Entities())
            {

                ctx.TB_VENDAS_NF.Add(vendasNF);
                    ctx.SaveChanges();
                    isSalvo = true;
            }
            return isSalvo;
        }
    }
}