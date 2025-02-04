﻿// перебор слов
/*
char[] s = {'а', 'и', 'с', 'в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        Console.WriteLine($"{n++, -5}{s[i]} {s[j]}");
    }
}
*/

//общее решение
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{ 
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length+ 1);
    }
}

FindWords("аисв", new char[4]);