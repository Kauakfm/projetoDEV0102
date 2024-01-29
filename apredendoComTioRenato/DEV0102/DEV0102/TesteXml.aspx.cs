using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

namespace DEV0102
{
    public partial class TesteXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            //   string xmlCte = @"<cteProc xmlns='http://www.portalfiscal.inf.br/cte' versao='3.00'><CTe xmlns='http://www.portalfiscal.inf.br/cte'><infCte versao='3.00' Id='CTe35230807471771000106570010002061931449004043'><ide><cUF>35</cUF><cCT>44900404</cCT><CFOP>5353</CFOP><natOp>PRESTAÇÃO DE SERVIÇO DE TRANSPORTE</natOp><mod>57</mod><serie>1</serie><nCT>206193</nCT><dhEmi>2023-08-09T10:24:20-02:00</dhEmi><tpImp>1</tpImp><tpEmis>1</tpEmis><cDV>3</cDV><tpAmb>1</tpAmb><tpCTe>0</tpCTe><procEmi>0</procEmi><verProc>3.00</verProc><cMunEnv>3513009</cMunEnv><xMunEnv>COTIA</xMunEnv><UFEnv>SP</UFEnv><modal>01</modal><tpServ>0</tpServ><cMunIni>3513009</cMunIni><xMunIni>COTIA</xMunIni><UFIni>SP</UFIni><cMunFim>3513009</cMunFim><xMunFim>COTIA</xMunFim><UFFim>SP</UFFim><retira>0</retira><xDetRetira>ENTREGA DOMICILIO</xDetRetira><indIEToma>1</indIEToma><toma4><toma>4</toma><CNPJ>02625364000192</CNPJ><IE>720046466116</IE><xNome>PACTUALL COMERCIO E DISTRIBUICAO DE ALIMENTOS LTDA</xNome><xFant>PACTUALL COMERCIO E DISTRIBUICAO DE ALIMENTOS LTDA</xFant><fone>1130301710</fone><enderToma><xLgr>RUA CRISTOVAM DE VITA</xLgr><nro>260</nro><xCpl>GALPAO 03</xCpl><xBairro>CENTRO</xBairro><cMun>3556453</cMun><xMun>VARGEM GRANDE PAULISTA</xMun><CEP>06730000</CEP><UF>SP</UF><cPais>1058</cPais><xPais>Brasil</xPais></enderToma></toma4></ide><compl><xObs>Depto.: MKT | C.C: MKT | Nro.Orcamento: 2632675</xObs></compl><emit><CNPJ>07471771000106</CNPJ><IE>278105647112</IE><xNome>POSTALL TRANSPORTE E ARMAZENAGEM LTDA</xNome><xFant>POSTALL TRANSPORTE E ARMAZENAGEM LTDA</xFant><enderEmit><xLgr>RUA JOAO PAULO ABLAS</xLgr><nro>420</nro><xBairro>JD DA GLORIA</xBairro><cMun>3513009</cMun><xMun>COTIA</xMun><CEP>06711250</CEP><UF>SP</UF><fone>1130301710</fone></enderEmit></emit><rem><CNPJ>07471771000378</CNPJ><IE>720040013112</IE><xNome>POSTALL TRANSPORTE ARMAZENAGEM LTDA</xNome><xFant>POSTALL TRANSPORTE ARMAZENAGEM LTDA</xFant><fone>1130301710</fone><enderReme><xLgr>RUA CRISTOVAM DE VITA</xLgr><nro>260</nro><xBairro>CENTRO</xBairro><cMun>3556453</cMun><xMun>VARGEM GRANDE PAULISTA</xMun><CEP>06730000</CEP><UF>SP</UF><cPais>1058</cPais><xPais>Brasil</xPais></enderReme></rem><dest><CNPJ>02625364000273</CNPJ><IE>278376613118</IE><xNome>PACTUALL COM E DISTRIBUICAO DE ALIMENTOS LTDA</xNome><fone>1137893260</fone><enderDest><xLgr>AV JOAO PAULO ABLAS</xLgr><nro>420</nro><xBairro>JARDIM DA GLORIA</xBairro><cMun>3513009</cMun><xMun>COTIA</xMun><CEP>06711250</CEP><UF>SP</UF><cPais>1058</cPais><xPais>Brasil</xPais></enderDest></dest><vPrest><vTPrest>0.01</vTPrest><vRec>0.01</vRec><Comp><xNome>FRETE VALOR</xNome><vComp>0.01</vComp></Comp></vPrest><imp><ICMS><ICMS00><CST>00</CST><vBC>0.01</vBC><pICMS>12.00</pICMS><vICMS>0.00</vICMS></ICMS00></ICMS></imp><infCTeNorm><infCarga><vCarga>833.60</vCarga><proPred>Outros</proPred><infQ><cUnid>01</cUnid><tpMed>PESO BRUTO</tpMed><qCarga>8.0000</qCarga></infQ><infQ><cUnid>01</cUnid><tpMed>PESO TAXADO</tpMed><qCarga>0.0000</qCarga></infQ><infQ><cUnid>01</cUnid><tpMed>PESO AFERIDO</tpMed><qCarga>0.0000</qCarga></infQ><infQ><cUnid>03</cUnid><tpMed>VOLUME</tpMed><qCarga>1.0000</qCarga></infQ><vCargaAverb>0.01</vCargaAverb></infCarga><infDoc><infNFe><chave>35230802625364000192550010000239121173567192</chave><dPrev>2023-08-09</dPrev></infNFe></infDoc><infModal versaoModal='3.00'><rodo><RNTRC>09878455</RNTRC></rodo></infModal></infCTeNorm></infCte><infCTeSupl><qrCodCTe>https://nfe.fazenda.sp.gov.br/CTeConsulta/qrCode?chCTe=35230807471771000106570010002061931449004043&amp;tpAmb=1</qrCodCTe></infCTeSupl><Signature xmlns='http://www.w3.org/2000/09/xmldsig#'><SignedInfo><CanonicalizationMethod Algorithm='http://www.w3.org/TR/2001/REC-xml-c14n-20010315'/><SignatureMethod Algorithm='http://www.w3.org/2000/09/xmldsig#rsa-sha1'/><Reference URI='#CTe35230807471771000106570010002061931449004043'><Transforms><Transform Algorithm='http://www.w3.org/2000/09/xmldsig#enveloped-signature'/><Transform Algorithm='http://www.w3.org/TR/2001/REC-xml-c14n-20010315'/></Transforms><DigestMethod Algorithm='http://www.w3.org/2000/09/xmldsig#sha1'/><DigestValue>Cp89tvinvGqcbcoPU21ibRFJJdo=</DigestValue></Reference></SignedInfo><SignatureValue>SDHG5wU1VQABQP5LYMSmq4TFawCj/jOuzzbz8UW953jlhpXg7mSIWpsOq/hb/uNsh8VDCoBlRyM4mnj+z/csiMwn6AUH4nOHDxno8t0yOEkA7mnBvGGYqZTyPE2TR4eA1kALyvhlytVctnB+BTTcsi/NDQz89SHzbZUa6iF0poOVK0XCjrNiY2LLTQ3cy5EeWSFS7QnhVb0xVgP83VdW1+geBAFm/MieMg7X08eWCPVozhZRAaiqAFUPrF9TroQ2hf7pMYE+fNyiQr59WH9QamY3oWjJfP3sRIaWQFTG9WnTS+uIwqxb2iczSSvDvMJn18ToYZ7hGhOy/PuHrazSog==</SignatureValue><KeyInfo><X509Data>  <X509Certificate>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</X509Certificate></X509Data></KeyInfo></Signature></CTe><protCTe xmlns = 'http://www.portalfiscal.inf.br/cte' versao = '3.00'><infProt><tpAmb>1</tpAmb><verAplic> SP - CTe - 2023 - 08 - 04 - 1 </verAplic><chCTe>35230807471771000106570010002061931449004043</chCTe><dhRecbto> 2023 - 08 - 09T10: 27:08 - 03:00 </dhRecbto><nProt>135238564562373</nProt><digVal>Cp89tvinvGqcbcoPU21ibRFJJdo=</digVal><cStat>100</cStat><xMotivo>Autorizado o uso do CT - e</xMotivo></infProt></protCTe></cteProc>";
            using (DEV0102Entities ctx = new DEV0102Entities())
            {

                var xml = ctx.tabXml.Where(x => x.id == 1).FirstOrDefault();
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(xml.xmlvalue);
                XmlNodeList vTPrest = xmldoc.GetElementsByTagName("vTPrest");
                var valor = vTPrest[0].InnerText.Trim().ToUpper();
                var kawai = decimal.TryParse(valor, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal valorr);
                var kawaiteste = valorr;
                /*
                  tabXml xx = new tabXml();
                  CteProc cte;
                  XmlDocument xmldoc = new XmlDocument();
                  xmldoc.LoadXml(xml.xmlvalue);
                  xmldoc.GetElementsByTagName("vCargaAverb")[0].InnerText = "0.03";
                  using (StringReader stringReader = new StringReader(xml.xmlvalue))
                  {
                      XmlSerializer serializer = new XmlSerializer(typeof(CteProc));
                      cte = (CteProc)serializer.Deserialize(stringReader);
                  }
                  cte.CTe.InfCte.Emit.xNome = "Postall lovers";
                  // Agora você tem o objeto CTe e pode manipulá-lo conforme necessário
                  // Se desejar, pode serializar o objeto novamente para XML
                  using (StringWriter stringWriter = new StringWriter())
                  {
                      XmlSerializer serializer = new XmlSerializer(typeof(CteProc));
                      serializer.Serialize(stringWriter, cte);
                      string xmlResult = stringWriter.ToString();

                      xml.xmlvalue = xmlResult;
                      ctx.SaveChanges();
                  }
                  */
            }
        }
    }
}