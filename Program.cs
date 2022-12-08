/*
//Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Palindrom(int num) 
{ 
    int rev = 0; 
    int x = num; 
     
    while(num > 0) 
    { 
         
        rev = rev * 10 + num % 10; 
        num /= 10; 
    }    
 
    if(x == rev) 
    { 
        return true; 
    } 
    else 
    { 
        return false; 
    } 
 
} 
Console.Write("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
bool res = Palindrom(number); 
Console.WriteLine($"Result {res}");
*/

/*
//Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Dist(double x1, double y1, double x2, double y2, double z1, double z2)
{
double x =  x2 -  x1;
double y =  y2 - y1;
double z = z2 - z1;

double gip = Math.Pow(x,2) + Math.Pow(y,2) + Math.Pow(z,2);
double result = Math.Sqrt(gip);
return result;

}
Console.Write("Введите координату Х для А: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y для А: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z для А: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х для B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y для B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z для B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double res = Math.Round(Dist(xA, yA, xB, yB, zA, zB),2);
Console.WriteLine($"Длина отрезка между А и В {res}");
*/
/*
//Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Cube (int num)
{
    int count = 1;
    while (count <= num)
    {
        double cubeNum = Math.Pow(count,3);
        Console.Write(cubeNum + " ");
        count++;
    }
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);
*/
