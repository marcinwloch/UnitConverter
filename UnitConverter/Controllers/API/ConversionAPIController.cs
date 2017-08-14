using Converter;
using DTO;
using Helpers.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnitConverter.Models.ViewModels;

namespace UnitConverter.Controllers.API
{
    [RoutePrefix("api/v1/conversion")]
    public class ConversionAPIController : ApiController
    {
        private readonly IConverter converter;

        public ConversionAPIController(IConverter _converter)
        {
            converter = _converter;
        }

        /// <summary>
        /// Convert value to destination unit
        /// </summary>
        /// <remarks>
        /// Types of Unit
        /// Length: CENTIMETER, METER, KILOMETER, INCH, FOOT, MILE, ASTRONOMICALUNIT
        /// Mass:   GRAM, KILOGRAM, TON, GRAIN, OUNCE, POUND, STONE
        /// </remarks>
        /// <param name="Value">Value of unity</param>
        /// <param name="Unit">imperial or SI</param>
        /// <param name="ToUnit">Destination unit</param>
        /// <returns></returns>
        [HttpPost]
        [Route("convert")]
        public HttpResponseMessage Convert(BaseUnitViewModel model)
        {
            UnitLengthEnum lengthUnitEnum;
            if (Enum.TryParse(model.Unit, out lengthUnitEnum))
            {
                UnitLengthEnum lengthToUnitEnum;
                if (Enum.TryParse(model.ToUnit, out lengthToUnitEnum))
                {
                    UnitLengthDTO m = new UnitLengthDTO(model.Value, lengthUnitEnum);

                    UnitLengthDTO convertedModel = converter.To(m, lengthToUnitEnum);

                    model.Value = convertedModel.Value;
                    model.Unit = model.ToUnit;

                    var obj = JsonConvert.SerializeObject(model);            
                    return Request.CreateResponse(HttpStatusCode.OK, obj);
                }
                else
                {
                    var obj = JsonConvert.SerializeObject(model);
                    return Request.CreateResponse(HttpStatusCode.NotModified, obj);
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

                        model.Value = convertedModel.Value;
                        model.Unit = model.ToUnit;

                        var obj = JsonConvert.SerializeObject(model);
                        return Request.CreateResponse(HttpStatusCode.OK, obj);
                    }
                    else
                    {
                        var obj = JsonConvert.SerializeObject(model);
                        return Request.CreateResponse(HttpStatusCode.NotModified, obj);
                    }
                }
            }


            var objModel = JsonConvert.SerializeObject(model);
            return Request.CreateResponse(HttpStatusCode.NotModified, objModel);
        }
    }
}
