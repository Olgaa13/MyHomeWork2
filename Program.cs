Console.Clear();
void task1()
{
int number = new Random().Next(100,1000);
Console.WriteLine(number);
int result = (number / 10) % 10;
Console.Write($"{result}");
}

void task2()
{
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) 
{
    num=-num;
}
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
while (num > 999) {num = num/10;}  
    num = num%10;
    Console.WriteLine(num);
}
}

void task3()
{
Console.Write("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7) 
{
    Console.WriteLine("Не является днем недели");
}   
if (day == 1) {Console.WriteLine("Понедельник не является выходным днем");}
if (day == 2) {Console.WriteLine("Вторник не является выходным днем");}
if (day == 3) {Console.WriteLine("Среда не является выходным днем");}
if (day == 4) {Console.WriteLine("Четверг не является выходным днем");}
if (day == 5) {Console.WriteLine("Пятница не является выходным днем");}
if (day == 6) {Console.WriteLine("Суббота - выходной день!");}
if (day == 7) {Console.WriteLine("Воскресенье - выходной день!");}
}

// task1();
// task2();
// task3();