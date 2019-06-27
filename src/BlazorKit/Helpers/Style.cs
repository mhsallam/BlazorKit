using BlazorKit.Util;
using System.ComponentModel;

namespace BlazorKit
{
  public enum Color
  {
    None,
    [EnumValue("active")]
    Active,
    [EnumValue("primary")]
    Primary,
    [EnumValue("secondary")]
    Secondary,
    [EnumValue("success")]
    Success,
    [EnumValue("danger")]
    Danger,
    [EnumValue("warning")]
    Warning,
    [EnumValue("info")]
    Info,
    [EnumValue("link")]
    Link,
    [EnumValue("light")]
    Light,
    [EnumValue("dark")]
    Dark
  }

  public enum BaseColor
  {
    None,
    [EnumValue("default")]
    Default,
    [EnumValue("primary")]
    Primary,
    [EnumValue("secondary")]
    Secondary,
  }
  public enum InputState
  {
    None,
    [EnumValue("default")]
    Default,
    [EnumValue("success")]
    Success,
    [EnumValue("danger")]
    Danger,
  }

  public enum ButtonColor
  {
    None,
    Default,
    Primary,
    Secondary,
    Success,
    Danger,
    Text,
    Link
  }

  public enum LabelStyle
  {
    None,
    [EnumValue("success")]
    Success,
    [EnumValue("warning")]
    Warning,
    [EnumValue("danger")]
    Danger
  }
  public enum FormLayout
  {
    None,
    Stacked,
    Horizontal,
    Label,
    Controls
  }

  public enum TextStyle
  {
    None,
    [EnumValue("lead")]
    Lead,
    [EnumValue("meta")]
    Meta
  }

  public enum TextTransformStyle
  {
    None,
    Uppercase,
    Capitalize,
    Lowercase
  }

  public enum TextColor
  {
    None,
    [EnumValue("muted")]
    Muted,
    [EnumValue("emphasis")]
    Emphasis,
    [EnumValue("primary")]
    Primary,
    [EnumValue("secondary")]
    Secondary,
    [EnumValue("success")]
    Success,
    [EnumValue("danger")]
    Danger,
    [EnumValue("warning")]
    Warning,
  }

  public enum BackgroundColor
  {
    None,
    [EnumValue("muted")]
    Muted,
    [EnumValue("primary")]
    Primary,
    [EnumValue("secondary")]
    Secondary,
    [EnumValue("default")]
    Default,
  }
  public enum DefaultPrimaryColor
  {
    None,
    [EnumValue("default")]
    Default,
    [EnumValue("primary")]
    Primary
  }

  public enum InverseColor
  {
    None,
    [EnumValue("dark")]
    Dark,
    [EnumValue("light")]
    Light,
  }

  public enum TextWrap
  {
    None,
    [EnumValue("truncate")]
    Truncate,
    [EnumValue("break")]
    Break,
    [EnumValue("nowrap")]
    NoWrap,
  }

  public enum BlendMode
  {
    None,
    [EnumValue("multiply")]
    Multiply,
    [EnumValue("screen")]
    Screen,
    [EnumValue("overlay")]
    Overlay,
    [EnumValue("darken")]
    Darken,
    [EnumValue("lighten")]
    Lighten,
    [EnumValue("color-dodge")]
    ColorDodge,
    [EnumValue("burn")]
    Burn,
    [EnumValue("hard-light")]
    HardLight,
    [EnumValue("soft-light")]
    SoftLight,
    [EnumValue("difference")]
    Difference,
    [EnumValue("exclusion")]
    Exclusion,
    [EnumValue("blend-hue")]
    BlendHue,
    [EnumValue("blend-saturation")]
    BlendSaturation,
    [EnumValue("blend-color")]
    BlendColor,
    [EnumValue("blend-luminosity")]
    BlendLuminosity
  }

  public enum PaddingSize
  {
    None,
    [EnumValue("")]
    Default,
    [EnumValue("-small")]
    Small,
    [EnumValue("-large")]
    Large
  }
}