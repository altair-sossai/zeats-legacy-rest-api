<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-legacy-rest-api

Methods to solve common problems when working with RestApi

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-rest-api?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=33&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Legacy.RestApi.svg)](https://www.nuget.org/packages/Zeats.Legacy.RestApi)

## Installation

```PM>
Install-Package Zeats.Legacy.RestApi
```

## Methods

### IRestResponse<T> Post<T>(string resource, object model, Parameter[] headers = null, Parameter[] parameters = null)
Send a POST request to API
```c#
public class Product
{
	public int Id { get; set; }
	public string Title { get; set; }
}

const string apiUrl = "https://sample-api.com";
            
var unitOfWork = new UnitOfWorkRestApi(apiUrl);

var product = new Product() { Id = 1, Title = "Lorem ipsum"};
var restResponse = unitOfWork.Post<Product>("product", product);
```
---
