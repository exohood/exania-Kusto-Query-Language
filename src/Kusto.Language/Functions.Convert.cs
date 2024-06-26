//
// This file was auto-generated by the ConverUnits.CodeGen utility class
// To regenerate it, run the ConverUnits.CodeGen.exe, and see the results in the "GeneratedCode" folder
//
// DO NOT MODIFY THIS FILE DIRECTLY
//
namespace Kusto.Language
{
    using Symbols;

    public partial class Functions
    {
        #region convert functions

        private static readonly string[] s_angleLiteralValues = new[] {
            "Arcminute",
            "Arcsecond",
            "Centiradian",
            "Deciradian",
            "Degree",
            "Gradian",
            "Microdegree",
            "Microradian",
            "Millidegree",
            "Milliradian",
            "Nanodegree",
            "Nanoradian",
            "NatoMil",
            "Radian",
            "Revolution",
            "Tilt",

            };

        public static readonly FunctionSymbol ConvertAngle =
            new FunctionSymbol("convert_angle", ScalarTypes.Real,
                new Parameter("value", ScalarTypes.Real),
                new Parameter("from", ScalarTypes.String, ArgumentKind.Expression, s_angleLiteralValues),
                new Parameter("to", ScalarTypes.String, ArgumentKind.Expression, s_angleLiteralValues))
            .ConstantFoldable()
            .WithResultNameKind(ResultNameKind.None);


        private static readonly string[] s_energyLiteralValues = new[] {
            "BritishThermalUnit",
            "Calorie",
            "DecathermEc",
            "DecathermImperial",
            "DecathermUs",
            "ElectronVolt",
            "Erg",
            "FootPound",
            "GigabritishThermalUnit",
            "GigaelectronVolt",
            "Gigajoule",
            "GigawattDay",
            "GigawattHour",
            "HorsepowerHour",
            "Joule",
            "KilobritishThermalUnit",
            "Kilocalorie",
            "KiloelectronVolt",
            "Kilojoule",
            "KilowattDay",
            "KilowattHour",
            "MegabritishThermalUnit",
            "Megacalorie",
            "MegaelectronVolt",
            "Megajoule",
            "MegawattDay",
            "MegawattHour",
            "Millijoule",
            "TeraelectronVolt",
            "TerawattDay",
            "TerawattHour",
            "ThermEc",
            "ThermImperial",
            "ThermUs",
            "WattDay",
            "WattHour",

            };

        public static readonly FunctionSymbol ConvertEnergy =
            new FunctionSymbol("convert_energy", ScalarTypes.Real,
                new Parameter("value", ScalarTypes.Real),
                new Parameter("from", ScalarTypes.String, ArgumentKind.Expression, s_energyLiteralValues),
                new Parameter("to", ScalarTypes.String, ArgumentKind.Expression, s_energyLiteralValues))
            .ConstantFoldable()
            .WithResultNameKind(ResultNameKind.None);


        private static readonly string[] s_forceLiteralValues = new[] {
            "Decanewton",
            "Dyn",
            "KilogramForce",
            "Kilonewton",
            "KiloPond",
            "KilopoundForce",
            "Meganewton",
            "Micronewton",
            "Millinewton",
            "Newton",
            "OunceForce",
            "Poundal",
            "PoundForce",
            "ShortTonForce",
            "TonneForce",

            };

        public static readonly FunctionSymbol ConvertForce =
            new FunctionSymbol("convert_force", ScalarTypes.Real,
                new Parameter("value", ScalarTypes.Real),
                new Parameter("from", ScalarTypes.String, ArgumentKind.Expression, s_forceLiteralValues),
                new Parameter("to", ScalarTypes.String, ArgumentKind.Expression, s_forceLiteralValues))
            .ConstantFoldable()
            .WithResultNameKind(ResultNameKind.None);


        private static readonly string[] s_lengthLiteralValues = new[] {
            "Angstrom",
            "AstronomicalUnit",
            "Centimeter",
            "Chain",
            "DataMile",
            "Decameter",
            "Decimeter",
            "DtpPica",
            "DtpPoint",
            "Fathom",
            "Foot",
            "Hand",
            "Hectometer",
            "Inch",
            "KilolightYear",
            "Kilometer",
            "Kiloparsec",
            "LightYear",
            "MegalightYear",
            "Megaparsec",
            "Meter",
            "Microinch",
            "Micrometer",
            "Mil",
            "Mile",
            "Millimeter",
            "Nanometer",
            "NauticalMile",
            "Parsec",
            "PrinterPica",
            "PrinterPoint",
            "Shackle",
            "SolarRadius",
            "Twip",
            "UsSurveyFoot",
            "Yard",

            };

        public static readonly FunctionSymbol ConvertLength =
            new FunctionSymbol("convert_length", ScalarTypes.Real,
                new Parameter("value", ScalarTypes.Real),
                new Parameter("from", ScalarTypes.String, ArgumentKind.Expression, s_lengthLiteralValues),
                new Parameter("to", ScalarTypes.String, ArgumentKind.Expression, s_lengthLiteralValues))
            .ConstantFoldable()
            .WithResultNameKind(ResultNameKind.None);


