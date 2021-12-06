using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VizitForm.Models
{
    public class FormDataModel
    {
        [Key]
        public int id { get; set; }

        [DataType(DataType.Date)]
        public DateTime vizitTarihi { get; set; }
        public string merkez { get; set; }
        public int tc { get; set; }
        public string isim { get; set; }

        [DataType(DataType.Date)]
        public DateTime dogum { get; set; }
        public string meslek { get; set; }
        public string ikamet { get; set; }
        public string cinsiyet { get; set; }
        public string medeniDurum { get; set; }
        public int cocukSayisi { get; set; }
        public string egitimDurumu { get; set; }
        public string sigaraKullanımı { get; set; }
        public int sigaraPaketiYıllık { get; set; }

        [DataType(DataType.Date)]
        public DateTime sigaraBaslama { get; set; }

        [DataType(DataType.Date)]
        public DateTime sigaraBitis { get; set; }
        public int haneHalkiSayisi { get; set; }
        public int boy { get; set; }
        public int kilo { get; set; }
        public int bmi { get; set; }
        public string sosyalGüvence { get; set; }
        public string işDurum { get; set; }
        public string gelirDüzeyi { get; set; }
        public string gebelik { get; set; }
        public string hastalıkDogumDurumu { get; set; }
        public string dogumSekli { get; set; }
        public string bebekDurumu { get; set; }
        public string ekHastalık { get; set; }
        public string overlapSendrom { get; set; }
        public string malignite { get; set; }
        public string ailedeOtoimmun { get; set; }
        public string ailedeMalignite { get; set; }
        public int ciltKalınlaşması1 { get; set; }
        public int ciltKalınlaşması2 { get; set; }
        public int parmakLezyonu { get; set; }
        public int telenijektazi { get; set; }
        public int anormalTırnak { get; set; }
        public int akciğerHastalığı { get; set; }
        public int raynaudFenomeni { get; set; }
        public int otoAntikor { get; set; }
        public string raynaud { get; set; }
        [DataType(DataType.Date)]
        public DateTime raynaudTarih { get; set; }
        public string puffy { get; set; }
        [DataType(DataType.Date)]
        public DateTime puffyTarih { get; set; }
        public string sklerodaktili { get; set; }
        [DataType(DataType.Date)]
        public DateTime sklerodaktiliTarih { get; set; }
        public string pitting { get; set; }
        [DataType(DataType.Date)]
        public DateTime pittingTarih { get; set; }
        public string ülser { get; set; }
        [DataType(DataType.Date)]
        public DateTime ülserTarih { get; set; }
        public string kalsinozis { get; set; }
        [DataType(DataType.Date)]
        public DateTime kalsinozisTarih { get; set; }
        public string telenjiektazi { get; set; }
        [DataType(DataType.Date)]
        public DateTime telenjiektaziTarih { get; set; }
        public string gangren { get; set; }
        [DataType(DataType.Date)]
        public DateTime gangrenTarih { get; set; }
        public string inflamatuvar { get; set; }
        [DataType(DataType.Date)]
        public DateTime inflamatuvarTarih { get; set; }
        public string interstisyel { get; set; }
        [DataType(DataType.Date)]
        public DateTime interstisyelTarih { get; set; }
        public string miyozit { get; set; }
        [DataType(DataType.Date)]
        public DateTime miyozitTarih { get; set; }
        public string pulmoner { get; set; }
        [DataType(DataType.Date)]
        public DateTime pulmonerTarih { get; set; }
        public string skleroderma { get; set; }
        [DataType(DataType.Date)]
        public DateTime sklerodermaTarih { get; set; }
        public string gis { get; set; }
        [DataType(DataType.Date)]
        public DateTime gisTarih { get; set; }
        public string eklem { get; set; }
        [DataType(DataType.Date)]
        public DateTime eklemTarih { get; set; }
        public string diğer { get; set; }
        [DataType(DataType.Date)]
        public DateTime diğerTarih { get; set; }
        public string cerrahiAmpütasyon { get; set; }
        public string otoAmpütasyon { get; set; }
        public string kontraktür { get; set; }
        public string eklemKontraktür { get; set; }
        public string inflamatuvarArtrit { get; set; }
        public string tendonSürtünme { get; set; }
        public string kasGüçsüz { get; set; }
        public string kasAtrofisi { get; set; }
        public string agızKurulugu { get; set; }
        public string özefagus { get; set; }
        public string mideSemptom { get; set; }
        public string barsakSemptom { get; set; }
        public string kiloKaybı { get; set; }
        public int maksAgız { get; set; }
        public string özefagogram { get; set; }
        [DataType(DataType.Date)]
        public DateTime özefagogramTarih { get; set; }
        public string sintigrafi { get; set; }
        [DataType(DataType.Date)]
        public DateTime sintigrafiTarih { get; set; }
        public int sintigrafiTransit { get; set; }
        public int sintigrafiBoşalma { get; set; }
        public string gastro { get; set; }
        [DataType(DataType.Date)]
        public DateTime gastroTarih { get; set; }
        public string gastroKardiak { get; set; }
        public string gastroÖzefajit { get; set; }
        public string gastroAntral { get; set; }
        public string gastroVasküler { get; set; }
        public string gastroHiatal { get; set; }
        public string gastroBarret { get; set; }
        public string gastroMetaplazi { get; set; }
        public string gastroDoudenit { get; set; }
        public string impedans { get; set; }
        [DataType(DataType.Date)]
        public DateTime impedansTarih { get; set; }
        public int impedansPH { get; set; }
        public int impedansPedenza { get; set; }
        public string özefageal { get; set; }
        [DataType(DataType.Date)]
        public DateTime özefagealTarih { get; set; }
        public string özefagealBasınç { get; set; }
        public string özefagealLatency { get; set; }
        public string özefagealKontraktil { get; set; }
        public string özefagealOrtBasınç { get; set; }
        public string özefagealHipoBasınç { get; set; }
        public string özefagealMotilite { get; set; }
        public string rektal { get; set; }
        [DataType(DataType.Date)]
        public DateTime rektalTarih { get; set; }
        public int rektalDinlenmeBasıncı { get; set; }
        public int rektalSıkmaBasıncı { get; set; }
        public string kolonoskopi { get; set; }
        [DataType(DataType.Date)]
        public DateTime kolonoskopiTarih { get; set; }
        public string kolonoskopiDilatasyon { get; set; }
        public string kolonoskopiDivertikül { get; set; }
        public string kolonoskopiVasküler { get; set; }
        public string kolonoskopiPolip { get; set; }
        public string kolonoskopiKolit { get; set; }
        public string PifDistaliTüm { get; set; }
        public string AltEkstremiteTüm { get; set; }
        public string DiğerTüm { get; set; }
        public string PifDistaliAktif { get; set; }
        public string AltEkstremiteAktif { get; set; }
        public string DiğerAktif { get; set; }
        public string maxÜlser { get; set; }
        public string interstisyelAkciğer { get; set; }
        [DataType(DataType.Date)]
        public DateTime HRCTTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime SFTTarih { get; set; }
        public string buzluCam { get; set; }
        public string FVC { get; set; }
        public string balPetegi { get; set; }
        public string FEV1 { get; set; }
        public string retikulerDansite { get; set; }
        public string Fev1Fvc { get; set; }
        public string traksiyonBronşi { get; set; }
        public string DLCO { get; set; }
        public string interlobulerSeptal { get; set; }
        public string DlcoVa { get; set; }
        public string interstisyelKalınlaşma { get; set; }
        public string TLCO { get; set; }
        public string digerBulgular { get; set; }
        public string RV { get; set; }
        public string PAAC { get; set; }
        public string PahKateterizasyon { get; set; }
        public int PahKateterizasyonSayı { get; set; }
        [DataType(DataType.Date)]
        public DateTime PahKateterizasyonTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime EkoTarihi { get; set; }
        public string sağArter { get; set; }
        public string sağPulmonerUc { get; set; }
        public string sağKardiakIndex { get; set; }
        public string sağMikst { get; set; }
        public string sağDiastolik { get; set; }
        public string sağPulmonerVasküler { get; set; }
        public string sağAtrium { get; set; }
        public string sağArteryal { get; set; }
        public string sağVent { get; set; }
        public string sağKardiyakOut { get; set; }
        public string ekoSistolik { get; set; }
        public string ekoArter { get; set; }
        public string ekoTrj { get; set; }
        public string ekoAtrium { get; set; }
        public string ekoEjeksiyon { get; set; }
        public string ekoVentrikül { get; set; }
        public string ekoPerikardiyal { get; set; }
        public string ekoKapak { get; set; }
        public string pah { get; set; }
        public string dso3Ay { get; set; }
        [DataType(DataType.Date)]
        public DateTime dso3AyTarih { get; set; }
        public string dsoSon { get; set; }
        [DataType(DataType.Date)]
        public DateTime dsoSonTarih { get; set; }
        public string kateter3AyMesafe { get; set; }
        public string kateter3AyYürümeBas { get; set; }
        public string kateter3AyYürümeBit { get; set; }
        [DataType(DataType.Date)]
        public DateTime kateter3AyTarih { get; set; }
        public string kateterSonMesafe { get; set; }
        public string kateterSonYürümeBas { get; set; }
        public string kateterSonYürümeBit { get; set; }
        [DataType(DataType.Date)]
        public DateTime kateterSonTarih { get; set; }
        public string kateter3AyBORG { get; set; }
        [DataType(DataType.Date)]
        public DateTime kateter3AyBORGTarih { get; set; }
        public string kateterSonBORG { get; set; }
        [DataType(DataType.Date)]
        public DateTime kateterSonBORGTarih { get; set; }
        public string sklerodermaKriz { get; set; }
        [DataType(DataType.Date)]
        public DateTime sklerodermaKrizTarih { get; set; }
        public string bulguTansiyon { get; set; }
        public string bulguSerum { get; set; }
        public string bulguTrombosit { get; set; }
        public string bulguProteinüri { get; set; }
        public string bulguIdrarSedimi { get; set; }
        public string bulguPeriferik { get; set; }
        public string bulguRenalBiyopsi { get; set; }
        public string bulguRenalBiyopsiSonucu { get; set; }
        [DataType(DataType.Date)]
        public DateTime serolojiTarih { get; set; }
        public string ana { get; set; }
        public string anaTitresi { get; set; }
        public string anaPatern { get; set; }
        public string otoAnti { get; set; }
        [DataType(DataType.Date)]
        public DateTime hemogram3AyTarih { get; set; }
        public int AKS { get; set; }
        public int CRP { get; set; }
        public int NTproBNP { get; set; }
        public int C3 { get; set; }
        public int Üre { get; set; }
        public int ESH { get; set; }
        public int BNP { get; set; }
        public int C4 { get; set; }
        public int Kreatinin { get; set; }
        public int Lökosit { get; set; }
        public int KreKinaz { get; set; }
        public int ALT { get; set; }
        public int Hb { get; set; }
        public string Proteinuri { get; set; }
        public int AST { get; set; }
        public int Trombosit { get; set; }
        public string idrarDurum { get; set; }
        [DataType(DataType.Date)]
        public DateTime ekoKardiyoTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime solunumFonksTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime HRCT2Tarih { get; set; }
        public string ekoKarSagVent { get; set; }
        public string solunumFVC { get; set; }
        public string HRCTBuzluCam { get; set; }
        public string ekoKarPulmonerArter { get; set; }
        public string solunumFEV1 { get; set; }
        public string HRCTBalPetek { get; set; }
        public string ekoKarTRJhizi { get; set; }
        public string solunumFev1FVC { get; set; }
        public string HRCTRetiküler { get; set; }
        public string ekoKarSağAtrium { get; set; }
        public string solunumDLCO { get; set; }
        public string HRCTTraksiyon { get; set; }
        public string ekoKarEjeksiyonFraksiyon { get; set; }
        public string solunumDlcoVa { get; set; }
        public string HRCTİnterLobuler { get; set; }
        public string ekoKarSağVentriküler { get; set; }
        public string solunumTLCO { get; set; }
        public string HRCTİnterstisyel { get; set; }
        public string ekoKarPerikardiyalSıvı { get; set; }
        public string solunumRV { get; set; }
        public string HRCTDiger { get; set; }
        public string kapakPatolojisi { get; set; }
        public string kemikMineral { get; set; }
        [DataType(DataType.Date)]
        public DateTime kemikTarih { get; set; }
        public int kemikFemurSkor { get; set; }
        public int kemikL1Skor { get; set; }
        [DataType(DataType.Date)]
        public DateTime kapilleroskopiTarih { get; set; }
        public string kapilleroskopiMarka { get; set; }
        public string kapilleroskopiBüyütme { get; set; }
        public string kapilleroskopiSonuc { get; set; }
        public string sklerodermaPatern { get; set; }
        public int yüz { get; set; }
        public int sağKol { get; set; }
        public int solKol { get; set; }
        public int göğüs { get; set; }
        public int karın { get; set; }
        public int sağÖnKol { get; set; }
        public int solÖnKol { get; set; }
        public int sağEl { get; set; }
        public int solEl { get; set; }
        public int sağParmak { get; set; }
        public int solParmak { get; set; }
        public int sağBacak { get; set; }
        public int solBacak { get; set; }
        public int sağBaldır { get; set; }
        public int solBaldır { get; set; }
        public int sağAyak { get; set; }
        public int solAyak { get; set; }
        public string eustarCilt { get; set; }
        public string eustarDLCO { get; set; }
        public string eustarÜlser { get; set; }
        public string eustarCRP { get; set; }
        public string eustarTendon { get; set; }
        public string eustarmRCS { get; set; }
        public string medsgerGenelKilo { get; set; }
        public string medsgerGenelHCT { get; set; }
        public string medsgerGenelHGB { get; set; }
        public string medsgerPeriferikVasküler { get; set; }
        public string medsgerCilt { get; set; }
        public string medsgerEklem { get; set; }
        public string medsgerKas { get; set; }
        public string medsgerGI { get; set; }
        public string medsgerAkciğer { get; set; }
        public string medsgerKalpEKG { get; set; }
        public string medsgerKalpEF { get; set; }
        public string medsgerBöbrek { get; set; }
        public string SSC { get; set; }
        public string kortikosteroid { get; set; }
        [DataType(DataType.Date)]
        public DateTime kortikosteroidBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime kortikosteroidBitTarih { get; set; }
        public string siklofosfamid { get; set; }
        [DataType(DataType.Date)]
        public DateTime siklofosfamidBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime siklofosfamidBitTarih { get; set; }
        public string metotreksat { get; set; }
        [DataType(DataType.Date)]
        public DateTime metotreksatBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime metotreksatBitTarih { get; set; }
        public string leflunomid { get; set; }
        [DataType(DataType.Date)]
        public DateTime leflunomidBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime leflunomidBitTarih { get; set; }
        public string azatiopirin { get; set; }
        [DataType(DataType.Date)]
        public DateTime azatiopirinBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime azatiopirinBitTarih { get; set; }
        public string mikofenolat { get; set; }
        [DataType(DataType.Date)]
        public DateTime mikofenolatBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime mikofenolatBitTarih { get; set; }
        public string siklosporin { get; set; }
        [DataType(DataType.Date)]
        public DateTime siklosporinBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime siklosporinBitTarih { get; set; }
        public string rituximab { get; set; }
        [DataType(DataType.Date)]
        public DateTime rituximabBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime rituximabBitTarih { get; set; }
        public string tocilizumab { get; set; }
        [DataType(DataType.Date)]
        public DateTime tocilizumabBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime tocilizumabBitTarih { get; set; }
        public string abatacept { get; set; }
        [DataType(DataType.Date)]
        public DateTime abataceptBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime abataceptBitTarih { get; set; }
        public string imatinib { get; set; }
        [DataType(DataType.Date)]
        public DateTime imatinibBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime imatinibBitTarih { get; set; }
        public string pirfenidon { get; set; }
        [DataType(DataType.Date)]
        public DateTime pirfenidonBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime pirfenidonBitTarih { get; set; }
        public string nintedanib { get; set; }
        [DataType(DataType.Date)]
        public DateTime nintedanibBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime nintedanibBitTarih { get; set; }
        public string bosentan { get; set; }
        [DataType(DataType.Date)]
        public DateTime bosentanBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime bosentanBitTarih { get; set; }
        public string ambrisentan { get; set; }
        [DataType(DataType.Date)]
        public DateTime ambrisentanBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime ambrisentanBitTarih { get; set; }
        public string macitentan { get; set; }
        [DataType(DataType.Date)]
        public DateTime macitentanBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime macitentanBitTarih { get; set; }
        public string sildenafil { get; set; }
        [DataType(DataType.Date)]
        public DateTime sildenafilBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime sildenafilBitTarih { get; set; }
        public string vardenafil { get; set; }
        [DataType(DataType.Date)]
        public DateTime vardenafilBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime vardenafilBitTarih { get; set; }
        public string tadalafil { get; set; }
        [DataType(DataType.Date)]
        public DateTime tadalafilBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime tadalafilBitTarih { get; set; }
        public string pentoksifilin { get; set; }
        [DataType(DataType.Date)]
        public DateTime pentoksifilinBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime pentoksifilinBitTarih { get; set; }
        public string iloprost { get; set; }
        [DataType(DataType.Date)]
        public DateTime iloprostBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime iloprostBitTarih { get; set; }
        public string epoprostenol { get; set; }
        [DataType(DataType.Date)]
        public DateTime epoprostenolBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime epoprostenolBitTarih { get; set; }
        public string nifedipin { get; set; }
        [DataType(DataType.Date)]
        public DateTime nifedipinBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime nifedipinBitTarih { get; set; }
        public string nicardipin { get; set; }
        [DataType(DataType.Date)]
        public DateTime nicardipinBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime nicardipinBitTarih { get; set; }
        public string amlodipin { get; set; }
        [DataType(DataType.Date)]
        public DateTime amlodipinBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime amlodipinBitTarih { get; set; }
        public string felodipin { get; set; }
        [DataType(DataType.Date)]
        public DateTime felodipinBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime felodipinBitTarih { get; set; }
        public string benidipin { get; set; }
        [DataType(DataType.Date)]
        public DateTime benidipinBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime benidipinBitTarih { get; set; }
        public string lercanidipin { get; set; }
        [DataType(DataType.Date)]
        public DateTime lercanidipinBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime lercanidipinBitTarih { get; set; }
        public string diltiazem { get; set; }
        [DataType(DataType.Date)]
        public DateTime diltiazemBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime diltiazemBitTarih { get; set; }
        public string verapamil { get; set; }
        [DataType(DataType.Date)]
        public DateTime verapamilBasTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime verapamilBitTarih { get; set; }

    }

}
