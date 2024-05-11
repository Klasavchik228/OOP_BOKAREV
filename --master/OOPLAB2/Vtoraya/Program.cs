using Microsoft.VisualBasic;
using System;
using System.Net;
using System.Numerics;
using System.Text;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        printResponseAsync("https://youtube.com");
        printResponseAsync("https://translate.google.ru");
        printResponseAsync("https://metanit.com");
    }

    public static void printResponseAsync(string url)
    {
        Task<string> responseTask = getHttpResponse(url);
        responseTask.Wait();
        Console.WriteLine(responseTask.Result);
    }

    public async static Task<string> getHttpResponse(string url)
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(url);
        return await response.Content.ReadAsStringAsync();
    }
}