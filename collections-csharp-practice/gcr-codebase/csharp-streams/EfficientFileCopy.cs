using System;
using System.Diagnostics;
using System.IO;

class EfficientFileCopy
{
    static void Main()
    {
        string sourceFile = "file-copy-demo-source.txt";
        string normalCopy = "normal.txt";
        string bufferedCopy = "buffered.txt";

        if (!File.Exists(sourceFile))
        {
            Console.WriteLine("Source file not found.");
            return;
        }

        byte[] buffer = new byte[4096];
        Stopwatch sw = new Stopwatch();
        
        sw.Start();

        FileStream r1 = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
        FileStream w1 = new FileStream(normalCopy, FileMode.Create, FileAccess.Write);

        int bytesRead;
        while ((bytesRead = r1.Read(buffer, 0, buffer.Length)) > 0)
        {
            w1.Write(buffer, 0, bytesRead);
        }

        r1.Close();
        w1.Close();

        sw.Stop();
        Console.WriteLine("Unbuffered Time: " + sw.ElapsedTicks);

        
        sw.Reset();
        sw.Start();

        FileStream r2 = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
        FileStream w2 = new FileStream(bufferedCopy, FileMode.Create, FileAccess.Write);

        BufferedStream br = new BufferedStream(r2, 4096);
        BufferedStream bw = new BufferedStream(w2, 4096);

        while ((bytesRead = br.Read(buffer, 0, buffer.Length)) > 0)
        {
            bw.Write(buffer, 0, bytesRead);
        }

        br.Close();
        bw.Close();
        r2.Close();
        w2.Close();

        sw.Stop();
        Console.WriteLine("Buffered Time: " + sw.ElapsedTicks);
    }
}
