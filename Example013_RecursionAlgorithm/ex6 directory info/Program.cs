﻿// как посмотреть содержимое папки

string path = "/Users/alina/Documents/Projects/Examples/Example001_HelloConsole";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
