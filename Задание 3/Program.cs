Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int last = number % 10;
int first = number;
while (first > 9)
{
    first /= 10;
}
int sum = first + last;
Console.WriteLine("Сумма первой и последней цифры этого чисела: " + sum);