TCMB Exchange Rates (TCMB Döviz Kurları)
=======
C# ile Türkiye Cumhuriyet Merkez Bankası döviz kur verilerinizi almaya sağlayacak ve basitçe bazı hesaplamalar yapmanızı sağlayacak bir kütüphane.

## Örnekler

#### CurrencyCode Sabitleri


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

#### ExchangeType Sabitleri

```c#
public enum ExchangeType
{
    ForexBuying,ForexSelling,
    BanknoteBuying,BanknoteSelling
}
```

#### Currency Sınıfı

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

#### Örnek DataTable Çıktısı

<table><tr><th><sub>Name</th></sub><th><sub>Code</th></sub><th><sub>CrossRateName</th></sub><th><sub>ForexBuying</th></sub><th><sub>ForexSelling</th></sub><th><sub>BanknoteBuying</th></sub><th><sub>BanknoteSelling</th></sub></tr><tr><td><sub>Türk Lirası</td></sub><td><sub>TRY</td></sub><td><sub>TRY/TRY</td></sub><td><sub>1</td></sub><td><sub>1</td></sub><td><sub>1</td></sub><td><sub>1</td></sub></tr><tr><td><sub>ABD DOLARI</td></sub><td><sub>USD</td></sub><td><sub>USD/TRY</td></sub><td><sub>5,3505</td></sub><td><sub>5,3601</td></sub><td><sub>5,3467</td></sub><td><sub>5,3682</td></sub></tr><tr><td><sub>AVUSTRALYA DOLARI</td></sub><td><sub>AUD</td></sub><td><sub>AUD/TRY</td></sub><td><sub>3,8456</td></sub><td><sub>3,8706</td></sub><td><sub>3,8279</td></sub><td><sub>3,8939</td></sub></tr><tr><td><sub>DANİMARKA KRONU</td></sub><td><sub>DKK</td></sub><td><sub>DKK/TRY</td></sub><td><sub>0,81438</td></sub><td><sub>0,81838</td></sub><td><sub>0,81381</td></sub><td><sub>0,82026</td></sub></tr><tr><td><sub>EURO</td></sub><td><sub>EUR</td></sub><td><sub>EUR/TRY</td></sub><td><sub>6,088</td></sub><td><sub>6,099</td></sub><td><sub>6,0837</td></sub><td><sub>6,1081</td></sub></tr><tr><td><sub>İNGİLİZ STERLİNİ</td></sub><td><sub>GBP</td></sub><td><sub>GBP/TRY</td></sub><td><sub>6,7289</td></sub><td><sub>6,764</td></sub><td><sub>6,7242</td></sub><td><sub>6,7741</td></sub></tr><tr><td><sub>İSVİÇRE FRANGI</td></sub><td><sub>CHF</td></sub><td><sub>CHF/TRY</td></sub><td><sub>5,4037</td></sub><td><sub>5,4384</td></sub><td><sub>5,3956</td></sub><td><sub>5,4465</td></sub></tr><tr><td><sub>İSVEÇ KRONU</td></sub><td><sub>SEK</td></sub><td><sub>SEK/TRY</td></sub><td><sub>0,58816</td></sub><td><sub>0,59425</td></sub><td><sub>0,58775</td></sub><td><sub>0,59562</td></sub></tr><tr><td><sub>KANADA DOLARI</td></sub><td><sub>CAD</td></sub><td><sub>CAD/TRY</td></sub><td><sub>3,9861</td></sub><td><sub>4,0041</td></sub><td><sub>3,9714</td></sub><td><sub>4,0193</td></sub></tr><tr><td><sub>KUVEYT DİNARI</td></sub><td><sub>KWD</td></sub><td><sub>KWD/TRY</td></sub><td><sub>17,4913</td></sub><td><sub>17,7201</td></sub><td><sub>17,2289</td></sub><td><sub>17,9859</td></sub></tr><tr><td><sub>NORVEÇ KRONU</td></sub><td><sub>NOK</td></sub><td><sub>NOK/TRY</td></sub><td><sub>0,62547</td></sub><td><sub>0,62968</td></sub><td><sub>0,62504</td></sub><td><sub>0,63113</td></sub></tr><tr><td><sub>SUUDİ ARABİSTAN RİYALİ</td></sub><td><sub>SAR</td></sub><td><sub>SAR/TRY</td></sub><td><sub>1,4261</td></sub><td><sub>1,4287</td></sub><td><sub>1,4154</td></sub><td><sub>1,4394</td></sub></tr><tr><td><sub>JAPON YENİ</td></sub><td><sub>JPY</td></sub><td><sub>JPY/TRY</td></sub><td><sub>4,7195</td></sub><td><sub>4,7507</td></sub><td><sub>4,702</td></sub><td><sub>4,7688</td></sub></tr><tr><td><sub>BULGAR LEVASI</td></sub><td><sub>BGN</td></sub><td><sub>BGN/TRY</td></sub><td><sub>3,0952</td></sub><td><sub>3,1357</td></sub><td><sub>0</td></sub><td><sub>0</td></sub></tr><tr><td><sub>RUMEN LEYİ</td></sub><td><sub>RON</td></sub><td><sub>RON/TRY</td></sub><td><sub>1,3009</td></sub><td><sub>1,318</td></sub><td><sub>0</td></sub><td><sub>0</td></sub></tr><tr><td><sub>RUS RUBLESİ</td></sub><td><sub>RUB</td></sub><td><sub>RUB/TRY</td></sub><td><sub>0,08009</td></sub><td><sub>0,08114</td></sub><td><sub>0</td></sub><td><sub>0</td></sub></tr><tr><td><sub>İRAN RİYALİ</td></sub><td><sub>IRR</td></sub><td><sub>IRR/TRY</td></sub><td><sub>0,01267</td></sub><td><sub>0,01283</td></sub><td><sub>0</td></sub><td><sub>0</td></sub></tr><tr><td><sub>ÇİN YUANI</td></sub><td><sub>CNY</td></sub><td><sub>CNY/TRY</td></sub><td><sub>0,77084</td></sub><td><sub>0,78092</td></sub><td><sub>0</td></sub><td><sub>0</td></sub></tr><tr><td><sub>PAKİSTAN RUPİSİ</td></sub><td><sub>PKR</td></sub><td><sub>PKR/TRY</td></sub><td><sub>0,03806</td></sub><td><sub>0,03856</td></sub><td><sub>0</td></sub><td><sub>0</td></sub></tr><tr><td><sub>KATAR RİYALİ</td></sub><td><sub>QAR</td></sub><td><sub>QAR/TRY</td></sub><td><sub>1,4613</td></sub><td><sub>1,4804</td></sub><td><sub>0</td></sub><td><sub>0</td></sub></tr><tr><td><sub>ÖZEL ÇEKME HAKKI (SDR)                            </td></sub><td><sub>XDR</td></sub><td><sub>XDR/TRY</td></sub><td><sub>7,4087</td></sub><td><sub>0</td></sub><td><sub>0</td></sub><td><sub>0</td></sub></tr></table>

