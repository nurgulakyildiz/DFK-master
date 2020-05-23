using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Iniupdater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            try
            {
                // Setting için json formatında text dosyası içeriği oluşturuluyor.
                string _data = "{'[AsStored]':'','PROGDIL':0,'MenuResimYolu':'','MenuResimCenter':false,'MenuResimStretch':true,'MESAJ_TIPI':2,'FORMHEADER_FONTCOLOR':'clWhite','FORMHEADER_STARTCOLOR':'$00CE9363','FORMHEADER_ENDCOLOR':'$00FFEFE5','BUTON_FONTCOLOR':'clBlack','BUTON_OVERCOLOR':'clMaroon','BUTON_STARTCOLOR':'clWhite','BUTON_ENDCOLOR':'$00ECA077','AUTO_VERSCONT':true,'VERSCONT_DAY':30,'LAST_VERSCONT':0,'SHORTCUT_BAR':true,'FINANSAL_SON_GUN':'','VarsayilanSUBE':'','SF_SAYAC':'','AF_SAYAC':'','CR_SAYAC':'','ST_SAYAC':'','CH_SAYAC':'','KDV_DURUMU':2,'STOKLIMIT_KONTROL':false,'CARILIMIT_KONTROL':false,'FATURAYAZDIR':2,'FATURAYAZDIRSOR':false,'BARKODSES':false,'CARIBAKIYEKONT':false,'CARIBAKIYEKONT_GRUBU':'','SF_DOVIZ_KULLAN':true,'SF_DOVIZ_HES_ISLE_CR':true,'SF_DOVIZ_HES_ISLE_ST':true,'SF_KPBDVZ_CR':0,'SF_KPBDVZ_ST':0,'FT_POSVADEFARKI':1,'CARI_KARALISTE':false,'STOK_BIRLESTIR':0,'ODEMETANIMLARI':true,'STOKFIYAT':false,'GRIDFONT':8,'STOK_PAKET_MIKTARSOR':true,'VADE_TARIHISOR':false,'ELEKTRONIK_TERAZI':false,'HS_MIKTAR_KARAKTER':'*','HS_STOK_BIRLESTIR':1,'MENU_TIPI':1,'YZPORT':'COM1','YZHIZ':9600,'AKTIFKASA':'NAKİT','AKTIFDEPO':'','STRESIM_GOSTER':false,'STRESIM_GOSTER_SURE':2,'CR_DEF_KODU':'CR0002','UR_DEF_OZELKODU':'','STFIYAT':false,'MDI_TURU':0,'ST_GORUNUM':'ST_HEADER|','ST_MAXMIKTAR':0,'ST_MAXFIYAT':0,'YZBARKODTIPI':24,'YZPLUBASAMAK':5,'YZPLUMIKTARHAS':3,'HESAPADETLIBARKOD':false,'INTERNET_XMLPOST':false,'ME_RENK_BASLIK':16776960,'ME_RENK_MESAJ':65280,'ME_RENK_TUTAR':33023,'ME_RENK_ZEMIN':0,'ME_FONT_BASLIK':178,'ME_FONT_MESAJ':178,'ME_FONT_TUTAR':178,'ME_MESAJ_BEKLEME':'DENEMEMARKETEHOŞGELDİNİZ','ME_VIDEO_YOLU':'','ME_SATISLOGO_YOLU':'','ME_VIDEO_SESDRM':true,'ME_BOYUTLAMA_ORN':96,'ME_KULLAN':0,'ME_MONITORNO':-1,'ME_MESAJ_HIZI':10,'ST_GORUNUMBOYUT':30,'SATISDIZAYNMESAJ':2,'BARKODKNAKTIF':true,'BARKODKNSN':10,'WIZARD':1,'SF_ALISFYT_KONTROL':false,'YAZAR_KASA_ONAY':true,'MANUELBIRIMENGEL':false,'CARIDOVIZ':false,'HUGINFLY385_M_EKRANI':false,'HUGINFLY385_M_COMPORT':'COM6','DOVIZ_BIRIMI_3':false,'CARI_BAKIYE_GOSTER':false,'CARI_FIYAT_DEGISIM':0,'VRS_PAZARLAMACI_BLKODU':0,'VRS_PAZARLAMACI_ADI':'','TEM_TERAZI':false,'TEM_PORT':8891,'MANUEL_FIS_CIKTISI':'','EKRAN_TR':true,'TAMEKRAN':false,'BRKKLAVYE':false,'STAMAMLA':true,'S_IRSALIYE':false,'M_OZELLESTIR':false,'BBAKKAL':true,'BBAKKAL_KULLANDI':true,'BBAKKALMESAJ':true,'BBAKKALILK':true,'FTYAZDIR':false,'POSSLIM_AKTIF':false,'POSSLIM_COMPORT':0,'BEPARABIRIMI':'KPB','TFYGOS':true,'SABITLEME':false,'TARTIBIRIM':'KG','SATISLOG':false,'SATISLOGSAYI':10,'ESF_SAYAC':'','EASF_SAYAC':'','SATISSAKLA':false,'STOKSECIMMIKTAR':true,'OTOOTURUMKAPATMA':false,'OTOOTURUMKAPATMASURESI':5,'BARKOD_TIPI':1,'BIRIMSECME_DURUM':false,'BIRIMSECME_BIRIM':'','OTOVADE':false,'NKT_HESAPLAMA':false,'OTV_KULLAN':0,'GUNSONU_RAPORU_TARIHI':0,'GUNSONU_RAPORU_SAATI':0,'ONLINE_BEKLEME_LIST':false,'BARKOD_SOUND_FILENAME':'','PARAUSTUAKTIF':false,'OTO_FATURAYAZDIR':2,'KurDownload':true,'CARISECIMZORUNLU':false,'URUNBULUNAMADIKAPAT':false,'FIS_ALTI_MESAJ':'','FIYATSOR':true,'GELISMISVARDIYASISTEMI':false,'TARTIMSIFIRLA':false,'STOKFIYATNO':1,'GELISMIS_ME_KULLAN':false,'TANIMSIZSTOK':true,'MOTOMASYONRUN':false,'YFATURALIMIT':1000,'CALLERIDKULLAN':false,'CALLERIDSERVERPORT':8890,'CALLERIDALANKODU':'332-Konya','CALLERIDNOTIFYTIME':60,'CALLERIDDIREKTAC':false,'SANALSANTRALDAHILINO':'','FISIPTALNEDENI':true,'OKC_TIMEOUT_SURESI':120,'YUVARLAMALIMITCHECK':true,'YUVARLAMALIMIT':'0,1','FATURA_STOK_OPEN':false,'CEKMECE_ACMASISTEMI_KULLAN':false,'CEKMECE_YAZICISI':'','STOKRESIMGOSTERME':false,'MULTINET_ODEME_TURU':0,'STOKFIYATGOSTERME':false,'DOVUZKURGIRISIGOSTERME':false}";
                
                // Minify edilmiş String içeriği JSON objesi formatına getiriliyor.
                string json = JsonConvert.SerializeObject(_data);

                // Json formatındaki text dosyasyı belirtilen konuma yazılıyor.
                System.IO.File.WriteAllText(@"settings.txt", json);

                using (StreamWriter file = File.CreateText(@"settings.txt"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, _data);
                }

                label2.Text = "Settings.txt Dosyası Başarıyla Oluşturuldu.";

            }

            catch
            {
                label2.Text = "Settings.txt Dosyası Oluşturulamadı !";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                // Belirtilen konumdan text dosyası okunuyor.
                string doc  = System.IO.File.ReadAllText(@"settings.txt");

                // Okunan string tipindeki içerik key, value parsing için JSON objesine dönüştürülüyor.
                Dictionary<string, string> jdoc = JsonConvert.DeserializeObject<Dictionary<string, string>>(doc.Replace('"', ' '));

                // Obje içinden CR_DEF_KODU key'i seçiliyor. Değeri label'a yazdırılıyor.
                label1.Text = jdoc["CR_DEF_KODU"];




                /// File.WriteAllText(@"D:\path.txt", File.ReadAllText(@"D:\path.txt").Replace("CR_DEF_KODU=CR0002", "CR_DEF_KODU=CR0001"));

            }
            catch
            {

            }
        }
    }
}
