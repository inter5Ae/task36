﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void InputArray(int[] array) 
{     
    for (int i = 0; i < array.Length; i++)         
    array[i] = new Random().Next(0, 10);  
} 

void ReleaseArray(int[] array) 
{     
    int sum = 0; 
    for (int i = 0; i < array.Length; i++)
       if (i % 2 == 0);
       
       else   
       sum = sum+= array[i];         
        Console.Write($"{sum}");          
} 

void PrintArray(int[] array) 
{     
    Console.WriteLine($"[{string.Join(", ", array)}]"); 
} 

Console.Clear(); 
Console.Write($"n = "); 
int n = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[n]; 
InputArray(array); 
PrintArray(array); 
ReleaseArray(array);
