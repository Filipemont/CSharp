namespace StreamWriter1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\Windows\temp\File1.txt";
            string targetPath = @"c:\Windows\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
                
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}