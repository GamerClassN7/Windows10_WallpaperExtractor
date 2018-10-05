using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/*
 bool hasAlpha = false;
foreach (var pixel in image)
{
    hasAlpha = pixel.Alpha != 255;
    if (hasAlpha)
    {
        break;
    }
}
     */

namespace Windows10Walpaper_Extractor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Export Tapet z Lock Screen on WIN 10";
            Console.WriteLine(@" _____                   _             _             
/  ___|                 (_)           | |            
\ `--. _ __   __ _  __ _ _ _ __   __ _| |_ ___  _ __ 
 `--. \ '_ \ / _` |/ _` | | '_ \ / _` | __/ _ \| '__|
/\__/ / |_) | (_| | (_| | | | | | (_| | || (_) | |   
\____/| .__/ \__,_|\__, |_|_| |_|\__,_|\__\___/|_|   
      | |           __/ |                            
      |_|          |___/                             
Export Tapet z Lock Screen do DESKTOP\Exported_Wallpaers by Vašek Španinger, verze 1.0");
            string username = Environment.UserName;
            string input_d = @"C:\Users\" + username + @"\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets\";
            string output_d = @"C:\Users\" + username + @"\Desktop\Exported_Wallpaers\";
            try
            {
                DirectoryInfo d = new DirectoryInfo(input_d);
                FileInfo[] infos = d.GetFiles();
                if (!Directory.Exists(output_d))
                {
                    Directory.CreateDirectory(output_d);
                }
                int i = 0;
                foreach (FileInfo f in infos)
                {
                    File.Copy(f.FullName, output_d + f.Name + ".jpg");
                    i++;
                }
                Console.WriteLine("Hotovo! exportováno " + i + " Obrázků");
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("Stiskněte ENTER pro ukončení");
            Console.ReadKey();
        }
    }
}
