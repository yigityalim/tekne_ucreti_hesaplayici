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
                                { "Mayýs", 450 },
                                { "Haziran", 500 },
                                { "Temmuz", 550 },
                                { "Aðustos", 550 },
                                { "Eylül", 500 },
                                { "Ekim", 450 },
                            }
                        },
                        { 15, new Dictionary<string, decimal>
                            {
                                { "Nisan", 500 },
                                { "Mayýs", 700 },
                                { "Haziran", 750 },
                                { "Temmuz", 850 },
                                { "Aðustos", 900 },
                                { "Eylül", 750 },
                                { "Ekim", 700 },
                            }
                        },
                        { 14, new Dictionary<string, decimal>
                            {
                                { "Nisan", 250 },
                                { "Mayýs", 400 },
                                { "Haziran", 550 },
                                { "Temmuz", 650 },
                                { "Aðustos", 650 },
                                { "Eylül", 550 },
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
                                { "Mayýs", 1500 },
                                { "Haziran", 1750 },
                                { "Temmuz", 2000 },
                                { "Aðustos", 2000 },
                                { "Eylül", 1750 },
                                { "Ekim", 1500 },
                            }
                        },
                        { 15, new Dictionary<string, decimal>
                            {
                                { "Nisan", 900 },
                                { "Mayýs", 1000 },
                                { "Haziran", 1100 },
                                { "Temmuz", 1200 },
                                { "Aðustos", 1200 },
                                { "Eylül", 1100 },
                                { "Ekim", 1000 },
                            }
                        },
                        { 14, new Dictionary<string, decimal>
                            {
                                { "Nisan", 600 },
                                { "Mayýs", 750 },
                                { "Haziran", 900 },
                                { "Temmuz", 1200 },
                                { "Aðustos", 1200 },
                                { "Eylül", 900 },
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
                MessageBox.Show("Lütfen tekne türü ve uzunluk seçiniz.");
                return;
            }

            DateTime baslangicTarihi = baslangicDTP.Value;
            DateTime bitisTarihi = bitisDTP.Value;

            if (baslangicTarihi >= bitisTarihi)
            {
                MessageBox.Show("Geçerli bir tarih aralýðý seçiniz.");
                return;
            }

            int gunSayisi = (bitisTarihi - baslangicTarihi).Days;
            string ay = baslangicTarihi.ToString("MMMM");

            if (!fiyatTablosu[secilenTekne][secilenUzunluk].ContainsKey(ay))
            {
                MessageBox.Show("Geçerli bir ay seçiniz.");
                return;
            }

            decimal gunlukUcret = fiyatTablosu[secilenTekne][secilenUzunluk][ay];
            decimal toplamUcret = gunSayisi * gunlukUcret;

            if (secilenTekne == "Gulet")
            {
                toplamUcret *= EuroKur;
                MessageBox.Show($"Toplam ücret: {toplamUcret} TL (Euro cinsinden: {toplamUcret / EuroKur} €)");
            }
            else
            {
                MessageBox.Show($"Toplam ücret: {toplamUcret} TL");
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
