// принимаем число, возвращаем все четные числа от 1 до него
int module (int num){
    if (num >= 0) {
        return num;
    }
    else {
        return (num * (-1));
    }
}

Boolean isEven (int num){
if ((module(num)%2) == 0){
    return true;
}else{
return false;
}
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
if (module(number) < 2){
    Console.WriteLine("Таких чисел нет");
}
if (number == 0){
    Console.WriteLine("Это ноль");
}else {
    if (number > 0){
        for(int i=2; i<number; i++){
            if (isEven(i)){
            Console.Write(i);
            Console.Write(", ");
            }
        }
        if (isEven(number)){
        Console.WriteLine(number);
        }
    } else {
        for(int i=-2; i>number; i--){
            if (isEven(i)){
            Console.Write(i);
            Console.Write(", ");
            }
        }
        if (isEven(number)){
        Console.Write(number);
        }
    }
}
Console.WriteLine();