#### Güncel Döviz Kurlarını Alma ( Dictionary<string DövizKuruKodu, Currency> )

```c#
Dictionary<string, Currency> curs = CurrenciesExchange.GetAllCurrenciesTodaysExchangeRates();
```

#### Güncel Döviz Kurlarını Alma ( DataTable )

```c#
DataTable curs = CurrenciesExchange.GetDataTableAllCurrenciesTodaysExchangeRates();
```

#### Geçmiş Tarihli Döviz Kurlarını Alma ( Dictionary<string DövizKuruKodu, Currency> )

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

#### Geçmiş Tarihli Döviz Kurlarını Alma ( DataTable )

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

#### Güncel Döviz Kurunu Alma

```c#
//CurrenciesExchange.GetTodaysExchangeRates(CurrencyCode Kur);
Currency cur = CurrenciesExchange.GetTodaysExchangeRates(CurrenciesExchange.CurrencyCode.USD);
```

#### Geçmiş Tarihli Döviz Kurunu Alma

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

#### Güncel Çapraz Kur Verilerini Alma

```c#
//CurrenciesExchange.GetTodaysCrossRates(CurrencyCode Dönüştürülecek Kur, CurrencyCode Şuanki Kur);
Currency cur = CurrenciesExchange.GetTodaysCrossRates(CurrenciesExchange.CurrencyCode.EUR, CurrenciesExchange.CurrencyCode.USD);
```    

#### Güncel Çapraz Kur Oranını Alma

```c#
//CurrenciesExchange.GetTodaysCrossRate(CurrencyCode Dönüştürülecek Kur, CurrencyCode Şuanki Kur);
double cur = CurrenciesExchange.GetTodaysCrossRate(CurrenciesExchange.CurrencyCode.EUR, CurrenciesExchange.CurrencyCode.USD);
``` 

#### Geçmiş Tarihli Çapraz Kur Verilerini Alma

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

#### Geçmiş Tarihli Çapraz Kur Oranını Alma

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

#### Güncel Kur Fiyatı Hesaplama

```c#
//CurrenciesExchange.CalculateTodaysExchange(double Miktar, CurrencyCode Şuanki Kur, CurrencyCode Dönüştürülecek Kur);
double cur = CurrenciesExchange.CalculateTodaysExchange(2000 ,CurrenciesExchange.CurrencyCode.TRY, CurrenciesExchange.CurrencyCode.USD);
```  
Yada

```c#
//CurrenciesExchange.CalculateTodaysExchange(double Miktar, CurrencyCode Şuanki Kur, CurrencyCode Dönüştürülecek Kur, ExchangeType Dönüşüm Tipi);
double cur = CurrenciesExchange.CalculateTodaysExchange(2000 ,CurrenciesExchange.CurrencyCode.TRY, CurrenciesExchange.CurrencyCode.USD,CurrenciesExchange.ExchangeType.BanknoteBuying);
``` 

#### Geçmiş Tarihli Kur Fiyatı Hesaplama

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
