using BlazorKit.Util;
using System.ComponentModel;

namespace BlazorKit
{
  public enum Size
  {
    None,
    [EnumValue("small")]
    Small,
    [EnumValue("medium")]
    Medium,
    [EnumValue("large")]
    Large,
    [EnumValue("xlarge")]
    Larger,
    [EnumValue("2xlarge")]
    ExtraLarger
  }

  public enum BaseSize
  {
    None,
    Small,
    Large,
  }
  public enum BaseSizeAndDefault
  {
    None,
    Small,
    Large,
    Default
  }

  public enum GutterSize
  {
    None,
    Small,
    Medium,
    Large,
    Collapse

  }

  public enum WidthSize
  {
    None,
    [EnumValue("auto")]
    Auto,
    [EnumValue("expand")]
    Expand,
    [EnumValue("1-1")]
    Whole,
    [EnumValue("1-2")]
    Half,
    [EnumValue("1-3")]
    OneThird,
    [EnumValue("2-3")]
    TwoThirds,
    [EnumValue("1-4")]
    OneFourth,
    [EnumValue("2-4")]
    TwoFourth,
    [EnumValue("3-4")]
    ThreeFourth,
    [EnumValue("1-5")]
    OneFifth,
    [EnumValue("2-5")]
    TwoFifths,
    [EnumValue("3-5")]
    ThreeFifths,
    [EnumValue("4-5")]
    FourFifths,
    [EnumValue("1-6")]
    OneSixth,
    [EnumValue("2-6")]
    TwoSixth,
    [EnumValue("3-6")]
    ThreeSixth,
    [EnumValue("4-6")]
    FourSixth,
    [EnumValue("5-6")]
    FiveSixth,

    [EnumValue("1-1@s")]
    WholeAtSmallScreen,
    [EnumValue("1-2@s")]
    HalfAtSmallScreen,
    [EnumValue("1-3@s")]
    OneThirdAtSmallScreen,
    [EnumValue("2-3@s")]
    TwoThirdsAtSmallScreen,
    [EnumValue("1-4@s")]
    OneFourthAtSmallScreen,
    [EnumValue("2-4@s")]
    TwoFourthAtSmallScreen,
    [EnumValue("3-4@s")]
    ThreeFourthAtSmallScreen,
    [EnumValue("1-5@s")]
    OneFifthAtSmallScreen,
    [EnumValue("2-5@s")]
    TwoFifthsAtSmallScreen,
    [EnumValue("3-5@s")]
    ThreeFifthsAtSmallScreen,
    [EnumValue("4-5@s")]
    FourFifthsAtSmallScreen,
    [EnumValue("1-6@s")]
    OneSixthAtSmallScreen,
    [EnumValue("2-6@s")]
    TwoSixthAtSmallScreen,
    [EnumValue("3-6@s")]
    ThreeSixthAtSmallScreen,
    [EnumValue("4-6@s")]
    FourSixthAtSmallScreen,
    [EnumValue("5-6@s")]
    FiveSixthAtSmallScreen,

    [EnumValue("1-1@m")]
    WholeAtMediumScreen,
    [EnumValue("1-2@m")]
    HalfAtMediumScreen,
    [EnumValue("1-3@m")]
    OneThirdAtMediumScreen,
    [EnumValue("2-3@m")]
    TwoThirdsAtMediumScreen,
    [EnumValue("1-4@m")]
    OneFourthAtMediumScreen,
    [EnumValue("2-4@m")]
    TwoFourthAtMediumScreen,
    [EnumValue("3-4@m")]
    ThreeFourthAtMediumScreen,
    [EnumValue("1-5@m")]
    OneFifthAtMediumScreen,
    [EnumValue("2-5@m")]
    TwoFifthsAtMediumScreen,
    [EnumValue("3-5@m")]
    ThreeFifthsAtMediumScreen,
    [EnumValue("4-5@m")]
    FourFifthsAtMediumScreen,
    [EnumValue("1-6@m")]
    OneSixthAtMediumScreen,
    [EnumValue("2-6@m")]
    TwoSixthAtMediumScreen,
    [EnumValue("3-6@m")]
    ThreeSixthAtMediumScreen,
    [EnumValue("4-6@m")]
    FourSixthAtMediumScreen,
    [EnumValue("5-6@m")]
    FiveSixthAtMediumScreen,

