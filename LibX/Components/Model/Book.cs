using System;
using System.ComponentModel.DataAnnotations;

namespace LibX.Components.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty; // Kitabın Adı
        public string? Subtitle { get; set; } // Alt Başlık
        public string Author { get; set; } = string.Empty; // Yazar
        public string Publisher { get; set; } = string.Empty; // Yayın Evi
        public int Edition { get; set; }
        public int PageCount { get; set; }
        public string Barcode { get; set; } = string.Empty; // Barkod Numarası
        public string? RFID { get; set; } // RFID Numarası
        public string? ShelfLocation { get; set; } // Dolap-Raf Bilgisi
        public string? AssignedTo { get; set; } // Zimmete Verilen Kişi
        public DateTime? AssignedDate { get; set; } // Zimmet Tarihi
        public string? MemberInfo { get; set; } // Üye Bilgileri
        public DateTime? CheckoutDate { get; set; } // Çıkış Tarihi
        public DateTime? ReturnDate { get; set; } // Dönüş Tarihi
        public string? IssuedByStaff { get; set; } // Personel
        public string? Condition { get; set; } // Sağlık Durumu
        public string? Defects { get; set; } // Kusurlar
        public bool HasBackup { get; set; }
        public decimal EstimatedValue { get; set; }
        public string? Category { get; set; } // Kategori
        public string? UsageType { get; set; } // Kullanım Türü
        public int TimesExchanged { get; set; }
    }
}
