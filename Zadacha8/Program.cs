Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number<=1) Console.Write("Вы ввели число меньше или равное 1");
else
{
    int count = 1;
while(count<=number)
{
    if(count % 2 == 0) Console.Write(count + ", ");
    count++;
}
}