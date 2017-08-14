using Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Model for unit of mass
    /// </summary>
    public class UnitMassDTO : UnitDTO
    {
        public UnitMassEnum UnitType { get; set; }

        public UnitMassDTO(double value, UnitMassEnum type) : base(value)
        {
            UnitType = type;
        }

        public UnitMassDTO()
        {
        }
    }
}
