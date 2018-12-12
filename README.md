TCMB Exchange Rates (TCMB Döviz Kurları)
=======
C# ile Türkiye Cumhuriyet Merkez Bankası döviz kur verilerinizi almaya sağlayacak ve basitçe bazı hesaplamalar yapmanızı sağlayacak bir kütüphane.

## Örnekler

CurrencyCode Sabitleri
---

```c#
public enum CurrencyCode
{
    USD, AUD, DKK,
    EUR, GBP, CHF,
    SEK, CAD, KWD,
    NOK, SAR, JPY,
    BGN, RON, RUB,
    IRR, CNY, PKR,
    TRY
}
```

ExchangeType Sabitleri
---

```c#
public enum ExchangeType
{
    ForexBuying,ForexSelling,
    BanknoteBuying,BanknoteSelling
}
```



Currency Class
---

```c#
public class Currency
{
    public string Name { get; }
    public string Code { get; }
    public string CrossRateName { get; }
    public double ForexBuying { get; }
    public double ForexSelling { get; }
    public double BanknoteBuying { get; }
    public double BanknoteSelling { get; }
}
```

Örnek DataTable Çıktısı
---
<table border = '1'><tr><th>Name</th><th>Code</th><th>CrossRateName</th><th>ForexBuying</th><th>ForexSelling</th><th>BanknoteBuying</th><th>BanknoteSelling</th></tr><tr><td>Türk Lirası</td><td>TRY</td><td>TRY/TRY</td><td>1</td><td>1</td><td>1</td><td>1</td></tr><tr><td>ABD DOLARI</td><td>USD</td><td>USD/TRY</td><td>5,3505</td><td>5,3601</td><td>5,3467</td><td>5,3682</td></tr><tr><td>AVUSTRALYA DOLARI</td><td>AUD</td><td>AUD/TRY</td><td>3,8456</td><td>3,8706</td><td>3,8279</td><td>3,8939</td></tr><tr><td>DANİMARKA KRONU</td><td>DKK</td><td>DKK/TRY</td><td>0,81438</td><td>0,81838</td><td>0,81381</td><td>0,82026</td></tr><tr><td>EURO</td><td>EUR</td><td>EUR/TRY</td><td>6,088</td><td>6,099</td><td>6,0837</td><td>6,1081</td></tr><tr><td>İNGİLİZ STERLİNİ</td><td>GBP</td><td>GBP/TRY</td><td>6,7289</td><td>6,764</td><td>6,7242</td><td>6,7741</td></tr><tr><td>İSVİÇRE FRANGI</td><td>CHF</td><td>CHF/TRY</td><td>5,4037</td><td>5,4384</td><td>5,3956</td><td>5,4465</td></tr><tr><td>İSVEÇ KRONU</td><td>SEK</td><td>SEK/TRY</td><td>0,58816</td><td>0,59425</td><td>0,58775</td><td>0,59562</td></tr><tr><td>KANADA DOLARI</td><td>CAD</td><td>CAD/TRY</td><td>3,9861</td><td>4,0041</td><td>3,9714</td><td>4,0193</td></tr><tr><td>KUVEYT DİNARI</td><td>KWD</td><td>KWD/TRY</td><td>17,4913</td><td>17,7201</td><td>17,2289</td><td>17,9859</td></tr><tr><td>NORVEÇ KRONU</td><td>NOK</td><td>NOK/TRY</td><td>0,62547</td><td>0,62968</td><td>0,62504</td><td>0,63113</td></tr><tr><td>SUUDİ ARABİSTAN RİYALİ</td><td>SAR</td><td>SAR/TRY</td><td>1,4261</td><td>1,4287</td><td>1,4154</td><td>1,4394</td></tr><tr><td>JAPON YENİ</td><td>JPY</td><td>JPY/TRY</td><td>4,7195</td><td>4,7507</td><td>4,702</td><td>4,7688</td></tr><tr><td>BULGAR LEVASI</td><td>BGN</td><td>BGN/TRY</td><td>3,0952</td><td>3,1357</td><td>0</td><td>0</td></tr><tr><td>RUMEN LEYİ</td><td>RON</td><td>RON/TRY</td><td>1,3009</td><td>1,318</td><td>0</td><td>0</td></tr><tr><td>RUS RUBLESİ</td><td>RUB</td><td>RUB/TRY</td><td>0,08009</td><td>0,08114</td><td>0</td><td>0</td></tr><tr><td>İRAN RİYALİ</td><td>IRR</td><td>IRR/TRY</td><td>0,01267</td><td>0,01283</td><td>0</td><td>0</td></tr><tr><td>ÇİN YUANI</td><td>CNY</td><td>CNY/TRY</td><td>0,77084</td><td>0,78092</td><td>0</td><td>0</td></tr><tr><td>PAKİSTAN RUPİSİ</td><td>PKR</td><td>PKR/TRY</td><td>0,03806</td><td>0,03856</td><td>0</td><td>0</td></tr><tr><td>KATAR RİYALİ</td><td>QAR</td><td>QAR/TRY</td><td>1,4613</td><td>1,4804</td><td>0</td><td>0</td></tr><tr><td>ÖZEL ÇEKME HAKKI (SDR)                            </td><td>XDR</td><td>XDR/TRY</td><td>7,4087</td><td>0</td><td>0</td><td>0</td></tr></table>

