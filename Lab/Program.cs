// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region Task1
//ededin sade ve ya murekkeb oldugunu tapin
//Console.WriteLine("Eded daxil edin:");
//int a = Convert.ToInt32(Console.ReadLine());
//bool isPrime = true;
//for (int i = 2; i < a; i++)
//{
//    if (a % i == 0)
//    {
//        isPrime = false;
//        break;
//    }
//}
//if (isPrime)
//{
//    Console.WriteLine("Sadedir");
//}
//else
//{
//    Console.WriteLine("Murekkebdir");
//}
#endregion
#region Task2
//Console.WriteLine("Eded daxil edin:");
//int a = Convert.ToInt32(Console.ReadLine());
//int sum = 1;
//for (int i = 1; i <= a;  i++)
//{
//    sum *= i;
//}
//Console.WriteLine(sum);
#endregion
#region Task3
//int[] arr = { 1, 2, 3, 4, 5, 6, 5, 5, 4, 3, 4, 5, 4 };
//int count = 0;

//foreach(int i in arr)
//{
//    if (i == 5)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
//==================================
//for (int i = arr[0]; i < arr.Length; i++)
//{
//    if (arr[i] == 5)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
#endregion
#region Task4
int[] arr = { 1, 2, 3, 5, 6, 7, 4, 3, 4, 25, 45, 63, 46, 23, 41, 53, 64, 53, 5225, 2, 3, 234, 12, };
int count = 0;
foreach  (int i in arr)
{
    if (i == 63)
    {
        count++;
    }
}
Console.WriteLine(count);


#endregion