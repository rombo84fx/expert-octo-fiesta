using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EncryptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile();
            Console.WriteLine("Press enter to encrypt the file...");
            Console.ReadLine();

            EncryptFile("ml.txt");

            Console.WriteLine("Press enter to decrypt the file...");
            Console.Read();

            DecryptFile("ml.txt");
        }

        public static void ReadFile()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            StreamReader file = new StreamReader("ml.txt");

            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            counter++;
            file.Close();
        }

        public static void EncryptFile(string x)
        {
            File.Encrypt(x);
        }

        public static void DecryptFile(string x)
        {
            File.Decrypt(x);
        }
    }
}
