using DTO;
using Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnitConverter.Models.ViewModels
{
    public class BaseUnitViewModel
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public string ToUnit { get; set; }



    }
}