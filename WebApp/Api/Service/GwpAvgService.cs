using System;
using System.Formats.Asn1;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using WebApp.Api.ServiceInterface;
using WebApp.DataBase.Entities;
using WebApp.Models;
using WebApp.Models.Response;

namespace WebApp.Api.Service
{
    public class GwpAvgService : IGwpAvgService
    {
        private List<GwtByCountry> gwtByCountries = new List<GwtByCountry>();


        public GwpAvgService()
        {
        }
        public List<GwpAvgResponeModel> GetGwpAvg(GwpAvgModel model)
        {
            List<GwtByCountry> gwtByCountries = File.ReadAllLines(@"gwpByCountry.csv")
                .Skip(1)
                .Select(x => GwtByCountry.FromCsv(x))
                .ToList();

            var result = gwtByCountries.Where(x => x.Country == model.Country && model.LineOfBusiness.Contains(x.LineOfBusiness))
                            .Select(x => new GwpAvgResponeModel
                            {
                                LineOfBusiness = x.LineOfBusiness,
                                Avg = Math.Round((x.Y2008 +
                                x.Y2009 +
                                x.Y2010 +
                                x.Y2011 +
                                x.Y2012 +
                                x.Y2013 +
                                x.Y2014 +
                                x.Y2015) / 8,1)
                            }).ToList();
            return result;

        }
    }
}

