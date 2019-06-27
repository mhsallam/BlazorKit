using BlazorKit.Util;

namespace BlazorKit
{
  public enum ToggleMode
  {
    None,
    [EnumValue("hover")]
    Hover,
    [EnumValue("click")]
    Click,
    [EnumValue("click, hover")]
    ClickOrHover,
    [EnumValue("media")]
    Media
  }

  public enum MouseActionMode
  {
    Hover,
    [EnumValue("click")]
    Click
  }

  public enum DropbarMode
  {
    Overlay,
    [EnumValue("push")]
    Push,
  }
}
