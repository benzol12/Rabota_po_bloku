string[] words(string[] array) 
{
    string[] words1 = new string[11];
    //Будем использовать for
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
        words1 [count] = array[i];
        count++;
        }
    }
    Array.Resize(ref words1, count);
    return words1;

}
void Print(string[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
    Console.WriteLine();
}
string[] NewArray = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };