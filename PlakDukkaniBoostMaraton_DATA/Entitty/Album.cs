using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniBoostMaraton_DATA.Entitty
{
    public class Album
    {
        public int Id { get; set; }
        public string AlbumAdi { get; set; }
        public string Sanatci { get; set; }
        public DateTime CikisTarihi { get; set; }
        public double Indirim { get; set; }
        public string SatisDurumu { get; set; }
        public double Fiyati { get; set; }
        public int AdminId { get; set; }
        public AdminInfo? _admin { get; set; }
    }
}
