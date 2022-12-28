using System.Diagnostics;

namespace GorevLıst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // BU BUTON GÖREV LİSTESİNE GÖREV EKLEMEMİZİ SAĞLAR. 
        private void button_gorev_ekleme_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Görev Eklenemez !!");
            }

            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Select();
            }

            
            
        }

        // BU BUTON GÖREV LİSTESİNE YANLIŞ GÖREV EKLEDİYSEK ÇIKARMAYA YARAR.
        private void gorevCıkar_Click(object sender, EventArgs e)
        {


            if (listBox1.Text != "")
            {
                listBox1.Items.Remove(listBox1.Text);
            }
            else 
            {
                MessageBox.Show("Çıkartılacak Görev Bulunamadı !!");
            }
        }

        // BU BUTON GÖREV LİSTESİNDE SEÇTİĞİMİZ GÖREVİN YUKARI HARAKET ETMESİNİ SAĞLAR.
        private void button_yukariGit_Click(object sender, EventArgs e)
        {
            int sira= listBox1.SelectedIndex;
            if (sira -1 >=0)
            { 
                string seciliGorev = listBox1.SelectedItem.ToString();
                listBox1.Items[sira] = listBox1.Items[sira - 1];
                listBox1.Items[sira - 1] = seciliGorev;
                listBox1.SelectedIndex = sira -1;
            }   
        }

        // BU BUTON GÖREV LİSTESİNDE SEÇTİĞİMİZ GÖREVİN AŞAĞI HARAKET ETMESİNİ SAĞLAR.

        private void button_asagiGit_Click(object sender, EventArgs e)
        {
            int sira = listBox1.SelectedIndex;
            
            
            
            if (sira != - 1 && sira +1 < listBox1.Items.Count)
            {
                string seciliGorev = listBox1.SelectedItem.ToString();
                listBox1.Items[sira] = listBox1.Items[sira + 1];
                listBox1.Items[sira + 1] = seciliGorev;
                listBox1.SelectedIndex = sira + 1;
            }
            
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        // BU BUTON YAPTIĞIMIZ GÖREVİ YAPILANLAR LİSTESİNE EKLER
        private void button_degistir_Click(object sender, EventArgs e)
        {
             // int sira1 = listBox1.SelectedIndex;

            if (listBox1.Text == "")
            {
                MessageBox.Show("Yapılmış Görev Bulunamadı");

                return;
            }

            string seciliGorev = listBox1.SelectedItem.ToString();

            if (seciliGorev != "")
            {
                listBox1.SelectedItem = listBox2.Items.Add(seciliGorev);
                listBox1.Items.Remove(seciliGorev);
            }


            /*  if (seciliGorev = )*/
            // listBox1.Items[sira] = "";

        }

        // BU BUTON YAPILANLAR GÖREV LİSTESİNİ TAMAMEN TEMİZLER.
        private void button_clear_Click(object sender, EventArgs e)
        {

                listBox2.Items.Clear();
            
        }


        // BU BUTON YANLIŞLIKLA YAPILANLAR LİSTESİNE EKLENEN GÖREVİ GERİ ALDIRIR.
        private void button_goBack_Click(object sender, EventArgs e)
        {

            if (listBox2.Text == "")
            {
                MessageBox.Show("Geri Alınacak Görev Bulunamadı");

                return;
            }

            string yanlisGörev = listBox2.SelectedItem.ToString();

            
            if (yanlisGörev != "")
            {
                listBox2.SelectedItem = listBox1.Items.Add(yanlisGörev);
                listBox2.Items.Remove(yanlisGörev);
            }

            

        }
    }
}