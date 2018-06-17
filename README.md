# AbstractClassDemo


Öncelikle “Abstract Class nedir?” sorusunu cevaplandıralım. Abstract Class, ortak özellikli Class’lara Base(taban) Class olma görevini üstlenir. Örneğin siz projenizde birden fazla Class oluşturup kullanmak istiyorsunuz. Ve oluşturacağınız Class’lar pek çok yönden ortak özellikleri içerisinde barındırıyor. İşte bu durumda Abstract Class kullanmanız kodunuzun daha sağlıklı olmasını sağlayacaktır.

*Abstract Class’lar, diğer sınıflara base Class olmak için yazılır. Bu nedenle Abstract Class’dan nesne türetilemez*

İkinci iş olarak Abstract Method‘ların ne olduğunu açıklığa kavuşturalım. Abstract method, sadece Abstract Class’ların içerisinde tanımlanır ve Abstract Class’ı kalıtan sınıf tarafından override edilmek zorundadır. Oluşturduğumuz Abstract Class içerisine, Abstract Method yazılırken gövdesi yazılmaz ve daha sonra Abstract Class’ımızı kalıtacağımız sınıfta Abstract Method’u override ederiz.

*Abstract Method, sadece Abstract Class’ların içerisinde tanımlanabilen, tanımlanırken gövde bulundurmayan, daha sonra içerisinde bulunduğu Abstract Class kalıtılırken override edilen Method‘lardır*
Abstract Method’lar, Private olarak tanımlanamaz.
Temel olarak Abstract Class ve Abstract Method’ları tanımlamaya çalıştım. Sıra geldi Abstract’ları bir örnekle pekiştirmeye. Ben bu örneğimi C# Console Application üzerinde yapacağım.

Öncelikle senaryoyu anlatayım. Bizim Ucak adında bir tane Abstract(taban) sınıfımız olacak. Ve daha sonra bu Abstract Class’dan BuyukUcak ve KucukUcak sınıflarını kalıtacağız. Ve Ucak Abstract Class’ımızın içerisine basit bir “UcakFiyatı” isimli method yazıp, bu method’u kalıttığımız Class’larda override ederek, UcakFiyatı isimli methodumuza gövdeyi implement edeceğiz.

**_Öncelikle “Ucak” Abstract Class’ımızı yazalım_**

```C#
abstract class Ucak
{
public int YolcuKapasitesi { get; set; }
public string UcakSirketi { get; set; }
//Ucak’ların ortak Özellikleri’leri

public abstract void UcakFiyati();
//override edilecek abstract methodumuz
}
```

**_Gördüğünüz gibi Abstract Class’ımızda, sonradan oluşturulabilecek Ucak Class’larının ortak özellikleri ve 
bir tane override ederek gövdesini oluşturacağımız bir Abstract Method var_**

```C#
//Büyük Uçak Sınıfı
class BuyukUcak : Ucak //Ucak Abstract Class’ından kalıtılan Class
{
public override void UcakFiyati() //Ucak Abstract Class’ından, Class kalıtırken override ettiğimiz, gövdesini doldurduğumuz method.
{
Console.WriteLine(“Büyük Uçağın Fiyatı 5m”);
Console.ReadLine();
}
}

//Küçük Uçak Sınıfı
class KucukUcak : Ucak
{
public override void UcakFiyati()
{
Console.WriteLine(“Küçük Uçağın Fiyatı 3m”);
Console.ReadLine();
}
}
```
**_Ucak Abstract Class’ından kalıttığımız BuyukUcak ve KucukUcak sınıflarında, UcakFiyati Abstract Method’unu override ederek 
gövdesini dolduruyoruz. İçerisine ise Büyük Uçağın ve Küçük Uçağın temsili fiyatlarını Console’a yazdırıyoruz_**

```C#
static void Main(string[] args)
{
KucukUcak k = new KucukUcak();
k.UcakFiyati();
}
```

**_Son olarak ise Ucak Abstract sınıfından kalıtılan KucukUcak sınıfından oluşturduğumuz “k” nesnesini kullanarak UcakFiyati methodunu çalıştırıyoruz. Konsoldan gelen çıktı aşağıdaki gibi olacaktır_**

**_Eğer Ucak Abstract Class’ından bir nesne türetmeye çalışırsanız hata verecektir_**

**_Özetle Abstract Class, sonradan oluşturacağımız ortak özellik barındıran Class’lara base(temel) Class olur. Kodlarımızın Class’lar bazında düzenli olmasını sağlar. Abstract Method ise,
Abstract Class’ların içerisine yazılabilen ve sonradan override edilmek üzere yazılır_**
