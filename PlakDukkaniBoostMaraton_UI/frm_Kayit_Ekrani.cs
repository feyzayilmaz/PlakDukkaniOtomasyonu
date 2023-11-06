using PlakDukkaniBoostMaraton_DAL.AppDbContext;
using PlakDukkaniBoostMaraton_DATA.Entitty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkaniBoostMaraton_UI
{
    public partial class frm_Kayit_Ekrani : Form
    {
        public frm_Kayit_Ekrani()
        {
            InitializeComponent();
        }
        Context Context;
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            Context = new Context();
            var user = Context.Admin.FirstOrDefault(x => x.KullaniciAdi == txtKullaniciAdi.Text.Trim());
            if (user == null)
            {
                if (txtKullaniciAdi.Text.Trim() != "" && txtSifre.Text.Trim() != "" && txtSifreTekrar.Text.Trim() != "")
                {
                    if (txtSifre.Text == txtSifreTekrar.Text)
                    {

                        Context.Admin.Add(new AdminInfo() { KullaniciAdi = txtKullaniciAdi.Text.Trim(), Sifre = sha256_hash(txtSifre.Text.Trim()) });
                        Context.SaveChanges();



                    }
                    else MessageBox.Show("Girdiğiniz Şifre Değerleri uyuşmamaktadır.");
                }
                else MessageBox.Show("Boş Alan bırakmayınız.");
            }
            else { MessageBox.Show("kullanıcı zaten kayıtlı"); }
            if (sifreKural(txtSifre.Text.Trim()) == true)
            {
                Context.SaveChanges();
                MessageBox.Show("Başarıyla Kayıt Oldunuz");
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreniz kurallara uymadı tekrar deneyiniz.");
            }

        }
        public bool sifreKural(string sifre)
        {

            if (sifre.Length < 8) { return false; }

            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).*$";
            return Regex.IsMatch(sifre, pattern);

        }


    }
}

