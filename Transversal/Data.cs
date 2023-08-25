﻿namespace Transversal
{
    using Newtonsoft.Json;
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Data
    {
        public string currency { get; set; }
        public Rates rates { get; set; }
    }

    public class Rates
    {
        [JsonProperty("00")]
        public string _00 { get; set; }

        [JsonProperty("1INCH")]
        public string _1INCH { get; set; }
        public string AAVE { get; set; }
        public string ABT { get; set; }
        public string ACH { get; set; }
        public string ACS { get; set; }
        public string ADA { get; set; }
        public string AED { get; set; }
        public string AERGO { get; set; }
        public string AFN { get; set; }
        public string AGLD { get; set; }
        public string AIOZ { get; set; }
        public string ALCX { get; set; }
        public string ALEPH { get; set; }
        public string ALGO { get; set; }
        public string ALICE { get; set; }
        public string ALL { get; set; }
        public string AMD { get; set; }
        public string AMP { get; set; }
        public string ANG { get; set; }
        public string ANKR { get; set; }
        public string ANT { get; set; }
        public string AOA { get; set; }
        public string APE { get; set; }
        public string API3 { get; set; }
        public string APT { get; set; }
        public string ARB { get; set; }
        public string ARPA { get; set; }
        public string ARS { get; set; }
        public string ASM { get; set; }
        public string AST { get; set; }
        public string ATA { get; set; }
        public string ATOM { get; set; }
        public string AUCTION { get; set; }
        public string AUD { get; set; }
        public string AUDIO { get; set; }
        public string AURORA { get; set; }
        public string AVAX { get; set; }
        public string AVT { get; set; }
        public string AWG { get; set; }
        public string AXL { get; set; }
        public string AXS { get; set; }
        public string AZN { get; set; }
        public string BADGER { get; set; }
        public string BAL { get; set; }
        public string BAM { get; set; }
        public string BAND { get; set; }
        public string BAT { get; set; }
        public string BBD { get; set; }
        public string BCH { get; set; }
        public string BDT { get; set; }
        public string BGN { get; set; }
        public string BHD { get; set; }
        public string BICO { get; set; }
        public string BIF { get; set; }
        public string BIT { get; set; }
        public string BLUR { get; set; }
        public string BLZ { get; set; }
        public string BMD { get; set; }
        public string BND { get; set; }
        public string BNT { get; set; }
        public string BOB { get; set; }
        public string BOBA { get; set; }
        public string BOND { get; set; }
        public string BRL { get; set; }
        public string BSD { get; set; }
        public string BSV { get; set; }
        public string BTC { get; set; }
        public string BTN { get; set; }
        public string BTRST { get; set; }
        public string BUSD { get; set; }
        public string BWP { get; set; }
        public string BYN { get; set; }
        public string BYR { get; set; }
        public string BZD { get; set; }
        public string C98 { get; set; }
        public string CAD { get; set; }
        public string CBETH { get; set; }
        public string CDF { get; set; }
        public string CELR { get; set; }
        public string CGLD { get; set; }
        public string CHF { get; set; }
        public string CHZ { get; set; }
        public string CLF { get; set; }
        public string CLP { get; set; }
        public string CLV { get; set; }
        public string CNH { get; set; }
        public string CNY { get; set; }
        public string COMP { get; set; }
        public string COP { get; set; }
        public string COTI { get; set; }
        public string COVAL { get; set; }
        public string CRC { get; set; }
        public string CRO { get; set; }
        public string CRPT { get; set; }
        public string CRV { get; set; }
        public string CTSI { get; set; }
        public string CTX { get; set; }
        public string CUC { get; set; }
        public string CUP { get; set; }
        public string CVC { get; set; }
        public string CVE { get; set; }
        public string CVX { get; set; }
        public string CZK { get; set; }
        public string DAI { get; set; }
        public string DAR { get; set; }
        public string DASH { get; set; }
        public string DDX { get; set; }
        public string DESO { get; set; }
        public string DEXT { get; set; }
        public string DIA { get; set; }
        public string DIMO { get; set; }
        public string DJF { get; set; }
        public string DKK { get; set; }
        public string DNT { get; set; }
        public string DOGE { get; set; }
        public string DOP { get; set; }
        public string DOT { get; set; }
        public string DREP { get; set; }
        public string DYP { get; set; }
        public string DZD { get; set; }
        public string EEK { get; set; }
        public string EGLD { get; set; }
        public string EGP { get; set; }
        public string ELA { get; set; }
        public string ENJ { get; set; }
        public string ENS { get; set; }
        public string EOS { get; set; }
        public string ERN { get; set; }
        public string ETB { get; set; }
        public string ETC { get; set; }
        public string ETH { get; set; }
        public string ETH2 { get; set; }
        public string EUR { get; set; }
        public string EUROC { get; set; }
        public string FARM { get; set; }
        public string FET { get; set; }
        public string FIDA { get; set; }
        public string FIL { get; set; }
        public string FIS { get; set; }
        public string FJD { get; set; }
        public string FKP { get; set; }
        public string FLOW { get; set; }
        public string FLR { get; set; }
        public string FORT { get; set; }
        public string FORTH { get; set; }
        public string FOX { get; set; }
        public string FX { get; set; }
        public string GAL { get; set; }
        public string GALA { get; set; }
        public string GBP { get; set; }
        public string GEL { get; set; }
        public string GFI { get; set; }
        public string GGP { get; set; }
        public string GHS { get; set; }
        public string GHST { get; set; }
        public string GIP { get; set; }
        public string GLM { get; set; }
        public string GMD { get; set; }
        public string GMT { get; set; }
        public string GNF { get; set; }
        public string GNO { get; set; }
        public string GNT { get; set; }
        public string GODS { get; set; }
        public string GRT { get; set; }
        public string GST { get; set; }
        public string GTC { get; set; }
        public string GTQ { get; set; }
        public string GUSD { get; set; }
        public string GYD { get; set; }
        public string GYEN { get; set; }
        public string HBAR { get; set; }
        public string HFT { get; set; }
        public string HIGH { get; set; }
        public string HKD { get; set; }
        public string HNL { get; set; }
        public string HNT { get; set; }
        public string HOPR { get; set; }
        public string HRK { get; set; }
        public string HTG { get; set; }
        public string HUF { get; set; }
        public string ICP { get; set; }
        public string IDEX { get; set; }
        public string IDR { get; set; }
        public string ILS { get; set; }
        public string ILV { get; set; }
        public string IMP { get; set; }
        public string IMX { get; set; }
        public string INDEX { get; set; }
        public string INJ { get; set; }
        public string INR { get; set; }
        public string INV { get; set; }
        public string IOTX { get; set; }
        public string IQD { get; set; }
        public string IRR { get; set; }
        public string ISK { get; set; }
        public string JASMY { get; set; }
        public string JEP { get; set; }
        public string JMD { get; set; }
        public string JOD { get; set; }
        public string JPY { get; set; }
        public string JUP { get; set; }
        public string KAVA { get; set; }
        public string KEEP { get; set; }
        public string KES { get; set; }
        public string KGS { get; set; }
        public string KHR { get; set; }
        public string KMF { get; set; }
        public string KNC { get; set; }
        public string KRL { get; set; }
        public string KRW { get; set; }
        public string KSM { get; set; }
        public string KWD { get; set; }
        public string KYD { get; set; }
        public string KZT { get; set; }
        public string LAK { get; set; }
        public string LBP { get; set; }
        public string LCX { get; set; }
        public string LDO { get; set; }
        public string LINK { get; set; }
        public string LIT { get; set; }
        public string LKR { get; set; }
        public string LOKA { get; set; }
        public string LOOM { get; set; }
        public string LPT { get; set; }
        public string LQTY { get; set; }
        public string LRC { get; set; }
        public string LRD { get; set; }
        public string LSETH { get; set; }
        public string LSL { get; set; }
        public string LTC { get; set; }
        public string LTL { get; set; }
        public string LVL { get; set; }
        public string LYD { get; set; }
        public string MAD { get; set; }
        public string MAGIC { get; set; }
        public string MANA { get; set; }
        public string MASK { get; set; }
        public string MATH { get; set; }
        public string MATIC { get; set; }
        public string MCO2 { get; set; }
        public string MDL { get; set; }
        public string MDT { get; set; }
        public string MEDIA { get; set; }
        public string METIS { get; set; }
        public string MGA { get; set; }
        public string MINA { get; set; }
        public string MIR { get; set; }
        public string MKD { get; set; }
        public string MKR { get; set; }
        public string MLN { get; set; }
        public string MMK { get; set; }
        public string MNDE { get; set; }
        public string MNT { get; set; }
        public string MONA { get; set; }
        public string MOP { get; set; }
        public string MPL { get; set; }
        public string MRO { get; set; }
        public string MRU { get; set; }
        public string MSOL { get; set; }
        public string MTL { get; set; }
        public string MULTI { get; set; }
        public string MUR { get; set; }
        public string MUSD { get; set; }
        public string MUSE { get; set; }
        public string MVR { get; set; }
        public string MWK { get; set; }
        public string MXC { get; set; }
        public string MXN { get; set; }
        public string MYR { get; set; }
        public string MZN { get; set; }
        public string NAD { get; set; }
        public string NCT { get; set; }
        public string NEAR { get; set; }
        public string NEST { get; set; }
        public string NGN { get; set; }
        public string NIO { get; set; }
        public string NKN { get; set; }
        public string NMR { get; set; }
        public string NOK { get; set; }
        public string NPR { get; set; }
        public string NU { get; set; }
        public string NZD { get; set; }
        public string OCEAN { get; set; }
        public string OGN { get; set; }
        public string OMG { get; set; }
        public string OMR { get; set; }
        public string OOKI { get; set; }
        public string OP { get; set; }
        public string ORCA { get; set; }
        public string ORN { get; set; }
        public string OSMO { get; set; }
        public string OXT { get; set; }
        public string PAB { get; set; }
        public string PAX { get; set; }
        public string PEN { get; set; }
        public string PERP { get; set; }
        public string PGK { get; set; }
        public string PHP { get; set; }
        public string PKR { get; set; }
        public string PLA { get; set; }
        public string PLN { get; set; }
        public string PLU { get; set; }
        public string PNG { get; set; }
        public string POLS { get; set; }
        public string POLY { get; set; }
        public string POND { get; set; }
        public string POWR { get; set; }
        public string PRIME { get; set; }
        public string PRO { get; set; }
        public string PRQ { get; set; }
        public string PUNDIX { get; set; }
        public string PYG { get; set; }
        public string PYR { get; set; }
        public string QAR { get; set; }
        public string QI { get; set; }
        public string QNT { get; set; }
        public string QSP { get; set; }
        public string QUICK { get; set; }
        public string RAD { get; set; }
        public string RAI { get; set; }
        public string RARE { get; set; }
        public string RARI { get; set; }
        public string RBN { get; set; }
        public string REN { get; set; }
        public string REP { get; set; }
        public string REPV2 { get; set; }
        public string REQ { get; set; }
        public string RGT { get; set; }
        public string RLC { get; set; }
        public string RLY { get; set; }
        public string RNDR { get; set; }
        public string RON { get; set; }
        public string ROSE { get; set; }
        public string RPL { get; set; }
        public string RSD { get; set; }
        public string RUB { get; set; }
        public string RWF { get; set; }
        public string SAND { get; set; }
        public string SAR { get; set; }
        public string SBD { get; set; }
        public string SCR { get; set; }
        public string SDG { get; set; }
        public string SEI { get; set; }
        public string SEK { get; set; }
        public string SGD { get; set; }
        public string SHIB { get; set; }
        public string SHP { get; set; }
        public string SHPING { get; set; }
        public string SKK { get; set; }
        public string SKL { get; set; }
        public string SLL { get; set; }
        public string SNT { get; set; }
        public string SNX { get; set; }
        public string SOL { get; set; }
        public string SOS { get; set; }
        public string SPA { get; set; }
        public string SPELL { get; set; }
        public string SRD { get; set; }
        public string STD { get; set; }
        public string STG { get; set; }
        public string STORJ { get; set; }
        public string STX { get; set; }
        public string SUI { get; set; }
        public string SUKU { get; set; }
        public string SUPER { get; set; }
        public string SUSHI { get; set; }
        public string SVC { get; set; }
        public string SWFTC { get; set; }
        public string SYLO { get; set; }
        public string SYN { get; set; }
        public string SZL { get; set; }
        public string T { get; set; }
        public string THB { get; set; }
        public string TIME { get; set; }
        public string TJS { get; set; }
        public string TMM { get; set; }
        public string TMT { get; set; }
        public string TND { get; set; }
        public string TONE { get; set; }
        public string TOP { get; set; }
        public string TRAC { get; set; }
        public string TRB { get; set; }
        public string TRIBE { get; set; }
        public string TRU { get; set; }
        public string TRY { get; set; }
        public string TTD { get; set; }
        public string TVK { get; set; }
        public string TWD { get; set; }
        public string TZS { get; set; }
        public string UAH { get; set; }
        public string UGX { get; set; }
        public string UMA { get; set; }
        public string UNFI { get; set; }
        public string UNI { get; set; }
        public string UPI { get; set; }
        public string USD { get; set; }
        public string USDC { get; set; }
        public string USDT { get; set; }
        public string UST { get; set; }
        public string UYU { get; set; }
        public string UZS { get; set; }
        public string VEF { get; set; }
        public string VES { get; set; }
        public string VGX { get; set; }
        public string VND { get; set; }
        public string VOXEL { get; set; }
        public string VUV { get; set; }
        public string WAMPL { get; set; }
        public string WAXL { get; set; }
        public string WBTC { get; set; }
        public string WCFG { get; set; }
        public string WLUNA { get; set; }
        public string WST { get; set; }
        public string XAF { get; set; }
        public string XAG { get; set; }
        public string XAU { get; set; }
        public string XCD { get; set; }
        public string XCN { get; set; }
        public string XLM { get; set; }
        public string XMON { get; set; }
        public string XOF { get; set; }
        public string XPD { get; set; }
        public string XPF { get; set; }
        public string XPT { get; set; }
        public string XRP { get; set; }
        public string XTZ { get; set; }
        public string XYO { get; set; }
        public string YER { get; set; }
        public string YFI { get; set; }
        public string YFII { get; set; }
        public string ZAR { get; set; }
        public string ZEC { get; set; }
        public string ZEN { get; set; }
        public string ZMK { get; set; }
        public string ZMW { get; set; }
        public string ZRX { get; set; }
        public string ZWD { get; set; }
    }

    public class Root
    {
        public Data data { get; set; }
    }


}
