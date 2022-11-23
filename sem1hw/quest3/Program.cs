int module (int num){
    if (num >= 0) {
        return num;
    }
    else {
        return (num * (-1));
    }
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
if (number == 0){
    Console.WriteLine("Это ноль");
}else if ((module(number)%2) == 0){
    Console.WriteLine("Это число четное");
}else{
Console.WriteLine("Это число нечетное");
}
