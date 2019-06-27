using BlazorKit.Util;
using System.ComponentModel;

namespace BlazorKit
{
  public enum DropdownPosition
  {
    None,
    [EnumValue("pos: bottom-left")]
    BottomLeft,
    [EnumValue("pos: bottom-center")]
    BottomCenter,
    [EnumValue("pos: bottom-right")]
    BottomRight,
    [EnumValue("pos: bottom-justify")]
    BottomJustify,
    [EnumValue("pos: top-left")]
    TopLeft,
    [EnumValue("pos: top-center")]
    TopCenter,
    [EnumValue("pos: top-right")]
    TopRight,
    [EnumValue("pos: top-justify")]
    TopJustify,
    [EnumValue("pos: left-top")]
    LeftTop,
    [EnumValue("pos: left-center")]
    LeftCenter,
    [EnumValue("pos: left-bottom")]
    LeftBottom,
    [EnumValue("pos: right-top")]
    RightTop,
    [EnumValue("pos: right-center")]
    RightCenter,
    [EnumValue("pos: right-bottom")]
    RightBottom,
  }

  public enum DropdownMode
  {
    Hover,
    [EnumValue("mode: click")]
    Click
  }
}
