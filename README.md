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

<table border = '1'><tr><th>Name</th><th>Code</th><th>CrossRateName</th><th>ForexBuying</th><th>ForexSelling</th><th>BanknoteBuying</th><th>BanknoteSelling</th></tr><tr><td>Türk Lirası</td><td>TRY</td><td>TRY/TRY</td><td>1</td><td>1</td><td>1</td><td>1</td></tr><tr><td>ABD DOLARI</td><td>USD</td><td>USD/TRY</td><td>5,3505</td><td>5,3601</td><td>5,3467</td><td>5,3682</td></tr><tr><td>AVUSTRALYA DOLARI</td><td>AUD</td><td>AUD/TRY</td><td>3,8456</td><td>3,8706</td><td>3,8279</td><td>3,8939</td></tr><tr><td>DANİMARKA KRONU</td><td>DKK</td><td>DKK/TRY</td><td>0,81438</td><td>0,81838</td><td>0,81381</td><td>0,82026</td></tr><tr><td>EURO</td><td>EUR</td><td>EUR/TRY</td><td>6,088</td><td>6,099</td><td>6,0837</td><td>6,1081</td></tr><tr><td>İNGİLİZ STERLİNİ</td><td>GBP</td><td>GBP/TRY</td><td>6,7289</td><td>6,764</td><td>6,7242</td><td>6,7741</td></tr><tr><td>İSVİÇRE FRANGI</td><td>CHF</td><td>CHF/TRY</td><td>5,4037</td><td>5,4384</td><td>5,3956</td><td>5,4465</td></tr><tr><td>İSVEÇ KRONU</td><td>SEK</td><td>SEK/TRY</td><td>0,58816</td><td>0,59425</td><td>0,58775</td><td>0,59562</td></tr><tr><td>KANADA DOLARI</td><td>CAD</td><td>CAD/TRY</td><td>3,9861</td><td>4,0041</td><td>3,9714</td><td>4,0193</td></tr><tr><td>KUVEYT DİNARI</td><td>KWD</td><td>KWD/TRY</td><td>17,4913</td><td>17,7201</td><td>17,2289</td><td>17,9859</td></tr><tr><td>NORVEÇ KRONU</td><td>NOK</td><td>NOK/TRY</td><td>0,62547</td><td>0,62968</td><td>0,62504</td><td>0,63113</td></tr><tr><td>SUUDİ ARABİSTAN RİYALİ</td><td>SAR</td><td>SAR/TRY</td><td>1,4261</td><td>1,4287</td><td>1,4154</td><td>1,4394</td></tr><tr><td>JAPON YENİ</td><td>JPY</td><td>JPY/TRY</td><td>4,7195</td><td>4,7507</td><td>4,702</td><td>4,7688</td></tr><tr><td>BULGAR LEVASI</td><td>BGN</td><td>BGN/TRY</td><td>3,0952</td><td>3,1357</td><td>0</td><td>0</td></tr><tr><td>RUMEN LEYİ</td><td>RON</td><td>RON/TRY</td><td>1,3009</td><td>1,318</td><td>0</td><td>0</td></tr><tr><td>RUS RUBLESİ</td><td>RUB</td><td>RUB/TRY</td><td>0,08009</td><td>0,08114</td><td>0</td><td>0</td></tr><tr><td>İRAN RİYALİ</td><td>IRR</td><td>IRR/TRY</td><td>0,01267</td><td>0,01283</td><td>0</td><td>0</td></tr><tr><td>ÇİN YUANI</td><td>CNY</td><td>CNY/TRY</td><td>0,77084</td><td>0,78092</td><td>0</td><td>0</td></tr><tr><td>PAKİSTAN RUPİSİ</td><td>PKR</td><td>PKR/TRY</td><td>0,03806</td><td>0,03856</td><td>0</td><td>0</td></tr><tr><td>KATAR RİYALİ</td><td>QAR</td><td>QAR/TRY</td><td>1,4613</td><td>1,4804</td><td>0</td><td>0</td></tr><tr><td>ÖZEL ÇEKME HAKKI (SDR)                            </td><td>XDR</td><td>XDR/TRY</td><td>7,4087</td><td>0</td><td>0</td><td>0</td></tr></table>

     
