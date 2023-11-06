using PlakDukkaniBoostMaraton_DAL.AppDbContext;
using System.Security.Cryptography;
using System.Text;

namespace PlakDukkaniBoostMaraton_UI
{
    public partial class frm_Giris_Ekrani : Form
    {
        public frm_Giris_Ekrani()
        {
            InitializeComponent();
        }
        Context context = new Context();
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = sha256_hash(txtSifre.Text);

            var user = context.Admin.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre);
            if (user is not null)
            {
                frm_Listeler frm_Listeler = new frm_Listeler(user.Id);
                frm_Listeler.Show();


            }
            else
            {
                MessageBox.Show("Hatalý Giriþ");
                txtKullaniciAdi.Text = txtSifre.Text = "";
            }

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frm_Kayit_Ekrani frm = new frm_Kayit_Ekrani();
            frm.Show();

        }
    }
}