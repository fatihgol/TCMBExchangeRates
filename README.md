TCMB Exchange Rates (TCMB Döviz Kurları)
=======
C# ile Türkiye Cumhuriyet Merkez Bankası döviz kur verilerinizi almaya sağlayacak ve basitçe bazı hesaplamalar yapmanızı sağlayacak bir kütüphane.

## Örnekler

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
Çıktı
-----
==================================================== DataTable ====================================================
 | Name                   | Code | CrossRateName | ForexBuying | ForexSelling | BanknoteBuying | BanknoteSelling | 
-------------------------------------------------------------------------------------------------------------------
 | Türk Lirası 			  |  TRY |       TRY/TRY |           1 |            1 |              1 |               1 | 
 | ABD DOLARI 			  |  USD |       USD/TRY |      5,3505 |       5,3601 |         5,3467 |          5,3682 | 
 | AVUSTRALYA DOLARI 	  |  AUD |       AUD/TRY |      3,8456 |       3,8706 |         3,8279 |          3,8939 | 
 | DANİMARKA KRONU 		  |  DKK |       DKK/TRY |     0,81438 |      0,81838 |        0,81381 |         0,82026 | 
 | EURO 				  |  EUR |       EUR/TRY |       6,088 |        6,099 |         6,0837 |          6,1081 | 
 | İNGİLİZ STERLİNİ 	  |  GBP |       GBP/TRY |      6,7289 |        6,764 |         6,7242 |          6,7741 | 
 | İSVİÇRE FRANGI 		  |  CHF |       CHF/TRY |      5,4037 |       5,4384 |         5,3956 |          5,4465 | 
 | İSVEÇ KRONU 			  |  SEK |       SEK/TRY |     0,58816 |      0,59425 |        0,58775 |         0,59562 | 
 | KANADA DOLARI 		  |  CAD |       CAD/TRY |      3,9861 |       4,0041 |         3,9714 |          4,0193 | 
 | KUVEYT DİNARI 		  |  KWD |       KWD/TRY |     17,4913 |      17,7201 |        17,2289 |         17,9859 | 
 | NORVEÇ KRONU 		  |  NOK |       NOK/TRY |     0,62547 |      0,62968 |        0,62504 |         0,63113 | 
 | SUUDİ ARABİSTAN RİYALİ |  SAR |       SAR/TRY |      1,4261 |       1,4287 |         1,4154 |          1,4394 | 
 | JAPON YENİ 			  |  JPY |       JPY/TRY |      4,7195 |       4,7507 |          4,702 |          4,7688 | 
 | BULGAR LEVASI 		  |  BGN |       BGN/TRY |      3,0952 |       3,1357 |              0 |               0 | 
 | RUMEN LEYİ 		      |  RON |       RON/TRY |      1,3009 |        1,318 |              0 |               0 | 
 | RUS RUBLESİ 			  |  RUB |       RUB/TRY |     0,08009 |      0,08114 |              0 |               0 | 
 | İRAN RİYALİ 			  |  IRR |       IRR/TRY |     0,01267 |      0,01283 |              0 |               0 | 
 | ÇİN YUANI 			  |  CNY |       CNY/TRY |     0,77084 |      0,78092 |              0 |               0 | 
 | PAKİSTAN RUPİSİ 		  |  PKR |       PKR/TRY |     0,03806 |      0,03856 |              0 |               0 | 
 | KATAR RİYALİ 		  |  QAR |       QAR/TRY |      1,4613 |       1,4804 |              0 |               0 | 
 | ÖZEL ÇEKME HAKKI (SDR) |  XDR |       XDR/TRY |      7,4087 |            0 |              0 |               0 | 
===================================================================================================================

     
