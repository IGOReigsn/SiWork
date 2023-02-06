// -------------------МЕТОДЫ----------------------------------------------------------------------------
int InputNumber(string qwerStr)//проверяет "численность"."Не выпускает" без ввода ЧИСЛА
    {int num;
    string? text;
    while(true)
        {
            Console.WriteLine(qwerStr);
            text=Console.ReadLine();
           if(int.TryParse(text,out num)) break;
           Console.WriteLine("Введено некорректное значение.Попробуйте еще раз"); 
        }
    return num;  
    }
//------------------------------------------------------------------------------------------------------
int InputNumberWithFilter(string qwerStr, bool zeroEnable, bool negativEnable)//Пропускает положительные. 0 и отрицательные пропускает в соответствии со булевыми значениями zeroEnable,negativEnable
    {int num;
    while(true)
        {
            num=InputNumber(qwerStr);//проверяет "численность"."Не выпускает" без ввода ЧИСЛА
           if(num>0 || num==0 && zeroEnable || num<0 && negativEnable) break;
           Console.WriteLine("Введено не разрешенное значение.Попробуйте еще раз"); 
        }
    return num;  
    }
//------------------------------------------------------------------------------------------------------
// -------------------ОСНОВНАЯ ПРОГРАММА----------------------------------------------------------------------------
// ВЫЗОВ МЕТОДА
int size=InputNumberWithFilter("Введите размер массива :",true,false);
// МАССИВ - ОПИСАНИЕ +ВАРИАНТ ЗАПОЛНЕНИЯ
int [] ar =new int[size];
string[]coordName={"X","Y","Z"};//заполнение
// ОПИСАНИЕ И ВЫЗОВ RANDOMа
Random rnd = new Random();
for (int i=0;i<ar.Length;i++)  { ar[i] = rnd.Next(0,100);} 
// ВЫВОД МАССИВА НА ПЕЧАТЬ
System.Console.WriteLine("[ "+String.Join(", ",ar)+"]");
//----------------СТАРЫЕ ФРАГМЕНТЫ-------------------------------------------
//Просто ВВОД
Console.WriteLine("Введите число:");
double num=Convert.ToDouble(Console.ReadLine());
//Порядок числа (количество цифр в числе в целой части числа)
int rangeNum=Convert.ToInt32(Math.Truncate((Math.Log10(Math.Abs(num))))+1);


/* в конструкции double rangeNum=(int)((Math.Log10(num))) : (int) -отбрасывает дробную часть, 
    но что это за "штука" такая (вытащенная из интернета) -не очень понятно (это не метод, а что?)*/
//----------ЗАПОЛНЕНИЕ МАССИВОВ-------------------------------------------------------------------------------------
//ЗАПОЛНЕНИЕ ДВУМЕРНОГО МАССИВА ВЕЩЕСТВЕННЫМИ ЧИСЛАМИ ДЗ-7
double[,] FillMatrixDouble(int rows, int cols)
{
Random rand = new Random();
double[,] matr = new double[rows, cols];
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < cols; j++)
{
matr[i, j] = Math.Round(rand.Next(0, 100)+rand.NextDouble(),2);
}
}
return matr;
}
//ЗАПОЛНЕНИЕ ДВУМЕРНОГО МАССИВА ЦЕЛЫМИ ЧИСЛАМИ ДЗ-7
int[,] FillMatrix(int rows, int cols)
{
Random rand = new Random();
int[,] matr = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
for (int j = 0; j < cols; j++)
{
matr[i, j] = rand.Next(0, 100);
}
}

return matr;
}
//---------ЗАПОЛНЕНИЕ ОДНОМЕРНОГО МАССИАВА ЧЕРЕЗ ПРОБЕЛ (ЗАКОММЕНТИРОВАННЫЙ ВАРИАНТ ЛУЧШЕ)---------------
Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
// var arr2 = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
if (arr[i] > 0)
{
count++;
}
}
//--------------------ПЕЧАТЬ МАССИВА----------------------------------------------------------------------------------
//---------Вывод ОДНОМЕРНОГО массива с заголовком (ЧЕРЕЗ JOIN), указанным в title и отображением длины при sizeView=true--------------------------------
void PrintArrayWithTitle(int[] array,string title,bool sizeView)//Вывод массива с заголовком, указанным в title и отображением длины при sizeView=true
    {
        System.Console.Write("Был введен массив");
        if(sizeView)
            {System.Console.WriteLine (" из " + array.Length + " элементов:");}
        else 
            {System.Console.WriteLine(":");}
        System.Console.WriteLine("[ "+String.Join(", ",array)+"]");
    }
//-----------ВЫВОД ОДНОМЕРНОГО МАССИВА НА ПЕЧАТЬ-------------------------------------------------------------------------------------------
void PrnArray(int[] array) // ВЫВОД МАССИВА НА ПЕЧАТЬ
    {
    System.Console.WriteLine("[ "+String.Join(", ",array)+"]");
    }
//-----------ПЕЧАТЬ ДВУМЕРНОГО ДУБЛЕ-МАССИВА-------------------------------------------------------------------------------------------
void PrintMatrixDouble(double[,] matrix)//ПЕЧАТЬ ДВУМЕРНОГО ДУБЛЕ-МАССИВА
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write(matrix[i, j] + "\t");
}
System.Console.WriteLine();
}
}

//---------ПЕЧАТЬ ДВУМЕРНОГО ИНТ-МАССИВА---------------------------------------------------------------------------------------------
void PrintMatrix(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
System.Console.Write(matr[i, j] + "\t");
}
System.Console.WriteLine();
}
}