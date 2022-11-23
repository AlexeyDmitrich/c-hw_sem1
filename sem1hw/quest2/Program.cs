Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = int.Parse(Console.ReadLine());
int max = -1;
if (num1 == num2 && num2 == num3){
    max = num1;
    Console.WriteLine("Нечего сравнивать - все числа равны");
}else if (num1 == num2){
    max = num1;
    if (num3 > max){
        max = num3;
	Console.WriteLine("Максимальное число - третье");
    } else {
	Console.WriteLine("Максимальные числа - первое и второе");
    }
}else if (num1 == num3){
    max = num1;
    if (num2 > max){
        max = num2;
	Console.WriteLine("Максимальное число - второе");
    } else {
	Console.WriteLine("Максимальные числа - первое и третье");
    }
}else if (num2 == num3){
    max = num2;
    if (num1 > max){
        max = num1;
	Console.WriteLine("Максимальное число - первое");
    } else {
	Console.WriteLine("Максимальные числа - второе и третье");
    }
}else{
    max = num1;
    if (num2 > max){
        max = num2;
    }
    if (num3 > max){
        max = num3;
    }
if (max == num1) Console.WriteLine("Максимальное число - первое");
if (max == num2) Console.WriteLine("Максимальное число - второе");
if (max == num3) Console.WriteLine("Максимальное число - третье");
}
Console.WriteLine(max);
