using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniBoostMaraton_DATA.Entitty
{
    public class AdminInfo
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public ICollection<Album> Albums { get; set; }

    }
}
