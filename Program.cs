/*Написать программу, которая из имеющегося массива строк формирует
новый массив из строк, длина которых меньше, либо равна 
3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не 
рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/
string[] array =  SetArrayStrings();
string[] SetArrayStrings()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}
string[] result = InitialArray(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");
string[] InitialArray(string[] input, int n) {
    string[] output = new string[FinalArray(input, n)];
    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}
int FinalArray(string[] input, int n) {
    int count = 0;
    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }
    return count;
}

