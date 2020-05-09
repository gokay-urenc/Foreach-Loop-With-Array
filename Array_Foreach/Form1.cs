using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayilar = new int[5]; // button 1
        string[] ogrenciler = new string[10]; // button 2
        char[] kisi = new char[5]; // button 3

        private void button1_Click(object sender, EventArgs e)
        {
            sayilar[0] = 23;
            sayilar[1] = 35;
            sayilar[2] = 46;
            sayilar[3] = 58;
            sayilar[4] = 69;
            // sayilar[5] = 75; // Son index numarası 4 olduğu için hata verir.
            foreach (int sayi in sayilar)
            {
                listBox1.Items.Add(sayi);
                // MessageBox.Show(sayi.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogrenciler[0] = "Negan";
            ogrenciler[1] = "Rick";
            ogrenciler[2] = "Daryl";
            ogrenciler[3] = "The Governor";
            ogrenciler[4] = "Glenn";
            ogrenciler[5] = "Rosita";
            ogrenciler[6] = "Eugene";
            ogrenciler[7] = "Nick";
            ogrenciler[8] = "Alicia";
            ogrenciler[9] = "Morgan";
            // listBox2.Items.Add(ogrenciler[5]); // Sadece birini ekler.
            foreach (string sinif in ogrenciler)
            {
                listBox2.Items.Add(sinif);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kisi[0] = 'E';
            kisi[1] = 'R';
            kisi[2] = 'D';
            kisi[3] = 'F';
            kisi[4] = 'C';
            foreach (char kisiler in kisi)
            {
                MessageBox.Show(kisiler.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kisi = "Negan";
            foreach (char karakter in kisi)
            {
                MessageBox.Show(karakter.ToString());
            }
            listBox1.Items.Add(kisi[3]); // g harfini alır.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string kelime = "ama";
            if (kelime[0] == kelime[2]) // [] her zaman index operatörüdür.
            {
                MessageBox.Show("Aynıdır.");
            }
            MessageBox.Show(kelime.Length.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string kelime_2 = "KEKEKEKEKEKEKEKEKEK";
            if (kelime_2[0] == kelime_2[kelime_2.Length - 1]) // Dikkat
            {
                MessageBox.Show("Aynıdır.");
            }
        }
    }
}
/* Dizi: Aynı tipteki birden fazla veriyi bir arada tutan nesne kümesidir.
   Bellekte (ram) ard arda yer alan aynı türden nesneler kümesidir.
   Döngüler dizilerde dizi elemanlarına sıralı bir şekilde erişmek için kullanılır.
   Diziler için C# dilinde geliştirilmiş olan Foreach döngüsü vardır.
   Bu döngü dizi içerisindeki elemanlara sırayla ulaşır.
   Dizi oluşturulurken dikkat edilmesi gerekenler şunlardır.
   * Veri Tipi
   * Köşeli Parantezler []
   * Dizinin elemanları (Boyutu)
   * <Dizi Tipi[]> <Dizi Adı> = new <Dizi Tipi[<Dizi Boyutu>]>
   Index dizi içerisinde sıralama sayısıdır. Index sıralaması 0'dan başlar.
   Bu sıralama boyutun bir eksiği olacak şekilde sonlanır.
   foreach (<Veri Tipi> <Değişken Adı> in <Okunacak Dizi>)
   {
       <İşlemler>
   }
   Foreach döngüsü for ve while gibi bitiş veya başlangıç değeri beklemez.
   Foreach sadece diziyi okumak içindir.
   Foreach döngüsünün tek koşulu okunacak dizinin boş olmamasıdır.
   Dizi tanımlamanın 2. yolu: string[] <Değişken Adı> = { "Ad", "Ad, "Ad" };
   Dizi tanımlamanın 3. yolu: string[] <Değişken Adı> =  new string[] { "Ad", "Ad, "Ad" };
   Her string bir char dizisidir.
*/