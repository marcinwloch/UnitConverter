using DTO;
using Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public interface IConverter
    {
        UnitMassDTO To(UnitMassDTO model, UnitMassEnum toType);
        UnitLengthDTO To(UnitLengthDTO model, UnitLengthEnum toType);
    }
}
