using Converter;
using DTO;
using Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest
{
   public class ConverterTest
    {
        private readonly IConverter converter;

        public ConverterTest()
        {
            converter = new Converter.Converter();
        }

        [Theory]
        [InlineData(1, UnitLengthEnum.ASTRONOMICALUNIT, UnitLengthEnum.ASTRONOMICALUNIT, 1)]
        [InlineData(1, UnitLengthEnum.ASTRONOMICALUNIT, UnitLengthEnum.CENTIMETER, 1.496e+13)]
        [InlineData(1, UnitLengthEnum.ASTRONOMICALUNIT, UnitLengthEnum.FOOT, 490813648293.96325684)]
        [InlineData(1, UnitLengthEnum.ASTRONOMICALUNIT, UnitLengthEnum.INCH, 5889763779527.5595703)]
        [InlineData(1, UnitLengthEnum.ASTRONOMICALUNIT, UnitLengthEnum.KILOMETER, 149600000)]
        [InlineData(1, UnitLengthEnum.ASTRONOMICALUNIT, UnitLengthEnum.METER, 1.496e+11)]
        [InlineData(1, UnitLengthEnum.ASTRONOMICALUNIT, UnitLengthEnum.MILE, 92957361.4028)]

        [InlineData(1, UnitLengthEnum.CENTIMETER, UnitLengthEnum.ASTRONOMICALUNIT, 6.684682267272403742e-14)]
        [InlineData(1, UnitLengthEnum.CENTIMETER, UnitLengthEnum.CENTIMETER, 1)]
        [InlineData(1, UnitLengthEnum.CENTIMETER, UnitLengthEnum.FOOT, 0.032808865928149598401)]
        [InlineData(1, UnitLengthEnum.CENTIMETER, UnitLengthEnum.INCH, 0.39370639113779520857)]
        [InlineData(1, UnitLengthEnum.CENTIMETER, UnitLengthEnum.KILOMETER, 1.000014233489999773e-5)]
        [InlineData(1, UnitLengthEnum.CENTIMETER, UnitLengthEnum.METER, 0.010000142334899998417)]
        [InlineData(1, UnitLengthEnum.CENTIMETER, UnitLengthEnum.MILE, 6.21380036517984888e-6)]

        [InlineData(1, UnitLengthEnum.FOOT, UnitLengthEnum.ASTRONOMICALUNIT, 2.037491155064628469e-12)]
        [InlineData(1, UnitLengthEnum.FOOT, UnitLengthEnum.CENTIMETER, 30.480433836775194578)]
        [InlineData(1, UnitLengthEnum.FOOT, UnitLengthEnum.FOOT, 1)]
        [InlineData(1, UnitLengthEnum.FOOT, UnitLengthEnum.INCH, 12.00017080187999774)]
        [InlineData(1, UnitLengthEnum.FOOT, UnitLengthEnum.KILOMETER, 0.00030480433836775193976)]
        [InlineData(1, UnitLengthEnum.FOOT, UnitLengthEnum.METER, 0.304804338367751948)]
        [InlineData(1, UnitLengthEnum.FOOT, UnitLengthEnum.MILE, 0.00018939663513068178574)]

        [InlineData(1, UnitLengthEnum.INCH, UnitLengthEnum.ASTRONOMICALUNIT, 1.697909295887189717e-13)]
        [InlineData(1, UnitLengthEnum.INCH, UnitLengthEnum.CENTIMETER, 2.540036153064598512)]
        [InlineData(1, UnitLengthEnum.INCH, UnitLengthEnum.FOOT, 0.083334519457499964257)]
        [InlineData(1, UnitLengthEnum.INCH, UnitLengthEnum.INCH, 1)]
        [InlineData(1, UnitLengthEnum.INCH, UnitLengthEnum.KILOMETER, 2.540036153064598369e-5)]
        [InlineData(1, UnitLengthEnum.INCH, UnitLengthEnum.METER, 0.025400361530645985259)]
        [InlineData(1, UnitLengthEnum.INCH, UnitLengthEnum.MILE, 1.57830529275568087e-5)]

        [InlineData(1, UnitLengthEnum.KILOMETER, UnitLengthEnum.ASTRONOMICALUNIT, 6.684682267272400983e-9)]
        [InlineData(1, UnitLengthEnum.KILOMETER, UnitLengthEnum.CENTIMETER, 100000)]
        [InlineData(1, UnitLengthEnum.KILOMETER, UnitLengthEnum.FOOT, 3280.84)]
        [InlineData(1, UnitLengthEnum.KILOMETER, UnitLengthEnum.INCH, 39370.0787)]
        [InlineData(1, UnitLengthEnum.KILOMETER, UnitLengthEnum.KILOMETER, 1)]
        [InlineData(1, UnitLengthEnum.KILOMETER, UnitLengthEnum.METER, 1000.000032)]
        [InlineData(1, UnitLengthEnum.KILOMETER, UnitLengthEnum.MILE, 0.62137121212121)]

        [InlineData(1, UnitLengthEnum.METER, UnitLengthEnum.ASTRONOMICALUNIT, 6.6846e-12)]
        [InlineData(1, UnitLengthEnum.METER, UnitLengthEnum.CENTIMETER, 100)]
        [InlineData(1, UnitLengthEnum.METER, UnitLengthEnum.FOOT, 3.28084)]
        [InlineData(1, UnitLengthEnum.METER, UnitLengthEnum.INCH, 39.3701)]
        [InlineData(1, UnitLengthEnum.METER, UnitLengthEnum.KILOMETER, 0.001)]
        [InlineData(1, UnitLengthEnum.METER, UnitLengthEnum.METER, 1)]
        [InlineData(1, UnitLengthEnum.METER, UnitLengthEnum.MILE, 0.000621371)]

        [InlineData(1, UnitLengthEnum.MILE, UnitLengthEnum.ASTRONOMICALUNIT, 6.6846e-12)]
        [InlineData(1, UnitLengthEnum.MILE, UnitLengthEnum.CENTIMETER, 160934)]
        [InlineData(1, UnitLengthEnum.MILE, UnitLengthEnum.FOOT, 5279.986876)]
        [InlineData(1, UnitLengthEnum.MILE, UnitLengthEnum.INCH, 63359.8425)]
        [InlineData(1, UnitLengthEnum.MILE, UnitLengthEnum.KILOMETER, 1.60934)]
        [InlineData(1, UnitLengthEnum.MILE, UnitLengthEnum.METER, 1609.34)]
        [InlineData(1, UnitLengthEnum.MILE, UnitLengthEnum.MILE, 1)]
        public void ConversionLengthTest(double value, UnitLengthEnum type, UnitLengthEnum toType, double sum)
        {
            UnitLengthDTO model = new UnitLengthDTO();

            model.Value = value;
            model.UnitType = type;

            UnitLengthDTO output = converter.To(model, toType);

            Assert.InRange(output.Value, sum - 0.0005, sum + 0.005);
        }
    }
}
