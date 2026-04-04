using System;
using System.IO;

class ImageToBigArray
{
    static void Main()
    {
        string sourceImage = "input.jpg";
        string outputImage = "output.jpg";

        if (!File.Exists(sourceImage))
        {
            Console.WriteLine("Source image not found.");
            return;
        }

        FileStream fsRead = new FileStream(sourceImage, FileMode.Open, FileAccess.Read);
        MemoryStream ms = new MemoryStream();

        fsRead.CopyTo(ms);
        byte[] imageBytes = ms.ToArray();

        fsRead.Close();
        ms.Close();

        MemoryStream msWrite = new MemoryStream(imageBytes);
        FileStream fsWrite = new FileStream(outputImage, FileMode.Create, FileAccess.Write);

        msWrite.CopyTo(fsWrite);

        msWrite.Close();
        fsWrite.Close();

        byte[] original = File.ReadAllBytes(sourceImage);
        byte[] copied = File.ReadAllBytes(outputImage);

        bool identical = original.Length == copied.Length;

        if (identical)
        {
            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] != copied[i])
                {
                    identical = false;
                    break;
                }
            }
        }

        Console.WriteLine(identical
            ? "Files are identical."
            : "Files are not identical.");
    }
}
