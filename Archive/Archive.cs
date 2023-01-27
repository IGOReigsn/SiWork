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
           if(num>=0 || num==0 && zeroEnable || num<0 && negativEnable) break;
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