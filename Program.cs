// See https://aka.ms/new-console-template for more information

//1- Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.

Console.Write("Lütfen sipariş numarasını giriniz: ");
string orderNo = Console.ReadLine();

switch (orderNo)
{
    case "1":
        Console.WriteLine("Sipariş edilen ürün: Kalem");
        break;
    case "2":
        Console.WriteLine("Sipariş edilen ürün: Defter");
        break;
    case "3":
        Console.WriteLine("Sipariş edilen ürün: Kalemlik");
        break;
    case "4":
        Console.WriteLine("Sipariş edilen ürün: Silgi");
        break;
    case "5":
        Console.WriteLine("Sipariş edilen ürün: A4 Kağıdı");
        break;
    case "6":
        Console.WriteLine("Sipariş edilen ürün: Sulu Boya");
        break;

    default:
        Console.WriteLine("Geçersiz sipariş numarası.");
        break;
}

//2- kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)

var productPrices = new Dictionary<string, double>()
        {
            {"Kalem", 20.0},
            {"Defter", 35.0},
            {"Kalemlik", 100.0},
            {"Silgi", 15.0},
            {"A4 Kağıdı", 80.0},
            {"Sulu Boya", 120.0}
        };

Console.WriteLine("Mevcut ürünler ve fiyatları: ");
foreach (var product in productPrices)
{
    Console.WriteLine(product.Key + ": " + product.Value.ToString("0.00") + " TL ");
}

int productNumber;

while (true)
{
    Console.Write("Kaç ürün almak istiyorsunuz? : ");
    if (int.TryParse(Console.ReadLine(), out productNumber) && productNumber > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Lütfen geçerli bir sayı girin.");
    }
}

double totalPrice = 0;

for (int i = 1; i <= productNumber; i++)
{
    Console.Write("Ürün " + i + " adı: ");
    string productName = Console.ReadLine();

    if (!productPrices.ContainsKey(productName))
    {
        Console.WriteLine("Geçersiz ürün adı! Lütfen listeden bir ürün seçin.");
        Console.Write("Ürün " + i + " adı: ");
        productName = Console.ReadLine();
    }

    totalPrice += productPrices[productName];
}

Console.Write("Toplam alışveriş tutarı: " + totalPrice.ToString("0.00") + " TL ");

//3- Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.

//Do-While Döngüsü: Do-While döngüsü, döngü bloğunu en az bir kez çalıştırır ve ardından şartı kontrol eder. Şart doğru olduğu sürece döngü devam eder.Örneğimizle inceleyelim:

int dailyWorkingTime = 5;
int totalWorkingTime = 0;
int goalWorkingTime = 30;

int dayNumber = 0;

do
{
    // Öğrenci her gün belirli bir konuyu çalışır.
    Console.WriteLine("Gün " + (dayNumber + 1) + ": " + dailyWorkingTime + " saat çalışıldı.");

    totalWorkingTime += dailyWorkingTime;
    dayNumber++;
    Thread.Sleep(1000);

} while (totalWorkingTime < goalWorkingTime);

Console.WriteLine("Hedef çalışma süresine ulaşıldı! Toplam çalışma süresi: " + (totalWorkingTime) + " saat, " + "Geçen gün sayısı: " + (dayNumber) + " gün.");

//While Döngüsü: While döngüsü, başlangıçta şart doğru olduğu sürece döngüyü çalıştırır. Döngü bloğu çalıştırıldıktan sonra tekrar şart kontrol edilir. Eğer şart hala doğruysa döngü tekrarlanır, aksi halde döngü sona erer.Örneğimizle inceleyelim:

int waitingTime = 0;
int maxWaitingTime = 5;

Console.WriteLine("Kasa sırasındasınız. Lütfen bekleyin...");

while (waitingTime < maxWaitingTime)
{
    Console.WriteLine("Bekleme süresi: " + waitingTime + " dakika geçti.");

    waitingTime++;

    Thread.Sleep(1000); // 1000 milisaniye = 1 saniye
}

Console.WriteLine("Maksimum bekleme süresi doldu. Kasaya ilerleyebilirsiniz.");

//4- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

int number;
do
{
    Console.Write("Bir sayı girin: ");
    number = Convert.ToInt32(Console.ReadLine());

    bool perfectNumber = PerfectNumberControl(number);

    Console.WriteLine(number + (perfectNumber ? " mükemmel bir sayıdır." : " mükemmel bir sayı değildir."));

} while (!PerfectNumberControl(number));

