using System;
using System.IO;

class Program
{
    public static void Main()
    {
        //Объявление переменных
        string path = "D:\\TestText.txt";
        string text;
        string[] sentences;


        try
        {
            // Открывает текстовый файл используя stream reader.
            using (var readText = new StreamReader(path))
            {
                // Читает поток, как string и отправляет его в text
                text = readText.ReadToEnd();
            }
            //Разбивает текст на массив строк, меняет размер массива (ограничивая его 3 предложениями) и переворачивает его
            sentences = text.Split(". ");
            Array.Resize(ref sentences, 3);
            Array.Reverse(sentences);

            //Вывод в консоль
            foreach (var sent in sentences)
            {
                Console.WriteLine(sent + ". ");
            }

        }
        //В случае сбоя выдает ошибку
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}