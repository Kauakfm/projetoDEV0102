using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("cteProc", Namespace = "http://www.portalfiscal.inf.br/cte")]
public class CteProc
{
    [XmlElement("CTe", Namespace = "http://www.portalfiscal.inf.br/cte")]
    public CTe CTe { get; set; }
   
}

public class CTe
{
    [XmlElement("infCte")]
    public InfCte InfCte { get; set; }

    [XmlElement(ElementName = "infCTeSupl")]
    public InfCTeSupl infCTeSupl { get; set; }

    [XmlElement("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public Signature Signature { get; set; }

}

public class InfCte
{
    [XmlElement(ElementName = "ide")]
    public Ide Ide { get; set; }

    [XmlElement(ElementName = "compl")]
    public Compl Compl { get; set; }

    [XmlElement(ElementName = "emit")]
    public Emit Emit { get; set; }

    [XmlElement(ElementName = "rem")]
    public Rem Rem { get; set; }

    [XmlElement(ElementName = "dest")]
    public Dest Dest { get; set; }

    [XmlElement(ElementName = "vPrest")]
    public VPrest VPrest { get; set; }

    [XmlElement(ElementName = "imp")]
    public Imp Imp { get; set; }

    [XmlElement(ElementName = "infCTeNorm")]
    public InfCTeNorm InfCTeNorm { get; set; }
}

public class Ide
{
    public string cUF { get; set; }
    public string cCT { get; set; }
    public string CFOP { get; set; }
    public string natOp { get; set; }
    public string mod { get; set; }
    public string serie { get; set; }
    public string nCT { get; set; }
    public string dhEmi { get; set; }
    public string tpImp { get; set; }
    public string tpEmis { get; set; }
    public string cDV { get; set; }
    public string tpAmb { get; set; }
    public string tpCTe { get; set; }
    public string procEmi { get; set; }
    public string verProc { get; set; }
    public string cMunEnv { get; set; }
    public string xMunEnv { get; set; }
    public string UFEnv { get; set; }
    public string modal { get; set; }
    public string tpServ { get; set; }
    public string cMunIni { get; set; }
    public string xMunIni { get; set; }
    public string UFIni { get; set; }
    public string cMunFim { get; set; }
    public string xMunFim { get; set; }
    public string UFFim { get; set; }
    public string retira { get; set; }
    public string xDetRetira { get; set; }
    public string indIEToma { get; set; }

    [XmlElement(ElementName = "toma4")]
    public CTTomador4 Tomador4 { get; set; }
}

public class CTTomador4
{
    public string toma { get; set; }
    public string CNPJ { get; set; }
    public string IE { get; set; }
    public string xNome { get; set; }
    public string xFant { get; set; }
    public string fone { get; set; }

    [XmlElement(ElementName = "enderToma")]
    public CTEnderToma enderToma { get; set; }
}

public class CTEnderToma
{
    public string xLgr { get; set; }
    public string nro { get; set; }
    public string xCpl { get; set; }
    public string xBairro { get; set; }
    public string cMun { get; set; }
    public string xMun { get; set; }
    public string CEP { get; set; }
    public string UF { get; set; }
    public string cPais { get; set; }
    public string xPais { get; set; }
}
public class Compl
{
    public string xObs { get; set; }
}

public class Emit
{
    public string CNPJ { get; set; }
    public string IE { get; set; }
    public string xNome { get; set; }
    public string xFant { get; set; }
    public EnderEmit EnderEmit { get; set; }
}

public class EnderEmit
{
    public string xLgr { get; set; }
    public string nro { get; set; }
    public string xBairro { get; set; }
    public string cMun { get; set; }
    public string xMun { get; set; }
    public string CEP { get; set; }
    public string UF { get; set; }
    public string fone { get; set; }
}
public class Rem
{
    public string CNPJ { get; set; }
    public string IE { get; set; }
    public string xNome { get; set; }
    public string xFant { get; set; }
    public string fone { get; set; }
    public EnderReme EnderReme { get; set; }
}

public class EnderReme
{
    public string xLgr { get; set; }
    public string nro { get; set; }
    public string xBairro { get; set; }
    public string cMun { get; set; }
    public string xMun { get; set; }
    public string CEP { get; set; }
    public string UF { get; set; }
    public string cPais { get; set; }
    public string xPais { get; set; }
}

public class Dest
{
    public string CNPJ { get; set; }
    public string IE { get; set; }
    public string xNome { get; set; }
    public string fone { get; set; }
    public EnderDest EnderDest { get; set; }
}

public class EnderDest
{
    public string xLgr { get; set; }
    public string nro { get; set; }
    public string xBairro { get; set; }
    public string cMun { get; set; }
    public string xMun { get; set; }
    public string CEP { get; set; }
    public string UF { get; set; }
    public string cPais { get; set; }
    public string xPais { get; set; }
}

public class VPrest
{
    public string vTPrest { get; set; }
    public string vRec { get; set; }
    public Comp Comp { get; set; }
}

public class Comp
{
    public string xNome { get; set; }
    public string vComp { get; set; }
}

public class Imp
{
    public ICMS ICMS { get; set; }
}

public class ICMS
{
    public ICMS00 ICMS00 { get; set; }
}

public class ICMS00
{
    public string CST { get; set; }
    public string vBC { get; set; }
    public string pICMS { get; set; }
    public string vICMS { get; set; }
}

public class InfCTeNorm
{
    [XmlElement(ElementName = "infCarga")]
    public InfCarga InfCarga { get; set; }
    [XmlElement(ElementName = "infDoc")]
    public InfDoc InfDoc { get; set; }
    [XmlElement(ElementName = "infModal")]
    public InfModal InfModal { get; set; }
}

public class InfCarga
{
    public string vCarga { get; set; }
    public string proPred { get; set; }
    public List<InfQ> InfQ { get; set; }
    public string vCargaAverb { get; set; }
}

public class InfQ
{
    public string cUnid { get; set; }
    public string tpMed { get; set; }
    public string qCarga { get; set; }
}

public class InfDoc
{
    [XmlElement(ElementName = "infNFe")]
    public InfNFe InfNFe { get; set; }
}

public class InfNFe
{
    public string chave { get; set; }
    public string dPrev { get; set; }
}

public class InfModal
{
    [XmlAttribute(AttributeName = "versaoModal")]
    public string VersaoModal { get; set; }
    [XmlElement(ElementName = "rodo")]
    public Rodoviario Rodoviario { get; set; }
}

public class Rodoviario
{
    public string RNTRC { get; set; }
}
public class InfCTeSupl
{
    public string qrCodCTe { get; set; }
}

[XmlRoot(Namespace = "http://www.w3.org/2000/09/xmldsig#", ElementName = "Signature")]
public class Signature
{
    [XmlElement(ElementName = "SignedInfo")]
    public SignedInfo SignedInfo { get; set; }
    public string SignatureValue { get; set; }
    [XmlElement(ElementName = "KeyInfo")]
    public KeyInfo KeyInfo { get; set; }
}

public class SignedInfo
{

    public CanonicalizationMethod CanonicalizationMethod { get; set; }
    public string SignatureMethod { get; set; }
    [XmlElement(ElementName = "Reference")]
    public Reference Reference { get; set; }
}

public class CanonicalizationMethod
{
    [XmlAttribute]
    public string Algorithm { get; set; }
}

public class Reference
{
    [XmlAttribute]
    public string URI { get; set; }

    public List<Transform> Transforms { get; set; }
    public DigestMethod DigestMethod { get; set; }
    public string DigestValue { get; set; }
}

public class Transform
{
    [XmlAttribute]
    public string Algorithm { get; set; }
}

public class DigestMethod
{
    [XmlAttribute]
    public string Algorithm { get; set; }
}

public class KeyInfo
{
    public X509Data X509Data { get; set; }
}

public class X509Data
{
    public string X509Certificate { get; set; }
}