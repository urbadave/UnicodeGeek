using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnicodeData
{
    //<group age="unassigned" na="" JSN="" gc="Cn" ccc="0" dt="none" dm="#" nt="None" nv="NaN" bc="BN" bpt="n" bpb="#" Bidi_M="N" bmg="" suc="#" slc="#" stc="#" uc="#" lc="#" tc="#" scf="#" cf="#" jt="U" jg="No_Joining_Group" ea="N" lb="XX" sc="Zzzz" scx="Zzzz" Dash="N" WSpace="N" Hyphen="N" QMark="N" Radical="N" Ideo="N" UIdeo="N" IDSB="N" IDST="N" hst="NA" DI="N" ODI="N" Alpha="N" OAlpha="N" Upper="N" OUpper="N" Lower="N" OLower="N" Math="N" OMath="N" Hex="N" AHex="N" NChar="N" VS="N" Bidi_C="N" Join_C="N" Gr_Base="N" Gr_Ext="N" OGr_Ext="N" Gr_Link="N" STerm="N" Ext="N" Term="N" Dia="N" Dep="N" IDS="N" OIDS="N" XIDS="N" IDC="N" OIDC="N" XIDC="N" SD="N" LOE="N" Pat_WS="N" Pat_Syn="N" GCB="XX" WB="XX" SB="XX" CE="N" Comp_Ex="N" NFC_QC="Y" NFD_QC="Y" NFKC_QC="Y" NFKD_QC="Y" XO_NFC="N" XO_NFD="N" XO_NFKC="N" XO_NFKD="N" FC_NFKC="#" CI="N" Cased="N" CWCF="N" CWCM="N" CWKCF="N" CWL="N" CWT="N" CWU="N" NFKC_CF="#" InSC="Other" InPC="NA" PCM="N" vo="R" RI="N" blk="NB" isc="" na1="" Emoji="N" EPres="N" EMod="N" EBase="N" EComp="N" ExtPict="N">

    public class GroupObj
    {
        #region Attributes
        [XmlAttribute(AttributeName = "age")]
        public string? age { get; set; }

        [XmlAttribute(AttributeName = "na")]
        public string? na { get; set; }

        [XmlAttribute(AttributeName = "JSN")]
        public string? JSN { get; set; }

        [XmlAttribute(AttributeName = "gc")]
        public string? gc { get; set; }

        [XmlAttribute(AttributeName = "ccc")]
        public string? ccc { get; set; }

        [XmlAttribute(AttributeName = "dt")]
        public string? dt { get; set; }

        [XmlAttribute(AttributeName = "dm")]
        public string? dm { get; set; }

        [XmlAttribute(AttributeName = "nt")]
        public string? nt { get; set; }

        [XmlAttribute(AttributeName = "nv")]
        public string? nv { get; set; }

        [XmlAttribute(AttributeName = "bc")]
        public string? bc { get; set; }

        [XmlAttribute(AttributeName = "bpt")]
        public string? bpt { get; set; }

        [XmlAttribute(AttributeName = "bpb")]
        public string? bpb { get; set; }

        [XmlAttribute(AttributeName = "Bidi_M")]
        public string? Bidi_M { get; set; }

        [XmlAttribute(AttributeName = "bmg=")]
        public string? bmg { get; set; }

        [XmlAttribute(AttributeName = "suc")]
        public string? suc { get; set; }

        [XmlAttribute(AttributeName = "slc")]
        public string? slc { get; set; }

        [XmlAttribute(AttributeName = "stc")]
        public string? stc { get; set; }

        [XmlAttribute(AttributeName = "uc")]
        public string? uc { get; set; }

        [XmlAttribute(AttributeName = "lc")]
        public string? lc { get; set; }

        [XmlAttribute(AttributeName = "tc")]
        public string? tc { get; set; }

        [XmlAttribute(AttributeName = "scf")]
        public string? scf { get; set; }

        [XmlAttribute(AttributeName = "cf")]
        public string? cf { get; set; }

        [XmlAttribute(AttributeName = "jt")]
        public string? jt { get; set; }

        [XmlAttribute(AttributeName = "jg")]
        public string? jg { get; set; }

        [XmlAttribute(AttributeName = "ea")]
        public string? ea { get; set; }

        [XmlAttribute(AttributeName = "lb")]
        public string? lb { get; set; }

        [XmlAttribute(AttributeName = "sc")]
        public string? sc { get; set; }

        [XmlAttribute(AttributeName = "scx")]
        public string? scx { get; set; }

        [XmlAttribute(AttributeName = "Dash")]
        public string? Dash { get; set; }

        [XmlAttribute(AttributeName = "WSpace")]
        public string? WSpace { get; set; }

        [XmlAttribute(AttributeName = "Hyphen")]
        public string? Hyphen { get; set; }

        [XmlAttribute(AttributeName = "QMark")]
        public string? QMark { get; set; }

        [XmlAttribute(AttributeName = "Radical")]
        public string? Radical { get; set; }

        [XmlAttribute(AttributeName = "Ideo")]
        public string? Ideo { get; set; }

        [XmlAttribute(AttributeName = "UIdeo")]
        public string? UIdeo { get; set; }

        [XmlAttribute(AttributeName = "IDSB")]
        public string? IDSB { get; set; }

        [XmlAttribute(AttributeName = "IDST")]
        public string? IDST { get; set; }

        [XmlAttribute(AttributeName = "hst")]
        public string? hst { get; set; }

        [XmlAttribute(AttributeName = "DI")]
        public string? DI { get; set; }

        [XmlAttribute(AttributeName = "ODI")]
        public string? ODI { get; set; }

        [XmlAttribute(AttributeName = "Alpha")]
        public string? Alpha { get; set; }

        [XmlAttribute(AttributeName = "OAlpha")]
        public string? OAlpha { get; set; }

        [XmlAttribute(AttributeName = "Upper")]
        public string? Upper { get; set; }

        [XmlAttribute(AttributeName = "OUpper")]
        public string? OUpper { get; set; }

        [XmlAttribute(AttributeName = "Lower")]
        public string? Lower { get; set; }

        [XmlAttribute(AttributeName = "OLower")]
        public string? OLower { get; set; }

        [XmlAttribute(AttributeName = "Math")]
        public string? Math { get; set; }

        [XmlAttribute(AttributeName = "OMath")]
        public string? OMath { get; set; }

        [XmlAttribute(AttributeName = "Hex")]
        public string? Hex { get; set; }

        [XmlAttribute(AttributeName = "AHex")]
        public string? AHex { get; set; }

        [XmlAttribute(AttributeName = "NChar")]
        public string? NChar { get; set; }

        [XmlAttribute(AttributeName = "VS")]
        public string? VS { get; set; }

        [XmlAttribute(AttributeName = "Bidi_C")]
        public string? Bidi_C { get; set; }

        [XmlAttribute(AttributeName = "Join_C")]
        public string? Join_C { get; set; }

        [XmlAttribute(AttributeName = "Gr_Base")]
        public string? Gr_Base { get; set; }

        [XmlAttribute(AttributeName = "Gr_Ext")]
        public string? Gr_Ext { get; set; }

        [XmlAttribute(AttributeName = "OGr_Ext")]
        public string? OGr_Ext { get; set; }

        [XmlAttribute(AttributeName = "Gr_Link")]
        public string? Gr_Link { get; set; }

        [XmlAttribute(AttributeName = "STerm")]
        public string? STerm { get; set; }

        [XmlAttribute(AttributeName = "Ext")]
        public string? Ext { get; set; }

        [XmlAttribute(AttributeName = "Term")]
        public string? Term { get; set; }

        [XmlAttribute(AttributeName = "Dia")]
        public string? Dia { get; set; }

        [XmlAttribute(AttributeName = "Dep")]
        public string? Dep { get; set; }

        [XmlAttribute(AttributeName = "IDS")]
        public string? IDS { get; set; }

        [XmlAttribute(AttributeName = "OIDS")]
        public string? OIDS { get; set; }

        [XmlAttribute(AttributeName = "XIDS")]
        public string? XIDS { get; set; }

        [XmlAttribute(AttributeName = "IDC")]
        public string? IDC { get; set; }

        [XmlAttribute(AttributeName = "OIDC")]
        public string? OIDC { get; set; }

        [XmlAttribute(AttributeName = "XIDC")]
        public string? XIDC { get; set; }

        [XmlAttribute(AttributeName = "SD")]
        public string? SD { get; set; }

        [XmlAttribute(AttributeName = "LOE")]
        public string? LOE { get; set; }

        [XmlAttribute(AttributeName = "Pat_WS")]
        public string? Pat_WS { get; set; }

        [XmlAttribute(AttributeName = "Pat_Syn")]
        public string? Pat_Syn { get; set; }

        [XmlAttribute(AttributeName = "GCB")]
        public string? GCB { get; set; }

        [XmlAttribute(AttributeName = "WB")]
        public string? WB { get; set; }

        [XmlAttribute(AttributeName = "SB")]
        public string? SB { get; set; }

        [XmlAttribute(AttributeName = "CE")]
        public string? CE { get; set; }

        [XmlAttribute(AttributeName = "Comp_Ex")]
        public string? Comp_Ex { get; set; }

        [XmlAttribute(AttributeName = "NFC_QC")]
        public string? NFC_QC { get; set; }

        [XmlAttribute(AttributeName = "NFD_QC")]
        public string? NFD_QC { get; set; }

        [XmlAttribute(AttributeName = "NFKC_QC")]
        public string? NFKC_QC { get; set; }

        [XmlAttribute(AttributeName = "NFKD_QC")]
        public string? NFKD_QC { get; set; }

        [XmlAttribute(AttributeName = "XO_NFC")]
        public string? XO_NFC { get; set; }

        [XmlAttribute(AttributeName = "XO_NFD")]
        public string? XO_NFD { get; set; }

        [XmlAttribute(AttributeName = "XO_NFKC")]
        public string? XO_NFKC { get; set; }

        [XmlAttribute(AttributeName = "XO_NFKD")]
        public string? XO_NFKD { get; set; }

        [XmlAttribute(AttributeName = "FC_NFKC")]
        public string? FC_NFKC { get; set; }

        [XmlAttribute(AttributeName = "CI")]
        public string? CI { get; set; }

        [XmlAttribute(AttributeName = "Cased")]
        public string? Cased { get; set; }

        [XmlAttribute(AttributeName = "CWCF")]
        public string? CWCF { get; set; }

        [XmlAttribute(AttributeName = "CWCM")]
        public string? CWCM { get; set; }

        [XmlAttribute(AttributeName = "CWKCF")]
        public string? CWKCF { get; set; }

        [XmlAttribute(AttributeName = "CWL")]
        public string? CWL { get; set; }

        [XmlAttribute(AttributeName = "CWT")]
        public string? CWT { get; set; }

        [XmlAttribute(AttributeName = "CWU")]
        public string? CWU { get; set; }

        [XmlAttribute(AttributeName = "NFKC_CF")]
        public string? NFKC_CF { get; set; }

        [XmlAttribute(AttributeName = "InSC")]
        public string? InSC { get; set; }

        [XmlAttribute(AttributeName = "InPC")]
        public string? InPC { get; set; }

        [XmlAttribute(AttributeName = "PCM")]
        public string? PCM { get; set; }

        [XmlAttribute(AttributeName = "vo")]
        public string? vo { get; set; }

        [XmlAttribute(AttributeName = "RI")]
        public string? RI { get; set; }

        [XmlAttribute(AttributeName = "blk")]
        public string? blk { get; set; }

        [XmlAttribute(AttributeName = "isc")]
        public string? isc { get; set; }

        [XmlAttribute(AttributeName = "na1")]
        public string? na1 { get; set; }

        [XmlAttribute(AttributeName = "Emoji")]
        public string? Emoji { get; set; }

        [XmlAttribute(AttributeName = "EPres")]
        public string? EPres { get; set; }

        [XmlAttribute(AttributeName = "EMod")]
        public string? EMod { get; set; }

        [XmlAttribute(AttributeName = "EBase")]
        public string? EBase { get; set; }

        [XmlAttribute(AttributeName = "EComp")]
        public string? EComp { get; set; }

        [XmlAttribute(AttributeName = "ExtPict")]
        public string? ExtPict { get; set; }

        #endregion

        #region Elements

        [XmlElement(ElementName = "char")]
        public List<CharObj>? Char { get; set; }

        [XmlElement(ElementName = "noncharacter")]
        public List<NonCharacter>? NonCharacter { get; set; }

        [XmlElement(ElementName = "reserved")]
        public List<Reserved>? Reserved { get; set; }

        #endregion
    }
}
