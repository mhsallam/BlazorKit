# BlazorKit

### A Ui-Kit Components Library Wrapper for Blazor


![BlazorKit Package Installation](https://img.shields.io/nuget/vpre/BlazorKit.svg)
![BlazorKit Downloads](https://img.shields.io/nuget/dt/BlazorKit.svg)

I would say 80% of the UI kit components have been ported to Blazor. Right now I'll be working on the website and documentation.

# Installation
 
You can install a preview version of BlazorKit from NuGet using the following command:
```
Install-Package Blazorkit -Version 0.1.101
```
Or using dotnet CLI command:
```
dotnet add package Blazorkit --version 0.1.101
```

Now that you have installed BlazorKit, use its markup as described in the [BlazorKit](http://blazorkit.mhsallam.xyz) website, like this example which demonstrate creating an Alert component:

```
<Alert Color="Color.Primary" IsDismissible="true">
  This is a primary alert — check it out!
</Alert>
```

or Card:

```
<Card Color="BaseColor.Primary">
  <CardBody>
    <CardTitle>Title Text</CardTitle>
    Card body text...
  </CardBody>
</Card>
```

or Button:

```
<BlazorKit.Button Color="ButtonColor.Danger">Click Me!</BlazorKit.Button>
```

Note: completing the documentation and the website is still a work on progress

# See Also
[@chanan/BlazorStrap](https://github.com/chanan/BlazorStrap)