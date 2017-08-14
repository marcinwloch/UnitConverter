using DTO;
using Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnitConverter.Models.ViewModels
{
    public class UnitViewModel : BaseUnitViewModel
    {

        public double ToValue { get; set; }
        public List<SelectListItem> DropDownUnits { get; set; }

        public UnitViewModel()
        {
            DropDownUnits = new List<SelectListItem>();

            Enum.GetNames(typeof(UnitLengthEnum)).ToList().ForEach(x =>
            {
                DropDownUnits.Add(new SelectListItem() { Text = x.ToLower(), Value = x });
            });

            Enum.GetNames(typeof(UnitMassEnum)).ToList().ForEach(x =>
            {
                DropDownUnits.Add(new SelectListItem() { Text = x.ToLower(), Value = x });
            });

            ToUnit = DropDownUnits.First().Value;
        }


    }
}