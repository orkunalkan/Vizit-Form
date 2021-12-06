using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VizitForm.Models
{
    public class FormTakipDataModel
    {
        [Key]
        public int id { get; set; }

        [DataType(DataType.Date)]
        public DateTime vizitTarihiT { get; set; }
        public string merkezT { get; set; }
        public string meslekT { get; set; }
        public string ikametT { get; set; }
        public string cinsiyetT { get; set; }
        public string medeniDurumT { get; set; }
        public int cocukSayisiT { get; set; }
        public string takipDurumuT { get; set; }
        public string olumDurumuT { get; set; }
        [DataType(DataType.Date)]
        public DateTime olumTarihiT { get; set; }
        public string sigaraKullanımıT { get; set; }
        public int sigaraPaketiYıllıkT { get; set; }

        [DataType(DataType.Date)]
        public DateTime sigaraBaslamaT { get; set; }

        [DataType(DataType.Date)]
        public DateTime sigaraBitisT { get; set; }
        public int haneHalkiSayisiT { get; set; }
        public string menapozT { get; set; }
        public float boyT { get; set; }
        public int kiloT { get; set; }
        public float bmiT { get; set; }
        public string sosyalGüvenceT { get; set; }
        public string işDurumT { get; set; }
        public string gelirT { get; set; }
        public string gelirDüzeyiT { get; set; }
        public string gebelikT { get; set; }
        public string hastalıkDogumDurumuT { get; set; }
        public string dogumSekliT { get; set; }
        public string bebekDurumuT { get; set; }
        public string ekHastalıkT { get; set; }
        public string overlapSendromT { get; set; }
        public string maligniteT { get; set; }
        public string ailedeOtoimmunT { get; set; }
        public string ailedeMaligniteT { get; set; }
        public int ciltKalınlaşması1T { get; set; }
        public int ciltKalınlaşması2T { get; set; }
        public int parmakLezyonuT { get; set; }
        public int telenijektaziT { get; set; }
        public int anormalTırnakT { get; set; }
        public int akciğerHastalığıT { get; set; }
        public int raynaudFenomeniT { get; set; }
        public int otoAntikorT { get; set; }
        public string raynaudT { get; set; }
        [DataType(DataType.Date)]
        public DateTime raynaudTarihT { get; set; }
        public string puffyT { get; set; }
        [DataType(DataType.Date)]
        public DateTime puffyTarihT { get; set; }
        public string sklerodaktiliT { get; set; }
        [DataType(DataType.Date)]
        public DateTime sklerodaktiliTarihT { get; set; }
        public string pittingT { get; set; }
        [DataType(DataType.Date)]
        public DateTime pittingTarihT { get; set; }
        public string ülserT { get; set; }
        [DataType(DataType.Date)]
        public DateTime ülserTarihT { get; set; }
        public string kalsinozisT { get; set; }
        [DataType(DataType.Date)]
        public DateTime kalsinozisTarihT { get; set; }
        public string telenjiektaziT { get; set; }
        [DataType(DataType.Date)]
        public DateTime telenjiektaziTarihT { get; set; }
        public string gangrenT { get; set; }
        [DataType(DataType.Date)]
        public DateTime gangrenTarihT { get; set; }
        public string inflamatuvarT { get; set; }
        [DataType(DataType.Date)]
        public DateTime inflamatuvarTarihT { get; set; }
        public string interstisyelT { get; set; }
        [DataType(DataType.Date)]
        public DateTime interstisyelTarihT { get; set; }
        public string miyozitT { get; set; }
        [DataType(DataType.Date)]
        public DateTime miyozitTarihT { get; set; }
        public string pulmonerT { get; set; }
        [DataType(DataType.Date)]
        public DateTime pulmonerTarihT { get; set; }
        public string sklerodermaT { get; set; }
        [DataType(DataType.Date)]
        public DateTime sklerodermaTarihT { get; set; }
        public string gisT { get; set; }
        [DataType(DataType.Date)]
        public DateTime gisTarihT { get; set; }
        public string eklemT { get; set; }
        [DataType(DataType.Date)]
        public DateTime eklemTarihT { get; set; }
        public string diğerT { get; set; }
        [DataType(DataType.Date)]
        public DateTime diğerTarihT { get; set; }
        public string cerrahiAmpütasyonT { get; set; }
        public string otoAmpütasyonT { get; set; }
        public string kontraktürT { get; set; }
        public string eklemKontraktürT { get; set; }
        public string inflamatuvarArtritT { get; set; }
        public string tendonSürtünmeT { get; set; }
        public string kasGüçsüzT { get; set; }
        public string kasAtrofisiT { get; set; }
        public string agızKuruluguT { get; set; }
        public string özefagusT { get; set; }
        public string mideSemptomT { get; set; }
        public string barsakSemptomT { get; set; }
        public string kiloKaybıT { get; set; }
        public int maksAgızT { get; set; }
        public string özefagogramT { get; set; }
        [DataType(DataType.Date)]
        public DateTime özefagogramTarihT { get; set; }
        public string sintigrafiT { get; set; }
        [DataType(DataType.Date)]
        public DateTime sintigrafiTarihT { get; set; }
        public int sintigrafiTransitT { get; set; }
        public int sintigrafiBoşalmaT { get; set; }
        public string gastroT { get; set; }
        [DataType(DataType.Date)]
        public DateTime gastroTarihT { get; set; }
        public string gastroKardiakT { get; set; }
        public string gastroÖzefajitT { get; set; }
        public string gastroAntralT { get; set; }
        public string gastroVaskülerT { get; set; }
        public string gastroHiatalT { get; set; }
        public string gastroBarretT { get; set; }
        public string gastroMetaplaziT { get; set; }
        public string gastroDoudenitT { get; set; }
        public string impedansT { get; set; }
        [DataType(DataType.Date)]
        public DateTime impedansTarihT { get; set; }
        public int impedansPHT { get; set; }
        public int impedansPedenzaT { get; set; }
        public string özefagealT { get; set; }
        [DataType(DataType.Date)]
        public DateTime özefagealTarihT { get; set; }
        public string özefagealBasınçT { get; set; }
        public string özefagealLatencyT { get; set; }
        public string özefagealKontraktilT { get; set; }
        public string özefagealOrtBasınçT { get; set; }
        public string özefagealHipoBasınçT { get; set; }
        public string özefagealMotiliteT { get; set; }
        public string rektalT { get; set; }
        [DataType(DataType.Date)]
        public DateTime rektalTarihT { get; set; }
        public int rektalDinlenmeBasıncıT { get; set; }
        public int rektalSıkmaBasıncıT { get; set; }
        public string kolonoskopiT { get; set; }
        [DataType(DataType.Date)]
        public DateTime kolonoskopiTarihT { get; set; }
        public string kolonoskopiDilatasyonT { get; set; }
        public string kolonoskopiDivertikülT { get; set; }
        public string kolonoskopiVaskülerT { get; set; }
        public string kolonoskopiPolipT { get; set; }
        public string kolonoskopiKolitT { get; set; }
        public string PifDistaliTümT { get; set; }
        public string AltEkstremiteTümT { get; set; }
        public string DiğerTümT { get; set; }
        public string PifDistaliAktifT { get; set; }
        public string AltEkstremiteAktifT { get; set; }
        public string DiğerAktifT { get; set; }
        public string maxÜlserT { get; set; }
        public string interstisyelAkciğerT { get; set; }
        [DataType(DataType.Date)]
        public DateTime HRCTTarihT { get; set; }
        [DataType(DataType.Date)]
        public DateTime SFTTarihT { get; set; }
        public string buzluCamT { get; set; }
        public string FVCT { get; set; }
        public string balPeteğiT { get; set; }
        public string FEV1T { get; set; }
        public string retikülerDansiteT { get; set; }
        public string Fev1FvcT { get; set; }
        public string traksiyonBronşiT { get; set; }
        public string DLCOT { get; set; }
        public string interlobulerSeptalT { get; set; }
        public string DlcoVaT { get; set; }
        public string interstisyelKalınlaşmaT { get; set; }
        public string TLCOT { get; set; }
        public string digerBulgularT { get; set; }
        public string RVT { get; set; }
        public string PAACT { get; set; }
        public string PahKateterizasyonT { get; set; }
        public int PahKateterizasyonSayıT { get; set; }
        [DataType(DataType.Date)]
        public DateTime PahKateterizasyonTarihT { get; set; }
        [DataType(DataType.Date)]
        public DateTime EkoTarihiT { get; set; }
        public string sağArterT { get; set; }
        public string sağPulmonerUçT { get; set; }
        public string sağKardiakİndexT { get; set; }
        public string sağMikstT { get; set; }
        public string sağDiastolikT { get; set; }
        public string sağPulmonerVaskülerT { get; set; }
        public string sağAtriumT { get; set; }
        public string sağArteryalT { get; set; }
        public string sağVentT { get; set; }
        public string sağKardiyakOutT { get; set; }
        public string ekoSistolikT { get; set; }
        public string ekoArterT { get; set; }
        public string ekoTrjT { get; set; }
        public string ekoAtriumT { get; set; }
        public string ekoEjeksiyonT { get; set; }
        public string ekoVentrikülT { get; set; }
        public string ekoPerikardiyalT { get; set; }
        public string ekoKapakT { get; set; }
        public string pahT { get; set; }
        public string dso3AyT { get; set; }
        [DataType(DataType.Date)]
        public DateTime dso3AyTarihT { get; set; }
        public string dsoSonT { get; set; }
        [DataType(DataType.Date)]
        public DateTime dsoSonTarihT { get; set; }
        public string kateter3AyMesafeT { get; set; }
        public string kateter3AyYürümeBasT { get; set; }
        public string kateter3AyYürümeBitT { get; set; }
        [DataType(DataType.Date)]
        public DateTime kateter3AyTarihT { get; set; }
        public string kateterSonMesafeT { get; set; }
        public string kateterSonYürümeBasT { get; set; }
        public string kateterSonYürümeBitT { get; set; }
        [DataType(DataType.Date)]
        public DateTime kateterSonTarihT { get; set; }
        public string kateter3AyBORGT { get; set; }
        [DataType(DataType.Date)]
        public DateTime kateter3AyBORGTarihT { get; set; }
        public string kateterSonBORGT { get; set; }
        [DataType(DataType.Date)]
        public DateTime kateterSonBORGTarihT { get; set; }
        public string sklerodermaKrizT { get; set; }
        [DataType(DataType.Date)]
        public DateTime sklerodermaKrizTarihT { get; set; }
        public string bulguTansiyonT { get; set; }
        public string bulguSerumT { get; set; }
        public string bulguTrombositT { get; set; }
        public string bulguProteinüriT { get; set; }
        public string bulguİdrarSedimiT { get; set; }
        public string bulguPeriferikT { get; set; }
        public string bulguRenalBiyopsiT { get; set; }
        public string bulguRenalBiyopsiSonucuT { get; set; }
        [DataType(DataType.Date)]
        public DateTime hemogram3AyTarihT { get; set; }
        public int AKŞT { get; set; }
        public int CRPT { get; set; }
        public int NTproBNPT { get; set; }
        public int C3T { get; set; }
        public int ÜreT { get; set; }
        public int ESHT { get; set; }
        public int BNPT { get; set; }
        public int C4T { get; set; }
        public int KreatininT { get; set; }
        public int LökositT { get; set; }
        public int KreKinazT { get; set; }
        public int ALTT { get; set; }
        public int HbT { get; set; }
        public string ProteinüriT { get; set; }
        public int ASTT { get; set; }
        public int TrombositT { get; set; }
        public string idrarDurumT { get; set; }
        [DataType(DataType.Date)]
        public DateTime ekoKardiyoTarihT { get; set; }
        [DataType(DataType.Date)]
        public DateTime solunumFonksTarihT { get; set; }
        [DataType(DataType.Date)]
        public DateTime HRCT2TarihT { get; set; }
        public string ekoKarSağVentT { get; set; }
        public string solunumFVCT { get; set; }
        public string HRCTBuzluCamT { get; set; }
        public string ekoKarPulmonerArterT { get; set; }
        public string solunumFEV1T { get; set; }
        public string HRCTBalPetekT { get; set; }
        public string ekoKarTRJhızıT { get; set; }
        public string solunumFev1FVCT { get; set; }
        public string HRCTRetikülerT { get; set; }
        public string ekoKarSağAtriumT { get; set; }
        public string solunumDLCOT { get; set; }
        public string HRCTTraksiyonT { get; set; }
        public string ekoKarEjeksiyonFraksiyonT { get; set; }
        public string solunumDlcoVaT { get; set; }
        public string HRCTİnterLobulerT { get; set; }
        public string ekoKarSağVentrikülerT { get; set; }
        public string solunumTLCOT { get; set; }
        public string HRCTİnterstisyelT { get; set; }
        public string ekoKarPerikardiyalSıvıT { get; set; }
        public string solunumRVT { get; set; }
        public string HRCTDigerT { get; set; }
        public string kapakPatolojisiT { get; set; }
        public string kemikMineralT { get; set; }
        [DataType(DataType.Date)]
        public DateTime kemikTarihT { get; set; }
        public int kemikFemurSkorT { get; set; }
        public int kemikL1SkorT { get; set; }
        [DataType(DataType.Date)]
        public DateTime kapilleroskopiTarihT { get; set; }
        public string kapilleroskopiMarkaT { get; set; }
        public string kapilleroskopiBüyütmeT { get; set; }
        public string kapilleroskopiSonucT { get; set; }
        public string sklerodermaPaternT { get; set; }
        public int yüzT { get; set; }
        public int sağKolT { get; set; }
        public int solKolT { get; set; }
        public int göğüsT { get; set; }
        public int karınT { get; set; }
        public int sağÖnKolT { get; set; }
        public int solÖnKolT { get; set; }
        public int sağElT { get; set; }
        public int solElT { get; set; }
        public int sağParmakT { get; set; }
        public int solParmakT { get; set; }
        public int sağBacakT { get; set; }
        public int solBacakT { get; set; }
        public int sağBaldırT { get; set; }
        public int solBaldırT { get; set; }
        public int sağAyakT { get; set; }
        public int solAyakT { get; set; }
        public string eustarCiltT { get; set; }
        public string eustarDLCOT { get; set; }
        public string eustarÜlserT { get; set; }
        public string eustarCRPT { get; set; }
        public string eustarTendonT { get; set; }
        public string eustarmRCST { get; set; }
        public string medsgerGenelKiloT { get; set; }
        public string medsgerGenelHCTT { get; set; }
        public string medsgerGenelHGBT { get; set; }
        public string medsgerPeriferikVaskülerT { get; set; }
        public string medsgerCiltT { get; set; }
        public string medsgerEklemT { get; set; }
        public string medsgerKasT { get; set; }
        public string medsgerGIT { get; set; }
        public string medsgerAkciğerT { get; set; }
        public string medsgerKalpEKGT { get; set; }
        public string medsgerKalpEFT { get; set; }
        public string medsgerBöbrekT { get; set; }
        public string SSCT { get; set; }
    }
}
