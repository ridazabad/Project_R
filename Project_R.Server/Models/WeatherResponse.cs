using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text.Json.Serialization;

public class WeatherResponse
{   
    [JsonPropertyName("main")]
    public MainInfo Main { get; set; }

    [JsonPropertyName("weather")]
    public List<WeatherInfo> Weather { get; set; }

    [JsonPropertyName("wind")]
    public WindInfo Wind { get; set; }

    [JsonPropertyName("sys")]
    public SysInfo Sys { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class MainInfo
{
    [JsonPropertyName("temp")]
    public double Temp { get; set; }

    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }
}

public class WeatherInfo
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }
}

public class WindInfo
{
    [JsonPropertyName("speed")]
    public double Speed { get; set; }
}

public class SysInfo
{
    [JsonPropertyName("country")]
    public string Country { get; set; }
}

// End of the code file Project_R.Server/Models/WeatherResponse.cs
