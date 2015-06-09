using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace udemy_todolist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private string Path = Application.StartupPath + @"\data.xml";
        private List<TodoItem> Gorevlerim = new List<TodoItem>();
        private MyXmlSerializer Serializer = new MyXmlSerializer();

        private void ListeleriDoldur()
        {
            this.lstTamamlananlarListesi.Items.Clear();
            this.clbYapilacaklarListesi.Items.Clear();

            foreach (TodoItem gorev in Gorevlerim)
            {
                if (gorev.Tamamlandi == false)
                    this.clbYapilacaklarListesi.Items.Add(gorev);
                else
                    this.lstTamamlananlarListesi.Items.Add(gorev);
            }
        }

        private void YapilacaklarListesiKaydet()
        {
            Serializer.Serialize<List<TodoItem>>(Path, this.Gorevlerim);
        }

        private void YapilacaklarListesiOku()
        {
            this.Gorevlerim = Serializer.Deserialize<List<TodoItem>>(Path);
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            txtYeniGorev.Text = string.Empty;

            if (System.IO.File.Exists(Path))
            {
                this.YapilacaklarListesiOku();
            }

            this.ListeleriDoldur();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            TodoItem yeniGorev = new TodoItem()
            {
                Id = Guid.NewGuid(),
                GorevMetni = txtYeniGorev.Text,
                Tamamlandi = false
            };

            this.Gorevlerim.Add(yeniGorev);
            this.ListeleriDoldur();
            this.YapilacaklarListesiKaydet();
            //this.clbYapilacaklarListesi.Items.Add(yeniGorev);

            this.notifyIcon1.BalloonTipText = "Yeni görev oluşturuldu.";
            this.notifyIcon1.ShowBalloonTip(2000);
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            if (clbYapilacaklarListesi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen düzeltme işlemi için bir görev seçiniz.");
                return;
            }

            TodoItem gorev = (TodoItem)clbYapilacaklarListesi.SelectedItem;
            gorev.GorevMetni = txtYeniGorev.Text;

            this.ListeleriDoldur();
            this.YapilacaklarListesiKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (clbYapilacaklarListesi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silme işlemi için bir görev seçiniz.");
                return;
            }

            this.Gorevlerim.Remove((TodoItem)clbYapilacaklarListesi.SelectedItem);
            //clbYapilacaklarListesi.Items.Remove(clbYapilacaklarListesi.SelectedItem);

            this.ListeleriDoldur();
            this.YapilacaklarListesiKaydet();
        }

        private void clbYapilacaklarListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbYapilacaklarListesi.SelectedIndex == -1)
                return;

            TodoItem gorev = (TodoItem)clbYapilacaklarListesi.SelectedItem;
            txtYeniGorev.Text = gorev.GorevMetni;
        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            txtYeniGorev.Cut();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            txtYeniGorev.Copy();
        }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            txtYeniGorev.Paste();
        }

        private void clbYapilacaklarListesi_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                TodoItem gorev = (TodoItem)clbYapilacaklarListesi.SelectedItem;
                gorev.Tamamlandi = true;
                gorev.TamamlanmaTarihi = DateTime.Now;

                this.YapilacaklarListesiKaydet();
            }
        }

        private void clbYapilacaklarListesi_MouseUp(object sender, MouseEventArgs e)
        {
            if(clbYapilacaklarListesi.CheckedItems.Count > 0)
                this.ListeleriDoldur();
        }

        private void mnuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuUygHakkinda_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }
}
