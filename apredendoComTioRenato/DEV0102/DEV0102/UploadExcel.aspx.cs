using DEV0102.DAL;
using DEV0102.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEV0102
{
    public partial class UploadExcel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string ConvertParaString(object prTexto)
        {

            var ConteudoRetorno = "";

            if (prTexto != null)
            {
                ConteudoRetorno = prTexto.ToString();
            }

            return ConteudoRetorno;
        }

        protected void btnUpload_Click1(object sender, EventArgs e)
        {
            if (!Upload.HasFile)
                return;


            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            if (!Directory.Exists("C:/inetpub/wwwroot/images"))
                    Directory.CreateDirectory("C:/inetpub/wwwroot/images");

            string pattern = @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s.]";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            string filergx = rgx.Replace(Upload.FileName, replacement);

            var fileName = $"{DateTime.Now.ToString("dd_MM_yyyy_hh_mm")}_{filergx.Replace(" ", "")}";
            Upload.PostedFile.SaveAs("C:/inetpub/wwwroot/images/" + fileName);
            int salvos = 0;
            int totalLinhas = 0;

            using (ExcelPackage package = new ExcelPackage("C:/inetpub/wwwroot/images/" + "\\" + fileName))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int colCount = worksheet.Dimension.End.Column;
                int rownCount = worksheet.Dimension.End.Row;
                totalLinhas = rownCount - 1;

                int id_importacao = 1;
                for (int row = 2; row <= rownCount; row++)
                {
                    TB_VENDAS_NF objVendaNf = new TB_VENDAS_NF();

                    objVendaNf.Id_Importacao = id_importacao;
                    objVendaNf.tipo = ConvertParaString(worksheet.Cells[row, 1].Value);
                    objVendaNf.dtemissao = ConvertParaString(worksheet.Cells[row, 2].Value);
                    objVendaNf.status = ConvertParaString(worksheet.Cells[row, 3].Value);
                    objVendaNf.material = ConvertParaString(worksheet.Cells[row, 4].Value);
                    objVendaNf.segmento = ConvertParaString(worksheet.Cells[row, 5].Value);
                    objVendaNf.nf = ConvertParaString(worksheet.Cells[row, 6].Value);
                    objVendaNf.nro_serie = ConvertParaString(worksheet.Cells[row, 7].Value);
                    objVendaNf.nome_cliente = ConvertParaString(worksheet.Cells[row, 8].Value);
                    objVendaNf.uf_cliente = ConvertParaString(worksheet.Cells[row, 9].Value);
                    objVendaNf.filial_venda = ConvertParaString(worksheet.Cells[row, 10].Value);
                    objVendaNf.modelo = ConvertParaString(worksheet.Cells[row, 11].Value);
                    objVendaNf.grupo = ConvertParaString(worksheet.Cells[row, 12].Value);
                    objVendaNf.segmento_cliente = ConvertParaString(worksheet.Cells[row, 13].Value);
                    objVendaNf.vendedor = ConvertParaString(worksheet.Cells[row, 14].Value);
                    objVendaNf.volume = ConvertParaString(worksheet.Cells[row, 15].Value);
                    objVendaNf.preco_venda = ConvertParaString(worksheet.Cells[row, 16].Value);
                    objVendaNf.tot_receita = ConvertParaString(worksheet.Cells[row, 17].Value);
                    objVendaNf.icms = ConvertParaString(worksheet.Cells[row, 18].Value);
                    objVendaNf.icms_presumido = ConvertParaString(worksheet.Cells[row, 19].Value);
                    objVendaNf.difal = ConvertParaString(worksheet.Cells[row, 20].Value);
                    objVendaNf.pis = ConvertParaString(worksheet.Cells[row, 21].Value);
                    objVendaNf.cofins = ConvertParaString(worksheet.Cells[row, 22].Value);
                    objVendaNf.tot_impostos = ConvertParaString(worksheet.Cells[row, 23].Value);
                    objVendaNf.receita_liq = ConvertParaString(worksheet.Cells[row, 24].Value);
                    objVendaNf.cmv = ConvertParaString(worksheet.Cells[row, 25].Value);
                    objVendaNf.margem_bruta = ConvertParaString(worksheet.Cells[row, 26].Value);
                    objVendaNf.perc_margem = ConvertParaString(worksheet.Cells[row, 27].Value);
                    objVendaNf.DataCad = DateTime.Now;

                    VendasNFDAL objnfeDal = new VendasNFDAL();

                    if (objnfeDal.InserirVendasNF(objVendaNf))
                    {
                        salvos++;
                    }
                }
                //vendasNFDAL.AtualizarHistorico(fileName, totalLinhas, salvos);
            }
            lbDeuCerto.Text = ("Planilha com " + totalLinhas.ToString() + " registros, " + salvos.ToString() + " foram salvos.");
        }
    }
}