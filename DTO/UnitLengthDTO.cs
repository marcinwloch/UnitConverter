using Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Model for unit of length
    /// </summary>
    public class UnitLengthDTO : UnitDTO
    {
        public UnitLengthEnum UnitType { get; set; }

        public UnitLengthDTO(double value, UnitLengthEnum type) : base(value)
        {
            UnitType = type;
        }

        public UnitLengthDTO()
        {
        }
    }
}
