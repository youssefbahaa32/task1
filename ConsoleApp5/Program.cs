// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Enter the number of small carpets : ");
int small_carpets = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Enter the number of large carpets :");
int large_carpets = Convert.ToInt32(Console.ReadLine());
double sum = (small_carpets * 25) + (large_carpets * 35);
double taxs = (6 *sum) / 100;
double total = sum + taxs;
Console.WriteLine($"Totoal estimate : {total}");
Console.WriteLine("This estimate is valid for 30 days");
