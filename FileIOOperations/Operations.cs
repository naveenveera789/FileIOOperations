using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SystemIO
{
    public class Operations
    {
        public void FileExists()
        {
            string path = @"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\FileIOOperations\FileIOOperations\Files\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.WriteLine();
        }
        public void ReadAllLines()
        {
            string path = @"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\FileIOOperations\FileIOOperations\Files\Example.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine();
        }
        public void ReadAllText()
        {
            string path = @"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\FileIOOperations\FileIOOperations\Files\Example.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.WriteLine();
        }
        public void FileCopy()
        {
            string path = @"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\FileIOOperations\FileIOOperations\Files\Example.txt";
            string copyPath = @"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\FileIOOperations\FileIOOperations\Files\NewExample.txt";
            File.Copy(path, copyPath);
            Console.WriteLine();
        }
        public void DeleteFile()
        {
            string path = @"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\FileIOOperations\FileIOOperations\Files\Example.txt";
            File.Delete(path);
            Console.WriteLine();
        }
    }
}