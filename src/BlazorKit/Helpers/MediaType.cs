using BlazorKit.Util;

namespace BlazorKit
{
  public enum MediaType
  {
    Auto,
    [EnumValue("image")]
    Image,
    [EnumValue("video")]
    Video,
    [EnumValue("iframe")]
    IFrame
  }
}
