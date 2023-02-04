using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarListed = "Arabalar listelendi";
        public static string ListedByCarId = "Araba Id numarasına göre listelendi";
        public static string CarListedByBrandId = "Arabalar marka numarasına göre listelendi";
        public static string CarListedByColorId = "Arabalar renk numarasına göre listelendi";
        public static string CarListedByDto = "Araçlar Dto şeklinde listelendi";
        public static string CarDailyPriceInValid = "Araba günlük fiyatı 0'dan büyük olmalıdır.";
        public static string SystemIsInMaintenance = "Sistem bakımda";

        public static string BrandNameInValid = "Marka ismi en az 2 karakter olmalıdır";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandListed = "Markalar listelendi";
        public static string BrandById = "Marka Id numarasına göre listelendi";
        public static string BrandUpdated = "Marka Güncellendi";

        public static string ColorNameInValid = "Renk ismi en az 2 karakter olmalıdır";
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorListed = "Renkler Listelendi";
        public static string ColorById = "Renk ID numarasına göre listelendi";
        public static string ColorUpdated = "Renk Güncellendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserListed = "Kullanıcılar Listelendi";
        public static string UserByIdListed = "Kullanıcılar Id numarasına göre listelendi";
        public static string UserUpdated = "Kullanıcılar listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerListed = "Müşteriler listelendi";
        public static string GetByUserIdListed = "Müşteriler Id numarasına göre listelendi";
        public static string CustomerUpdated = "Kullanıcı güncellendi";

        public static string RentalNotAdded = "Araba teslim edilmemiş";
        public static string RentalAdded = "Kiralandı";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalUpdated = "Kiralama güncellendi";
        public static string RentalById = "Kiralama Id numarasına göre listelendi";
        public static string RentalByCustomerId = "Kiralama Müşteri Id numarasına göre listelendi";
        public static string RentalByCarId = "Kiralama Araba Id numarasına göre listelendi";
        public static string RentalListed = "Kiralamalar listelendi";
        public static string CheckImageLimit = "Araba resmi en fazla 5 adet olmalıdır";
        public static string ImageAdded = "Resim eklendi";
        public static string CarImageLimit = "En fazla 5 resim eklenebilir";
    }
}
