using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSI___2015_2
{
    public class Deal
    {


        public int Day
        {
            get; set;
        }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Hour{ get; set; }
        public int Minutes { get; set; }
        public int Code { get; set; }
        public int Quality { get; set; }
        public int Quantity { get; set; }
        public string Name_deliverer { get; set; }

        public Deal(int year, int month, int day,int hour,int minutes, int code,int quality,int quantity,string name)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
            this.Hour = hour;
            this.Minutes = minutes;
            this.Code = code;
            this.Quality = quality;
            this.Quantity = quantity;
            this.Name_deliverer = name;
        }
        public string Code_word()
        {
            string result = "";
            if (this.Code == 1) result = "манатарка";
            else if (this.Code == 2) result = "печурка";
            else if (this.Code == 3) result = "кладница";
            else if (this.Code == 4) result = "пачи крак";
            else if (this.Code == 5) result = "сърнела";
            else if (this.Code == 6) result = "друг вид";

            return result;
        }
        public string Quality_word()
        {
            string quality_word="";
            if (this.Quality == 1) quality_word = "1-во";
            else if (this.Quality == 2) quality_word = "2-ро";
            else if (this.Quality == 3) quality_word = "3-то";

            return quality_word;
        }
        public override string ToString()
        {
            return $"{this.Day}.{this.Month}.{this.Year} {this.Hour}:{this.Minutes}, {this.Code_word()}, {this.Quantity:f2} кг., {this.Quality_word()}, {this.Name_deliverer}";
        }
    }
}