Güncel Döviz Kurlarını Alma ( Dictionary<string DövizKuruKodu, Currency> )
---

```c#
Dictionary<string, Currency> curs = CurrenciesExchange.GetAllCurrenciesTodaysExchangeRates();
```

Güncel Döviz Kurlarını Alma ( DataTable )
---

```c#
DataTable curs = CurrenciesExchange.GetDataTableAllCurrenciesTodaysExchangeRates();
```

Geçmiş Tarihli Döviz Kurlarını Alma ( Dictionary<string DövizKuruKodu, Currency> )
---

```c#
//CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(DateTime tarih);
DateTime date = new DateTime(2018,5,20);
Dictionary<string,Currency> curs = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(date);
```
Yada

```c#
//CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(int Yıl,int Ay, int Gün);

Dictionary<string,Currency> curs = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2018,5,20);
```

Geçmiş Tarihli Döviz Kurlarını Alma ( DataTable )
---

```c#
//CurrenciesExchange.GetDataTableAllCurrenciesHistoricalExchangeRates(DateTime tarih);
DateTime date = new DateTime(2018,5,20);
DataTable curs = CurrenciesExchange.GetDataTableAllCurrenciesHistoricalExchangeRates(date);
```
Yada

```c#
//CurrenciesExchange.GetDataTableAllCurrenciesHistoricalExchangeRates(int Yıl, int Ay, int Gün);

DataTable curs = CurrenciesExchange.GetDataTableAllCurrenciesHistoricalExchangeRates(2018,5,20);
```

Güncel Döviz Kurunu Alma
---

```c#
//CurrenciesExchange.GetTodaysExchangeRates(CurrencyCode Kur);
Currency cur = CurrenciesExchange.GetTodaysExchangeRates(CurrenciesExchange.CurrencyCode.USD);
```

Geçmiş Tarihli Döviz Kurunu Alma
---

```c#
//CurrenciesExchange.GetTodaysExchangeRates(CurrencyCode Kur, DateTime tarih);
DateTime date = new DateTime(2018,5,20);
Currency cur = CurrenciesExchange.GetHistoricalExchangeRates(CurrenciesExchange.CurrencyCode.USD,date);
```
Yada

```c#
//CurrenciesExchange.GetTodaysExchangeRates(CurrencyCode Kur, int Yıl, int Ay, int Gün);
Currency cur = CurrenciesExchange.GetHistoricalExchangeRates(CurrenciesExchange.CurrencyCode.USD, 2018, 5, 20);
```

Güncel Çapraz Kur Verilerini Alma
---

```c#
//CurrenciesExchange.GetTodaysCrossRates(CurrencyCode Dönüştürülecek Kur, CurrencyCode Şuanki Kur);
Currency cur = CurrenciesExchange.GetTodaysCrossRates(CurrenciesExchange.CurrencyCode.EUR, CurrenciesExchange.CurrencyCode.USD);
```    

Güncel Çapraz Kur Oranını Alma
---

```c#
//CurrenciesExchange.GetTodaysCrossRate(CurrencyCode Dönüştürülecek Kur, CurrencyCode Şuanki Kur);
double cur = CurrenciesExchange.GetTodaysCrossRate(CurrenciesExchange.CurrencyCode.EUR, CurrenciesExchange.CurrencyCode.USD);
``` 

Geçmiş Tarihli Çapraz Kur Verilerini Alma
---

```c#
//CurrenciesExchange.GetHistoricalCrossRates(CurrencyCode Dönüştürülecek Kur, CurrencyCode Şuanki Kur, DateTime tarih);
DateTime date = new DateTime(2018,5,20);
Currency cur = CurrenciesExchange.GetHistoricalCrossRates(CurrenciesExchange.CurrencyCode.EUR, CurrenciesExchange.CurrencyCode.USD, date);
```   

