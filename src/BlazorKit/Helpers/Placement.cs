using BlazorKit.Util;
using System.ComponentModel;

namespace BlazorKit
{
    public enum Placement
    {
        [EnumValue("auto")]
        Auto,
        [EnumValue("auto-start")]
        AutoStart,
        [EnumValue("auto-end")]
        AutoEnd,
        [EnumValue("top")]
        Top,
        [EnumValue("top-start")]
        TopStart,
        [EnumValue("top-end")]
        TopEnd,
        [EnumValue("right")]
        Right,
        [EnumValue("right-start")]
        RightStart,
        [EnumValue("right-end")]
        EightEnd,
        [EnumValue("bottom")]
        Bottom,
        [EnumValue("bottom-start")]
        BottomStart,
        [EnumValue("bottom-end")]
        BottomEnd,
        [EnumValue("left")]
        Left,
        [EnumValue("left-start")]
        LeftStart,
        [EnumValue("left-end")]
        LeftEnd
    }
}
