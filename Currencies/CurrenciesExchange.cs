using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace TCMBCurrencies
{
    public enum ExchangeType
    {
        ForexBuying, ForexSelling,
        BanknoteBuying, BanknoteSelling
    }

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

    public static class CurrenciesExchange
    {
        

        public static Dictionary<string, Currency> GetAllCurrenciesTodaysExchangeRates()
        {
            try
            {
                return GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/today.xml");
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static DataTable GetDataTableAllCurrenciesTodaysExchangeRates()
        {
            try
            {
                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/today.xml");

                DataTable dt = new DataTable();
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Code", typeof(string));
                dt.Columns.Add("CrossRateName", typeof(string));
                dt.Columns.Add("ForexBuying", typeof(double));
                dt.Columns.Add("ForexSelling", typeof(double));
                dt.Columns.Add("BanknoteBuying", typeof(double));
                dt.Columns.Add("BanknoteSelling", typeof(double));

                foreach (string item in CurrencyRates.Keys)
                {
                    DataRow dr = dt.NewRow();
                    dr["Name"] = CurrencyRates[item].Name;
                    dr["Code"] = CurrencyRates[item].Code;
                    dr["CrossRateName"] = CurrencyRates[item].CrossRateName;
                    dr["ForexBuying"] = CurrencyRates[item].ForexBuying;
                    dr["ForexSelling"] = CurrencyRates[item].ForexSelling;
                    dr["BanknoteBuying"] = CurrencyRates[item].BanknoteBuying;
                    dr["BanknoteSelling"] = CurrencyRates[item].BanknoteSelling;
                    dt.Rows.Add(dr);
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static Dictionary<string, Currency> GetAllCurrenciesHistoricalExchangeRates(int Year, int Month, int Day)
        {
            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                return GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static DataTable GetDataTableAllCurrenciesHistoricalExchangeRates(int Year, int Month, int Day)
        {
            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                DataTable dt = new DataTable();
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Code", typeof(string));
                dt.Columns.Add("CrossRateName", typeof(string));
                dt.Columns.Add("ForexBuying", typeof(double));
                dt.Columns.Add("ForexSelling", typeof(double));
                dt.Columns.Add("BanknoteBuying", typeof(double));
                dt.Columns.Add("BanknoteSelling", typeof(double));

                foreach (string item in CurrencyRates.Keys)
                {
                    DataRow dr = dt.NewRow();
                    dr["Name"] = CurrencyRates[item].Name;
                    dr["Code"] = CurrencyRates[item].Code;
                    dr["CrossRateName"] = CurrencyRates[item].CrossRateName;
                    dr["ForexBuying"] = CurrencyRates[item].ForexBuying;
                    dr["ForexSelling"] = CurrencyRates[item].ForexSelling;
                    dr["BanknoteBuying"] = CurrencyRates[item].BanknoteBuying;
                    dr["BanknoteSelling"] = CurrencyRates[item].BanknoteSelling;
                    dt.Rows.Add(dr);
                }

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static Dictionary<string, Currency> GetAllCurrenciesHistoricalExchangeRates(DateTime date)
        {
            try
            {
                string SYear = String.Format("{0:0000}", date.Year);
                string SMonth = String.Format("{0:00}", date.Month);
                string SDay = String.Format("{0:00}", date.Day);

                return GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static DataTable GetDataTableAllCurrenciesHistoricalExchangeRates(DateTime date)
        {
            try
            {
                string SYear = String.Format("{0:0000}", date.Year);
                string SMonth = String.Format("{0:00}", date.Month);
                string SDay = String.Format("{0:00}", date.Day);

                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                DataTable dt = new DataTable();
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Code", typeof(string));
                dt.Columns.Add("CrossRateName", typeof(string));
                dt.Columns.Add("ForexBuying", typeof(double));
                dt.Columns.Add("ForexSelling", typeof(double));
                dt.Columns.Add("BanknoteBuying", typeof(double));
                dt.Columns.Add("BanknoteSelling", typeof(double));

                foreach (string item in CurrencyRates.Keys)
                {
                    DataRow dr = dt.NewRow();
                    dr["Name"] = CurrencyRates[item].Name;
                    dr["Code"] = CurrencyRates[item].Code;
                    dr["CrossRateName"] = CurrencyRates[item].CrossRateName;
                    dr["ForexBuying"] = CurrencyRates[item].ForexBuying;
                    dr["ForexSelling"] = CurrencyRates[item].ForexSelling;
                    dr["BanknoteBuying"] = CurrencyRates[item].BanknoteBuying;
                    dr["BanknoteSelling"] = CurrencyRates[item].BanknoteSelling;
                    dt.Rows.Add(dr);
                }

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static Currency GetTodaysExchangeRates(CurrencyCode Currency)
        {
            try
            {
                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/today.xml");

                if (CurrencyRates.Keys.Contains(Currency.ToString()))
                {
                    return CurrencyRates[Currency.ToString()];
                }
                else
                {
                    throw new Exception("The specified currency(" + Currency.ToString() + ") was not found!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static Currency GetHistoricalExchangeRates(CurrencyCode Currency, int Year, int Month, int Day)
        {
            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (CurrencyRates.Keys.Contains(Currency.ToString()))
                {
                    return CurrencyRates[Currency.ToString()];
                }
                else
                {
                    throw new Exception("The specified currency(" + Currency.ToString() + ") was not found!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static Currency GetHistoricalExchangeRates(CurrencyCode Currency, DateTime date)
        {
            try
            {
                string SYear = String.Format("{0:0000}", date.Year);
                string SMonth = String.Format("{0:00}", date.Month);
                string SDay = String.Format("{0:00}", date.Day);

                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (CurrencyRates.Keys.Contains(Currency.ToString()))
                {
                    return CurrencyRates[Currency.ToString()];
                }
                else
                {
                    throw new Exception("The specified currency("+ Currency.ToString() + ") was not found!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static Currency GetTodaysCrossRates(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode)
        {
            try
            {
                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/today.xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    Currency MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    Currency OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return new Currency(
                        OtherCurrency.Name,
                        OtherCurrency.Code,
                        OtherCurrency.Code+"/"+MainCurrency.Code,
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0)? 0: Math.Round((OtherCurrency.ForexBuying /MainCurrency.ForexBuying), 4),
                        (OtherCurrency.ForexSelling == 0 || MainCurrency.ForexSelling == 0)? 0: Math.Round((OtherCurrency.ForexSelling / MainCurrency.ForexSelling), 4),
                        (OtherCurrency.BanknoteBuying == 0 || MainCurrency.BanknoteBuying == 0)? 0: Math.Round((OtherCurrency.BanknoteBuying / MainCurrency.BanknoteBuying), 4),
                        (OtherCurrency.BanknoteSelling == 0 || MainCurrency.BanknoteSelling == 0)? 0: Math.Round((OtherCurrency.BanknoteSelling / MainCurrency.BanknoteSelling), 4)
                    );
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static double GetTodaysCrossRate(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode)
        {
            try
            {
                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/today.xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    Currency MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    Currency OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static Currency GetHistoricalCrossRates(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode, DateTime date)
        {
            try
            {
                string SYear = String.Format("{0:0000}", date.Year);
                string SMonth = String.Format("{0:00}", date.Month);
                string SDay = String.Format("{0:00}", date.Day);

                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    Currency MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    Currency OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return new Currency(
                        OtherCurrency.Name,
                        OtherCurrency.Code,
                        OtherCurrency.Code + "/" + MainCurrency.Code,
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4),
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4),
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4),
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4)
                    );
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static double GetHistoricalCrossRate(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode, DateTime date)
        {
            try
            {
                string SYear = String.Format("{0:0000}", date.Year);
                string SMonth = String.Format("{0:00}", date.Month);
                string SDay = String.Format("{0:00}", date.Day);

                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    Currency MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    Currency OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static Currency GetHistoricalCrossRates(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode, int Year, int Month, int Day)
        {
            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency("+ FromCurrencyCode.ToString()+") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    Currency MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    Currency OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return new Currency(
                        OtherCurrency.Name,
                        OtherCurrency.Code,
                        OtherCurrency.Code + "/" + MainCurrency.Code,
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4),
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4),
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4),
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4)
                    );
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static double GetHistoricalCrossRate(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode, int Year, int Month, int Day)
        {
            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    Currency MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    Currency OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static double CalculateTodaysExchange(double Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode)
        {
            try
            {
                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/today.xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    Currency MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    Currency OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexBuying / OtherCurrency.ForexBuying), 4);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static double CalculateTodaysExchange(double Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode, ExchangeType exchangeType)
        {
            try
            {
                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/today.xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    Currency MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    Currency OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    switch (exchangeType)
                    {
                        case ExchangeType.ForexBuying:
                            return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexBuying / OtherCurrency.ForexBuying), 4);
                        case ExchangeType.ForexSelling:
                            return (OtherCurrency.ForexSelling == 0 || MainCurrency.ForexSelling == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexSelling / OtherCurrency.ForexSelling), 4);
                        case ExchangeType.BanknoteBuying:
                            return (OtherCurrency.BanknoteBuying == 0 || MainCurrency.BanknoteBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.BanknoteBuying / OtherCurrency.BanknoteBuying), 4);
                        case ExchangeType.BanknoteSelling:
                            return (OtherCurrency.BanknoteSelling == 0 || MainCurrency.BanknoteSelling == 0) ? 0 : Math.Round(Amount * (MainCurrency.BanknoteSelling / OtherCurrency.BanknoteSelling), 4);
                        default:
                            return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static double CalculateHistoricalExchange(double Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode, DateTime date)
        {
            try
            {
                string SYear = String.Format("{0:0000}", date.Year);
                string SMonth = String.Format("{0:00}", date.Month);
                string SDay = String.Format("{0:00}", date.Day);

                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    Currency MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    Currency OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexBuying / OtherCurrency.ForexBuying), 4);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static double CalculateHistoricalExchange(double Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode, ExchangeType exchangeType, DateTime date)
        {
            try
            {
                string SYear = String.Format("{0:0000}", date.Year);
                string SMonth = String.Format("{0:00}", date.Month);
                string SDay = String.Format("{0:00}", date.Day);

                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    Currency MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    Currency OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    switch (exchangeType)
                    {
                        case ExchangeType.ForexBuying:
                            return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexBuying / OtherCurrency.ForexBuying), 4);
                        case ExchangeType.ForexSelling:
                            return (OtherCurrency.ForexSelling == 0 || MainCurrency.ForexSelling == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexSelling / OtherCurrency.ForexSelling), 4);
                        case ExchangeType.BanknoteBuying:
                            return (OtherCurrency.BanknoteBuying == 0 || MainCurrency.BanknoteBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.BanknoteBuying / OtherCurrency.BanknoteBuying), 4);
                        case ExchangeType.BanknoteSelling:
                            return (OtherCurrency.BanknoteSelling == 0 || MainCurrency.BanknoteSelling == 0) ? 0 : Math.Round(Amount * (MainCurrency.BanknoteSelling / OtherCurrency.BanknoteSelling), 4);
                        default:
                            return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static double CalculateHistoricalExchange(double Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode, int Year, int Month, int Day)
        {
            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    Currency MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    Currency OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexBuying / OtherCurrency.ForexBuying), 4);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static double CalculateHistoricalExchange(double Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode,ExchangeType exchangeType, int Year, int Month, int Day)
        {
            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                Dictionary<string, Currency> CurrencyRates = GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    Currency MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    Currency OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    switch (exchangeType)
                    {
                        case ExchangeType.ForexBuying:
                            return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexBuying / OtherCurrency.ForexBuying), 4);
                        case ExchangeType.ForexSelling:
                            return (OtherCurrency.ForexSelling == 0 || MainCurrency.ForexSelling == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexSelling / OtherCurrency.ForexSelling), 4);
                        case ExchangeType.BanknoteBuying:
                            return (OtherCurrency.BanknoteBuying == 0 || MainCurrency.BanknoteBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.BanknoteBuying / OtherCurrency.BanknoteBuying), 4);
                        case ExchangeType.BanknoteSelling:
                            return (OtherCurrency.BanknoteSelling == 0 || MainCurrency.BanknoteSelling == 0) ? 0 : Math.Round(Amount * (MainCurrency.BanknoteSelling / OtherCurrency.BanknoteSelling), 4);
                        default:
                            return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        private static Dictionary<string, Currency> GetCurrencyRates(string Link)
        {
            try
            {
                XmlTextReader rdr = new XmlTextReader(Link);
                // XmlTextReader nesnesini yaratıyoruz ve parametre olarak xml dokümanın urlsini veriyoruz
                // XmlTextReader urlsi belirtilen xml dokümanlarına hızlı ve forward-only giriş imkanı sağlar.
                XmlDocument myxml = new XmlDocument();
                // XmlDocument nesnesini yaratıyoruz.
                myxml.Load(rdr);
                // Load metodu ile xml yüklüyoruz
                XmlNode tarih = myxml.SelectSingleNode("/Tarih_Date/@Tarih");
                XmlNodeList mylist = myxml.SelectNodes("/Tarih_Date/Currency");
                XmlNodeList adi = myxml.SelectNodes("/Tarih_Date/Currency/Isim");
                XmlNodeList kod = myxml.SelectNodes("/Tarih_Date/Currency/@Kod");
                XmlNodeList doviz_alis = myxml.SelectNodes("/Tarih_Date/Currency/ForexBuying");
                XmlNodeList doviz_satis = myxml.SelectNodes("/Tarih_Date/Currency/ForexSelling");
                XmlNodeList efektif_alis = myxml.SelectNodes("/Tarih_Date/Currency/BanknoteBuying");
                XmlNodeList efektif_satis = myxml.SelectNodes("/Tarih_Date/Currency/BanknoteSelling");

                Dictionary<string, Currency> ExchangeRates = new Dictionary<string, Currency>();

                ExchangeRates.Add("TRY", new Currency("Türk Lirası", "TRY", "TRY/TRY", 1, 1, 1, 1));

                for (int i = 0; i < adi.Count; i++)
                {
                    Currency cur = new Currency(adi.Item(i).InnerText.ToString(),
                        kod.Item(i).InnerText.ToString(),
                        kod.Item(i).InnerText.ToString() + "/TRY",
                        (String.IsNullOrWhiteSpace(doviz_alis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(doviz_alis.Item(i).InnerText.ToString().Replace(".", ",")),
                        (String.IsNullOrWhiteSpace(doviz_satis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(doviz_satis.Item(i).InnerText.ToString().Replace(".", ",")),
                        (String.IsNullOrWhiteSpace(efektif_alis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(efektif_alis.Item(i).InnerText.ToString().Replace(".", ",")),
                        (String.IsNullOrWhiteSpace(efektif_satis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(efektif_satis.Item(i).InnerText.ToString().Replace(".", ","))
                        );

                    ExchangeRates.Add(kod.Item(i).InnerText.ToString(), cur);
                }

                return ExchangeRates;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
