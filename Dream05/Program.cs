// Напишите программу,которая на вход принимает одно число (N),а на выходе показывает се целые числа от -N до N

int n = 5;
int index = -1 * n;
while (index <= n)
{
    Console.Write(index + " ");
    index = index + 1;
}
