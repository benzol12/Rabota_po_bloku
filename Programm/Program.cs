string[] words(string[] array) 
{
    string[] words1 = new string[11];
    //Будем использовать for
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
        words1 [counter] = array[i];
        counter++;
        }
    }
    Array.Resize(ref words1, counter);
    return words1;

}
void Print(string[] array)
{

}
string[] NewArray = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };