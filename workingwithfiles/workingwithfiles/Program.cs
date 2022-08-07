namespace workingwithfiles
{
    class Program
    {
        static void Main(string[] args)

        {

            // File and Fileinfo 

            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\lol.txt", @"d:\temp\lolva.txt");
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            // Directory and Directoryinfo

            var directorypath = @"c:\";

            Directory.CreateDirectory(directorypath);

            var files = Directory.GetFiles(directorypath, "*.*", SearchOption.AllDirectories);
            foreach(var file in files)
            {
                Console.WriteLine(file);    
            }

            var direcotries = Directory.GetDirectories(directorypath,"*.*", SearchOption.AllDirectories);

            foreach (var direcotry in direcotries)
            {
                Console.WriteLine(direcotry);
            }

            Directory.Exists(directorypath);



            // Directoryinfo

            var directoryInfo = new DirectoryInfo("....");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}