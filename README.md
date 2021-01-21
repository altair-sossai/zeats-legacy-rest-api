<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-legacy-rest-api

Extensions to solve common problems when working with RestApi

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-rest-api?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=33&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Legacy.RestApi.svg)](https://www.nuget.org/packages/Zeats.Legacy.RestApi)

## Installation

```PM>
Install-Package Zeats.Legacy.RestApi
```

## Extensions

### IpValidator.IsIpV4(string rest-api)
Checks if the content of a string is a valid RestApi V4
```c#
IpValidator.IsIpV4("10.a.30.40") /* return false */
IpValidator.IsIpV4("10.0.0.150") /* return true */
```
---
