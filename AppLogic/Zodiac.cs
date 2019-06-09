namespace AppLogic
{
    using System;

    public static class Zodiac
    {
        private enum eZodiacSign
        {
            Aries,
            Taurus,
            Gemini,
            Cancer,
            Leo,
            Virgo,
            Libra,
            Scorpio,
            Sagittarius,
            Capricorn,
            Aquarius,
            Pisces
        }

        public static string CalculateSign(string i_Date)
        {
            string format = "MM/dd/yyyy";
            DateTime date = DateTime.ParseExact(i_Date, format, null);
            int day = date.Day;
            int month = date.Month;
            eZodiacSign result = default(eZodiacSign);

            switch (month)
            {
                case 1:
                    result = (day <= 20) ? eZodiacSign.Capricorn : eZodiacSign.Aquarius;
                    break;
                case 2:
                    result = (day <= 19) ? eZodiacSign.Aquarius : eZodiacSign.Pisces;
                    break;
                case 3:
                    result = (day <= 21) ? eZodiacSign.Pisces : eZodiacSign.Aries;
                    break;
                case 4:
                    result = (day <= 20) ? eZodiacSign.Aries : eZodiacSign.Taurus;
                    break;
                case 5:
                    result = (day <= 21) ? eZodiacSign.Taurus : eZodiacSign.Gemini;
                    break;
                case 6:
                    result = (day <= 22) ? eZodiacSign.Gemini : eZodiacSign.Cancer;
                    break;
                case 7:
                    result = (day <= 23) ? eZodiacSign.Cancer : eZodiacSign.Leo;
                    break;
                case 8:
                    result = (day <= 23) ? eZodiacSign.Leo : eZodiacSign.Virgo;
                    break;
                case 9:
                    result = (day <= 24) ? eZodiacSign.Virgo : eZodiacSign.Libra;
                    break;
                case 10:
                    result = (day <= 23) ? eZodiacSign.Libra : eZodiacSign.Scorpio;
                    break;
                case 11:
                    result = (day <= 23) ? eZodiacSign.Scorpio : eZodiacSign.Sagittarius;
                    break;
                case 12:
                    result = (day <= 22) ? eZodiacSign.Sagittarius : eZodiacSign.Capricorn;
                    break;
            }

            return result.ToString();
        }
    }
}
