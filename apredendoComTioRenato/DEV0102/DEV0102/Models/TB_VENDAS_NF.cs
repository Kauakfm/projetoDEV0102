using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEV0102.Models
{
    public class TB_VENDAS_NF
    {
        public Nullable<int> Id_Importacao { get; set; }
        public string tipo { get; set; }
        public string dtemissao { get; set; }
        public string status { get; set; }
        public string material { get; set; }
        public string segmento { get; set; }
        public string nf { get; set; }
        public string nro_serie { get; set; }
        public string nome_cliente { get; set; }
        public string uf_cliente { get; set; }
        public string filial_venda { get; set; }
        public string flial_nota { get; set; }
        public string modelo { get; set; }
        public string grupo { get; set; }
        public string segmento_cliente { get; set; }
        public string vendedor { get; set; }
        public string volume { get; set; }
        public string preco_venda { get; set; }
        public string tot_receita { get; set; }
        public string icms { get; set; }
        public string icms_presumido { get; set; }
        public string difal { get; set; }
        public string pis { get; set; }
        public string cofins { get; set; }
        public string tot_impostos { get; set; }
        public string receita_liq { get; set; }
        public string cmv { get; set; }
        public string margem_bruta { get; set; }
        public string perc_margem { get; set; }
        public System.DateTime DataCad { get; set; }
        public Nullable<int> leilaoId { get; set; }
        public string cidade_origem { get; set; }
        public string uf_origem { get; set; }
        public string cidade_destino { get; set; }
        public string uf_destino { get; set; }
        public string centro_resultado { get; set; }
        public string tipo_frete { get; set; }

    }
}