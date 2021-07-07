using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _171180010_CANSU_AYTEN
{
    public partial class Form1 : Form
    {
        Process[] prosesler = Process.GetProcesses();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listeGuncelle();
        }
        public void listeGuncelle()
        {
            Process[] prosesler = Process.GetProcesses(); //prosesleri çektik
            liste.Items.Clear();
            foreach (Process proses in prosesler)
            {
                liste.Items.Add(proses.ProcessName);
            }
        }
        private void prosesinSahipOlduğuThreadSayısıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(liste.SelectedIndex !=-1) //listboxdan proses seçilmesi durumu
            {
                prosesler[liste.SelectedIndex].Refresh(); //prosesle ilgili önbelleğe alınan işlemler atılır
                MessageBox.Show("Prosesin sahip olduğu thread sayısı: " + prosesler[liste.SelectedIndex].Threads.Count.ToString()); //seçilen indexe ait prosesin thread sayısı
            }
            else //seçilmemesi durumu
                MessageBox.Show("Lütfen bir proses seçiniz.");
        }

        private void prosesinKullandığıBellekMiktarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (liste.SelectedIndex != -1)
            {
                prosesler[liste.SelectedIndex].Refresh();
                double bellekMiktari = Convert.ToDouble(prosesler[liste.SelectedIndex].WorkingSet64) / 1024; //WorkingSet64 çalışma kümesini byte cinsinden döndürüyor.
                MessageBox.Show("Prosesin kullandığı bellek miktarı: " + bellekMiktari.ToString() + " kilobayt");

            }
            else
                MessageBox.Show("Lütfen bir proses seçiniz.");
        }

        private void prosesinKullandığıİşlemciYüzdesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (liste.SelectedIndex != -1)
            {
                prosesler[liste.SelectedIndex].Refresh();
                PerformanceCounter PC = new PerformanceCounter("Process", "% Processor Time", prosesler[liste.SelectedIndex].ProcessName.ToString(), true);
                double[] yuzde = new double[5];
                double islemciYuzdesi = 0.0;

                for (int j = 0; j < 5; j++)
                {
                    yuzde[j] = PC.NextValue() / Environment.ProcessorCount; // 5 farklı yüzde, bunlardan ilki 0. İşlemci sayısına bölüyoruz
                    Thread.Sleep(250); //250 ms aralıkla yeni yüzde değerleri
                    islemciYuzdesi += yuzde[j];
                }

                islemciYuzdesi = islemciYuzdesi / 4;
                MessageBox.Show("Prosesin sahip olduğu işlemci yüzdesi: % " + islemciYuzdesi.ToString());


            }
            else
                MessageBox.Show("Lütfen bir proses seçiniz.");
        }

        private void prosesiÖldürmekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (liste.SelectedIndex != -1)
            {
                prosesler[liste.SelectedIndex].Refresh();
                prosesler[liste.SelectedIndex].Kill(); //proses öldürülüyor
                MessageBox.Show("Proses sonlandırıldı");

                listeGuncelle();
            }
            else
                MessageBox.Show("Lütfen bir proses seçiniz.");
        }
    }
}
