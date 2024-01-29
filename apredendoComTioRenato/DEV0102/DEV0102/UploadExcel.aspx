<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadExcel.aspx.cs" Inherits="DEV0102.UploadExcel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div class="row">
                            <div>
                                <asp:Label runat="server" ID="lbDeuCerto"></asp:Label>
                                <asp:FileUpload CssClass="form-control file" ID="Upload" runat="server" />
                                <br />
                                <asp:Button CssClass="form-control bt" runat="server" Text="Carregar arquivo" OnClick="btnUpload_Click1" ID="btexecutar" OnClientClick="javascript: OcultarBotoes();" />
                                <br />
                              
                                <br />

                                <button type="button" class="btn btn-primary" onclick="downloadNFVenda('https://portal.plataformabmc.com.br/PlataformaBMCArquivos/UploadVendaNF.xlsx')" runat="server" id="btmodelo">Download Planilha Modelo</button>
                                <br />

                            </div>
                        </div>
        </div>
    </form>
</body>
</html>
