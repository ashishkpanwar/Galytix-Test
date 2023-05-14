using System;
namespace WebApp.DataBase.Entities
{
	public class GwtByCountry
	{
		public string Country { get; set; }
        public string VariableId { get; set; }
        public string VariableName { get; set; }
        public string LineOfBusiness { get; set; }
        public double Y2000 { get; set; }
        public double Y2001 { get; set; }
        public double Y2002 { get; set; }
        public double Y2003 { get; set; }
        public double Y2004 { get; set; }
        public double Y2005 { get; set; }
        public double Y2006 { get; set; }
        public double Y2007 { get; set; }
        public double Y2008 { get; set; }
        public double Y2009 { get; set; }
        public double Y2010 { get; set; }
        public double Y2011 { get; set; }
        public double Y2012 { get; set; }
        public double Y2013 { get; set; }
        public double Y2014 { get; set; }
        public double Y2015 { get; set; }

        public GwtByCountry()
		{
		}
        public static GwtByCountry FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            GwtByCountry gwtByCountry = new GwtByCountry();
            gwtByCountry.Country = values[0];
            gwtByCountry.VariableId = values[1];
            gwtByCountry.VariableName = values[2];
            gwtByCountry.LineOfBusiness = values[3];
            gwtByCountry.Y2000 = Convert.ToDouble(string.IsNullOrEmpty(values[4]) ? "0" : values[4]);
            gwtByCountry.Y2001 = Convert.ToDouble(string.IsNullOrEmpty(values[5]) ? "0" : values[5]);
            gwtByCountry.Y2002 = Convert.ToDouble(string.IsNullOrEmpty(values[6]) ? "0" : values[6]);
            gwtByCountry.Y2003 = Convert.ToDouble(string.IsNullOrEmpty(values[7]) ? "0" : values[7]);
            gwtByCountry.Y2004 = Convert.ToDouble(string.IsNullOrEmpty(values[8]) ? "0" : values[8]);
            gwtByCountry.Y2005 = Convert.ToDouble(string.IsNullOrEmpty(values[9]) ? "0" : values[9]);
            gwtByCountry.Y2006 = Convert.ToDouble(string.IsNullOrEmpty(values[10]) ? "0" : values[10]);
            gwtByCountry.Y2007 = Convert.ToDouble(string.IsNullOrEmpty(values[11]) ? "0" : values[11]);
            gwtByCountry.Y2008 = Convert.ToDouble(string.IsNullOrEmpty(values[12]) ? "0" : values[12]);
            gwtByCountry.Y2009 = Convert.ToDouble(string.IsNullOrEmpty(values[13]) ? "0" : values[13]);
            gwtByCountry.Y2010 = Convert.ToDouble(string.IsNullOrEmpty(values[14]) ? "0" : values[14]);
            gwtByCountry.Y2011 = Convert.ToDouble(string.IsNullOrEmpty(values[15]) ? "0" : values[15]);
            gwtByCountry.Y2012 = Convert.ToDouble(string.IsNullOrEmpty(values[16]) ? "0" : values[16]);
            gwtByCountry.Y2013 = Convert.ToDouble(string.IsNullOrEmpty(values[17]) ? "0" : values[17]);
            gwtByCountry.Y2014 = Convert.ToDouble(string.IsNullOrEmpty(values[18]) ? "0" : values[18]);
            gwtByCountry.Y2015 = Convert.ToDouble(string.IsNullOrEmpty(values[19]) ? "0" : values[19]);
            return gwtByCountry;
        }
    }
}

