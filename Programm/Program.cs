string[] words(string[] array) 
{
    /*Создаем новый экземпляр массива*/
    string[] words1 = new string[11];
    /*Инициализируем переменную, хранящую счетчик*/
    int count = 0;
    /*Прогоняем массив через цикл for пока i не станет больше или равна количеству элементов в массиве*/
    for (int i = 0; i < array.Length; i++)
    {
    /*Если размер массива меньше трех то в words1 индекс count помещаем помещаем array с индексом i. counter + 1*/
        if (array[i].Length <= 3)
        {
        words1 [count] = array[i];
        count++;
        }
    }
    /*увеличиваем размер массива*/
    Array.Resize(ref words1, count);
    /*Возвращаем результат*/
    return words1;

}
void Print(string[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
    Console.WriteLine();
}
string[] NewArray = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

Print(words(NewArray));
