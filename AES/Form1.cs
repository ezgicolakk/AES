using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        aesSifreleVeCoz AesSifreleVeCoz = new aesSifreleVeCoz();

        public class INIKaydet
        {
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

            public INIKaydet(string dosyaYolu)
            {
                DosyaYolu = dosyaYolu;
            }
            private string DosyaYolu = String.Empty;
            public string Varsayilan { get; set; }
            public string Oku(string bolum, string ayaradi)
            {
                Varsayilan = Varsayilan ?? string.Empty;
                StringBuilder StrBuild = new StringBuilder(256);
                GetPrivateProfileString(bolum, ayaradi, Varsayilan, StrBuild, 255, DosyaYolu);
                return StrBuild.ToString();
            }
            public long Yaz(string bolum, string ayaradi, string deger)
            {
                return WritePrivateProfileString(bolum, ayaradi, deger, DosyaYolu);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            INIKaydet ini = new INIKaydet(Application.StartupPath + @"\Ayarlar.ini");
            ini.Yaz("Gizli Bilgi", "Gizli Metin Kutusu", txtGizliMetin.Text);
            ini.Yaz("Gizli CheckBox", "Gizli Bilgi", cbGizliBilgi.Checked.ToString());
            MessageBox.Show("Ayarlar kayıt altına alındı.");
        }
        private void btnVeriOku_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\Ayarlar.ini"))
                {
                    INIKaydet ini = new INIKaydet(Application.StartupPath + @"\Ayarlar.ini");
                    txtGizliMetin.Text = ini.Oku("Gizli Bilgi", "Gizli Metin Kutusu");
                    cbGizliBilgi.Checked = Convert.ToBoolean(ini.Oku("Gizli CheckBox", "Gizli Bilgi"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ini dosyası hasarlı" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\Ayarlar.ini"))
                {
                    INIKaydet ini = new INIKaydet(Application.StartupPath + @"\Ayarlar.ini");
                    txtGizliMetin.Text = ini.Oku("Gizli Bilgi", "Gizli Metin Kutusu");
                    cbGizliBilgi.Checked = Convert.ToBoolean(ini.Oku("Gizli CheckBox", "Gizli Bilgi"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ini dosyası hasarlı" + ex.Message);
            }
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            rtbSifreliAlan.Text = AesSifreleVeCoz.aesSifrele(txtGizliMetin.Text);
        }

        private void btnSifreCoz_Click(object sender, EventArgs e)
        {
            if (rtbSifreliAlan.Text == string.Empty)
            {
                MessageBox.Show("Çözülecek bir şifre bulunamadı.");
            }
            else
            {
                rtbSifreCozmeAlanı.Text = AesSifreleVeCoz.aesSifre_Coz(rtbSifreliAlan.Text);
            }
        }
    }
}
