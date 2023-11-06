using Microsoft.VisualBasic.ApplicationServices;
using PlakDukkaniBoostMaraton_DAL.AppDbContext;
using PlakDukkaniBoostMaraton_DATA.Entitty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkaniBoostMaraton_UI
{
    public partial class frm_Listeler : Form
    {
        private AdminInfo _admin;
        public frm_Listeler(int id)
        {
            context = new Context();
            InitializeComponent();
            var user = context.Admin.FirstOrDefault(x => x.Id == id);
            _admin = user;

        }

        private void frm_Listeler_Load(object sender, EventArgs e)
        {
            dgvBilgiler.DataSource = context.Albums.ToList();

            cmbListeSecim.Items.Add("Satışı duranlar");
            cmbListeSecim.Items.Add("Satışı devam edenler");
            cmbListeSecim.Items.Add("Son 10 Albüm");
            cmbListeSecim.Items.Add("İndirimdekiler");


        }


        Context context;
        private void btnEkle_Click(object sender, EventArgs e)
        {

            AlbumEkle();
        }

        private void AlbumEkle()
        {
            context = new Context();
            if (txtAlbumAdi.Text != "" && txtSanatci.Text != "" && dtCikisTarihi.Value != DateTime.Now && txtFiyati.Text != "" && txtIndirimOrani.Text != "" && (rdoDevam.Checked || rdoDurdu.Checked))
            {
                context.Albums.Add(new Album() { AlbumAdi = txtAlbumAdi.Text.Trim(), CikisTarihi = dtCikisTarihi.Value, Fiyati = Convert.ToDouble(txtFiyati.Text.Trim()), Indirim = Convert.ToDouble(txtIndirimOrani.Text.Trim()), Sanatci = txtSanatci.Text.Trim(), SatisDurumu = rdoDevam.Checked ? "Satışı devam ediyor" : "Satışı durduruldu", AdminId = _admin.Id });
                context.SaveChanges();
                dgvBilgiler.DataSource = context.Albums.ToList();
                MessageBox.Show("Kaydınız Başarılı.");
            }
            else { MessageBox.Show("Boş alan bırakmayınız."); }

        }

        Album secilenAlbum;
        private void dgvBilgiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenAlbum = new Album();
            secilenAlbum = context.Albums.Find(Convert.ToInt32(dgvBilgiler.Rows[e.RowIndex].Cells[0].Value));
            Getir();
        }
        private void Getir()
        {
            txtAlbumAdi.Text = secilenAlbum.AlbumAdi;
            txtSanatci.Text = secilenAlbum.Sanatci;
            dtCikisTarihi.Value = secilenAlbum.CikisTarihi;
            txtIndirimOrani.Text = secilenAlbum.Indirim.ToString();
            txtFiyati.Text = secilenAlbum.Fiyati.ToString();
            if (secilenAlbum.SatisDurumu == "Satışı devam ediyor")
            {
                rdoDevam.Checked = true;
            }
            else if (secilenAlbum.SatisDurumu == "Satışı durduruldu")
            {
                rdoDurdu.Checked = true;
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Getir();
            VeriSil();
            AlbumEkle();

        }
        private void VeriSil()
        {
            if (secilenAlbum == null)
            { MessageBox.Show("Silinecek veriyi seçiniz"); }
            else
            {
                context.Albums.Remove(secilenAlbum);
                context.SaveChanges();
                MessageBox.Show("Veri Silinmiştir.");
                dgvBilgiler.DataSource = context.Albums.ToList();

            }

        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            VeriSil();
            dgvBilgiler.DataSource = context.Albums.ToList();
        }

      

        private void cmbListeSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbListeSecim.SelectedIndex==0)
            {
                dgvBilgiler.DataSource = context.Albums.Where(x => x.SatisDurumu == "Satışı durduruldu").Select(x => new { AlbumAdi = x.AlbumAdi, Sanatçı = x.Sanatci }).ToList();
                dgvBilgiler.Enabled = false;
            }
            else if (cmbListeSecim.SelectedIndex == 1)
            {
                dgvBilgiler.DataSource = context.Albums.Where(x => x.SatisDurumu == "Satışı devam ediyor").Select(x => new { AlbumAdi = x.AlbumAdi, Sanatçı = x.Sanatci }).ToList();
                dgvBilgiler.Enabled = false;
            }
            else if (cmbListeSecim.SelectedIndex == 2)
            {
                dgvBilgiler.DataSource = context.Albums.OrderByDescending(x => x.Id).Take(10).Select(x => new { AlbumAdi = x.AlbumAdi, Sanatçı = x.Sanatci }).ToList();
                dgvBilgiler.Enabled = false;
            }
            else if (cmbListeSecim.SelectedIndex == 3)
            {
                dgvBilgiler.DataSource = context.Albums.Where(x => x.Indirim != 0).OrderByDescending(x => x.Indirim).Select(x => new { AlbumAdi = x.AlbumAdi, Sanatçı = x.Sanatci }).ToList();
                dgvBilgiler.Enabled = false;
            }
        }
    }
}


