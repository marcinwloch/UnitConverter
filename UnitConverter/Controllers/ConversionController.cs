using Converter;
using DTO;
using Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitConverter.Models.ViewModels;

namespace UnitConverter.Controllers
{
    public class ConversionController : Controller
    {

        private readonly IConverter converter;


        public ConversionController(IConverter _converter)
        {
            converter = _converter;
        }

        // GET: Conversion
        public ActionResult Index()
        {
            UnitViewModel model = new UnitViewModel();          

            return View(model);
        }

        public ActionResult Convert(UnitViewModel model)
        {
            UnitLengthEnum lengthUnitEnum;
            if (Enum.TryParse(model.Unit, out lengthUnitEnum))
            {
                UnitLengthEnum lengthToUnitEnum;
                if (Enum.TryParse(model.ToUnit, out lengthToUnitEnum))
                {
                    UnitLengthDTO m = new UnitLengthDTO(model.Value, lengthUnitEnum);

                    UnitLengthDTO convertedModel = converter.To(m, lengthToUnitEnum);

                    model.ToValue = convertedModel.Value;
                    ModelState.Clear();
                    return View("Index", model);
                }
                else
                {
                    //return error;
                }
            }
            else
            {
                UnitMassEnum massUnitEnum;
                if (Enum.TryParse(model.Unit, out massUnitEnum))
                {
                    UnitMassEnum massToUnitEnum;
                    if (Enum.TryParse(model.ToUnit, out massToUnitEnum))
                    {
                        UnitMassDTO m = new UnitMassDTO(model.Value, massUnitEnum);

                        UnitMassDTO convertedModel = converter.To(m, massToUnitEnum);

                        model.ToValue = convertedModel.Value;
                        ModelState.Clear();
                        return View("Index", model);
                    }
                    else
                    {
                        //return error;
                    }
                }
            }


            return View("Index",model);
        }
    }
}