    [EnumValue("1-1@l")]
    WholeAtLargeScreen,
    [EnumValue("1-2@l")]
    HalfAtLargeScreen,
    [EnumValue("1-3@l")]
    OneThirdAtLargeScreen,
    [EnumValue("2-3@l")]
    TwoThirdsAtLargeScreen,
    [EnumValue("1-4@l")]
    OneFourthAtLargeScreen,
    [EnumValue("2-4@l")]
    TwoFourthAtLargeScreen,
    [EnumValue("3-4@l")]
    ThreeFourthAtLargeScreen,
    [EnumValue("1-5@l")]
    OneFifthAtLargeScreen,
    [EnumValue("2-5@l")]
    TwoFifthsAtLargeScreen,
    [EnumValue("3-5@l")]
    ThreeFifthsAtLargeScreen,
    [EnumValue("4-5@l")]
    FourFifthsAtLargeScreen,
    [EnumValue("1-6@l")]
    OneSixthAtLargeScreen,
    [EnumValue("2-6@l")]
    TwoSixthAtLargeScreen,
    [EnumValue("3-6@l")]
    ThreeSixthAtLargeScreen,
    [EnumValue("4-6@l")]
    FourSixthAtLargeScreen,
    [EnumValue("5-6@l")]
    FiveSixthAtLargeScreen,

    [EnumValue("1-1@xl")]
    WholeAtExtraLargeScreen,
    [EnumValue("1-2@xl")]
    HalfAtExtraLargeScreen,
    [EnumValue("1-3@xl")]
    OneThirdAtExtraLargeScreen,
    [EnumValue("2-3@xl")]
    TwoThirdsAtExtraLargeScreen,
    [EnumValue("1-4@xl")]
    OneFourthAtExtraLargeScreen,
    [EnumValue("2-4@xl")]
    TwoFourthAtExtraLargeScreen,
    [EnumValue("3-4@xl")]
    ThreeFourthAtExtraLargeScreen,
    [EnumValue("1-5@xl")]
    OneFifthAtExtraLargeScreen,
    [EnumValue("2-5@xl")]
    TwoFifthsAtExtraLargeScreen,
    [EnumValue("3-5@xl")]
    ThreeFifthsAtExtraLargeScreen,
    [EnumValue("4-5@xl")]
    FourFifthsAtExtraLargeScreen,
    [EnumValue("1-6@xl")]
    OneSixthAtExtraLargeScreen,
    [EnumValue("2-6@xl")]
    TwoSixthAtExtraLargeScreen,
    [EnumValue("3-6@xl")]
    ThreeSixthAtExtraLargeScreen,
    [EnumValue("4-6@xl")]
    FourSixthAtExtraLargeScreen,
    [EnumValue("5-6@xl")]
    FiveSixthAtExtraLargeScreen,

    [EnumValue("small")]
    Small,
    [EnumValue("medium")]
    Medium,
    [EnumValue("large")]
    Large,
    [EnumValue("xlarge")]
    ExtraLarge,
    [EnumValue("xxlarge")]
    DoubleExtraLarge,
  }

  public enum HeightSize
  {
    None,
    [EnumValue("1-1")]
    Full,
    [EnumValue("small")]
    Small,
    [EnumValue("max-small")]
    MaxSmall,
    [EnumValue("medium")]
    Medium,
    [EnumValue("max-medium")]
    MaxMedium,
    [EnumValue("large")]
    Large,
    [EnumValue("max-large")]
    MaxLarge,
  }

  public enum SmallToExtraSize
  {
    None,
    [EnumValue("small")]
    Small,
    [EnumValue("medium")]
    Medium,
    [EnumValue("large")]
    Large,
    [EnumValue("xlarge")]
    ExtraLarge,
  }

  public enum ExtraSmallToLargeSize
  {
    None,
    [EnumValue("xsmall")]
    ExtraSmall,
    [EnumValue("small")]
    Small,
    [EnumValue("medium")]
    Medium,
    [EnumValue("large")]
    Large,
  }

  public enum ExtraSmallToExpandSize
  {
    None,
    [EnumValue("xsmall")]
    ExtraSmall,
    [EnumValue("small")]
    Small,
    [EnumValue("large")]
    Large,
    [EnumValue("expand")]
    Expand,
  }

  public enum SmallToLargeSize
  {
    None,
    [EnumValue("small")]
    Small,
    [EnumValue("medium")]
    Medium,
    [EnumValue("large")]
    Large,
  }

  public enum BackgroundSize
  {
    None,
    [EnumValue("cover")]
    Cover,
    [EnumValue("contain")]
    Contain
  }

  public enum ResponsiveScreen
  {
    None,
    [EnumValue("@s")]
    Small,
    [EnumValue("@m")]
    Medium,
    [EnumValue("@l")]
    Large,
    [EnumValue("@xl")]
    ExtraLarge
  }
}
