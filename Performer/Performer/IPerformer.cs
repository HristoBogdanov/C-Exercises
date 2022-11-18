using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performer
{
    public enum Style_Performer
    {
        Rock, Pop, Opera, Folklore
    }

    interface IPerformer
    {

        Style_Performer Style
        { get; set; }
        string Name
        { get; set; }

        int Start
        { get; set; }

        int Years(int tekushta_godina);
        double Profit(int broi_albumi, int tekushta_godina);

    }

public class Performerr : IPerformer
{
    private string name;
    private Style_Performer style;
    private int start;
    public string Name
    { get { return this.name; }
        set{ this.name = value; }
    }
    public Style_Performer Style
    {
        get { return this.style; }
        set { this.style = value; }
    }
    public int Start
    {
        get { return this.start; }
        set { this.start = value; }
    }
       public int Years(int tekushta_godina)
        {
            return tekushta_godina - Start;
        }
        public double Profit(int broi_albumi, int tekushta_godina)
        {

            return (broi_albumi * 10000) / Years(tekushta_godina);
        }
        public override string ToString()
        {
            return $"{this.Name} -- {this.Style} изпълнител ";
        }
        public Performerr(string name, Style_Performer style, int start)
        {
            this.Name = name;
            this.Style = style;
            this.Start = start;
        }
    }
}
