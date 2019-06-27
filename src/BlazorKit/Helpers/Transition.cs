using BlazorKit.Util;
using System.ComponentModel;

namespace BlazorKit
{
  public enum AnimationType
  {
    None,
    [EnumValue("uk-animation-fade")]
    Fade,
    [EnumValue("uk-animation-scale-up")]
    ScaleUp,
    [EnumValue("uk-animation-scale-down")]
    ScaleDown,
    [EnumValue("uk-animation-slide-top")]
    SlideTop,
    [EnumValue("uk-animation-slide-bottom")]
    SlideBottom,
    [EnumValue("uk-animation-slide-left")]
    SlideLeft,
    [EnumValue("uk-animation-slide-right")]
    SlideRight,
    [EnumValue("uk-animation-slide-top-small")]
    SlideTopSmall,
    [EnumValue("uk-animation-slide-bottom-small")]
    SlideBottomSmall,
    [EnumValue("uk-animation-slide-left-small")]
    SlideLeftSmall,
    [EnumValue("uk-animation-slide-right-small")]
    SlideRightSmall,
    [EnumValue("uk-animation-slide-top-medium")]
    SlideTopMedium,
    [EnumValue("uk-animation-slide-bottom-medium")]
    SlideBottomMedium,
    [EnumValue("uk-animation-slide-left-medium")]
    SlideLeftMedium,
    [EnumValue("uk-animation-slide-right-medium")]
    SlideRightMedium,
    [EnumValue("uk-animation-kenburns")]
    Kenburns,
    [EnumValue("uk-animation-shake")]
    Shake,
    [EnumValue("uk-animation-stroke")]
    Stroke
  }

  public enum BaseAnimationType
  {
    None,
    [EnumValue("slide")]
    Slide,
    [EnumValue("fade")]
    Fade,
    [EnumValue("scale")]
    Scale
  }

  public enum TransitionType
  {
    None,
    [EnumValue("fade")]
    Fade,
    [EnumValue("scale-up")]
    ScaleUp,
    [EnumValue("scale-down")]
    ScaleDown,
    [EnumValue("slide-top")]
    SlideTop,
    [EnumValue("slide-bottom")]
    SlideBottom,
    [EnumValue("slide-left")]
    SlideLeft,
    [EnumValue("slide-right")]
    SlideRight,
    [EnumValue("slide-top-small")]
    SlideTopSmall,
    [EnumValue("slide-bottom-small")]
    SlideBottomSmall,
    [EnumValue("slide-left-small")]
    SlideLeftSmall,
    [EnumValue("slide-right-small")]
    SlideRightSmall,
    [EnumValue("slide-top-medium")]
    SlideTopMedium,
    [EnumValue("slide-bottom-medium")]
    SlideBottomMedium,
    [EnumValue("slide-left-medium")]
    SlideLeftMedium,
    [EnumValue("slide-right-medium")]
    SlideRightMedium
  }
}