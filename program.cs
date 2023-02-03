
using System;

public class FinalWork {
    public static void Main(string[] args) {
        // вывод на экран сообщения
        Console.WriteLine("Введите элементы массива через пробел и нажмите 'Enter':");
        // чтение строки 
        string input = Console.ReadLine();
        // разбиение строки по пробелу и помещение результата в массив 
        string[] oldArray = input.Split(' ');

        // создание пустого массива
        string[] newArray = {};

        // цикл по массиву строк
        for (int i = 0; i < oldArray.Length; i++) {
            // если длина очередной строки меньше или равна 3
            if (oldArray[i].Length <= 3) {
                // увеличить размер массива newArray на 1
                Array.Resize(ref newArray, newArray.Length + 1);
                // положить найденный элемент в конец массива
                newArray[newArray.Length - 1] = oldArray[i];
            }
        }

        // цикл по новому массиву
        for (int i = 0; i < newArray.Length; i++) 
            // вывод на экран
            Console.Write(newArray[i] + " ");
    }
}