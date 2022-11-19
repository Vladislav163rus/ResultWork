// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void Zadacha()
{
    string[] arrString;
    arrString = new string[5];
    string[] krinj = { "lol", "kek", "", "cheburek", "=)" };
    Console.Write("Было: ");
    OldArray(arrString);
    Console.Write("Стало: ");
    NewArray(arrString);

    //Метод выводит изначальный массив строк

    void OldArray(string[] arrString)
    {
        for (int i = 0; i < krinj.Length; i++)
            Console.Write($"{krinj[i]} ");
    }

    //Метод выводит новый массив из строк, длина которых меньше, либо равна 3 символам.

    void NewArray(string[] arrString)
    {
        int maxSymbol = 3;
        var selectedKrinj = krinj.Where(krinj => krinj.Length <= maxSymbol);

        foreach (string slova in selectedKrinj)

            Console.Write(" " + slova);
    }
}
Zadacha();
