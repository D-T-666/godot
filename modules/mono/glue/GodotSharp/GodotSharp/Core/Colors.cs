using System.Collections.Generic;

namespace Godot
{
    /// <summary>
    /// This class contains color constants created from standardized color names.
    /// The standardized color set is based on the X11 and .NET color names.
    /// </summary>
    public static class Colors
    {
        // Color names and values are derived from core/math/color_names.inc
        internal static readonly Dictionary<string, Color> namedColors = new Dictionary<string, Color> {
            { "ALICE_BLUE", new Color(0xF0F8FFFF) },
            { "ANTIQUE_WHITE", new Color(0xFAEBD7FF) },
            { "AQUA", new Color(0x00FFFFFF) },
            { "AQUAMARINE", new Color(0x7FFFD4FF) },
            { "AZURE", new Color(0xF0FFFFFF) },
            { "BEIGE", new Color(0xF5F5DCFF) },
            { "BISQUE", new Color(0xFFE4C4FF) },
            { "BLACK", new Color(0x000000FF) },
            { "BLANCHED_ALMOND", new Color(0xFFEBCDFF) },
            { "BLUE", new Color(0x0000FFFF) },
            { "BLUE_VIOLET", new Color(0x8A2BE2FF) },
            { "BROWN", new Color(0xA52A2AFF) },
            { "BURLYWOOD", new Color(0xDEB887FF) },
            { "CADET_BLUE", new Color(0x5F9EA0FF) },
            { "CHARTREUSE", new Color(0x7FFF00FF) },
            { "CHOCOLATE", new Color(0xD2691EFF) },
            { "CORAL", new Color(0xFF7F50FF) },
            { "CORNFLOWER_BLUE", new Color(0x6495EDFF) },
            { "CORNSILK", new Color(0xFFF8DCFF) },
            { "CRIMSON", new Color(0xDC143CFF) },
            { "CYAN", new Color(0x00FFFFFF) },
            { "DARK_BLUE", new Color(0x00008BFF) },
            { "DARK_CYAN", new Color(0x008B8BFF) },
            { "DARK_GOLDENROD", new Color(0xB8860BFF) },
            { "DARK_GRAY", new Color(0xA9A9A9FF) },
            { "DARK_GREEN", new Color(0x006400FF) },
            { "DARK_KHAKI", new Color(0xBDB76BFF) },
            { "DARK_MAGENTA", new Color(0x8B008BFF) },
            { "DARK_OLIVE_GREEN", new Color(0x556B2FFF) },
            { "DARK_ORANGE", new Color(0xFF8C00FF) },
            { "DARK_ORCHID", new Color(0x9932CCFF) },
            { "DARK_RED", new Color(0x8B0000FF) },
            { "DARK_SALMON", new Color(0xE9967AFF) },
            { "DARK_SEA_GREEN", new Color(0x8FBC8FFF) },
            { "DARK_SLATE_BLUE", new Color(0x483D8BFF) },
            { "DARK_SLATE_GRAY", new Color(0x2F4F4FFF) },
            { "DARK_TURQUOISE", new Color(0x00CED1FF) },
            { "DARK_VIOLET", new Color(0x9400D3FF) },
            { "DEEP_PINK", new Color(0xFF1493FF) },
            { "DEEP_SKY_BLUE", new Color(0x00BFFFFF) },
            { "DIM_GRAY", new Color(0x696969FF) },
            { "DODGER_BLUE", new Color(0x1E90FFFF) },
            { "FIREBRICK", new Color(0xB22222FF) },
            { "FLORAL_WHITE", new Color(0xFFFAF0FF) },
            { "FOREST_GREEN", new Color(0x228B22FF) },
            { "FUCHSIA", new Color(0xFF00FFFF) },
            { "GAINSBORO", new Color(0xDCDCDCFF) },
            { "GHOST_WHITE", new Color(0xF8F8FFFF) },
            { "GOLD", new Color(0xFFD700FF) },
            { "GOLDENROD", new Color(0xDAA520FF) },
            { "GRAY", new Color(0xBEBEBEFF) },
            { "GREEN", new Color(0x00FF00FF) },
            { "GREEN_YELLOW", new Color(0xADFF2FFF) },
            { "HONEYDEW", new Color(0xF0FFF0FF) },
            { "HOT_PINK", new Color(0xFF69B4FF) },
            { "INDIAN_RED", new Color(0xCD5C5CFF) },
            { "INDIGO", new Color(0x4B0082FF) },
            { "IVORY", new Color(0xFFFFF0FF) },
            { "KHAKI", new Color(0xF0E68CFF) },
            { "LAVENDER", new Color(0xE6E6FAFF) },
            { "LAVENDER_BLUSH", new Color(0xFFF0F5FF) },
            { "LAWN_GREEN", new Color(0x7CFC00FF) },
            { "LEMON_CHIFFON", new Color(0xFFFACDFF) },
            { "LIGHT_BLUE", new Color(0xADD8E6FF) },
            { "LIGHT_CORAL", new Color(0xF08080FF) },
            { "LIGHT_CYAN", new Color(0xE0FFFFFF) },
            { "LIGHT_GOLDENROD", new Color(0xFAFAD2FF) },
            { "LIGHT_GRAY", new Color(0xD3D3D3FF) },
            { "LIGHT_GREEN", new Color(0x90EE90FF) },
            { "LIGHT_PINK", new Color(0xFFB6C1FF) },
            { "LIGHT_SALMON", new Color(0xFFA07AFF) },
            { "LIGHT_SEA_GREEN", new Color(0x20B2AAFF) },
            { "LIGHT_SKY_BLUE", new Color(0x87CEFAFF) },
            { "LIGHT_SLATE_GRAY", new Color(0x778899FF) },
            { "LIGHT_STEEL_BLUE", new Color(0xB0C4DEFF) },
            { "LIGHT_YELLOW", new Color(0xFFFFE0FF) },
            { "LIME", new Color(0x00FF00FF) },
            { "LIME_GREEN", new Color(0x32CD32FF) },
            { "LINEN", new Color(0xFAF0E6FF) },
            { "MAGENTA", new Color(0xFF00FFFF) },
            { "MAROON", new Color(0xB03060FF) },
            { "MEDIUM_AQUAMARINE", new Color(0x66CDAAFF) },
            { "MEDIUM_BLUE", new Color(0x0000CDFF) },
            { "MEDIUM_ORCHID", new Color(0xBA55D3FF) },
            { "MEDIUM_PURPLE", new Color(0x9370DBFF) },
            { "MEDIUM_SEA_GREEN", new Color(0x3CB371FF) },
            { "MEDIUM_SLATE_BLUE", new Color(0x7B68EEFF) },
            { "MEDIUM_SPRING_GREEN", new Color(0x00FA9AFF) },
            { "MEDIUM_TURQUOISE", new Color(0x48D1CCFF) },
            { "MEDIUM_VIOLET_RED", new Color(0xC71585FF) },
            { "MIDNIGHT_BLUE", new Color(0x191970FF) },
            { "MINT_CREAM", new Color(0xF5FFFAFF) },
            { "MISTY_ROSE", new Color(0xFFE4E1FF) },
            { "MOCCASIN", new Color(0xFFE4B5FF) },
            { "NAVAJO_WHITE", new Color(0xFFDEADFF) },
            { "NAVY_BLUE", new Color(0x000080FF) },
            { "OLD_LACE", new Color(0xFDF5E6FF) },
            { "OLIVE", new Color(0x808000FF) },
            { "OLIVE_DRAB", new Color(0x6B8E23FF) },
            { "ORANGE", new Color(0xFFA500FF) },
            { "ORANGE_RED", new Color(0xFF4500FF) },
            { "ORCHID", new Color(0xDA70D6FF) },
            { "PALE_GOLDENROD", new Color(0xEEE8AAFF) },
            { "PALE_GREEN", new Color(0x98FB98FF) },
            { "PALE_TURQUOISE", new Color(0xAFEEEEFF) },
            { "PALE_VIOLET_RED", new Color(0xDB7093FF) },
            { "PAPAYA_WHIP", new Color(0xFFEFD5FF) },
            { "PEACH_PUFF", new Color(0xFFDAB9FF) },
            { "PERU", new Color(0xCD853FFF) },
            { "PINK", new Color(0xFFC0CBFF) },
            { "PLUM", new Color(0xDDA0DDFF) },
            { "POWDER_BLUE", new Color(0xB0E0E6FF) },
            { "PURPLE", new Color(0xA020F0FF) },
            { "REBECCA_PURPLE", new Color(0x663399FF) },
            { "RED", new Color(0xFF0000FF) },
            { "ROSY_BROWN", new Color(0xBC8F8FFF) },
            { "ROYAL_BLUE", new Color(0x4169E1FF) },
            { "SADDLE_BROWN", new Color(0x8B4513FF) },
            { "SALMON", new Color(0xFA8072FF) },
            { "SANDY_BROWN", new Color(0xF4A460FF) },
            { "SEA_GREEN", new Color(0x2E8B57FF) },
            { "SEASHELL", new Color(0xFFF5EEFF) },
            { "SIENNA", new Color(0xA0522DFF) },
            { "SILVER", new Color(0xC0C0C0FF) },
            { "SKY_BLUE", new Color(0x87CEEBFF) },
            { "SLATE_BLUE", new Color(0x6A5ACDFF) },
            { "SLATE_GRAY", new Color(0x708090FF) },
            { "SNOW", new Color(0xFFFAFAFF) },
            { "SPRING_GREEN", new Color(0x00FF7FFF) },
            { "STEEL_BLUE", new Color(0x4682B4FF) },
            { "TAN", new Color(0xD2B48CFF) },
            { "TEAL", new Color(0x008080FF) },
            { "THISTLE", new Color(0xD8BFD8FF) },
            { "TOMATO", new Color(0xFF6347FF) },
            { "TRANSPARENT", new Color(0xFFFFFF00) },
            { "TURQUOISE", new Color(0x40E0D0FF) },
            { "VIOLET", new Color(0xEE82EEFF) },
            { "WEB_GRAY", new Color(0x808080FF) },
            { "WEB_GREEN", new Color(0x008000FF) },
            { "WEB_MAROON", new Color(0x800000FF) },
            { "WEB_PURPLE", new Color(0x800080FF) },
            { "WHEAT", new Color(0xF5DEB3FF) },
            { "WHITE", new Color(0xFFFFFFFF) },
            { "WHITE_SMOKE", new Color(0xF5F5F5FF) },
            { "YELLOW", new Color(0xFFFF00FF) },
            { "YELLOW_GREEN", new Color(0x9ACD32FF) },
        };

#pragma warning disable CS1591 // Disable warning: "Missing XML comment for publicly visible type or member"
        public static Color AliceBlue { get { return namedColors["ALICEBLUE"]; } }
        public static Color AntiqueWhite { get { return namedColors["ANTIQUEWHITE"]; } }
        public static Color Aqua { get { return namedColors["AQUA"]; } }
        public static Color Aquamarine { get { return namedColors["AQUAMARINE"]; } }
        public static Color Azure { get { return namedColors["AZURE"]; } }
        public static Color Beige { get { return namedColors["BEIGE"]; } }
        public static Color Bisque { get { return namedColors["BISQUE"]; } }
        public static Color Black { get { return namedColors["BLACK"]; } }
        public static Color BlanchedAlmond { get { return namedColors["BLANCHEDALMOND"]; } }
        public static Color Blue { get { return namedColors["BLUE"]; } }
        public static Color BlueViolet { get { return namedColors["BLUEVIOLET"]; } }
        public static Color Brown { get { return namedColors["BROWN"]; } }
        public static Color Burlywood { get { return namedColors["BURLYWOOD"]; } }
        public static Color CadetBlue { get { return namedColors["CADETBLUE"]; } }
        public static Color Chartreuse { get { return namedColors["CHARTREUSE"]; } }
        public static Color Chocolate { get { return namedColors["CHOCOLATE"]; } }
        public static Color Coral { get { return namedColors["CORAL"]; } }
        public static Color CornflowerBlue { get { return namedColors["CORNFLOWERBLUE"]; } }
        public static Color Cornsilk { get { return namedColors["CORNSILK"]; } }
        public static Color Crimson { get { return namedColors["CRIMSON"]; } }
        public static Color Cyan { get { return namedColors["CYAN"]; } }
        public static Color DarkBlue { get { return namedColors["DARKBLUE"]; } }
        public static Color DarkCyan { get { return namedColors["DARKCYAN"]; } }
        public static Color DarkGoldenrod { get { return namedColors["DARKGOLDENROD"]; } }
        public static Color DarkGray { get { return namedColors["DARKGRAY"]; } }
        public static Color DarkGreen { get { return namedColors["DARKGREEN"]; } }
        public static Color DarkKhaki { get { return namedColors["DARKKHAKI"]; } }
        public static Color DarkMagenta { get { return namedColors["DARKMAGENTA"]; } }
        public static Color DarkOliveGreen { get { return namedColors["DARKOLIVEGREEN"]; } }
        public static Color DarkOrange { get { return namedColors["DARKORANGE"]; } }
        public static Color DarkOrchid { get { return namedColors["DARKORCHID"]; } }
        public static Color DarkRed { get { return namedColors["DARKRED"]; } }
        public static Color DarkSalmon { get { return namedColors["DARKSALMON"]; } }
        public static Color DarkSeaGreen { get { return namedColors["DARKSEAGREEN"]; } }
        public static Color DarkSlateBlue { get { return namedColors["DARKSLATEBLUE"]; } }
        public static Color DarkSlateGray { get { return namedColors["DARKSLATEGRAY"]; } }
        public static Color DarkTurquoise { get { return namedColors["DARKTURQUOISE"]; } }
        public static Color DarkViolet { get { return namedColors["DARKVIOLET"]; } }
        public static Color DeepPink { get { return namedColors["DEEPPINK"]; } }
        public static Color DeepSkyBlue { get { return namedColors["DEEPSKYBLUE"]; } }
        public static Color DimGray { get { return namedColors["DIMGRAY"]; } }
        public static Color DodgerBlue { get { return namedColors["DODGERBLUE"]; } }
        public static Color Firebrick { get { return namedColors["FIREBRICK"]; } }
        public static Color FloralWhite { get { return namedColors["FLORALWHITE"]; } }
        public static Color ForestGreen { get { return namedColors["FORESTGREEN"]; } }
        public static Color Fuchsia { get { return namedColors["FUCHSIA"]; } }
        public static Color Gainsboro { get { return namedColors["GAINSBORO"]; } }
        public static Color GhostWhite { get { return namedColors["GHOSTWHITE"]; } }
        public static Color Gold { get { return namedColors["GOLD"]; } }
        public static Color Goldenrod { get { return namedColors["GOLDENROD"]; } }
        public static Color Gray { get { return namedColors["GRAY"]; } }
        public static Color Green { get { return namedColors["GREEN"]; } }
        public static Color GreenYellow { get { return namedColors["GREENYELLOW"]; } }
        public static Color Honeydew { get { return namedColors["HONEYDEW"]; } }
        public static Color HotPink { get { return namedColors["HOTPINK"]; } }
        public static Color IndianRed { get { return namedColors["INDIANRED"]; } }
        public static Color Indigo { get { return namedColors["INDIGO"]; } }
        public static Color Ivory { get { return namedColors["IVORY"]; } }
        public static Color Khaki { get { return namedColors["KHAKI"]; } }
        public static Color Lavender { get { return namedColors["LAVENDER"]; } }
        public static Color LavenderBlush { get { return namedColors["LAVENDERBLUSH"]; } }
        public static Color LawnGreen { get { return namedColors["LAWNGREEN"]; } }
        public static Color LemonChiffon { get { return namedColors["LEMONCHIFFON"]; } }
        public static Color LightBlue { get { return namedColors["LIGHTBLUE"]; } }
        public static Color LightCoral { get { return namedColors["LIGHTCORAL"]; } }
        public static Color LightCyan { get { return namedColors["LIGHTCYAN"]; } }
        public static Color LightGoldenrod { get { return namedColors["LIGHTGOLDENROD"]; } }
        public static Color LightGray { get { return namedColors["LIGHTGRAY"]; } }
        public static Color LightGreen { get { return namedColors["LIGHTGREEN"]; } }
        public static Color LightPink { get { return namedColors["LIGHTPINK"]; } }
        public static Color LightSalmon { get { return namedColors["LIGHTSALMON"]; } }
        public static Color LightSeaGreen { get { return namedColors["LIGHTSEAGREEN"]; } }
        public static Color LightSkyBlue { get { return namedColors["LIGHTSKYBLUE"]; } }
        public static Color LightSlateGray { get { return namedColors["LIGHTSLATEGRAY"]; } }
        public static Color LightSteelBlue { get { return namedColors["LIGHTSTEELBLUE"]; } }
        public static Color LightYellow { get { return namedColors["LIGHTYELLOW"]; } }
        public static Color Lime { get { return namedColors["LIME"]; } }
        public static Color LimeGreen { get { return namedColors["LIMEGREEN"]; } }
        public static Color Linen { get { return namedColors["LINEN"]; } }
        public static Color Magenta { get { return namedColors["MAGENTA"]; } }
        public static Color Maroon { get { return namedColors["MAROON"]; } }
        public static Color MediumAquamarine { get { return namedColors["MEDIUMAQUAMARINE"]; } }
        public static Color MediumBlue { get { return namedColors["MEDIUMBLUE"]; } }
        public static Color MediumOrchid { get { return namedColors["MEDIUMORCHID"]; } }
        public static Color MediumPurple { get { return namedColors["MEDIUMPURPLE"]; } }
        public static Color MediumSeaGreen { get { return namedColors["MEDIUMSEAGREEN"]; } }
        public static Color MediumSlateBlue { get { return namedColors["MEDIUMSLATEBLUE"]; } }
        public static Color MediumSpringGreen { get { return namedColors["MEDIUMSPRINGGREEN"]; } }
        public static Color MediumTurquoise { get { return namedColors["MEDIUMTURQUOISE"]; } }
        public static Color MediumVioletRed { get { return namedColors["MEDIUMVIOLETRED"]; } }
        public static Color MidnightBlue { get { return namedColors["MIDNIGHTBLUE"]; } }
        public static Color MintCream { get { return namedColors["MINTCREAM"]; } }
        public static Color MistyRose { get { return namedColors["MISTYROSE"]; } }
        public static Color Moccasin { get { return namedColors["MOCCASIN"]; } }
        public static Color NavajoWhite { get { return namedColors["NAVAJOWHITE"]; } }
        public static Color NavyBlue { get { return namedColors["NAVYBLUE"]; } }
        public static Color OldLace { get { return namedColors["OLDLACE"]; } }
        public static Color Olive { get { return namedColors["OLIVE"]; } }
        public static Color OliveDrab { get { return namedColors["OLIVEDRAB"]; } }
        public static Color Orange { get { return namedColors["ORANGE"]; } }
        public static Color OrangeRed { get { return namedColors["ORANGERED"]; } }
        public static Color Orchid { get { return namedColors["ORCHID"]; } }
        public static Color PaleGoldenrod { get { return namedColors["PALEGOLDENROD"]; } }
        public static Color PaleGreen { get { return namedColors["PALEGREEN"]; } }
        public static Color PaleTurquoise { get { return namedColors["PALETURQUOISE"]; } }
        public static Color PaleVioletRed { get { return namedColors["PALEVIOLETRED"]; } }
        public static Color PapayaWhip { get { return namedColors["PAPAYAWHIP"]; } }
        public static Color PeachPuff { get { return namedColors["PEACHPUFF"]; } }
        public static Color Peru { get { return namedColors["PERU"]; } }
        public static Color Pink { get { return namedColors["PINK"]; } }
        public static Color Plum { get { return namedColors["PLUM"]; } }
        public static Color PowderBlue { get { return namedColors["POWDERBLUE"]; } }
        public static Color Purple { get { return namedColors["PURPLE"]; } }
        public static Color RebeccaPurple { get { return namedColors["REBECCAPURPLE"]; } }
        public static Color Red { get { return namedColors["RED"]; } }
        public static Color RosyBrown { get { return namedColors["ROSYBROWN"]; } }
        public static Color RoyalBlue { get { return namedColors["ROYALBLUE"]; } }
        public static Color SaddleBrown { get { return namedColors["SADDLEBROWN"]; } }
        public static Color Salmon { get { return namedColors["SALMON"]; } }
        public static Color SandyBrown { get { return namedColors["SANDYBROWN"]; } }
        public static Color SeaGreen { get { return namedColors["SEAGREEN"]; } }
        public static Color Seashell { get { return namedColors["SEASHELL"]; } }
        public static Color Sienna { get { return namedColors["SIENNA"]; } }
        public static Color Silver { get { return namedColors["SILVER"]; } }
        public static Color SkyBlue { get { return namedColors["SKYBLUE"]; } }
        public static Color SlateBlue { get { return namedColors["SLATEBLUE"]; } }
        public static Color SlateGray { get { return namedColors["SLATEGRAY"]; } }
        public static Color Snow { get { return namedColors["SNOW"]; } }
        public static Color SpringGreen { get { return namedColors["SPRINGGREEN"]; } }
        public static Color SteelBlue { get { return namedColors["STEELBLUE"]; } }
        public static Color Tan { get { return namedColors["TAN"]; } }
        public static Color Teal { get { return namedColors["TEAL"]; } }
        public static Color Thistle { get { return namedColors["THISTLE"]; } }
        public static Color Tomato { get { return namedColors["TOMATO"]; } }
        public static Color Transparent { get { return namedColors["TRANSPARENT"]; } }
        public static Color Turquoise { get { return namedColors["TURQUOISE"]; } }
        public static Color Violet { get { return namedColors["VIOLET"]; } }
        public static Color WebGray { get { return namedColors["WEBGRAY"]; } }
        public static Color WebGreen { get { return namedColors["WEBGREEN"]; } }
        public static Color WebMaroon { get { return namedColors["WEBMAROON"]; } }
        public static Color WebPurple { get { return namedColors["WEBPURPLE"]; } }
        public static Color Wheat { get { return namedColors["WHEAT"]; } }
        public static Color White { get { return namedColors["WHITE"]; } }
        public static Color WhiteSmoke { get { return namedColors["WHITESMOKE"]; } }
        public static Color Yellow { get { return namedColors["YELLOW"]; } }
        public static Color YellowGreen { get { return namedColors["YELLOWGREEN"]; } }
#pragma warning restore CS1591
    }
}