Yada

```c#
//CurrenciesExchange.GetHistoricalCrossRates(CurrencyCode Dönüştürülecek Kur, CurrencyCode Şuanki Kur, int Yıl, int Ay, int Gün);
Currency cur = CurrenciesExchange.GetHistoricalCrossRates(CurrenciesExchange.CurrencyCode.EUR, CurrenciesExchange.CurrencyCode.USD, 2018, 5, 20);
```   

Geçmiş Tarihli Çapraz Kur Oranını Alma
---

```c#
//CurrenciesExchange.GetHistoricalCrossRate(CurrencyCode Dönüştürülecek Kur, CurrencyCode Şuanki Kur, DateTime tarih);
DateTime date = new DateTime(2018,5,20);
double cur = CurrenciesExchange.GetHistoricalCrossRate(CurrenciesExchange.CurrencyCode.EUR, CurrenciesExchange.CurrencyCode.USD, date);
```   

Yada

```c#
//CurrenciesExchange.GetHistoricalCrossRate(CurrencyCode Dönüştürülecek Kur, CurrencyCode Şuanki Kur, int Yıl, int Ay, int Gün);
double cur = CurrenciesExchange.GetHistoricalCrossRate(CurrenciesExchange.CurrencyCode.EUR, CurrenciesExchange.CurrencyCode.USD, 2018, 5, 20);
```  

Güncel Kur Fiyatı Hesaplama
---

```c#
//CurrenciesExchange.CalculateTodaysExchange(double Miktar, CurrencyCode Şuanki Kur, CurrencyCode Dönüştürülecek Kur);
double cur = CurrenciesExchange.CalculateTodaysExchange(2000 ,CurrenciesExchange.CurrencyCode.TRY, CurrenciesExchange.CurrencyCode.USD);
```  
Yada

```c#
//CurrenciesExchange.CalculateTodaysExchange(double Miktar, CurrencyCode Şuanki Kur, CurrencyCode Dönüştürülecek Kur, ExchangeType Dönüşüm Tipi);
double cur = CurrenciesExchange.CalculateTodaysExchange(2000 ,CurrenciesExchange.CurrencyCode.TRY, CurrenciesExchange.CurrencyCode.USD,CurrenciesExchange.ExchangeType.BanknoteBuying);
``` 

Geçmiş Tarihli Kur Fiyatı Hesaplama
---

```c#
//CurrenciesExchange.CalculateHistoricalExchange(double Miktar, CurrencyCode Şuanki Kur, CurrencyCode Dönüştürülecek Kur, DateTime tarih);
DateTime date = new DateTime(2018,5,20);
double cur = CurrenciesExchange.CalculateHistoricalExchange(2000 ,CurrenciesExchange.CurrencyCode.TRY, CurrenciesExchange.CurrencyCode.USD, date);
```  
Yada

```c#
//CurrenciesExchange.CalculateHistoricalExchange(double Miktar, CurrencyCode Şuanki Kur, CurrencyCode Dönüştürülecek Kur, int Yıl, int Ay, int Gün);
double cur = CurrenciesExchange.CalculateHistoricalExchange(2000 ,CurrenciesExchange.CurrencyCode.TRY, CurrenciesExchange.CurrencyCode.USD, 2018,5,20);
```  
Yada

```c#
//CurrenciesExchange.CalculateHistoricalExchange(double Miktar, CurrencyCode Şuanki Kur, CurrencyCode Dönüştürülecek Kur, ExchangeType Dönüşüm Tipi, DateTime tarih);
DateTime date = new DateTime(2018,5,20);
double cur = CurrenciesExchange.CalculateHistoricalExchange(2000 ,CurrenciesExchange.CurrencyCode.TRY, CurrenciesExchange.CurrencyCode.USD, CurrenciesExchange.ExchangeType.BanknoteBuying, date);
```  
Yada

```c#
//CurrenciesExchange.CalculateHistoricalExchange(double Miktar, CurrencyCode Şuanki Kur, CurrencyCode Dönüştürülecek Kur,CurrenciesExchange.ExchangeType.BanknoteBuying,ExchangeType Dönüşüm Tipi, int Yıl, int Ay, int Gün);
double cur = CurrenciesExchange.CalculateHistoricalExchange(2000 ,CurrenciesExchange.CurrencyCode.TRY, CurrenciesExchange.CurrencyCode.USD, CurrenciesExchange.ExchangeType.BanknoteBuying, 2018,5,20);
```  
