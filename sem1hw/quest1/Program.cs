Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2){
    Console.Write("max = ");
    Console.WriteLine(num1);
}else if (num2 > num1){
    Console.Write("max = ");
    Console.WriteLine(num2);
}else{
    Console.WriteLine("Числа равны");
}