        private static readonly string[] s_massLiteralValues = new[] {
            "Centigram",
            "Decagram",
            "Decigram",
            "EarthMass",
            "Grain",
            "Gram",
            "Hectogram",
            "Kilogram",
            "Kilopound",
            "Kilotonne",
            "LongHundredweight",
            "LongTon",
            "Megapound",
            "Megatonne",
            "Microgram",
            "Milligram",
            "Nanogram",
            "Ounce",
            "Pound",
            "ShortHundredweight",
            "ShortTon",
            "Slug",
            "SolarMass",
            "Stone",
            "Tonne",

            };

        public static readonly FunctionSymbol ConvertMass =
            new FunctionSymbol("convert_mass", ScalarTypes.Real,
                new Parameter("value", ScalarTypes.Real),
                new Parameter("from", ScalarTypes.String, ArgumentKind.Expression, s_massLiteralValues),
                new Parameter("to", ScalarTypes.String, ArgumentKind.Expression, s_massLiteralValues))
            .ConstantFoldable()
            .WithResultNameKind(ResultNameKind.None);


        private static readonly string[] s_speedLiteralValues = new[] {
            "CentimeterPerHour",
            "CentimeterPerMinute",
            "CentimeterPerSecond",
            "DecimeterPerMinute",
            "DecimeterPerSecond",
            "FootPerHour",
            "FootPerMinute",
            "FootPerSecond",
            "InchPerHour",
            "InchPerMinute",
            "InchPerSecond",
            "KilometerPerHour",
            "KilometerPerMinute",
            "KilometerPerSecond",
            "Knot",
            "MeterPerHour",
            "MeterPerMinute",
            "MeterPerSecond",
            "MicrometerPerMinute",
            "MicrometerPerSecond",
            "MilePerHour",
            "MillimeterPerHour",
            "MillimeterPerMinute",
            "MillimeterPerSecond",
            "NanometerPerMinute",
            "NanometerPerSecond",
            "UsSurveyFootPerHour",
            "UsSurveyFootPerMinute",
            "UsSurveyFootPerSecond",
            "YardPerHour",
            "YardPerMinute",
            "YardPerSecond",

            };

        public static readonly FunctionSymbol ConvertSpeed =
            new FunctionSymbol("convert_speed", ScalarTypes.Real,
                new Parameter("value", ScalarTypes.Real),
                new Parameter("from", ScalarTypes.String, ArgumentKind.Expression, s_speedLiteralValues),
                new Parameter("to", ScalarTypes.String, ArgumentKind.Expression, s_speedLiteralValues))
            .ConstantFoldable()
            .WithResultNameKind(ResultNameKind.None);


        private static readonly string[] s_temperatureLiteralValues = new[] {
            "DegreeCelsius",
            "DegreeDelisle",
            "DegreeFahrenheit",
            "DegreeNewton",
            "DegreeRankine",
            "DegreeReaumur",
            "DegreeRoemer",
            "Kelvin",
            "MillidegreeCelsius",
            "SolarTemperature",

            };

        public static readonly FunctionSymbol ConvertTemperature =
            new FunctionSymbol("convert_temperature", ScalarTypes.Real,
                new Parameter("value", ScalarTypes.Real),
                new Parameter("from", ScalarTypes.String, ArgumentKind.Expression, s_temperatureLiteralValues),
                new Parameter("to", ScalarTypes.String, ArgumentKind.Expression, s_temperatureLiteralValues))
            .ConstantFoldable()
            .WithResultNameKind(ResultNameKind.None);


        private static readonly string[] s_volumeLiteralValues = new[] {
            "AcreFoot",
            "AuTablespoon",
            "BoardFoot",
            "Centiliter",
            "CubicCentimeter",
            "CubicDecimeter",
            "CubicFoot",
            "CubicHectometer",
            "CubicInch",
            "CubicKilometer",
            "CubicMeter",
            "CubicMicrometer",
            "CubicMile",
            "CubicMillimeter",
            "CubicYard",
            "Decaliter",
            "DecausGallon",
            "Deciliter",
            "DeciusGallon",
            "HectocubicFoot",
            "HectocubicMeter",
            "Hectoliter",
            "HectousGallon",
            "ImperialBeerBarrel",
            "ImperialGallon",
            "ImperialOunce",
            "ImperialPint",
            "KilocubicFoot",
            "KilocubicMeter",
            "KiloimperialGallon",
            "Kiloliter",
            "KilousGallon",
            "Liter",
            "MegacubicFoot",
            "MegaimperialGallon",
            "Megaliter",
            "MegausGallon",
            "MetricCup",
            "MetricTeaspoon",
            "Microliter",
            "Milliliter",
            "OilBarrel",
            "UkTablespoon",
            "UsBeerBarrel",
            "UsCustomaryCup",
            "UsGallon",
            "UsLegalCup",
            "UsOunce",
            "UsPint",
            "UsQuart",
            "UsTablespoon",
            "UsTeaspoon",

            };

        public static readonly FunctionSymbol ConvertVolume =
            new FunctionSymbol("convert_volume", ScalarTypes.Real,
                new Parameter("value", ScalarTypes.Real),
                new Parameter("from", ScalarTypes.String, ArgumentKind.Expression, s_volumeLiteralValues),
                new Parameter("to", ScalarTypes.String, ArgumentKind.Expression, s_volumeLiteralValues))
            .ConstantFoldable()
            .WithResultNameKind(ResultNameKind.None);

        #endregion
    }
}
