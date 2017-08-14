using DTO;
using Helpers;
using Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsNet;

namespace Converter
{
    public class Converter : IConverter
    {

        /// <summary>
        /// Method for conversion mass units
        /// </summary>
        /// <param name="model">Model of unit</param>
        /// <param name="toType">result of conversion</param>
        /// <returns></returns>
        public UnitMassDTO To(UnitMassDTO model, UnitMassEnum toType)
        {
            Mass mass;

            switch (model.UnitType)
            {
                case UnitMassEnum.GRAM:
                    mass = Mass.FromGrams(model.Value);
                    break;
                case UnitMassEnum.KILOGRAM:
                    mass = Mass.FromKilograms(model.Value);
                    break;
                case UnitMassEnum.TON:
                    mass = Mass.FromTonnes(model.Value);
                    break;
                case UnitMassEnum.GRAIN:
                    mass = Mass.FromGrams(model.Value * Consts.GramToGrain);
                    break;
                case UnitMassEnum.OUNCE:
                    mass = Mass.FromOunces(model.Value);
                    break;
                case UnitMassEnum.POUND:
                    mass = Mass.FromPounds(model.Value);
                    break;
                case UnitMassEnum.STONE:
                    mass = Mass.FromStone(model.Value);
                    break;
                default:
                    mass = Mass.FromKilograms(model.Value);
                    break;
            }

            double value;

            switch (toType)
            {
                case UnitMassEnum.GRAM:
                    value = mass.Grams;
                    break;
                case UnitMassEnum.KILOGRAM:
                    value = mass.Kilograms;
                    break;
                case UnitMassEnum.TON:
                    value = mass.Tonnes;
                    break;
                case UnitMassEnum.GRAIN:
                    value = mass.Grams * Consts.GrainToGram;
                    break;
                case UnitMassEnum.OUNCE:
                    value = mass.Ounces;
                    break;
                case UnitMassEnum.POUND:
                    value = mass.Pounds;
                    break;
                case UnitMassEnum.STONE:
                    value = mass.Stone;
                    break;
                default:
                    value = mass.Kilograms;
                    break;
            }

            return new UnitMassDTO(value, toType);
        }

        /// <summary>
        /// Method for conversion length units
        /// </summary>
        /// <param name="model">Model of unit</param>
        /// <param name="toType">result of conversion</param>
        /// <returns></returns>
        public UnitLengthDTO To(UnitLengthDTO model, UnitLengthEnum toType)
        {
            Length length;

            switch(model.UnitType)
            {
                case UnitLengthEnum.ASTRONOMICALUNIT:
                    length = Length.FromMeters(model.Value * Consts.AstronomicalToMetre);
                    break;
                case UnitLengthEnum.CENTIMETER:
                    length = Length.FromCentimeters(model.Value);
                    break;
                case UnitLengthEnum.FOOT:
                    length = Length.FromFeet(model.Value);
                    break;
                case UnitLengthEnum.INCH:
                    length = Length.FromInches(model.Value);
                    break;
                case UnitLengthEnum.KILOMETER:
                    length = Length.FromKilometers(model.Value);
                    break;
                case UnitLengthEnum.METER:
                    length = Length.FromMeters(model.Value);
                    break;
                case UnitLengthEnum.MILE:
                    length = Length.FromMiles(model.Value);
                    break;
                default:
                    length = Length.FromMeters(model.Value);
                break;
            }

            double value;

            switch (toType)
            {
                case UnitLengthEnum.ASTRONOMICALUNIT:
                    value = length.Meters * Consts.MetreToAstronomical;
                    break;
                case UnitLengthEnum.CENTIMETER:
                    value = length.Centimeters;
                    break;
                case UnitLengthEnum.FOOT:
                    value = length.Feet;
                    break;
                case UnitLengthEnum.INCH:
                    value = length.Inches;
                    break;
                case UnitLengthEnum.KILOMETER:
                    value = length.Kilometers;
                    break;
                case UnitLengthEnum.METER:
                    value = length.Meters;
                    break;
                case UnitLengthEnum.MILE:
                    value = length.Miles;
                    break;
                default:
                    value = length.Meters;
                    break;
            }


            return new UnitLengthDTO(value, toType);
        }
        
        
          

    }
}