static bool PerfectNumberControl(int number)
{
    int total = 0;

    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
            total += i;
    }

    return total == number;
}

//5- String metotlarını araştırınız. Her bir metot için örnek yapınız.

////Length: Bir dizenin karakter sayısını alır.
string str1 = "Banu Dik";
int length = str1.Length;
Console.WriteLine(str1 + " ------>" + " Karakter Sayısı: " + length);

////ToLower: Bir dizenin tüm karakterlerini küçük harfe dönüştürür.
string str2 = "BANU DİK";
string lowerCaseStr = str2.ToLower();
Console.WriteLine(str2 + " ------>" + " Küçük Harf: " + lowerCaseStr);

////ToUpper: Bir dizenin tüm karakterlerini büyük harfe dönüştürür.
string str3 = "banu dik";
string upperCaseStr = str3.ToUpper();
Console.WriteLine(str3 + " ------>" + " Büyük Harf: " + upperCaseStr);

////Trim: Bir dizeden başındaki ve sonundaki boşlukları kaldırır.
string str4 = "   Banu Dik   ";
string trimmedStr = str4.Trim();
Console.WriteLine(str4 + " ------>" + " Boşlukları Kaldır: " + trimmedStr);

////Substring: Bir dizenin belirli bir kısmını alır.
string str5 = "Banu Dik";
string subStr = str5.Substring(2, 5);
Console.WriteLine(str5 + " ------>" + " Belirli bir kısım: " + subStr);

////Replace: Belirli bir karakteri veya karakter dizisini başka bir karakter veya karakter dizisiyle değiştirir.
string str6 = "Banu Dik";
string replacedStr = str6.Replace("Dik", "Çağlayan");
Console.WriteLine(str6 + " ------>" + " Değiştirme: " + replacedStr);

////Contains: Bir dizenin belirli bir alt dizeyi içerip içermediğini belirler.
string str7 = "Banu Dik";
bool contains = str7.Contains("Dik");
Console.WriteLine(str7 + " ------>" + " İçerme: " + contains);

////Split: Bir dizedeki karakterlerin belirli bir ayırıcıya göre ayrılmasını sağlar ve alt dize dizisini döndürür.
string str8 = "Sevgi,Emek,Sadakat";
string[] splittedStr = str8.Split(',');
Console.WriteLine(str8 + " ------>" + " Ayırıcı: ");
foreach (string str in splittedStr)
{
    Console.WriteLine(" ---: " + str);
}

////Concat: Belirtilen dize veya dize dizisini birleştirerek yeni bir dize oluşturmak için kullanılır. 
string str9 = "Banu";
string str10 = "Dik";
string concatenatedString = string.Concat(str9, " ", str10);
Console.WriteLine(str9 + str10 + " ------>" + " Birleştirme: " + concatenatedString);

//6- Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır. ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.

Console.Write("Ürünün fiyatını giriniz (TL): ");
double productPrice = Convert.ToDouble(Console.ReadLine());

double shippingCost = 0;

if (productPrice >= 300)
{
    shippingCost = 0;
    Console.WriteLine("Kargo ücreti alınmamaktadır.");
}
else
{
    shippingCost = 50;
    Console.WriteLine("Ürün fiyatı: " + productPrice + " TL");
    Console.WriteLine("Kargo ücreti: " + shippingCost + " TL");

}

double totalPayment = productPrice + shippingCost;
Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPayment + " TL");

//7- iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.

Console.WriteLine("İki ürünün fiyatını giriniz (TL): ");

Console.Write("1. Ürünün fiyatı: ");
double product1Price = Convert.ToDouble(Console.ReadLine());

Console.Write("2. Ürünün fiyatı: ");
double product2Price = Convert.ToDouble(Console.ReadLine());

double totalPayment = product1Price + product2Price;

if (totalPayment > 500)
{
    double discountedProduct2Price = product2Price * 0.60; // %40 indirim

    totalPayment = product1Price + discountedProduct2Price;
    Console.WriteLine("%40 indirim uygulanmıştır.");
    Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPayment + " TL");
}
else
{
    Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPayment + " TL");
}

//8- 1-200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.

int counter = 0;

Console.WriteLine("3'e veya 5'e tam bölünebilen sayılar: ");
for (int i = 1; i <= 200; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        
        Console.WriteLine("--->" + i);
        counter++;
    }
}

Console.WriteLine("Toplamda " + counter + " adet sayı bulunmaktadır.");