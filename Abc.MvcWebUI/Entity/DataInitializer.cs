using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Vazo", Description = "Antika vazo ürünleri"},
                new Category(){ Name = "Sandık", Description = "Antika Sandık ürünleri"},
                new Category(){ Name = "Gramafon", Description = "Antika Gramafon ürünleri"},
                new Category(){ Name = "Aydınlatma", Description = "Antika Aydınlatma ürünleri"},
                new Category(){ Name = "Takı", Description = "Antika Takı ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler=new List<Product>()
            {
                new Product(){ Name = "Vazo",Description = "Antika ürünler, geçmiş zamanlara ait özgün ve değerli objelerdir. Bu ürünler, tarihi ve kültürel bir zenginliği temsil ederek nostalji ve estetik bir atmosfer yaratırlar. Antika mobilyalar, takılar, porselenler ve diğer antika objeler, geçmiş dönemlerin yaşam tarzını ve sanat anlayışını yansıtarak kendine özgü bir hikaye anlatırlar. Her bir antika parça, geçmişin izlerini taşıyan benzersiz birer sanat eseridir ve koleksiyoncular için özel bir değer taşır. Antika ürünler, zamana meydan okuyan ve estetik bir anlam taşıyan özel parçalardır.", Price =4600 , Stock =1 , IsApproved =true , CategoryId = 1,IsHome = true,Image="1.jpg"},
                new Product(){ Name = "Yüzük",Description = "Antika ürünler, geçmiş zamanlara ait özgün ve değerli objelerdir. Bu ürünler, tarihi ve kültürel bir zenginliği temsil ederek nostalji ve estetik bir atmosfer yaratırlar. Antika mobilyalar, takılar, porselenler ve diğer antika objeler, geçmiş dönemlerin yaşam tarzını ve sanat anlayışını yansıtarak kendine özgü bir hikaye anlatırlar. Her bir antika parça, geçmişin izlerini taşıyan benzersiz birer sanat eseridir ve koleksiyoncular için özel bir değer taşır. Antika ürünler, zamana meydan okuyan ve estetik bir anlam taşıyan özel parçalardır.", Price =7500, Stock =1 , IsApproved =true , CategoryId = 1,IsHome = true,Image="2.jpg"},
                new Product(){ Name = "Gramafon",Description = "Antika ürünler, geçmiş zamanlara ait özgün ve değerli objelerdir. Bu ürünler, tarihi ve kültürel bir zenginliği temsil ederek nostalji ve estetik bir atmosfer yaratırlar. Antika mobilyalar, takılar, porselenler ve diğer antika objeler, geçmiş dönemlerin yaşam tarzını ve sanat anlayışını yansıtarak kendine özgü bir hikaye anlatırlar. Her bir antika parça, geçmişin izlerini taşıyan benzersiz birer sanat eseridir ve koleksiyoncular için özel bir değer taşır. Antika ürünler, zamana meydan okuyan ve estetik bir anlam taşıyan özel parçalardır.", Price =9000 , Stock =1 , IsApproved =false , CategoryId = 1,IsHome = true,Image="3.jpg"},
                new Product(){ Name = "Takı Kutusu",Description = "Antika ürünler, geçmiş zamanlara ait özgün ve değerli objelerdir. Bu ürünler, tarihi ve kültürel bir zenginliği temsil ederek nostalji ve estetik bir atmosfer yaratırlar. Antika mobilyalar, takılar, porselenler ve diğer antika objeler, geçmiş dönemlerin yaşam tarzını ve sanat anlayışını yansıtarak kendine özgü bir hikaye anlatırlar. Her bir antika parça, geçmişin izlerini taşıyan benzersiz birer sanat eseridir ve koleksiyoncular için özel bir değer taşır. Antika ürünler, zamana meydan okuyan ve estetik bir anlam taşıyan özel parçalardır.", Price =1200 , Stock =1, IsApproved =true , CategoryId = 1,IsHome = true,Image="4.jpg"},
                new Product(){ Name = "Safir Yüzük",Description = "Antika ürünler, geçmiş zamanlara ait özgün ve değerli objelerdir. Bu ürünler, tarihi ve kültürel bir zenginliği temsil ederek nostalji ve estetik bir atmosfer yaratırlar. Antika mobilyalar, takılar, porselenler ve diğer antika objeler, geçmiş dönemlerin yaşam tarzını ve sanat anlayışını yansıtarak kendine özgü bir hikaye anlatırlar. Her bir antika parça, geçmişin izlerini taşıyan benzersiz birer sanat eseridir ve koleksiyoncular için özel bir değer taşır. Antika ürünler, zamana meydan okuyan ve estetik bir anlam taşıyan özel parçalardır.", Price =5000 , Stock =1 , IsApproved =false , CategoryId = 1,Image="5.jpg"},

                new Product(){ Name = "zümrüt yüzük", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 2},
                new Product(){ Name = "İşlemeli vazo",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =4500 , Stock =1200 , IsApproved =true , CategoryId = 2,IsHome = true,Image="5.jpg"},
                new Product(){ Name = "Kadife Takı Kutusu",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =3400 , Stock =0 , IsApproved =false , CategoryId = 2,IsHome = true,Image="6.jpg"},
                new Product(){ Name = "Yaprak ve Çiçek Görünümlü Abajür",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =2500 , Stock =600 , IsApproved =true , CategoryId = 2,Image="7.jpg"},
                new Product(){ Name = "Tablo",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5200 , Stock =500 , IsApproved =true , CategoryId = 2,Image="8.jpg"},

                new Product(){ Name = "LG 49UH610V 49 124 Ekran 4K Uydu Alıcılı Smart LED TV", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 3},
                new Product(){ Name = "Vestel 49UB8300 49 124 Ekran 4K Smart Led Tv",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5600 , Stock =1200 , IsApproved =true , CategoryId = 3,Image="9.jpg"},
                new Product(){ Name = "Samsung 55KU7500 55 140 Ekran [4K] Uydu Alıcılı Smart[Tizen] LED TV",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =3400 , Stock =0 , IsApproved =false , CategoryId =3,IsHome = true,Image="10.jpg"},
                new Product(){ Name = "LG 55UH615V 55 140 Ekran 4K Uydu Alıcılı Smart Wi-Fi [webOS 3.0] LED TV",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =2500 , Stock =600 , IsApproved =true , CategoryId = 3,IsHome = true,Image="11.jpg"},
                new Product(){ Name = "Sony Kd-55Xd7005B 55 140 Ekran [4K] Uydu Alıcılı Smart LED TV",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5200 , Stock =500 , IsApproved =true , CategoryId = 3,Image="12.jpg"},

                new Product(){ Name = "Apple iPhone 6 32 GB (Apple Türkiye Garantili)", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 4},
                new Product(){ Name = "Apple iPhone 7 32 GB (Apple Türkiye Garantili)",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5600 , Stock =1200 , IsApproved =true , CategoryId = 4,IsHome = true,Image="13.jpg"},
                new Product(){ Name = "Apple iPhone 6S 32 GB (Apple Türkiye Garantili)",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =3400 , Stock =0 , IsApproved =false , CategoryId =4,IsHome = true,Image="14.jpg"},
                new Product(){ Name = "Case 4U Manyetik Mıknatıslı Araç İçi Telefon Tutucu",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =2500 , Stock =600 , IsApproved =true , CategoryId = 4,Image="15.jpg"},
                new Product(){ Name = "Xiaomi Mi 5S 64GB (İthalatçı Garantili)",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5200 , Stock =500 , IsApproved =true , CategoryId = 4,Image="16.jpg"},

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}