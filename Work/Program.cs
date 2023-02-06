// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int [] ar =new int[size];
string[]coordName={"X","Y","Z"};//заполнение
// ОПИСАНИЕ И ВЫЗОВ RANDOMа
Random rnd = new Random();
for (int i=0;i<ar.Length;i++)  { ar[i] = rnd.Next(0,100);} 
// ВЫВОД МАССИВА НА ПЕЧАТЬ
System.Console.WriteLine("[ "+String.Join(", ",ar)+"]");