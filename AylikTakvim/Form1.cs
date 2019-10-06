using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AylikTakvim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            haftaSonları();

            // Örnek için tarih sabitleme
            monthCalendar1.SelectionRange = new SelectionRange(new DateTime(2019, 09, 20), new DateTime(2019, 09, 20));
            
        }

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            string mesaj = "Seçili {0} gün bulunmaktadır.";
            string gun = string.Format(mesaj, gunFarki() + 1);
            MessageBox.Show(gun);
            //MessageBox.Show(monthCalendar1.SelectionRange.ToString());
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            gunleriListele();
        }

        private int gunFarki()
        {
            // İki Tarih arasında ki gün sayı farkını buluyoruz.
            DateTime ilkGun = monthCalendar1.SelectionStart;
            DateTime sonGun = monthCalendar1.SelectionEnd;
            TimeSpan gunSayisi = sonGun - ilkGun;

            return gunSayisi.Days;
        }

        private void gunleriListele()
        {
            // Gün Listesini Oluşturma
            List<DateTime> gunler = new List<DateTime>();

            // Seçili ilk gun belirleniyor.
            DateTime gun = monthCalendar1.SelectionStart;

            // İlk günü dahil ederek arada ki günleri listeye ekliyoruz.
            gunler.Add(gun);
            for (int i = 0; i < gunFarki(); i++)
            {
                gun = gun.AddDays(1);
                gunler.Add(gun);
            }

            // Tarih Listesini Formatlanmış bir şekilde String Listesine Dönüştürüyoruz.
            List<String> str_gunler = new List<string>();
            foreach (var item in gunler)
            {
                str_gunler.Add(item.ToString("d"));
            }

            // Str_Gunler listesini tek bir string ifadede topluyoruz.
            String day_list = string.Join("\n", str_gunler.ToArray());
            MessageBox.Show(day_list);
        }

        private void haftaSonları()
        {
            monthCalendar1.BoldedDates = new DateTime[] {
                new DateTime(2019, 09, 01),
                new DateTime(2019, 09, 07),
                new DateTime(2019, 09, 08),
                new DateTime(2019, 09, 14),
                new DateTime(2019, 09, 15),
                new DateTime(2019, 09, 21),
                new DateTime(2019, 09, 22),
                new DateTime(2019, 09, 28),
                new DateTime(2019, 09, 29),
            };
        }
    }
}
