using BlazorKit.Util;

namespace BlazorKit
{
  public enum Alignment
  {
    None,
    Left,
    Center,
    Right
  }

  public enum ResponsiveAlignment
  {
    None,
    [EnumValue("left")]
    Left,
    [EnumValue("center")]
    Center,
    [EnumValue("right")]
    Right,
    [EnumValue("left@s")]
    LeftAtSmall,
    [EnumValue("center@s")]
    CenterAtSmall,
    [EnumValue("right@s")]
    RightAtSmall,

    [EnumValue("left@m")]
    LeftAtMedium,
    [EnumValue("center@m")]
    CenterAtMedium,
    [EnumValue("right@m")]
    RightAtMedium,

    [EnumValue("left@l")]
    LeftAtLarge,
    [EnumValue("center@l")]
    CenterAtLarge,
    [EnumValue("right@;")]
    RightAtLarge,

    [EnumValue("left@xl")]
    LeftAtExtraLarge,
    [EnumValue("center@xl")]
    CenterAtExtraLarge,
    [EnumValue("right@xl")]
    RightAtExtraLarge,
  }

  public enum FlexAlignment
  {
    None,
    Left,
    Center,
    Right,
    Between,
    Around,
    Stretched,
    Top,
    Middle,
    Bottom
  }
  public enum VerticalAlignment
  {
    None,
    Bottom,
    Center,
    Top
  }

  public enum InlineVerticalAlignment
  {
    None,
    [EnumValue("bottom")]
    Bottom,
    [EnumValue("center")]
    Center,
    [EnumValue("top")]
    Top,
    [EnumValue("baseline")]
    Baseline
  }

  public enum EdgePosition
  {
    None,
    Top,
    Bottom,
    Left,
    Right
  }

  public enum ResizeDirection
  {
    None,
    [EnumValue("resize-vertical")]
    Vertical,
    [EnumValue("resize")]
    Both
  }

  public enum PositionType
  {
    None,
    [EnumValue("top-left")]
    TopLeft,
    [EnumValue("top-center")]
    TopCenter,
    [EnumValue("top-right")]
    TopRight,

    [EnumValue("center-left")]
    CenterLeft,
    [EnumValue("center")]
    Center,
    [EnumValue("center-right")]
    CenterRight,

    [EnumValue("bottom-left")]
    BottomLeft,
    [EnumValue("bottom-center")]
    BottomCenter,
    [EnumValue("bottom-right")]
    BottomRight,
  }
  public enum GeneralPositionType
  {
    None,
    [EnumValue("left")]
    Left,
    [EnumValue("top")]
    Top,
    [EnumValue("right")]
    Right,
    [EnumValue("bottom")]
    Bottom,

    [EnumValue("top-left")]
    TopLeft,
    [EnumValue("top-center")]
    TopCenter,
    [EnumValue("top-right")]
    TopRight,

    [EnumValue("center-left")]
    CenterLeft,
    [EnumValue("center")]
    Center,
    [EnumValue("center-right")]
    CenterRight,

    [EnumValue("bottom-left")]
    BottomLeft,
    [EnumValue("bottom-center")]
    BottomCenter,
    [EnumValue("bottom-right")]
    BottomRight,

    [EnumValue("cover")]
    Fill,

    [EnumValue("left-out")]
    LeftOut,
    [EnumValue("right-out")]
    RightOut,
  }
  public enum OuterPositionType
  {
    None,
    [EnumValue("left")]
    Left,
    [EnumValue("top")]
    Top,
    [EnumValue("right")]
    Right,
    [EnumValue("bottom")]
    Bottom,

    [EnumValue("top-left")]
    TopLeft,
    [EnumValue("top-right")]
    TopRight,

    [EnumValue("bottom-left")]
    BottomLeft,
    [EnumValue("bottom-right")]
    BottomRight
  }
}
