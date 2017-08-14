using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Base model of unit
    /// </summary>
    public class UnitDTO
    {
        public double Value { get; set; }

        public UnitDTO(double value)
        {
            Value = value;
        }
        public UnitDTO()
        {
        }
    }
}
