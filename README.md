<table>
<td width="160">
<svg id="Layer_1" data-name="Layer 1" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 485.86 421.58"><defs><style>.cls-1{fill:#5b2e8f;}.cls-2,.cls-3{fill:#fff;}.cls-3{font-size:95.44px;font-family:Offside-Regular, Offside;}</style></defs><title>blazorkit</title><path class="cls-1" d="M937.17,559.8c-.61,7.4,1,16.26-1,25-4.94,21.14-24.92,34.81-47,32.12-20.61-2.51-36.29-20.52-36.3-41.7,0-24,18.15-42.34,42.25-42.48,12.33-.07,24.66.1,37-.08,4-.06,5.27,1.37,5.13,5.26C937,544.74,937.17,551.58,937.17,559.8Z" transform="translate(-725.34 -329.71)"></path><path class="cls-1" d="M1060.48,700.26S1201,592,1211.2,458.33c.12-1.63-1.52-2.64-2.52-1.35-8.21,10.62-15.62,19.42-22.29,26.72,6.08-29.31,7-60.75,2.49-94.37-2.67-19.94-9.31-38.78-18.94-56.5-2.24-4.12-4.4-4.16-6.73-.17-2.18,3.74-4.25,7.54-6.36,11.32-23.3,41.72-57.92,68.87-104.26,80.87-1.91.49-4.27,2.4-6,0-1.52-2.1.83-3.67,1.77-5.23a157.36,157.36,0,0,0,17-39.28,146.49,146.49,0,0,0,4.64-24.47c.14-1.41.82-3.17-1-4-2-.95-3,.81-4.14,1.92-.36.35-.66.75-1,1.11-27.9,28.34-61.63,44.51-101.33,47-24.27,1.51-48.65-.48-72.94.84-48.53,2.64-89.22,22.16-120.89,58.87-38.13,44.21-50.55,95.74-39.57,152.82A168.37,168.37,0,0,0,885.75,750.85a305.23,305.23,0,0,0,59.72-2.65C988,742.05,1025.32,727.41,1058,702" transform="translate(-725.34 -329.71)"></path><polygon class="cls-2" points="223.1 137.45 179.69 112.29 134.41 140.29 178.47 164.55 223.1 137.45"></polygon><path class="cls-2" d="M969.3,477.94l-44.88,27.11,50.8,29.45v77.24l-68.48,38.63L838.9,611.83V551.94l-45.43-23.12V638.44L905,704l115.63-65.56v-131Z" transform="translate(-725.34 -329.71)"></path><text class="cls-3" transform="translate(122.45 278.82)">BK</text></svg>
</td>
<td>

# BlazorKit

### A Ui-Kit Components Library Wrapper for Blazor

![BlazorKit Package Installation](https://img.shields.io/nuget/vpre/BlazorKit.svg)
![BlazorKit Downloads](https://img.shields.io/nuget/dt/BlazorKit.svg)

</td>
</table>

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
[chanan/BlazorStrap](https://github.com/chanan/BlazorStrap)