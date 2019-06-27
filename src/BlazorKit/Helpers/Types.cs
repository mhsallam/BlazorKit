using BlazorKit.Util;

namespace BlazorKit
{
  public enum InputType
  {
    [EnumValue("checkbox")]
    Checkbox,
    [EnumValue("color")]
    Color,
    [EnumValue("date")]
    Date,
    [EnumValue("datetime-local")]
    DateTimeLocal,
    [EnumValue("email")]
    Email,
    [EnumValue("file")]
    File,
    [EnumValue("month")]
    Month,
    [EnumValue("number")]
    Number,
    [EnumValue("password")]
    Password,
    [EnumValue("radio")]
    Radio,
    [EnumValue("range")]
    Range,
    [EnumValue("search")]
    Search,
    [EnumValue("select")]
    Select,
    [EnumValue("tel")]
    Tel,
    [EnumValue("text")]
    Text,
    [EnumValue("textarea")]
    TextArea,
    [EnumValue("time")]
    Time,
    [EnumValue("url")]
    Url,
    [EnumValue("week")]
    Week
  }

  public enum ButtonType
    {
        Button,
        Link,
        Input,
        Submit,
        Reset,
        Close,
        Checkbox,
        Radio
    }

  public enum LinkType
  {
    None,
    [EnumValue("muted")]
    Muted,
    [EnumValue("text")]
    Text,
    [EnumValue("heading")]
    Heading,
    [EnumValue("reset")]
    Reset,
    [EnumValue("toggle")]
    Toggle
  }
}
