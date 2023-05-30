using DiyetSefii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace DiyetSefii.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result(Diyet diyet)
        {
            Diyet diyet1diyet1 = diyet;
            #region Yemekler-Çorbalar-Salatalar
            string[,] FKKalpHastasıYemekler = new string[22, 7] {
    { "Ratatouille", "Düşük", "Düşük", "Orta", "Düşük", "Düşük", "807" },
    { "Böşamel soslu somon", "Orta", "Orta", "Orta", "Düşük", "Düşük", "658" },
    { "Apfelstrudel", "düşük", "orta", "yüksek", "düşük", "orta", "550" },
    { "Airag (ayrag)", "düşük", "düşük", "düşük", "düşük", "düşük", "453,7" },
    { "Churros", "Düşük", "Yüksek", "Yüksek", "Düşük", "Yüksek", "430" },
    { "Blintz", "Orta", "Orta", "Orta", "Düşük", "Orta", "250" },
    { "Spü¤tzle", "düşük", "orta", "yüksek", "düşük", "düşük", "140" },
    { "Quiche Lorraine", "Orta", "Yüksek", "Orta", "Orta", "Düşük", "1034" },
    { "Ratatouille", "Düşük", "Düşük", "Orta", "Düşük", "Düşük", "807" },
    { "Samosa", "Düşük", "Yüksek", "Yüksek", "Orta", "Düşük", "404,15" },
    { "Yaki onigiri", "düşük", "orta", "yüksek", "orta", "yok", "668" },
    { "Pissaladiü¨re", "Düşük", "Orta", "Orta", "Orta", "Düşük", "616" },
    { "Gazpacho", "Düşük", "Düşük", "Yüksek", "Orta", "Düşük", "485" },
    { "Patatas bravas", "Düşük", "Orta", "Yüksek", "Orta", "Düşük", "458" },
    { "Samosa", "Düşük", "Yüksek", "Yüksek", "Orta", "Düşük", "404,15" },
    { "şuba", "Orta", "Orta", "Düşük", "Orta", "Düşük", "395,3" },
    { "Kaysafa", "düşük", "yüksek", "düşük", "orta", "yok", "220" },
    { "Aloo Gobi", "Düşük", "Orta", "Yüksek", "Orta", "Düşük", "208" },
    { "Kartoffelsalat", "düşük", "orta", "yüksek", "orta", "düşük", "142,9" },
    { "Khoresh bademjan", "Düşük", "Orta", "Düşük", "Orta", "Yok", "56" },
    { "Zereshk polo", "Düşük", "Orta", "Yüksek", "Orta", "Yok", "18,9" },
    { "Spaetzle", "düşük", "orta", "yüksek", "düşük", "düşük", "390" }
};
            string[,] FKKalpHastasıÇorba = new string[7, 7] {
{ "Börek çorbası", "orta", "orta", "yüksek", "orta", "yok", "367,8" },
{ "Arpa şehriye çorbası", "düşük", "düşük", "orta", "orta", "orta", "181" },
{ "Hamur çorbası", "düşük", "düşük", "yüksek", "orta", "yok", "167" },
{ "Ispanak çorbası", "düşük", "düşük", "yüksek", "düşük", "yüksek", "104" },
{ "Bahçıvan çorbası", "orta", "orta", "yüksek", "orta", "yok", "74" },
{ "Harput çorbası", "orta", "düşük", "yüksek", "orta", "yok", "71" },
{ "Bamya çorbası", "orta", "orta", "yüksek", "orta", "yok", "46" }
};
            string[,] FKKalpHastasıSalata = new string[4, 7] {
{ "Beyaz lahana salatası", "düşük", "düşük", "yüksek", "orta", "yok", "152,5" },
{ "Bulgur salatası", "orta", "orta", "yüksek", "orta", "orta", "147,5" },
{ "Olivye Salatası", "Orta", "Yüksek", "Düşük", "Orta", "Düşük", "110" },
{ "Bostona salatası", "düşük", "orta", "yüksek", "orta", "orta", "30" }
};

            string[,] FKŞekerHastasıYemek = new string[17, 7] {
{ "Quiche Lorraine", "Orta", "Yüksek", "Orta", "Orta", "Düşük", "1034" },
{ "Ratatouille", "Düşük", "Düşük", "Orta", "Düşük", "Düşük", "807" },
{ "Samosa", "Düşük", "Yüksek", "Yüksek", "Orta", "Düşük", "404,15" },
{ "Yaki onigiri", "düşük", "orta", "yüksek", "orta", "yok", "668" },
{ "Pissaladiü¨re", "Düşük", "Orta", "Orta", "Orta", "Düşük", "616" },
{ "Gazpacho", "Düşük", "Düşük", "Yüksek", "Orta", "Düşük", "485" },
{ "Samosa", "Düşük", "Yüksek", "Yüksek", "Orta", "Düşük", "404,15" },
{ "şuba", "Orta", "Orta", "Düşük", "Orta", "Düşük", "395,3" },
{ "Kaysafa", "düşük", "yüksek", "düşük", "orta", "yok", "220" },
{ "Aloo Gobi", "Düşük", "Orta", "Yüksek", "Orta", "Düşük", "208" },
{ "Kartoffelsalat", "düşük", "orta", "yüksek", "orta", "düşük", "142,9" },
{ "Soba", "yüksek", "düşük", "yüksek", "orta", "yok", "98,9" },
{ "Khoresh bademjan", "Düşük", "Orta", "Düşük", "Orta", "Yok", "56" },
{ "Zereshk polo", "Düşük", "Orta", "Yüksek", "Orta", "Yok", "18,9" },
{ "Spaetzle", "düşük", "orta", "yüksek", "düşük", "düşük", "390" },
{ "Zereshk polo", "Düşük", "Orta", "Yüksek", "Orta", "Yok", "18,9" },
{ "Spaetzle", "düşük", "orta", "yüksek", "düşük", "düşük", "390" }
};
            string[,] FKŞekerHastasıÇorba = new string[6, 7] {
{ "Börek çorbası", "orta", "orta", "yüksek", "orta", "yok", "367,8" },
{ "Hamur çorbası", "düşük", "düşük", "yüksek", "orta", "yok", "167" },
{ "Ispanak çorbası", "düşük", "düşük", "yüksek", "düşük", "yüksek", "104" },
{ "Herle çorbası", "orta", "düşük", "yüksek", "düşük", "yok", "93" },
{ "Düğün çorbası", "orta", "orta", "orta", "orta", "orta", "92" },
{ "Bamya çorbası", "orta", "orta", "yüksek", "orta", "yok", "46" }
};
            string[,] FKŞekerHastasıSalata = new string[4, 7] {
{ "Labada salatası","Orta","Yüksek","Orta","Düşük","Düşük", "110" },
{ "Kinoa salatası","Orta","Orta","Düşük","Orta","Yok", "159" },
{ "panzanella","Orta","Orta","Düşük","Düşük","Yok", "200" },
{ "Niçoise salatası","Orta","Orta","Düşük","Orta","Orta", "220" }
};

            string[,] FKTansiyonHastasıYemek = new string[9, 7] {
{ "Ratatouille", "Düşük", "Düşük", "Orta", "Düşük", "Düşük", "807" },
{ "Böşamel soslu somon", "Orta", "Orta", "Orta", "Düşük", "Düşük", "658" },
{ "Apfelstrudel", "düşük", "orta", "yüksek", "düşük", "orta", "550" },
{ "Airag (ayrag)", "düşük", "düşük", "düşük", "düşük", "düşük", "453,7" },
{ "Churros", "Düşük", "Yüksek", "Yüksek", "Düşük", "Yüksek", "430" },
{ "Roast Beef and Yorkshire Pudding", "Yüksek", "Orta", "Düşük", "Orta", "Düşük", "294" },
{ "Blintz", "Orta", "Orta", "Orta", "Düşük", "Orta", "250" },
{ "Kulebiak", "Orta", "Yüksek", "Orta", "Düşük", "Orta", "242" },
{ "Spü¤tzle", "düşük", "orta", "yüksek", "düşük", "düşük", "140" }
};
            string[,] FKTasnsiyonHastasıÇorba = new string[7, 7] {
{ "Börek çorbası", "orta", "orta", "yüksek", "orta", "yok", "367,8" },
{ "Arpa şehriye çorbası", "düşük", "düşük", "orta", "orta", "orta", "181" },
{ "Hamur çorbası", "düşük", "düşük", "yüksek", "orta", "yok", "167" },
{ "Ispanak çorbası", "düşük", "düşük", "yüksek", "düşük", "yüksek", "104" },
{ "Bahçıvan çorbası", "orta", "orta", "yüksek", "orta", "yok", "74" },
{ "Harput çorbası", "orta", "düşük", "yüksek", "orta", "yok", "71" },
{ "Bamya çorbası", "orta", "orta", "yüksek", "orta", "yok", "46" }
};
            string[,] FKTansiyonSalata = new string[4, 7] {
{ "Beyaz lahana salatası", "düşük", "düşük", "yüksek", "orta", "yok", "152,5" },
{ "Bulgur salatası", "orta", "orta", "yüksek", "orta", "orta", "147,5" },
{ "Olivye Salatası", "Orta", "Yüksek", "Düşük", "Orta", "Düşük", "110" },
{ "Bostona salatası", "düşük", "orta", "yüksek", "orta", "orta", "30" }
};

            string[,] YerliKalpHastasıYemek = new string[23, 7] {
{ "Balıkesir kaymaklısı", "orta", "yüksek", "yüksek", "düşük", "yüksek", "1200" },
{ "iskender Kebabı", "yüksek", "yüksek", "düşük", "düşük", "yok", "755" },
{ "Domatesli gözleme", "yüksek", "düşük", "orta", "düşük", "yok", "606" },
{ "iskeçe Köfte", "yüksek", "yüksek", "düşük", "düşük", "yok", "550" },
{ "Hünkü¢rbeğendi", "orta", "yüksek", "düşük", "orta", "yüksek", "469" },
{ "iskilip Tepsi Kebabı", "yüksek", "yüksek", "düşük", "düşük", "yok", "420" },
{ "Gelin Kebabı", "yüksek", "orta", "düşük", "düşük", "yok", "370" },
{ "içli Adana Kebabı", "yüksek", "yüksek", "düşük", "düşük", "yok", "361" },
{ "Bazlama", "orta", "düşük", "yüksek", "düşük", "yok", "358" },
{ "Kastamonu Ekşili Pilavı", "düşük", "düşük", "yüksek", "düşük", "yok", "343" },
{ "Gönül Kebabı", "yüksek", "orta", "düşük", "düşük", "yok", "336,5" },
{ "içli Köfte", "yüksek", "orta", "yüksek", "düşük", "yok", "332" },
{ "iskenderun Köfte", "yüksek", "yüksek", "düşük", "düşük", "yok", "310" },
{ "Akıtma", "orta", "yüksek", "orta", "düşük", "yok", "225" },
{ "Fırın Kebabı", "yüksek", "orta", "düşük", "düşük", "orta", "190" },
{ "istanbul Pilavı", "orta", "düşük", "yüksek", "düşük", "yok", "169" },
{ "Akkız", "düşük", "düşük", "düşük", "düşük", "yok", "160" },
{ "Kabak Bayıldı", "düşük", "düşük", "yüksek", "düşük", "yok", "84" },
{ "Dövme pilavı", "orta", "düşük", "yüksek", "düşük", "yok", "35,91" },
{ "Bazlama", "orta", "düşük", "yüksek", "düşük", "yok", "358" },
{ "Kastamonu Ekşili Pilavı", "düşük", "düşük", "yüksek", "düşük", "yok", "343" },
{ "Erişte", "orta", "düşük", "yüksek", "düşük", "yok", "330" },
{ "islim Köfte", "yüksek", "düşük", "düşük", "orta", "yok", "307,92" }
};
            string[,] YerliKalpHastasıÇorba = new string[7, 7] {
{ "Börek çorbası", "orta", "orta", "yüksek", "orta", "yok", "367,8" },
{ "Arpa şehriye çorbası", "düşük", "düşük", "orta", "orta", "orta", "181" },
{ "Hamur çorbası", "düşük", "düşük", "yüksek", "orta", "yok", "167" },
{ "Ispanak çorbası", "düşük", "düşük", "yüksek", "düşük", "yüksek", "104" },
{ "Bahçıvan çorbası", "orta", "orta", "yüksek", "orta", "yok", "74" },
{ "Harput çorbası", "orta", "düşük", "yüksek", "orta", "yok", "71" },
{ "Bamya çorbası", "orta", "orta", "yüksek", "orta", "yok", "46" }
};
            string[,] YerliKalpHastasıSalata = new string[5, 7] {
{ "Ispanak Salatası", "düşük", "yüksek", "düşük", "orta", "yok", "154" },
{ "Beyaz lahana salatası", "düşük", "düşük", "yüksek", "orta", "yok", "152,5" },
{ "çoban salatası", "orta", "orta", "düşük", "orta", "yok", "120" },
{ "Cevizli patlıcan salatası", "düşük", "orta", "düşük", "orta", "yok", "80" },
{ "Havuç Salatası", "düşük", "yüksek", "düşük", "düşük", "yüksek", "68" }
};

            string[,] KiloAlmakİsteyenFarklıKültürYemek = new string[19, 7] {
    { "Taberu rayu", "yüksek", "yüksek", "düşük", "orta", "yok", "1034" },
    { "Yaki onigiri", "düşük", "orta", "yüksek", "orta", "yok", "768" },
    { "Sushi", "yüksek", "düşük", "yüksek", "yüksek", "yok", "665" },
    { "Sashimi", "yüksek", "düşük", "düşük", "yüksek", "yok", "658" },
    { "Tempura", "orta", "yüksek", "yüksek", "yüksek", "düşük", "656" },
    { "Udon", "orta", "düşük", "yüksek", "yüksek", "yok", "650" },
    { "Soba", "yüksek", "düşük", "yüksek", "orta", "yok", "598" },
    { "Okonomiyaki", "yüksek", "orta", "yüksek", "yüksek", "düşük", "593" },
    { "Takoyaki", "orta", "orta", "yüksek", "yüksek", "düşük", "585" },
    { "Ramen", "orta", "orta", "yüksek", "yüksek", "yok", "571" },
    { "Butter Chicken", "yüksek", "orta", "düşük", "orta", "düşük", "565" },
    { "Chana Masala", "yüksek", "düşük", "yüksek", "orta", "düşük", "526" },
    { "Palak Paneer", "yüksek", "orta", "düşük", "orta", "düşük", "520" },
    { "Aloo Gobi", "düşük", "orta", "yüksek", "orta", "düşük", "485" },
    { "Tandoori Chicken", "yüksek", "düşük", "düşük", "orta", "düşük", "440" },
    { "Samosa", "düşük", "yüksek", "yüksek", "orta", "düşük", "439.22" },
    { "Rogan Josh", "yüksek", "orta", "düşük", "orta", "düşük", "436.2" },
    { "Vindaloo", "yüksek", "orta", "düşük", "orta", "düşük", "410" },
    { "Biryani", "yüksek", "orta", "yüksek", "orta", "düşük", "410" }
};
            string[,] KiloAlmakİsteyenFarklıKültürÇorba = new string[5, 7] {
    { "Borscht çorbası", "Orta", "Düşük", "Orta", "Orta", "Orta", "220" },
    { "Amin çorbası", "yüksek", "orta", "orta", "orta", "yok", "167" },
    { "Herle çorbası", "orta", "düşük", "yüksek", "düşük", "yok", "93" },
    { "Harput çorbası", "orta", "düşük", "yüksek", "orta", "yok", "71" },
    { "Gebol", "yüksek", "orta", "orta", "orta", "orta", "150" }
};
            string[,] KiloAlmakİsteyenFarklıKültürSalata = new string[5, 7] {
    { "Beyaz lahana salatası", "düşük", "düşük", "yüksek", "orta", "yok", "152,5" },
    { "Gavur Dağı Salatası", "orta", "yüksek", "orta", "orta", "orta", "113,78" },
    { "Olivye Salatası", "Orta", "Yüksek", "Düşük", "Orta", "Düşük", "110" },
    { "Bostona salatası", "düşük", "orta", "yüksek", "orta", "orta", "30" },
    { "iskilip Sirke Salatası", "düşük", "düşük", "yüksek", "yüksek", "yok", "150" }
};

            string[,] KiloVermekİsteyenFarklıKültürYemek = new string[26, 7] {
    { "Airag (ayrag)", "düşük", "düşük", "düşük", "düşük", "düşük", "297,3" },
    { "Schnitzel", "yüksek", "yüksek", "düşük", "orta", "yok", "285" },
    { "Bratwurst", "yüksek", "yüksek", "düşük", "yüksek", "yok", "281" },
    { "Sauerkraut", "düşük", "düşük", "düşük", "yüksek", "orta", "273,9" },
    { "Kartoffelsalat", "düşük", "orta", "yüksek", "orta", "düşük", "268" },
    { "Königsberger Klopse", "yüksek", "orta", "düşük", "orta", "düşük", "262" },
    { "Rouladen", "yüksek", "orta", "düşük", "orta", "düşük", "261,26" },
    { "Schwarzwü¤lder Kirschtorte", "düşük", "yüksek", "yüksek", "düşük", "yüksek", "259" },
    { "Weisswurst", "yüksek", "orta", "düşük", "orta", "yok", "250" },
    { "Shepherd's Pie", "Yüksek", "Orta", "Orta", "Orta", "Düşük", "141" },
    { "Fish and Chips", "Yüksek", "Yüksek", "Yüksek", "Orta", "Düşük", "140" },
    { "Full English Breakfast", "Yüksek", "Yüksek", "Orta", "Orta", "Düşük", "138,1" },
    { "Roast Beef and Yorkshire Pudding", "Yüksek", "Orta", "Düşük", "Orta", "Düşük", "128" },
    { "Toad in the Hole", "Yüksek", "Orta", "Orta", "Orta", "Düşük", "127" },
    { "Steak and Kidney Pie", "Yüksek", "Yüksek", "Orta", "Orta", "Düşük", "116" },
    { "Cornish Pasty", "Orta", "Orta", "Orta", "Orta", "Düşük", "113" },
    { "Ploughman's Lunch", "Yüksek", "Orta", "Orta", "Orta", "Düşük", "112" },
    { "Bubble and Squeak", "Orta", "Orta", "Orta", "Orta", "Düşük", "108" },
    { "Adas polo", "Yüksek", "Orta", "Yüksek", "Orta", "Yok", "98,9" },
    { "Baghali polo", "Yüksek", "Orta", "Yüksek", "Orta", "Yok", "98" },
    { "Chelo kabab", "Yüksek", "Yüksek", "Düşük", "Orta", "Yok", "91" },
    { "Fesenjan", "Düşük", "Orta", "Düşük", "Orta", "Yüksek", "50" },
    { "Ghormeh sabzi", "Yüksek", "Orta", "Düşük", "Orta", "Yok", "50" },
    { "Kebab koobideh", "Yüksek", "Orta", "Düşük", "Orta", "Yok", "40" },
    { "Khoresh gheymeh", "Yüksek", "Orta", "Düşük", "Orta", "Yok", "18,9" },
    { "Khoresh bademjan", "Düşük", "Orta", "Düşük", "Orta", "Yok", "18,6" },
};
            string[,] KiloVermekİsteyenFarklıKültürÇorba = new string[4, 7] {
    { "Herle çorbası", "orta", "düşük", "yüksek", "düşük", "yok", "93" },
    { "Harput çorbası", "orta", "düşük", "yüksek", "orta", "yok", "71" },
    { "Düğür çorbası", "yüksek", "orta", "orta", "orta", "orta", "80" },
    { "Gebol", "yüksek", "orta", "orta", "orta", "orta", "150" },
};
            string[,] KiloVermekİsteyenFarklıKültürSalata = new string[5, 7] {
    { "Beyaz lahana salatası", "düşük", "düşük", "yüksek", "orta", "yok", "152,5" },
    { "Gavur Dağı Salatası", "orta", "yüksek", "orta", "orta", "orta", "113,78" },
    { "Olivye Salatası", "Orta", "Yüksek", "Düşük", "Orta", "Düşük", "110" },
    { "Bostona salatası", "düşük", "orta", "yüksek", "orta", "orta", "30" },
    { "Antep salatası", "düşük", "orta", "düşük", "orta", "yok", "270" },
};

            string[,] KiloAlmakİsteyenSağlıklıTürkYemekleri = new string[29, 7] {
    { "Balıkesir kaymaklısı", "orta", "yüksek", "yüksek", "düşük", "yüksek", "1200" },
    { "Kazan Kebabı", "yüksek", "orta", "orta", "orta", "yok", "1599" },
    { "Fıstıklı Kebap", "yüksek", "yüksek", "orta", "orta", "yüksek", "1169,3" },
    { "Balıkesir mantısı", "yüksek", "orta", "yüksek", "orta", "orta", "1128" },
    { "iskender Kebabı", "yüksek", "yüksek", "düşük", "düşük", "yok", "755" },
    { "Biryani", "yüksek", "orta", "yüksek", "orta", "düşük", "720" },
    { "Alt-üst böreği", "düşük", "yüksek", "orta", "orta", "orta", "691,8" },
    { "Hamsi Tava", "yüksek", "yüksek", "düşük", "orta", "yok", "680,55" },
    { "Cağ kebabı", "yüksek", "orta", "düşük", "orta", "yok", "672" },
    { "çağ kebabı", "yüksek", "orta", "düşük", "orta", "yok", "672" },
    { "Böşamel soslu somon", "Orta", "Orta", "Orta", "Düşük", "Düşük", "658" },
    { "Domatesli gözleme", "yüksek", "düşük", "orta", "düşük", "yok", "606" },
    { "Etli Pide", "yüksek", "yüksek", "yüksek", "orta", "yok", "600" },
    { "Fırında Tavuklu Mantı", "yüksek", "orta", "orta", "orta", "orta", "600" },
    { "irmik Helvası", "düşük", "yüksek", "yüksek", "düşük", "orta", "532" },
    { "çiğ börek", "orta", "yüksek", "yüksek", "orta", "yok", "528" },
    { "Halil ibrahim Sofrası Kebabı", "yüksek", "yüksek", "orta", "orta", "yok", "528" },
    { "Islama Köfte", "yüksek", "düşük", "düşük", "orta", "yok", "520" },
    { "Kaburga Kebabı", "yüksek", "orta", "düşük", "orta", "yok", "500" },
    { "incik Yahnisi", "yüksek", "orta", "düşük", "orta", "yok", "490" },
    { "Beyti kebabı", "yüksek", "yüksek", "orta", "orta", "yok", "489,37" },
    { "Hünkü¢rbeğendi", "orta", "yüksek", "düşük", "orta", "yüksek", "469" },
    { "Patatas bravas", "Düşük", "Orta", "Yüksek", "Orta", "Düşük", "458" },
    { "Kemal Zade Kebabı", "yüksek", "orta", "orta", "orta", "yok", "441,4" },
    { "Alanya kebabı", "yüksek", "orta", "düşük", "orta", "yok", "420" },
    { "Ali nazik kebabı", "yüksek", "orta", "düşük", "orta", "yok", "407,46" },
    { "Bonfile kebabı", "yüksek", "yüksek", "düşük", "orta", "yok", "380" },
    { "istim Kebap", "yüksek", "düşük", "düşük", "orta", "yok", "380" },
    { "Etli Kuru Fasülye", "yüksek", "düşük", "yüksek", "orta", "yok", "377" } };
            string[,] KiloAlmakİsteyenSağlıklıTürkÇorba = new string[7, 7] {
    { "Börek çorbası", "orta", "orta", "yüksek", "orta", "yok", "367,8" },
    { "Ekşili çorba", "orta", "yüksek", "orta", "orta", "yok", "286" },
    { "Arpa şehriye çorbası", "düşük", "düşük", "orta", "orta", "orta", "181" },
    { "Hamur çorbası", "düşük", "düşük", "yüksek", "orta", "yok", "167" },
    { "Kara Lahana çorbası", "yüksek", "düşük", "düşük", "orta", "yok", "106,92" },
    { "Ispanak çorbası", "düşük", "düşük", "yüksek", "düşük", "yüksek", "104" },
    { "mercimek çorbası", "orta", "yüksek", "düşük", "orta", "yok", "136" }
};
            string[,] KiloAlmakİsteyenSağlıklıTürkSalata = new string[6, 7] {
    { "Ispanak Salatası", "düşük", "yüksek", "düşük", "orta", "yok", "154" },
    { "Bulgur salatası", "orta", "orta", "yüksek", "orta", "orta", "147,5" },
    { "çoban salatası", "orta", "orta", "düşük", "orta", "yok", "120" },
    { "Havuç Salatası", "düşük", "yüksek", "düşük", "düşük", "yüksek", "68" },
    { "Bostona salatası", "düşük", "orta", "yüksek", "orta", "orta", "30" },
    { "Antep salatası", "düşük", "orta", "düşük", "orta", "yok", "270" }
};

            string[,] KiloVermekİsteyenSağlıklıTürkYemek = new string[21, 7] {
    { "Buğu kebabı", "yüksek", "yüksek", "düşük", "orta", "yok", "305,26" },
    { "Bahçıvan kebabı", "yüksek", "yüksek", "düşük", "orta", "yok", "302,5" },
    { "Döner kebabı", "yüksek", "yüksek", "düşük", "orta", "yok", "301" },
    { "çardak kebabı", "yüksek", "orta", "düşük", "orta", "yok", "300" },
    { "Kartalaç", "yüksek", "düşük", "düşük", "orta", "yok", "260" },
    { "Bolu orman kebabı", "yüksek", "yüksek", "düşük", "orta", "yok", "255" },
    { "Domatesli pirinç pilavı", "düşük", "düşük", "yüksek", "düşük", "yok", "255" },
    { "Abugannuş kebabı", "yüksek", "orta", "düşük", "orta", "yok", "254" },
    { "Arap aşı", "orta", "orta", "orta", "orta", "orta", "250" },
    { "Bıldırcın kebabı", "yüksek", "yüksek", "düşük", "orta", "yok", "250" },
    { "Dalyan köfte", "yüksek", "orta", "düşük", "orta", "yok", "149,1" },
    { "Güveç", "orta", "orta", "yüksek", "orta", "orta", "148" },
    { "Ciğer tava", "yüksek", "yüksek", "düşük", "orta", "yok", "147" },
    { "Haşhaşlı Nokul", "düşük", "yüksek", "yüksek", "düşük", "yüksek", "140" },
    { "Kara Lahana çorbasık", "yüksek", "düşük", "düşük", "orta", "yok", "106,92" },
    { "Ispanak çorbası", "düşük", "düşük", "yüksek", "düşük", "yüksek", "104" },
    { "Acı filiz", "düşük", "düşük", "düşük", "düşük", "yok", "100" },
    { "Soba", "yüksek", "düşük", "yüksek", "orta", "yok", "98,9" },
    { "Dövme pilavı", "orta", "düşük", "yüksek", "düşük", "yok", "35,91" },
    { "Bulgur pilavı", "orta", "orta", "yüksek", "orta", "yok", "34" },
    { "çubuk turşu", "düşük", "düşük", "düşük", "yüksek", "yok", "7" }
};
            string[,] KiloVermekİsteyenSağlıklıTürkÇorba = new string[5, 7] {
     { "İşkembe çorbası", "yüksek", "düşük", "düşük", "yüksek", "yok", "73,9" },
            { "Harput çorbası", "orta", "düşük", "yüksek", "orta", "yok", "71" },
            { "Bamya çorbası", "orta", "orta", "yüksek", "orta", "yok", "46" },
            { "Analı kızlı", "yüksek", "orta", "düşük", "orta", "orta", "45" },
            { "Arap aşı", "orta", "orta", "orta", "orta", "orta", "250" }

};
            string[,] KiloVermekİsteyenSağlıklıTürkSalata = new string[4, 7] {
    { "Bulgur salatası", "orta", "orta", "yüksek", "orta", "orta", "147,5" },
    { "çoban salatası", "orta", "orta", "düşük", "orta", "yok", "120" },
    { "Cevizli patlıcan salatası", "düşük", "orta", "düşük", "orta", "yok", "80" },
    { "sade orta yağlı yoğurt", "yüksek", "orta", "düşük", "yok", "", "50" }
};

            string[,] KilosunuKorumakİsteyenFarklıKültürYemek = new string[11, 7] {
    { "Moules frites", "Orta", "Orta", "Orta", "Yüksek", "Düşük", "548" },
    { "Tortilla Espaü±ola", "Yüksek", "Orta", "Düşük", "Orta", "Düşük", "523" },
    { "Cornish Pasty", "Orta", "Orta", "Orta", "Orta", "Düşük", "225" },
    { "Kaysafa", "düşük", "yüksek", "düşük", "orta", "yok", "220" },
    { "Ploughman's Lunch", "Yüksek", "Orta", "Orta", "Orta", "Düşük", "212" },
    { "Duxelles", "orta", "yüksek", "düşük", "orta", "yok", "63" },
    { "Khoresh bademjan", "Düşük", "Orta", "Düşük", "Orta", "Yok", "56" },
    { "Tahchin", "Yüksek", "Orta", "Yüksek", "Orta", "Yok", "44,6" },
    { "Sauerkraut", "düşük", "düşük", "düşük", "yüksek", "orta", "19" },
    { "Zereshk polo", "Düşük", "Orta", "Yüksek", "Orta", "Yok", "18,9" },
    { "Spü¤tzle", "düşük", "orta", "yüksek", "düşük", "düşük", "" },
};
            string[,] KilosunuKorumakİsteyenFarklıKültürÇorba = new string[5, 7] {
    { "Borscht çorbası", "Orta", "Düşük", "Orta", "Orta", "Orta", "220" },
    { "Amin çorbası ", "Yüksek", "Orta", "Orta", "Orta", "Yok", "220" },
    { "Herle çorbası", "Orta", "Düşük", "Yüksek", "Düşük", "Yok", "93" },
    { "Harput çorbası", "Orta", "Düşük", "Yüksek", "orta", "yok", "71" },
    { "Gebol's Lunch", "Yüksek", "Orta", "Orta", "Orta", "Orta", "150" },
};
            string[,] KilosunuKorumakİsteyenFarklıKültürSalata = new string[4, 7] {
    { "Beyaz lahana salatası", "düşük", "düşük", "yüksek", "orta", "yok", "152,5" },
    { "Bulgur salatası", "orta", "orta", "yüksek", "orta", "orta", "147,5" },
    { "Olivye Salatası", "Orta", "Yüksek", "Düşük", "Orta", "Düşük", "110" },
    { "Bostona salatası", "düşük", "orta", "yüksek", "orta", "orta", "30" },
};

            string[,] KilosunuKorumakİsteyenSağlıklıTürkYemekleri = new string[25, 7]
{
    { "Bonfile kebabı", "yüksek", "yüksek", "düşük", "orta", "yok","" },
    { "Celtik kebabı", "yüksek", "yüksek", "düşük", "orta", "yok","" },
    { "istim Kebap", "yüksek", "düşük", "düşük", "orta", "yok" ,""},
    { "Etli Kuru Fasülye", "yüksek", "düşük", "yüksek", "orta", "yok","" },
    { "Gelin Kebabı", "yüksek", "orta", "düşük", "düşük", "yok" ,""},
    { "Börek çorbası", "orta", "orta", "yüksek", "orta", "yok" ,""},
    { "Hamburger", "yüksek", "yüksek", "orta", "orta", "yüksek" ,""},
    { "Ekşili çorba", "orta", "yüksek", "orta", "orta", "yok" ,""},
    { "Hoşmerim", "orta", "yüksek", "yüksek", "düşük", "yüksek" ,""},
    { "Kartalaç", "yüksek", "düşük", "düşük", "orta", "yok" ,""},
    { "Bolu orman kebabı", "yüksek", "yüksek", "düşük", "orta", "yok","" },
    { "Domatesli pirinç pilavı", "düşük", "düşük", "yüksek", "düşük", "yok","" },
    { "Abugannuş kebabı", "yüksek", "orta", "düşük", "orta", "yok","" },
    { "Hamsi Tuzlaması", "yüksek", "yüksek", "düşük", "düşük", "orta" ,""},
    { "Kereviz Dolması", "düşük", "yüksek", "düşük", "orta", "yok","" },
    { "Altı ezmeli tike kebabı", "yüksek", "orta", "düşük", "orta", "yok" ,""},
    { "Hasan Paşa Köftesi", "yüksek", "orta", "düşük", "orta", "orta" ,""},
    { "izmir Köfte", "yüksek", "düşük", "düşük", "orta", "yok" ,""},
    { "Domates dolması", "orta", "düşük", "orta", "orta", "yok" ,""},
    { "Elma Kompostosu", "düşük", "düşük", "yüksek", "düşük", "yüksek" ,"" },
    { "Karnıyarık", "yüksek", "orta", "düşük", "orta", "yok" ,""},
    { "Sushi", "yüksek", "düşük", "yüksek", "yüksek", "yok" ,""},
    { "istanbul Pilavı", "orta", "düşük", "yüksek", "düşük", "yok" ,""},
    { "Haşhaşlı Nokul", "düşük", "yüksek", "yüksek", "düşük", "yüksek" ,""},
    { "Etli Patlıcan", "orta", "orta", "orta", "yok", "" ,""}
};
            string[,] KilosunuKorumakİsteyenSağlıklıTürkÇorba = new string[6, 7]
{
    { "Arpa şehriye çorbası", "düşük", "düşük", "orta", "orta", "orta" ,""},
    { "Amin çorbası", "yüksek", "orta", "orta", "orta", "yok" ,""},
    { "Hamur çorbası", "düşük", "düşük", "yüksek", "orta", "yok" ,""},
    { "Kara Lahana çorbası", "yüksek", "düşük", "düşük", "orta", "yok" ,""},
    { "Ispanak çorbası", "düşük", "düşük", "yüksek", "düşük", "yüksek" ,""},
    { "Bulgur çorbası", "orta", "düşük", "yüksek", "orta", "yok" ,""}
};
            string[,] KilosunuKorumakİsteyenSağlıklıTürkSalata = new string[4, 7]
{
    { "Ispanak Salatası", "düşük", "yüksek", "düşük", "orta", "yok" ,""},
    { "Beyaz lahana salatası", "düşük", "düşük", "yüksek", "orta", "yok" ,""},
    { "Gavur Dağı Salatas", "orta", "yüksek", "orta", "orta", "orta" ,""},
    { "Havuç Salatası", "düşük", "yüksek", "düşük", "düşük", "yüksek" ,""}
};

            string[,] ŞekerHasatasıTürkYemek = new string[10, 7]
{
    { "içli Patates Köftesi", "düşük", "yüksek", "yüksek", "düşük", "yok" ,""},
    { "Patatas bravas", "Düşük", "Orta", "Yüksek", "Orta", "Düşük","" },
    { "Bazlama", "orta", "düşük", "yüksek", "düşük", "yok" ,""},
    { "Kastamonu Ekşili Pilavı", "düşük", "düşük", "yüksek", "düşük", "yok","" },
    { "Erişte", "orta", "düşük", "yüksek", "düşük", "yok","" },
    { "islim Köfte", "yüksek", "düşük", "düşük", "orta", "yok","" },
    { "Antep salatası", "düşük", "orta", "düşük", "orta", "yok","" },
    { "Domatesli pirinç pilavı", "düşük", "düşük", "yüksek", "düşük", "yok" ,""},
    { "Kereviz Dolması", "düşük", "yüksek", "düşük", "orta", "yok" ,""},
    { "iskilip Turşusu", "düşük", "düşük", "yüksek", "yüksek", "yok" ,""}
};
            string[,] ŞekerHasatasıTürkÇorba = new string[6, 7]
{
    { "Börek çorbası", "orta", "orta", "yüksek", "orta", "yok", "367,8" },
            { "Hamur çorbası", "düşük", "düşük", "yüksek", "orta", "yok", "167" },
            { "Ispanak çorbası", "düşük", "düşük", "yüksek", "düşük", "yüksek", "104" },
            { "Herle çorbası", "orta", "düşük", "yüksek", "düşük", "yok", "93" },
            { "Düğün çorbası", "orta", "orta", "orta", "orta", "orta", "92" },
            { "Bamya çorbası", "orta", "orta", "yüksek", "orta", "yok", "46" }

};
            string[,] ŞekerHasatasıTürkSalata = new string[5, 7]
{
    { "Bulgur salatası", "orta", "orta", "yüksek", "orta", "orta" ,""},
    { "çoban salatası", "orta", "orta", "düşük", "orta", "yok","" },
    { "Antep salatası", "düşük", "orta", "düşük", "orta", "yok","" },
    { "iskilip Sirke Salatası", "düşük", "düşük", "yüksek", "yüksek", "yok","" },
    { "sade orta yağlı yoğurt", "yüksek", "orta", "düşük", "yok","", "" }
};

            string[,] TansiyonHastasıTürkYemek = new string[15, 7]
{
     { "Balıkesir kaymaklısı", "orta", "yüksek", "yüksek", "düşük", "yüksek" ,""},
    { "iskender Kebabı", "yüksek", "yüksek", "düşük", "düşük", "yok","" },
    { "Domatesli gözleme", "yüksek", "düşük", "orta", "düşük", "yok" ,""},
    { "iskeçe Köfte", "yüksek", "yüksek", "düşük", "düşük", "yok" ,""},
    { "irmik Helvası", "düşük", "yüksek", "yüksek", "düşük", "orta","" },
    { "içli Patates Köftesi", "düşük", "yüksek", "yüksek", "düşük", "yok","" },
    { "Hünkü¢rbeğendi", "orta", "yüksek", "düşük", "orta", "yüksek" ,""},
    { "Kaymaçinadüşük", "yüksek", "düşük", "düşük", "düşük", "yok","" },
    { "Kastamonu Ekşili Pilavı", "düşük", "düşük", "yüksek", "düşük", "yok","" },
    { "Gönül Kebabı", "yüksek", "orta", "düşük", "düşük", "yok","" },
    { "içli Köfte", "yüksek", "orta", "yüksek", "düşük", "yok" ,""},
    { "Erişte", "orta", "düşük", "yüksek", "düşük", "yok","" },
    { "Acı filiz", "düşük", "düşük", "düşük", "düşük", "yok","" },
    { "Kabak Bayıldı", "düşük", "düşük", "yüksek", "düşük", "yok",""},
    { "Dövme pilavı", "orta", "düşük", "yüksek", "düşük", "yok" ,""}
};
            string[,] TansiyonHastasıTürkÇorba = new string[8, 7]
{
    { "Börek çorbası", "orta", "orta", "yüksek", "orta", "yok" ,""},
    { "Arpa şehriye çorbası", "düşük", "düşük", "orta", "orta", "orta" ,""},
    { "Hamur çorbası", "düşük", "düşük", "yüksek", "orta", "yok","" },
    { "Ispanak çorbası", "düşük", "düşük", "yüksek", "düşük", "yüksek" ,""},
    { "Bahçıvan çorbası", "orta", "orta", "yüksek", "orta", "yok" ,""},
    { "Harput çorbası", "orta", "düşük", "yüksek", "orta", "yok" ,""},
    { "Bamya çorbası", "orta", "orta", "yüksek", "orta", "yok","" },
    { "Herle çorbası", "orta", "düşük", "yüksek", "düşük", "yok" ,""}
};
            string[,] TansiyonHastasıTürkSalata = new string[4, 7]
{
   { "Antep salatası", "düşük", "orta", "düşük", "orta", "yok" ,""},
    { "iskilip Sirke Salatası", "düşük", "düşük", "yüksek", "yüksek", "yok" ,""},
    { "sade orta yağlı yoğurt", "yüksek", "orta", "düşük", "yok", "" ,""},
    { "Gönül Kebabı", "yüksek", "orta", "düşük", "düşük", "yok" ,""}
};
            #endregion
            List<YemekOzellikler> yemekOzelliklers = new List<YemekOzellikler>();
            //kilo almak 0 kilo vermek 1 kilo koruumak 2

            if (diyet.tansiyonHastasi == 0 && diyet.sekerHastasi == 0 && diyet.kalpHastasi == 0 && diyet.farkliKulturlerden == 1 && diyet.hedef == 0)
            {
                //kullanilacakYemekler = "kilo_almak_isteyen_farklı_kültür.xlsx içindeki bir çorba, bir yemek, bir salata";
                #region RastgeleSonuçlarÜretme


                Random random = new Random();
                int satirIndex = random.Next(KiloAlmakİsteyenFarklıKültürYemek.GetLength(0));
                YemekOzellikler yemekOzellikler = new YemekOzellikler();
                for (int i = 0; i < KiloAlmakİsteyenFarklıKültürYemek.GetLength(1); i++)
                {

                    yemekOzellikler.Yemekler = KiloAlmakİsteyenFarklıKültürYemek[satirIndex, 0];
                    yemekOzellikler.Protein = KiloAlmakİsteyenFarklıKültürYemek[satirIndex, 1];
                    yemekOzellikler.Yağ = KiloAlmakİsteyenFarklıKültürYemek[satirIndex, 2];
                    yemekOzellikler.Karbonhidrat = KiloAlmakİsteyenFarklıKültürYemek[satirIndex, 3];
                    yemekOzellikler.Tuz = KiloAlmakİsteyenFarklıKültürYemek[satirIndex, 4];
                    yemekOzellikler.Şeker = KiloAlmakİsteyenFarklıKültürYemek[satirIndex, 5];
                    yemekOzellikler.Kalori = KiloAlmakİsteyenFarklıKültürYemek[satirIndex, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler);
                Random random1 = new Random();
                int satirIndex1 = random1.Next(KiloAlmakİsteyenFarklıKültürÇorba.GetLength(0));
                YemekOzellikler yemekOzellikler1 = new YemekOzellikler();
                for (int i = 0; i < KiloAlmakİsteyenFarklıKültürÇorba.GetLength(1); i++)
                {

                    yemekOzellikler1.Yemekler = KiloAlmakİsteyenFarklıKültürÇorba[satirIndex1, 0];
                    yemekOzellikler1.Protein = KiloAlmakİsteyenFarklıKültürÇorba[satirIndex1, 1];
                    yemekOzellikler1.Yağ = KiloAlmakİsteyenFarklıKültürÇorba[satirIndex1, 2];
                    yemekOzellikler1.Karbonhidrat = KiloAlmakİsteyenFarklıKültürÇorba[satirIndex1, 3];
                    yemekOzellikler1.Tuz = KiloAlmakİsteyenFarklıKültürÇorba[satirIndex1, 4];
                    yemekOzellikler1.Şeker = KiloAlmakİsteyenFarklıKültürÇorba[satirIndex1, 5];
                    yemekOzellikler1.Kalori = KiloAlmakİsteyenFarklıKültürÇorba[satirIndex1, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler1);


                Random random2 = new Random();
                int satirIndex2 = random2.Next(KiloAlmakİsteyenFarklıKültürSalata.GetLength(0));
                YemekOzellikler yemekOzellikler2 = new YemekOzellikler();
                for (int i = 0; i < KiloAlmakİsteyenFarklıKültürSalata.GetLength(1); i++)
                {

                    yemekOzellikler2.Yemekler = KiloAlmakİsteyenFarklıKültürSalata[satirIndex2, 0];
                    yemekOzellikler2.Protein = KiloAlmakİsteyenFarklıKültürSalata[satirIndex2, 1];
                    yemekOzellikler2.Yağ = KiloAlmakİsteyenFarklıKültürSalata[satirIndex2, 2];
                    yemekOzellikler2.Karbonhidrat = KiloAlmakİsteyenFarklıKültürSalata[satirIndex2, 3];
                    yemekOzellikler2.Tuz = KiloAlmakİsteyenFarklıKültürSalata[satirIndex2, 4];
                    yemekOzellikler2.Şeker = KiloAlmakİsteyenFarklıKültürSalata[satirIndex2, 5];
                    yemekOzellikler2.Kalori = KiloAlmakİsteyenFarklıKültürSalata[satirIndex2, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler2);
                return View(yemekOzelliklers.ToList());
                #endregion
            }
            else if (diyet.tansiyonHastasi == 0 && diyet.sekerHastasi == 0 && diyet.kalpHastasi == 0 && diyet.farkliKulturlerden == 0 && diyet.hedef == 0)
            {
                //kullanilacakYemekler = "kilo_almak_isteyen_türk_yemekleri.xlsx içindeki bir çorba, bir yemek, bir salata";
                #region RastgeleSonuçlarÜretme


                Random random = new Random();
                int satirIndex = random.Next(KiloAlmakİsteyenSağlıklıTürkYemekleri.GetLength(0));
                YemekOzellikler yemekOzellikler12 = new YemekOzellikler();
                for (int i = 0; i < KiloAlmakİsteyenSağlıklıTürkYemekleri.GetLength(1); i++)
                {

                    yemekOzellikler12.Yemekler = KiloAlmakİsteyenSağlıklıTürkYemekleri[satirIndex, 0];
                    yemekOzellikler12.Protein = KiloAlmakİsteyenSağlıklıTürkYemekleri[satirIndex, 1];
                    yemekOzellikler12.Yağ = KiloAlmakİsteyenSağlıklıTürkYemekleri[satirIndex, 2];
                    yemekOzellikler12.Karbonhidrat = KiloAlmakİsteyenSağlıklıTürkYemekleri[satirIndex, 3];
                    yemekOzellikler12.Tuz = KiloAlmakİsteyenSağlıklıTürkYemekleri[satirIndex, 4];
                    yemekOzellikler12.Şeker = KiloAlmakİsteyenSağlıklıTürkYemekleri[satirIndex, 5];
                    yemekOzellikler12.Kalori = KiloAlmakİsteyenSağlıklıTürkYemekleri[satirIndex, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler12);
                Random random1 = new Random();
                int satirIndex1 = random1.Next(KiloAlmakİsteyenSağlıklıTürkÇorba.GetLength(0));
                YemekOzellikler yemekOzellikler1 = new YemekOzellikler();
                for (int i = 0; i < KiloAlmakİsteyenSağlıklıTürkÇorba.GetLength(1); i++)
                {

                    yemekOzellikler1.Yemekler = KiloAlmakİsteyenSağlıklıTürkÇorba[satirIndex1, 0];
                    yemekOzellikler1.Protein = KiloAlmakİsteyenSağlıklıTürkÇorba[satirIndex1, 1];
                    yemekOzellikler1.Yağ = KiloAlmakİsteyenSağlıklıTürkÇorba[satirIndex1, 2];
                    yemekOzellikler1.Karbonhidrat = KiloAlmakİsteyenSağlıklıTürkÇorba[satirIndex1, 3];
                    yemekOzellikler1.Tuz = KiloAlmakİsteyenSağlıklıTürkÇorba[satirIndex1, 4];
                    yemekOzellikler1.Şeker = KiloAlmakİsteyenSağlıklıTürkÇorba[satirIndex1, 5];
                    yemekOzellikler1.Kalori = KiloAlmakİsteyenSağlıklıTürkÇorba[satirIndex1, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler1);


                Random random2 = new Random();
                int satirIndex2 = random2.Next(KiloAlmakİsteyenSağlıklıTürkSalata.GetLength(0));
                YemekOzellikler yemekOzellikler2 = new YemekOzellikler();
                for (int i = 0; i < KiloAlmakİsteyenFarklıKültürSalata.GetLength(1); i++)
                {

                    yemekOzellikler2.Yemekler = KiloAlmakİsteyenSağlıklıTürkSalata[satirIndex2, 0];
                    yemekOzellikler2.Protein = KiloAlmakİsteyenSağlıklıTürkSalata[satirIndex2, 1];
                    yemekOzellikler2.Yağ = KiloAlmakİsteyenSağlıklıTürkSalata[satirIndex2, 2];
                    yemekOzellikler2.Karbonhidrat = KiloAlmakİsteyenSağlıklıTürkSalata[satirIndex2, 3];
                    yemekOzellikler2.Tuz = KiloAlmakİsteyenSağlıklıTürkSalata[satirIndex2, 4];
                    yemekOzellikler2.Şeker = KiloAlmakİsteyenSağlıklıTürkSalata[satirIndex2, 5];
                    yemekOzellikler2.Kalori = KiloAlmakİsteyenSağlıklıTürkSalata[satirIndex2, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler2);
                return View(yemekOzelliklers.ToList());
                #endregion
            }
            else if (diyet.tansiyonHastasi == 0 && diyet.sekerHastasi == 0 && diyet.kalpHastasi == 0 && diyet.farkliKulturlerden == 1 && diyet.hedef == 1)
            {
                //    kullanilacakYemekler = "kilo_vermek_isteyen_farklı_kültür.xlsx içindeki bir çorba, bir yemek, bir salata";
                #region RastgeleSonuçlarÜretme


                Random random = new Random();
                int satirIndex = random.Next(KiloVermekİsteyenFarklıKültürYemek.GetLength(0));
                YemekOzellikler yemekOzellikler12 = new YemekOzellikler();
                for (int i = 0; i < KiloVermekİsteyenFarklıKültürYemek.GetLength(1); i++)
                {

                    yemekOzellikler12.Yemekler = KiloVermekİsteyenFarklıKültürYemek[satirIndex, 0];
                    yemekOzellikler12.Protein = KiloVermekİsteyenFarklıKültürYemek[satirIndex, 1];
                    yemekOzellikler12.Yağ = KiloVermekİsteyenFarklıKültürYemek[satirIndex, 2];
                    yemekOzellikler12.Karbonhidrat = KiloVermekİsteyenFarklıKültürYemek[satirIndex, 3];
                    yemekOzellikler12.Tuz = KiloVermekİsteyenFarklıKültürYemek[satirIndex, 4];
                    yemekOzellikler12.Şeker = KiloVermekİsteyenFarklıKültürYemek[satirIndex, 5];
                    yemekOzellikler12.Kalori = KiloVermekİsteyenFarklıKültürYemek[satirIndex, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler12);
                Random random1 = new Random();
                int satirIndex1 = random1.Next(KiloVermekİsteyenFarklıKültürÇorba.GetLength(0));
                YemekOzellikler yemekOzellikler1 = new YemekOzellikler();
                for (int i = 0; i < KiloVermekİsteyenFarklıKültürÇorba.GetLength(1); i++)
                {

                    yemekOzellikler1.Yemekler = KiloVermekİsteyenFarklıKültürÇorba[satirIndex1, 0];
                    yemekOzellikler1.Protein = KiloVermekİsteyenFarklıKültürÇorba[satirIndex1, 1];
                    yemekOzellikler1.Yağ = KiloVermekİsteyenFarklıKültürÇorba[satirIndex1, 2];
                    yemekOzellikler1.Karbonhidrat = KiloVermekİsteyenFarklıKültürÇorba[satirIndex1, 3];
                    yemekOzellikler1.Tuz = KiloVermekİsteyenFarklıKültürÇorba[satirIndex1, 4];
                    yemekOzellikler1.Şeker = KiloVermekİsteyenFarklıKültürÇorba[satirIndex1, 5];
                    yemekOzellikler1.Kalori = KiloVermekİsteyenFarklıKültürÇorba[satirIndex1, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler1);


                Random random2 = new Random();
                int satirIndex2 = random2.Next(KiloVermekİsteyenFarklıKültürSalata.GetLength(0));
                YemekOzellikler yemekOzellikler2 = new YemekOzellikler();
                for (int i = 0; i < KiloVermekİsteyenFarklıKültürSalata.GetLength(1); i++)
                {

                    yemekOzellikler2.Yemekler = KiloVermekİsteyenFarklıKültürSalata[satirIndex2, 0];
                    yemekOzellikler2.Protein = KiloVermekİsteyenFarklıKültürSalata[satirIndex2, 1];
                    yemekOzellikler2.Yağ = KiloVermekİsteyenFarklıKültürSalata[satirIndex2, 2];
                    yemekOzellikler2.Karbonhidrat = KiloVermekİsteyenFarklıKültürSalata[satirIndex2, 3];
                    yemekOzellikler2.Tuz = KiloVermekİsteyenFarklıKültürSalata[satirIndex2, 4];
                    yemekOzellikler2.Şeker = KiloVermekİsteyenFarklıKültürSalata[satirIndex2, 5];
                    yemekOzellikler2.Kalori = KiloVermekİsteyenFarklıKültürSalata[satirIndex2, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler2);
                return View(yemekOzelliklers.ToList());
                #endregion
            }
            else if (diyet.tansiyonHastasi == 0 && diyet.sekerHastasi == 0 && diyet.kalpHastasi == 0 && diyet.farkliKulturlerden == 0 && diyet.hedef == 1)
            {
                //  kullanilacakYemekler = "kilo_vermek_isteyen_türk_yemekleri.xlsx içindeki bir çorba, bir yemek, bir salata";
                #region RastgeleSonuçlarÜretme


                Random random = new Random();
                int satirIndex = random.Next(KiloVermekİsteyenSağlıklıTürkYemek.GetLength(0));
                YemekOzellikler yemekOzellikler12 = new YemekOzellikler();
                for (int i = 0; i < KiloVermekİsteyenSağlıklıTürkYemek.GetLength(1); i++)
                {

                    yemekOzellikler12.Yemekler = KiloVermekİsteyenSağlıklıTürkYemek[satirIndex, 0];
                    yemekOzellikler12.Protein = KiloVermekİsteyenSağlıklıTürkYemek[satirIndex, 1];
                    yemekOzellikler12.Yağ = KiloVermekİsteyenSağlıklıTürkYemek[satirIndex, 2];
                    yemekOzellikler12.Karbonhidrat = KiloVermekİsteyenSağlıklıTürkYemek[satirIndex, 3];
                    yemekOzellikler12.Tuz = KiloVermekİsteyenSağlıklıTürkYemek[satirIndex, 4];
                    yemekOzellikler12.Şeker = KiloVermekİsteyenSağlıklıTürkYemek[satirIndex, 5];
                    yemekOzellikler12.Kalori = KiloVermekİsteyenSağlıklıTürkYemek[satirIndex, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler12);
                Random random1 = new Random();
                int satirIndex1 = random1.Next(KiloVermekİsteyenSağlıklıTürkÇorba.GetLength(0));
                YemekOzellikler yemekOzellikler1 = new YemekOzellikler();
                for (int i = 0; i < KiloVermekİsteyenSağlıklıTürkÇorba.GetLength(1); i++)
                {

                    yemekOzellikler1.Yemekler = KiloVermekİsteyenSağlıklıTürkÇorba[satirIndex1, 0];
                    yemekOzellikler1.Protein = KiloVermekİsteyenSağlıklıTürkÇorba[satirIndex1, 1];
                    yemekOzellikler1.Yağ = KiloVermekİsteyenSağlıklıTürkÇorba[satirIndex1, 2];
                    yemekOzellikler1.Karbonhidrat = KiloVermekİsteyenSağlıklıTürkÇorba[satirIndex1, 3];
                    yemekOzellikler1.Tuz = KiloVermekİsteyenSağlıklıTürkÇorba[satirIndex1, 4];
                    yemekOzellikler1.Şeker = KiloVermekİsteyenSağlıklıTürkÇorba[satirIndex1, 5];
                    yemekOzellikler1.Kalori = KiloVermekİsteyenSağlıklıTürkÇorba[satirIndex1, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler1);


                Random random2 = new Random();
                int satirIndex2 = random2.Next(KiloVermekİsteyenSağlıklıTürkSalata.GetLength(0));
                YemekOzellikler yemekOzellikler2 = new YemekOzellikler();
                for (int i = 0; i < KiloVermekİsteyenFarklıKültürSalata.GetLength(1); i++)
                {

                    yemekOzellikler2.Yemekler = KiloVermekİsteyenSağlıklıTürkSalata[satirIndex2, 0];
                    yemekOzellikler2.Protein = KiloVermekİsteyenSağlıklıTürkSalata[satirIndex2, 1];
                    yemekOzellikler2.Yağ = KiloVermekİsteyenSağlıklıTürkSalata[satirIndex2, 2];
                    yemekOzellikler2.Karbonhidrat = KiloVermekİsteyenSağlıklıTürkSalata[satirIndex2, 3];
                    yemekOzellikler2.Tuz = KiloVermekİsteyenSağlıklıTürkSalata[satirIndex2, 4];
                    yemekOzellikler2.Şeker = KiloVermekİsteyenSağlıklıTürkSalata[satirIndex2, 5];
                    yemekOzellikler2.Kalori = KiloVermekİsteyenSağlıklıTürkSalata[satirIndex2, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler2);
                return View(yemekOzelliklers.ToList());
                #endregion
            }
            else if (diyet.tansiyonHastasi == 0 && diyet.sekerHastasi == 0 && diyet.kalpHastasi == 0 && diyet.farkliKulturlerden == 0 && diyet.hedef == 2)
            {
                //kullanilacakYemekler = "kilo_korumak_isteyen_türk_yemekleri.xlsx içindeki bir çorba, bir yemek, bir salata";
                #region RastgeleSonuçlarÜretme


                Random random = new Random();
                int satirIndex = random.Next(KilosunuKorumakİsteyenSağlıklıTürkYemekleri.GetLength(0));
                YemekOzellikler yemekOzellikler12 = new YemekOzellikler();
                for (int i = 0; i < KilosunuKorumakİsteyenSağlıklıTürkYemekleri.GetLength(1); i++)
                {

                    yemekOzellikler12.Yemekler = KilosunuKorumakİsteyenSağlıklıTürkYemekleri[satirIndex, 0];
                    yemekOzellikler12.Protein = KilosunuKorumakİsteyenSağlıklıTürkYemekleri[satirIndex, 1];
                    yemekOzellikler12.Yağ = KilosunuKorumakİsteyenSağlıklıTürkYemekleri[satirIndex, 2];
                    yemekOzellikler12.Karbonhidrat = KilosunuKorumakİsteyenSağlıklıTürkYemekleri[satirIndex, 3];
                    yemekOzellikler12.Tuz = KilosunuKorumakİsteyenSağlıklıTürkYemekleri[satirIndex, 4];
                    yemekOzellikler12.Şeker = KilosunuKorumakİsteyenSağlıklıTürkYemekleri[satirIndex, 5];
                    yemekOzellikler12.Kalori = KilosunuKorumakİsteyenSağlıklıTürkYemekleri[satirIndex, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler12);
                Random random1 = new Random();
                int satirIndex1 = random1.Next(KilosunuKorumakİsteyenSağlıklıTürkÇorba.GetLength(0));
                YemekOzellikler yemekOzellikler1 = new YemekOzellikler();
                for (int i = 0; i < KilosunuKorumakİsteyenSağlıklıTürkÇorba.GetLength(1); i++)
                {

                    yemekOzellikler1.Yemekler = KilosunuKorumakİsteyenSağlıklıTürkÇorba[satirIndex1, 0];
                    yemekOzellikler1.Protein = KilosunuKorumakİsteyenSağlıklıTürkÇorba[satirIndex1, 1];
                    yemekOzellikler1.Yağ = KilosunuKorumakİsteyenSağlıklıTürkÇorba[satirIndex1, 2];
                    yemekOzellikler1.Karbonhidrat = KilosunuKorumakİsteyenSağlıklıTürkÇorba[satirIndex1, 3];
                    yemekOzellikler1.Tuz = KilosunuKorumakİsteyenSağlıklıTürkÇorba[satirIndex1, 4];
                    yemekOzellikler1.Şeker = KilosunuKorumakİsteyenSağlıklıTürkÇorba[satirIndex1, 5];
                    yemekOzellikler1.Kalori = KilosunuKorumakİsteyenSağlıklıTürkÇorba[satirIndex1, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler1);


                Random random2 = new Random();
                int satirIndex2 = random2.Next(KilosunuKorumakİsteyenSağlıklıTürkSalata.GetLength(0));
                YemekOzellikler yemekOzellikler2 = new YemekOzellikler();
                for (int i = 0; i < KilosunuKorumakİsteyenSağlıklıTürkSalata.GetLength(1); i++)
                {

                    yemekOzellikler2.Yemekler = KilosunuKorumakİsteyenSağlıklıTürkSalata[satirIndex2, 0];
                    yemekOzellikler2.Protein = KilosunuKorumakİsteyenSağlıklıTürkSalata[satirIndex2, 1];
                    yemekOzellikler2.Yağ = KilosunuKorumakİsteyenSağlıklıTürkSalata[satirIndex2, 2];
                    yemekOzellikler2.Karbonhidrat = KilosunuKorumakİsteyenSağlıklıTürkSalata[satirIndex2, 3];
                    yemekOzellikler2.Tuz = KilosunuKorumakİsteyenSağlıklıTürkSalata[satirIndex2, 4];
                    yemekOzellikler2.Şeker = KilosunuKorumakİsteyenSağlıklıTürkSalata[satirIndex2, 5];
                    yemekOzellikler2.Kalori = KilosunuKorumakİsteyenSağlıklıTürkSalata[satirIndex2, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler2);
                return View(yemekOzelliklers.ToList());
                #endregion
            }
            else if (diyet.tansiyonHastasi == 0 && diyet.sekerHastasi == 0 && diyet.kalpHastasi == 0 && diyet.farkliKulturlerden == 1 && diyet.hedef == 2)
            {
                //kullanilacakYemekler = "kilo_korumak_isteyen_farklı_kültür.xlsx içindeki bir çorba, bir yemek, bir salata";
                #region RastgeleSonuçlarÜretme


                Random random = new Random();
                int satirIndex = random.Next(KilosunuKorumakİsteyenFarklıKültürYemek.GetLength(0));
                YemekOzellikler yemekOzellikler12 = new YemekOzellikler();
                for (int i = 0; i < KilosunuKorumakİsteyenFarklıKültürYemek.GetLength(1); i++)
                {

                    yemekOzellikler12.Yemekler = KilosunuKorumakİsteyenFarklıKültürYemek[satirIndex, 0];
                    yemekOzellikler12.Protein = KilosunuKorumakİsteyenFarklıKültürYemek[satirIndex, 1];
                    yemekOzellikler12.Yağ = KilosunuKorumakİsteyenFarklıKültürYemek[satirIndex, 2];
                    yemekOzellikler12.Karbonhidrat = KilosunuKorumakİsteyenFarklıKültürYemek[satirIndex, 3];
                    yemekOzellikler12.Tuz = KilosunuKorumakİsteyenFarklıKültürYemek[satirIndex, 4];
                    yemekOzellikler12.Şeker = KilosunuKorumakİsteyenFarklıKültürYemek[satirIndex, 5];
                    yemekOzellikler12.Kalori = KilosunuKorumakİsteyenFarklıKültürYemek[satirIndex, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler12);
                Random random1 = new Random();
                int satirIndex1 = random1.Next(KilosunuKorumakİsteyenFarklıKültürÇorba.GetLength(0));
                YemekOzellikler yemekOzellikler1 = new YemekOzellikler();
                for (int i = 0; i < KilosunuKorumakİsteyenFarklıKültürÇorba.GetLength(1); i++)
                {

                    yemekOzellikler1.Yemekler = KilosunuKorumakİsteyenFarklıKültürÇorba[satirIndex1, 0];
                    yemekOzellikler1.Protein = KilosunuKorumakİsteyenFarklıKültürÇorba[satirIndex1, 1];
                    yemekOzellikler1.Yağ = KilosunuKorumakİsteyenFarklıKültürÇorba[satirIndex1, 2];
                    yemekOzellikler1.Karbonhidrat = KilosunuKorumakİsteyenFarklıKültürÇorba[satirIndex1, 3];
                    yemekOzellikler1.Tuz = KilosunuKorumakİsteyenFarklıKültürÇorba[satirIndex1, 4];
                    yemekOzellikler1.Şeker = KilosunuKorumakİsteyenFarklıKültürÇorba[satirIndex1, 5];
                    yemekOzellikler1.Kalori = KilosunuKorumakİsteyenFarklıKültürÇorba[satirIndex1, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler1);


                Random random2 = new Random();
                int satirIndex2 = random2.Next(KilosunuKorumakİsteyenFarklıKültürSalata.GetLength(0));
                YemekOzellikler yemekOzellikler2 = new YemekOzellikler();
                for (int i = 0; i < KilosunuKorumakİsteyenFarklıKültürSalata.GetLength(1); i++)
                {

                    yemekOzellikler2.Yemekler = KilosunuKorumakİsteyenFarklıKültürSalata[satirIndex2, 0];
                    yemekOzellikler2.Protein = KilosunuKorumakİsteyenFarklıKültürSalata[satirIndex2, 1];
                    yemekOzellikler2.Yağ = KilosunuKorumakİsteyenFarklıKültürSalata[satirIndex2, 2];
                    yemekOzellikler2.Karbonhidrat = KilosunuKorumakİsteyenFarklıKültürSalata[satirIndex2, 3];
                    yemekOzellikler2.Tuz = KilosunuKorumakİsteyenFarklıKültürSalata[satirIndex2, 4];
                    yemekOzellikler2.Şeker = KilosunuKorumakİsteyenFarklıKültürSalata[satirIndex2, 5];
                    yemekOzellikler2.Kalori = KilosunuKorumakİsteyenFarklıKültürSalata[satirIndex2, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler2);
                return View(yemekOzelliklers.ToList());
                #endregion
            }
            else if (diyet.tansiyonHastasi == 0 && diyet.sekerHastasi == 0 && diyet.kalpHastasi == 1 && diyet.farkliKulturlerden == 1)
            {
                //kullanilacakYemekler = "farklı_kültür_kalp_hastaları.xlsx içindeki bir çorba, bir yemek, bir salata";
                #region RastgeleSonuçlarÜretme


                Random random = new Random();
                int satirIndex = random.Next(FKKalpHastasıYemekler.GetLength(0));
                YemekOzellikler yemekOzellikler12 = new YemekOzellikler();
                for (int i = 0; i < KilosunuKorumakİsteyenFarklıKültürYemek.GetLength(1); i++)
                {

                    yemekOzellikler12.Yemekler = FKKalpHastasıYemekler[satirIndex, 0];
                    yemekOzellikler12.Protein = FKKalpHastasıYemekler[satirIndex, 1];
                    yemekOzellikler12.Yağ = FKKalpHastasıYemekler[satirIndex, 2];
                    yemekOzellikler12.Karbonhidrat = FKKalpHastasıYemekler[satirIndex, 3];
                    yemekOzellikler12.Tuz = FKKalpHastasıYemekler[satirIndex, 4];
                    yemekOzellikler12.Şeker = FKKalpHastasıYemekler[satirIndex, 5];
                    yemekOzellikler12.Kalori = FKKalpHastasıYemekler[satirIndex, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler12);
                Random random1 = new Random();
                int satirIndex1 = random1.Next(FKKalpHastasıÇorba.GetLength(0));
                YemekOzellikler yemekOzellikler1 = new YemekOzellikler();
                for (int i = 0; i < FKKalpHastasıÇorba.GetLength(1); i++)
                {

                    yemekOzellikler1.Yemekler = FKKalpHastasıÇorba[satirIndex1, 0];
                    yemekOzellikler1.Protein = FKKalpHastasıÇorba[satirIndex1, 1];
                    yemekOzellikler1.Yağ = FKKalpHastasıÇorba[satirIndex1, 2];
                    yemekOzellikler1.Karbonhidrat = FKKalpHastasıÇorba[satirIndex1, 3];
                    yemekOzellikler1.Tuz = FKKalpHastasıÇorba[satirIndex1, 4];
                    yemekOzellikler1.Şeker = FKKalpHastasıÇorba[satirIndex1, 5];
                    yemekOzellikler1.Kalori = FKKalpHastasıÇorba[satirIndex1, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler1);


                Random random2 = new Random();
                int satirIndex2 = random2.Next(FKKalpHastasıSalata.GetLength(0));
                YemekOzellikler yemekOzellikler2 = new YemekOzellikler();
                for (int i = 0; i < FKKalpHastasıSalata.GetLength(1); i++)
                {

                    yemekOzellikler2.Yemekler = FKKalpHastasıSalata[satirIndex2, 0];
                    yemekOzellikler2.Protein = FKKalpHastasıSalata[satirIndex2, 1];
                    yemekOzellikler2.Yağ = FKKalpHastasıSalata[satirIndex2, 2];
                    yemekOzellikler2.Karbonhidrat = FKKalpHastasıSalata[satirIndex2, 3];
                    yemekOzellikler2.Tuz = FKKalpHastasıSalata[satirIndex2, 4];
                    yemekOzellikler2.Şeker = FKKalpHastasıSalata[satirIndex2, 5];
                    yemekOzellikler2.Kalori = FKKalpHastasıSalata[satirIndex2, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler2);
                return View(yemekOzelliklers.ToList());
                #endregion
            }
            else if (diyet.tansiyonHastasi == 0 && diyet.sekerHastasi == 0 && diyet.kalpHastasi == 1 && diyet.farkliKulturlerden == 0)
            {
                //  kullanilacakYemekler = "kalp_hastaları_için_türk_yemekleri.xlsx içindeki bir çorba, bir yemek, bir salata";
                #region RastgeleSonuçlarÜretme


                Random random = new Random();
                int satirIndex = random.Next(YerliKalpHastasıYemek.GetLength(0));
                YemekOzellikler yemekOzellikler12 = new YemekOzellikler();
                for (int i = 0; i < YerliKalpHastasıYemek.GetLength(1); i++)
                {

                    yemekOzellikler12.Yemekler = YerliKalpHastasıYemek[satirIndex, 0];
                    yemekOzellikler12.Protein = YerliKalpHastasıYemek[satirIndex, 1];
                    yemekOzellikler12.Yağ = YerliKalpHastasıYemek[satirIndex, 2];
                    yemekOzellikler12.Karbonhidrat = YerliKalpHastasıYemek[satirIndex, 3];
                    yemekOzellikler12.Tuz = YerliKalpHastasıYemek[satirIndex, 4];
                    yemekOzellikler12.Şeker = YerliKalpHastasıYemek[satirIndex, 5];
                    yemekOzellikler12.Kalori = YerliKalpHastasıYemek[satirIndex, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler12);
                Random random1 = new Random();
                int satirIndex1 = random1.Next(YerliKalpHastasıÇorba.GetLength(0));
                YemekOzellikler yemekOzellikler1 = new YemekOzellikler();
                for (int i = 0; i < YerliKalpHastasıÇorba.GetLength(1); i++)
                {

                    yemekOzellikler1.Yemekler = YerliKalpHastasıÇorba[satirIndex1, 0];
                    yemekOzellikler1.Protein = YerliKalpHastasıÇorba[satirIndex1, 1];
                    yemekOzellikler1.Yağ = YerliKalpHastasıÇorba[satirIndex1, 2];
                    yemekOzellikler1.Karbonhidrat = YerliKalpHastasıÇorba[satirIndex1, 3];
                    yemekOzellikler1.Tuz = YerliKalpHastasıÇorba[satirIndex1, 4];
                    yemekOzellikler1.Şeker = YerliKalpHastasıÇorba[satirIndex1, 5];
                    yemekOzellikler1.Kalori = YerliKalpHastasıÇorba[satirIndex1, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler1);


                Random random2 = new Random();
                int satirIndex2 = random2.Next(YerliKalpHastasıSalata.GetLength(0));
                YemekOzellikler yemekOzellikler2 = new YemekOzellikler();
                for (int i = 0; i < YerliKalpHastasıSalata.GetLength(1); i++)
                {

                    yemekOzellikler2.Yemekler = YerliKalpHastasıSalata[satirIndex2, 0];
                    yemekOzellikler2.Protein = YerliKalpHastasıSalata[satirIndex2, 1];
                    yemekOzellikler2.Yağ = YerliKalpHastasıSalata[satirIndex2, 2];
                    yemekOzellikler2.Karbonhidrat = YerliKalpHastasıSalata[satirIndex2, 3];
                    yemekOzellikler2.Tuz = YerliKalpHastasıSalata[satirIndex2, 4];
                    yemekOzellikler2.Şeker = YerliKalpHastasıSalata[satirIndex2, 5];
                    yemekOzellikler2.Kalori = YerliKalpHastasıSalata[satirIndex2, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler2);
                return View(yemekOzelliklers.ToList());
                #endregion
            }
            else if (diyet.tansiyonHastasi == 1 && diyet.sekerHastasi == 0 && diyet.kalpHastasi == 0 && diyet.farkliKulturlerden == 0)
            {
                //    kullanilacakYemekler = "tansiyon_hastaları_için_türk_yemekleri.xlsx içindeki bir çorba, bir yemek, bir salata";
                #region RastgeleSonuçlarÜretme


                Random random = new Random();
                int satirIndex = random.Next(TansiyonHastasıTürkYemek.GetLength(0));
                YemekOzellikler yemekOzellikler12 = new YemekOzellikler();
                for (int i = 0; i < TansiyonHastasıTürkYemek.GetLength(1); i++)
                {

                    yemekOzellikler12.Yemekler = TansiyonHastasıTürkYemek[satirIndex, 0];
                    yemekOzellikler12.Protein = TansiyonHastasıTürkYemek[satirIndex, 1];
                    yemekOzellikler12.Yağ = TansiyonHastasıTürkYemek[satirIndex, 2];
                    yemekOzellikler12.Karbonhidrat = TansiyonHastasıTürkYemek[satirIndex, 3];
                    yemekOzellikler12.Tuz = TansiyonHastasıTürkYemek[satirIndex, 4];
                    yemekOzellikler12.Şeker = TansiyonHastasıTürkYemek[satirIndex, 5];
                    yemekOzellikler12.Kalori = TansiyonHastasıTürkYemek[satirIndex, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler12);
                Random random1 = new Random();
                int satirIndex1 = random1.Next(TansiyonHastasıTürkÇorba.GetLength(0));
                YemekOzellikler yemekOzellikler1 = new YemekOzellikler();
                for (int i = 0; i < TansiyonHastasıTürkÇorba.GetLength(1); i++)
                {

                    yemekOzellikler1.Yemekler = TansiyonHastasıTürkÇorba[satirIndex1, 0];
                    yemekOzellikler1.Protein = TansiyonHastasıTürkÇorba[satirIndex1, 1];
                    yemekOzellikler1.Yağ = TansiyonHastasıTürkÇorba[satirIndex1, 2];
                    yemekOzellikler1.Karbonhidrat = TansiyonHastasıTürkÇorba[satirIndex1, 3];
                    yemekOzellikler1.Tuz = TansiyonHastasıTürkÇorba[satirIndex1, 4];
                    yemekOzellikler1.Şeker = TansiyonHastasıTürkÇorba[satirIndex1, 5];
                    yemekOzellikler1.Kalori = TansiyonHastasıTürkÇorba[satirIndex1, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler1);


                Random random2 = new Random();
                int satirIndex2 = random2.Next(TansiyonHastasıTürkSalata.GetLength(0));
                YemekOzellikler yemekOzellikler2 = new YemekOzellikler();
                for (int i = 0; i < TansiyonHastasıTürkSalata.GetLength(1); i++)
                {

                    yemekOzellikler2.Yemekler = TansiyonHastasıTürkSalata[satirIndex2, 0];
                    yemekOzellikler2.Protein = TansiyonHastasıTürkSalata[satirIndex2, 1];
                    yemekOzellikler2.Yağ = TansiyonHastasıTürkSalata[satirIndex2, 2];
                    yemekOzellikler2.Karbonhidrat = TansiyonHastasıTürkSalata[satirIndex2, 3];
                    yemekOzellikler2.Tuz = TansiyonHastasıTürkSalata[satirIndex2, 4];
                    yemekOzellikler2.Şeker = TansiyonHastasıTürkSalata[satirIndex2, 5];
                    yemekOzellikler2.Kalori = TansiyonHastasıTürkSalata[satirIndex2, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler2);
                return View(yemekOzelliklers.ToList());
                #endregion
            }
            else if (diyet.tansiyonHastasi == 1 && diyet.sekerHastasi == 0 && diyet.kalpHastasi == 0 && diyet.farkliKulturlerden == 1)
            {
                // kullanilacakYemekler = "farklı_kültür_tansiyon_hastaları.xlsx içindeki bir çorba, bir yemek, bir salata";
                #region RastgeleSonuçlarÜretme


                Random random = new Random();
                int satirIndex = random.Next(FKTansiyonHastasıYemek.GetLength(0));
                YemekOzellikler yemekOzellikler12 = new YemekOzellikler();
                for (int i = 0; i < TansiyonHastasıTürkYemek.GetLength(1); i++)
                {

                    yemekOzellikler12.Yemekler = FKTansiyonHastasıYemek[satirIndex, 0];
                    yemekOzellikler12.Protein = FKTansiyonHastasıYemek[satirIndex, 1];
                    yemekOzellikler12.Yağ = FKTansiyonHastasıYemek[satirIndex, 2];
                    yemekOzellikler12.Karbonhidrat = FKTansiyonHastasıYemek[satirIndex, 3];
                    yemekOzellikler12.Tuz = FKTansiyonHastasıYemek[satirIndex, 4];
                    yemekOzellikler12.Şeker = FKTansiyonHastasıYemek[satirIndex, 5];
                    yemekOzellikler12.Kalori = FKTansiyonHastasıYemek[satirIndex, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler12);
                Random random1 = new Random();
                int satirIndex1 = random1.Next(FKTasnsiyonHastasıÇorba.GetLength(0));
                YemekOzellikler yemekOzellikler1 = new YemekOzellikler();
                for (int i = 0; i < TansiyonHastasıTürkÇorba.GetLength(1); i++)
                {

                    yemekOzellikler1.Yemekler = FKTasnsiyonHastasıÇorba[satirIndex1, 0];
                    yemekOzellikler1.Protein = FKTasnsiyonHastasıÇorba[satirIndex1, 1];
                    yemekOzellikler1.Yağ = FKTasnsiyonHastasıÇorba[satirIndex1, 2];
                    yemekOzellikler1.Karbonhidrat = FKTasnsiyonHastasıÇorba[satirIndex1, 3];
                    yemekOzellikler1.Tuz = FKTasnsiyonHastasıÇorba[satirIndex1, 4];
                    yemekOzellikler1.Şeker = FKTasnsiyonHastasıÇorba[satirIndex1, 5];
                    yemekOzellikler1.Kalori = FKTasnsiyonHastasıÇorba[satirIndex1, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler1);


                Random random2 = new Random();
                int satirIndex2 = random2.Next(FKTansiyonSalata.GetLength(0));
                YemekOzellikler yemekOzellikler2 = new YemekOzellikler();
                for (int i = 0; i < FKTansiyonSalata.GetLength(1); i++)
                {

                    yemekOzellikler2.Yemekler = FKTansiyonSalata[satirIndex2, 0];
                    yemekOzellikler2.Protein = FKTansiyonSalata[satirIndex2, 1];
                    yemekOzellikler2.Yağ = FKTansiyonSalata[satirIndex2, 2];
                    yemekOzellikler2.Karbonhidrat = FKTansiyonSalata[satirIndex2, 3];
                    yemekOzellikler2.Tuz = FKTansiyonSalata[satirIndex2, 4];
                    yemekOzellikler2.Şeker = FKTansiyonSalata[satirIndex2, 5];
                    yemekOzellikler2.Kalori = FKTansiyonSalata[satirIndex2, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler2);
                return View(yemekOzelliklers.ToList());
                #endregion
            }
            else if (diyet.tansiyonHastasi == 0 && diyet.sekerHastasi == 1 && diyet.kalpHastasi == 0 && diyet.farkliKulturlerden == 0)
            {
                //   kullanilacakYemekler = "şeker_hastaları_için_türk_yemekleri.xlsx içindeki bir çorba, bir yemek, bir salata";
                #region RastgeleSonuçlarÜretme


                Random random = new Random();
                int satirIndex = random.Next(ŞekerHasatasıTürkYemek.GetLength(0));
                YemekOzellikler yemekOzellikler12 = new YemekOzellikler();
                for (int i = 0; i < ŞekerHasatasıTürkYemek.GetLength(1); i++)
                {

                    yemekOzellikler12.Yemekler = ŞekerHasatasıTürkYemek[satirIndex, 0];
                    yemekOzellikler12.Protein = ŞekerHasatasıTürkYemek[satirIndex, 1];
                    yemekOzellikler12.Yağ = ŞekerHasatasıTürkYemek[satirIndex, 2];
                    yemekOzellikler12.Karbonhidrat = ŞekerHasatasıTürkYemek[satirIndex, 3];
                    yemekOzellikler12.Tuz = ŞekerHasatasıTürkYemek[satirIndex, 4];
                    yemekOzellikler12.Şeker = ŞekerHasatasıTürkYemek[satirIndex, 5];
                    yemekOzellikler12.Kalori = ŞekerHasatasıTürkYemek[satirIndex, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler12);
                Random random1 = new Random();
                int satirIndex1 = random1.Next(ŞekerHasatasıTürkÇorba.GetLength(0));
                YemekOzellikler yemekOzellikler1 = new YemekOzellikler();
                for (int i = 0; i < ŞekerHasatasıTürkÇorba.GetLength(1); i++)
                {

                    yemekOzellikler1.Yemekler = ŞekerHasatasıTürkÇorba[satirIndex1, 0];
                    yemekOzellikler1.Protein = ŞekerHasatasıTürkÇorba[satirIndex1, 1];
                    yemekOzellikler1.Yağ = ŞekerHasatasıTürkÇorba[satirIndex1, 2];
                    yemekOzellikler1.Karbonhidrat = ŞekerHasatasıTürkÇorba[satirIndex1, 3];
                    yemekOzellikler1.Tuz = ŞekerHasatasıTürkÇorba[satirIndex1, 4];
                    yemekOzellikler1.Şeker = ŞekerHasatasıTürkÇorba[satirIndex1, 5];
                    yemekOzellikler1.Kalori = ŞekerHasatasıTürkÇorba[satirIndex1, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler1);


                Random random2 = new Random();
                int satirIndex2 = random2.Next(ŞekerHasatasıTürkSalata.GetLength(0));
                YemekOzellikler yemekOzellikler2 = new YemekOzellikler();
                for (int i = 0; i < ŞekerHasatasıTürkSalata.GetLength(1); i++)
                {

                    yemekOzellikler2.Yemekler = ŞekerHasatasıTürkSalata[satirIndex2, 0];
                    yemekOzellikler2.Protein = ŞekerHasatasıTürkSalata[satirIndex2, 1];
                    yemekOzellikler2.Yağ = ŞekerHasatasıTürkSalata[satirIndex2, 2];
                    yemekOzellikler2.Karbonhidrat = ŞekerHasatasıTürkSalata[satirIndex2, 3];
                    yemekOzellikler2.Tuz = ŞekerHasatasıTürkSalata[satirIndex2, 4];
                    yemekOzellikler2.Şeker = ŞekerHasatasıTürkSalata[satirIndex2, 5];
                    yemekOzellikler2.Kalori = ŞekerHasatasıTürkSalata[satirIndex2, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler2);
                return View(yemekOzelliklers.ToList());
                #endregion
            }
            else if (diyet.tansiyonHastasi == 0 && diyet.sekerHastasi == 1 && diyet.kalpHastasi == 0 && diyet.farkliKulturlerden == 1)
            {
                //kullanilacakYemekler = "farklı_kültür_şeker_hastaları.xlsx içindeki bir çorba, bir yemek, bir salata";
                #region RastgeleSonuçlarÜretme


                Random random = new Random();
                int satirIndex = random.Next(FKŞekerHastasıYemek.GetLength(0));
                YemekOzellikler yemekOzellikler12 = new YemekOzellikler();
                for (int i = 0; i < ŞekerHasatasıTürkYemek.GetLength(1); i++)
                {

                    yemekOzellikler12.Yemekler = FKŞekerHastasıYemek[satirIndex, 0];
                    yemekOzellikler12.Protein = FKŞekerHastasıYemek[satirIndex, 1];
                    yemekOzellikler12.Yağ = FKŞekerHastasıYemek[satirIndex, 2];
                    yemekOzellikler12.Karbonhidrat = FKŞekerHastasıYemek[satirIndex, 3];
                    yemekOzellikler12.Tuz = FKŞekerHastasıYemek[satirIndex, 4];
                    yemekOzellikler12.Şeker = FKŞekerHastasıYemek[satirIndex, 5];
                    yemekOzellikler12.Kalori = FKŞekerHastasıYemek[satirIndex, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler12);
                Random random1 = new Random();
                int satirIndex1 = random1.Next(FKŞekerHastasıÇorba.GetLength(0));
                YemekOzellikler yemekOzellikler1 = new YemekOzellikler();
                for (int i = 0; i < FKŞekerHastasıÇorba.GetLength(1); i++)
                {

                    yemekOzellikler1.Yemekler = FKŞekerHastasıÇorba[satirIndex1, 0];
                    yemekOzellikler1.Protein = FKŞekerHastasıÇorba[satirIndex1, 1];
                    yemekOzellikler1.Yağ = FKŞekerHastasıÇorba[satirIndex1, 2];
                    yemekOzellikler1.Karbonhidrat = FKŞekerHastasıÇorba[satirIndex1, 3];
                    yemekOzellikler1.Tuz = FKŞekerHastasıÇorba[satirIndex1, 4];
                    yemekOzellikler1.Şeker = FKŞekerHastasıÇorba[satirIndex1, 5];
                    yemekOzellikler1.Kalori = FKŞekerHastasıÇorba[satirIndex1, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler1);


                Random random2 = new Random();
                int satirIndex2 = random2.Next(FKŞekerHastasıSalata.GetLength(0));
                YemekOzellikler yemekOzellikler2 = new YemekOzellikler();
                for (int i = 0; i < FKŞekerHastasıSalata.GetLength(1); i++)
                {

                    yemekOzellikler2.Yemekler = FKŞekerHastasıSalata[satirIndex2, 0];
                    yemekOzellikler2.Protein = FKŞekerHastasıSalata[satirIndex2, 1];
                    yemekOzellikler2.Yağ = FKŞekerHastasıSalata[satirIndex2, 2];
                    yemekOzellikler2.Karbonhidrat = FKŞekerHastasıSalata[satirIndex2, 3];
                    yemekOzellikler2.Tuz = FKŞekerHastasıSalata[satirIndex2, 4];
                    yemekOzellikler2.Şeker = FKŞekerHastasıSalata[satirIndex2, 5];
                    yemekOzellikler2.Kalori = FKŞekerHastasıSalata[satirIndex2, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler2);
                return View(yemekOzelliklers.ToList());
                #endregion

            }
            else if (diyet.tansiyonHastasi == 1 && diyet.sekerHastasi == 1 && diyet.kalpHastasi == 1 && diyet.farkliKulturlerden == 0)
            {
                //  kullanilacakYemekler = "şeker_hastaları_için_türk_yemekleri.xlsx içindeki bir çorba, bir yemek, bir salata";
                #region RastgeleSonuçlarÜretme


                Random random = new Random();
                int satirIndex = random.Next(ŞekerHasatasıTürkYemek.GetLength(0));
                YemekOzellikler yemekOzellikler12 = new YemekOzellikler();
                for (int i = 0; i < ŞekerHasatasıTürkYemek.GetLength(1); i++)
                {

                    yemekOzellikler12.Yemekler = ŞekerHasatasıTürkYemek[satirIndex, 0];
                    yemekOzellikler12.Protein = ŞekerHasatasıTürkYemek[satirIndex, 1];
                    yemekOzellikler12.Yağ = ŞekerHasatasıTürkYemek[satirIndex, 2];
                    yemekOzellikler12.Karbonhidrat = ŞekerHasatasıTürkYemek[satirIndex, 3];
                    yemekOzellikler12.Tuz = ŞekerHasatasıTürkYemek[satirIndex, 4];
                    yemekOzellikler12.Şeker = ŞekerHasatasıTürkYemek[satirIndex, 5];
                    yemekOzellikler12.Kalori = ŞekerHasatasıTürkYemek[satirIndex, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler12);
                Random random1 = new Random();
                int satirIndex1 = random1.Next(ŞekerHasatasıTürkÇorba.GetLength(0));
                YemekOzellikler yemekOzellikler1 = new YemekOzellikler();
                for (int i = 0; i < ŞekerHasatasıTürkÇorba.GetLength(1); i++)
                {

                    yemekOzellikler1.Yemekler = ŞekerHasatasıTürkÇorba[satirIndex1, 0];
                    yemekOzellikler1.Protein = ŞekerHasatasıTürkÇorba[satirIndex1, 1];
                    yemekOzellikler1.Yağ = ŞekerHasatasıTürkÇorba[satirIndex1, 2];
                    yemekOzellikler1.Karbonhidrat = ŞekerHasatasıTürkÇorba[satirIndex1, 3];
                    yemekOzellikler1.Tuz = ŞekerHasatasıTürkÇorba[satirIndex1, 4];
                    yemekOzellikler1.Şeker = ŞekerHasatasıTürkÇorba[satirIndex1, 5];
                    yemekOzellikler1.Kalori = ŞekerHasatasıTürkÇorba[satirIndex1, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler1);


                Random random2 = new Random();
                int satirIndex2 = random2.Next(ŞekerHasatasıTürkSalata.GetLength(0));
                YemekOzellikler yemekOzellikler2 = new YemekOzellikler();
                for (int i = 0; i < ŞekerHasatasıTürkSalata.GetLength(1); i++)
                {

                    yemekOzellikler2.Yemekler = ŞekerHasatasıTürkSalata[satirIndex2, 0];
                    yemekOzellikler2.Protein = ŞekerHasatasıTürkSalata[satirIndex2, 1];
                    yemekOzellikler2.Yağ = ŞekerHasatasıTürkSalata[satirIndex2, 2];
                    yemekOzellikler2.Karbonhidrat = ŞekerHasatasıTürkSalata[satirIndex2, 3];
                    yemekOzellikler2.Tuz = ŞekerHasatasıTürkSalata[satirIndex2, 4];
                    yemekOzellikler2.Şeker = ŞekerHasatasıTürkSalata[satirIndex2, 5];
                    yemekOzellikler2.Kalori = ŞekerHasatasıTürkSalata[satirIndex2, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler2);
                return View(yemekOzelliklers.ToList());
                #endregion
            }
            else if (diyet.tansiyonHastasi == 1 && diyet.sekerHastasi == 1 && diyet.kalpHastasi == 1 && diyet.farkliKulturlerden == 1)
            {
                //kullanilacakYemekler = "farklı_kültür_şeker_hastaları.xlsx içindeki bir çorba, bir yemek, bir salata";
                #region RastgeleSonuçlarÜretme


                Random random = new Random();
                int satirIndex = random.Next(FKŞekerHastasıYemek.GetLength(0));
                YemekOzellikler yemekOzellikler12 = new YemekOzellikler();
                for (int i = 0; i < ŞekerHasatasıTürkYemek.GetLength(1); i++)
                {

                    yemekOzellikler12.Yemekler = FKŞekerHastasıYemek[satirIndex, 0];
                    yemekOzellikler12.Protein = FKŞekerHastasıYemek[satirIndex, 1];
                    yemekOzellikler12.Yağ = FKŞekerHastasıYemek[satirIndex, 2];
                    yemekOzellikler12.Karbonhidrat = FKŞekerHastasıYemek[satirIndex, 3];
                    yemekOzellikler12.Tuz = FKŞekerHastasıYemek[satirIndex, 4];
                    yemekOzellikler12.Şeker = FKŞekerHastasıYemek[satirIndex, 5];
                    yemekOzellikler12.Kalori = FKŞekerHastasıYemek[satirIndex, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler12);
                Random random1 = new Random();
                int satirIndex1 = random1.Next(FKŞekerHastasıÇorba.GetLength(0));
                YemekOzellikler yemekOzellikler1 = new YemekOzellikler();
                for (int i = 0; i < FKŞekerHastasıÇorba.GetLength(1); i++)
                {

                    yemekOzellikler1.Yemekler = FKŞekerHastasıÇorba[satirIndex1, 0];
                    yemekOzellikler1.Protein = FKŞekerHastasıÇorba[satirIndex1, 1];
                    yemekOzellikler1.Yağ = FKŞekerHastasıÇorba[satirIndex1, 2];
                    yemekOzellikler1.Karbonhidrat = FKŞekerHastasıÇorba[satirIndex1, 3];
                    yemekOzellikler1.Tuz = FKŞekerHastasıÇorba[satirIndex1, 4];
                    yemekOzellikler1.Şeker = FKŞekerHastasıÇorba[satirIndex1, 5];
                    yemekOzellikler1.Kalori = FKŞekerHastasıÇorba[satirIndex1, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler1);


                Random random2 = new Random();
                int satirIndex2 = random2.Next(FKŞekerHastasıSalata.GetLength(0));
                YemekOzellikler yemekOzellikler2 = new YemekOzellikler();
                for (int i = 0; i < FKŞekerHastasıSalata.GetLength(1); i++)
                {

                    yemekOzellikler2.Yemekler = FKŞekerHastasıSalata[satirIndex2, 0];
                    yemekOzellikler2.Protein = FKŞekerHastasıSalata[satirIndex2, 1];
                    yemekOzellikler2.Yağ = FKŞekerHastasıSalata[satirIndex2, 2];
                    yemekOzellikler2.Karbonhidrat = FKŞekerHastasıSalata[satirIndex2, 3];
                    yemekOzellikler2.Tuz = FKŞekerHastasıSalata[satirIndex2, 4];
                    yemekOzellikler2.Şeker = FKŞekerHastasıSalata[satirIndex2, 5];
                    yemekOzellikler2.Kalori = FKŞekerHastasıSalata[satirIndex2, 6];

                }
                yemekOzelliklers.Add(yemekOzellikler2);
                return View(yemekOzelliklers.ToList());
                #endregion
            }



            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
    }
}