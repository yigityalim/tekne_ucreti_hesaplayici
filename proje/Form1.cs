using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proje
{
    public partial class Form1 : Form
    {
        string secilenTekne = "";
        UInt16 secilenUzunluk = 0;
        Dictionary<string, Dictionary<UInt16, Dictionary<string, decimal>>> fiyatTablosu;
        const decimal EuroKur = 30m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            fiyatTablosu = new Dictionary<string, Dictionary<UInt16, Dictionary<string, decimal>>>
            {
                {
                    "Gulet", new Dictionary<UInt16, Dictionary<string, decimal>>
                    {
                        { 16, new Dictionary<string, decimal>
                            {
                                { "Nisan", 400 },
                                { "May�s", 450 },
                                { "Haziran", 500 },
                                { "Temmuz", 550 },
                                { "A�ustos", 550 },
                                { "Eyl�l", 500 },
                                { "Ekim", 450 },
                            }
                        },
                        { 15, new Dictionary<string, decimal>
                            {
                                { "Nisan", 500 },
                                { "May�s", 700 },
                                { "Haziran", 750 },
                                { "Temmuz", 850 },
                                { "A�ustos", 900 },
                                { "Eyl�l", 750 },
                                { "Ekim", 700 },
                            }
                        },
                        { 14, new Dictionary<string, decimal>
                            {
                                { "Nisan", 250 },
                                { "May�s", 400 },
                                { "Haziran", 550 },
                                { "Temmuz", 650 },
                                { "A�ustos", 650 },
                                { "Eyl�l", 550 },
                                { "Ekim", 400 },
                            }
                        },
                    }
                },
                {
                    "Motoryat", new Dictionary<UInt16, Dictionary<string, decimal>>
                    {
                        { 16, new Dictionary<string, decimal>
                            {
                                { "Nisan", 1250 },
                                { "May�s", 1500 },
                                { "Haziran", 1750 },
                                { "Temmuz", 2000 },
                                { "A�ustos", 2000 },
                                { "Eyl�l", 1750 },
                                { "Ekim", 1500 },
                            }
                        },
                        { 15, new Dictionary<string, decimal>
                            {
                                { "Nisan", 900 },
                                { "May�s", 1000 },
                                { "Haziran", 1100 },
                                { "Temmuz", 1200 },
                                { "A�ustos", 1200 },
                                { "Eyl�l", 1100 },
                                { "Ekim", 1000 },
                            }
                        },
                        { 14, new Dictionary<string, decimal>
                            {
                                { "Nisan", 600 },
                                { "May�s", 750 },
                                { "Haziran", 900 },
                                { "Temmuz", 1200 },
                                { "A�ustos", 1200 },
                                { "Eyl�l", 900 },
                                { "Ekim", 750 },
                            }
                        },
                    }
                }
            };
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(secilenTekne) || secilenUzunluk == 0)
            {
                MessageBox.Show("L�tfen tekne t�r� ve uzunluk se�iniz.");
                return;
            }

            DateTime baslangicTarihi = baslangicDTP.Value;
            DateTime bitisTarihi = bitisDTP.Value;

            if (baslangicTarihi >= bitisTarihi)
            {
                MessageBox.Show("Ge�erli bir tarih aral��� se�iniz.");
                return;
            }

            int gunSayisi = (bitisTarihi - baslangicTarihi).Days;
            string ay = baslangicTarihi.ToString("MMMM");

            if (!fiyatTablosu[secilenTekne][secilenUzunluk].ContainsKey(ay))
            {
                MessageBox.Show("Ge�erli bir ay se�iniz.");
                return;
            }

            decimal gunlukUcret = fiyatTablosu[secilenTekne][secilenUzunluk][ay];
            decimal toplamUcret = gunSayisi * gunlukUcret;

            if (secilenTekne == "Gulet")
            {
                toplamUcret *= EuroKur;
                MessageBox.Show($"Toplam �cret: {toplamUcret} TL (Euro cinsinden: {toplamUcret / EuroKur} �)");
            }
            else
            {
                MessageBox.Show($"Toplam �cret: {toplamUcret} TL");
            }
        }

        private void tekneTurCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenTekne = tekneTurCB.SelectedItem.ToString();
        }

        private void tekneUzunluguCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenUzunluk = Convert.ToUInt16(tekneUzunluguCB.SelectedItem.ToString());
        }
    }
}
