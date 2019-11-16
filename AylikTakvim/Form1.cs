using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AylikTakvim
{
    public partial class Form1 : Form
    {

        SQLiteConnection con;
        SQLiteCommand cmd;
        ToolTip tp = new ToolTip();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("MyDatabase.sqlite"))
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite");
                string sql = @"CREATE TABLE Harici_Gunler(
                               ID INTEGER PRIMARY KEY AUTOINCREMENT,
                               Aciklama TEXT DEFAULT 'Özel bir gün',
                               Yil INTEGER NOT NULL,
                               Tarih TEXT NOT NULL
                                );";

                con = new SQLiteConnection("Data Source=MyDatabase.sqlite; Version=3;");
                con.Open();
                cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                //cmd.CommandText = "INSERT INTO Harici_Gunler(Yil, Tarih) values(0000, '0000')";
                //cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                con = new SQLiteConnection("Data Source=MyDatabase.sqlite; Version=3;");
            }
            TreeViewGuncelle();
            Gunleri_Isaretle();
        }

        private int gunHesapla()
        {
            DateTime ilkGun = monthCalendar1.SelectionStart;
            DateTime sonGun = monthCalendar1.SelectionEnd;

            TimeSpan sonuc = sonGun.Subtract(ilkGun);
            return Convert.ToInt32(sonuc.Days);
        }

        private List<DateTime> tarihListele(int gunSayisi)
        {
            List<DateTime> tarihListesi = new List<DateTime>();
            DateTime gun = monthCalendar1.SelectionStart;
            tarihListesi.Add(gun);

            for (int i = 0; i < gunSayisi; i++)
            {
                tarihListesi.Add(gun.AddDays(1));
                gun = gun.AddDays(1);
            }

            return tarihListesi;
        }

        private List<DateTime> Tarih_Listesi()
        {
            List<DateTime> gunler = tarihListele(gunHesapla());

            return gunler;
        }

        private List<Harici_Gunler> get_all()
        {
            List<Harici_Gunler> dbList = new List<Harici_Gunler>();

            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * From Harici_Gunler";
            cmd.ExecuteNonQuery();
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dbList.Add(new Harici_Gunler { id = Convert.ToInt32(dr["id"]), Yil = Convert.ToInt32(dr["Yil"]), Tarih = dr["Tarih"].ToString(), Aciklama = dr["Aciklama"].ToString()});
            }

            con.Close();
            return dbList;
        }

        private bool Gun_Kontrol(string param)
        {
            bool deger = false;
            if(get_all().Count == 0)
            {
                deger = true;
            }
            else
            {
                foreach (var item in get_all())
                {
                    if (item.Tarih == param)
                    {
                        deger = false;
                        break;
                    }
                    else
                    {
                        deger = true;
                    }

                }
            }

            return deger;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            bool kontrol = false;

            foreach (var item in Tarih_Listesi())
            {
                if (!Gun_Kontrol(item.ToString("d"))) {

                    MessageBox.Show("Eklemeye çalıştığınız tarih veya tarih aralığı zaten kayıtlıdır.");
                    kontrol = true;
                    break;
                }
                cmd = new SQLiteCommand();
                con.Open();
                cmd.Connection = con;
                if (string.IsNullOrWhiteSpace(txtAciklama.Text))
                {
                    cmd.CommandText = $"INSERT INTO Harici_Gunler(Yil, Tarih) values('{item.Year.ToString()}', '{item.ToString("d")}')";
                }
                else
                {
                    cmd.CommandText = $"INSERT INTO Harici_Gunler(Yil, Tarih, Aciklama) values('{item.Year.ToString()}', '{item.ToString("d")}', '{txtAciklama.Text.ToString()}')";
                }
                cmd.ExecuteNonQuery();
                con.Close();
            }

            if(!kontrol)
            MessageBox.Show("Tarihler veritabanına başarıyla kayıt edilmiştir.");
            txtAciklama.Text = "";

            TreeViewGuncelle();
        }

        private void TreeViewGuncelle()
        {
            treeView1.Nodes.Clear();
            List<Harici_Gunler> harici_gunler = get_all();
            List<int> yil = yil_listele();
            List<TreeNode> parent = new List<TreeNode>();

            foreach (var item in yil)
            {
                List<TreeNode> leaves = new List<TreeNode>();
                foreach (var gunler in harici_gunler)
                {
                    if(gunler.Yil == item)
                    {
                        TreeNode addNode = new TreeNode(gunler.Tarih.ToString());
                        addNode.ToolTipText = gunler.Aciklama.ToString();
                        addNode.Name = gunler.id.ToString();
                        leaves.Add(addNode);
                    }
                }
                parent.Add(new TreeNode(item.ToString(), leaves.ToArray()));
                leaves.Clear();
            }

            treeView1.Nodes.AddRange(parent.ToArray());

        }

        private List<int> yil_listele()
        {
            List<int> yil = new List<int>();

            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Yil from Harici_Gunler GROUP BY Yil ORDER BY Yil DESC";
            cmd.ExecuteNonQuery();
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                yil.Add(Convert.ToInt32(dr["Yil"]));
            }

            con.Close();

            return yil;
        }

        private void Gunleri_Isaretle()
        {
            List<DateTime> tarihler = new List<DateTime>();
            var a = get_all();
            for (int i = 0; i < a.Count; i++)
            {
                tarihler.Add(DateTime.Parse(a[i].Tarih));
            }
            monthCalendar1.BoldedDates = tarihler.ToArray();
            
        }
    }

    class Harici_Gunler
    {
        public int id { get; set; }
        public int Yil { get; set; }
        public String Tarih { get; set; }
        public String Aciklama { get; set; }
    }
}
