using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO;
using System.Text;

using VDProject;

namespace VDProject
{


    public class FileCreate : MonoBehaviour
    {
        int x = 0;
        int y = 1; // file number
              
        int j = 0;
        int k = 0;
        public static int NumberofEntries = 0;
        public static string[,] DataEntry = new string[30, 2];
        public static float fileNameExt;
        public static string root, filename, slash, path;
        public static string InputFolder;
        public static string InputFolderReplace;
        public static bool filecreated = false;
        public static bool filecreated1 = false;
        public static bool fileExists = false;
        public static bool fileExists1 = false;
        public static string fp = @"F:\Vehicle Developement Data\PerformanceMetric.csv";//F

        string path2;

        // Start is called before the first frame update
        void Start()
        {
            root = @"F:\Vehicle Developement Data\";//F
            filename = "Vehicle Matlab Input ";
            InputFolder = @"F:\Vehicle Developement Data\Inputs\" + PanelChange.vehicalType + @"\";//F
            InputFolderReplace = @"F:\Vehicle Developement Data\Inputs\" + PanelChange.vehicalType + @"\";//F
            filecreated = false;
            k = 0;
            y = 1;
        }

        // Update is called once per frame
        void Update()
        {
            if ((x == 0) && (PanelChange.buttonclicked))
            {
                x = 1;
                fieldSize();
                saveData();

            }

            if ((k == 0) && (SaveButtonDetect.saveButtonClicked))
            {
                k = 1;
                InputFileSavePath();
            }


        }
        void fieldSize()
        {

            switch (PanelChange.vehicalType)
            {
                case "Car":
                    NumberofEntries = 12;
                    break;
                case "Bike":
                    NumberofEntries = 12;
                    break;
                case "Rickshaw":
                    NumberofEntries = 12;
                    break;
                default:
                    NumberofEntries = 0;
                    break;
            }

        }
        void InputFileSavePath()
        {
            // If directory does not exist, create it. 
            if (!Directory.Exists(InputFolder))
            {
                Directory.CreateDirectory(InputFolder);
            }


            path2 = InputFolder + "" + y + ".txt";
            fileExists1 = File.Exists(path2);// to see if file is created

            while (fileExists1) {
                y++;

                path2 = InputFolder + "" + y + ".txt";
                fileExists1 = File.Exists(path2);// to see if file is created
                if (y>3) {
                    
                    replaceFile();  // replace file
                    break;
                }
            }

            if ((y <= 3) && (!fileExists1))  // if file does not exist

            {
                path2 = InputFolder + "" + y + ".txt";
                //if file does not exist then create the file
                InputFileSave(y, path2);
                fileExists1 = File.Exists(path2);// to see if file is created

            }
            y = 1;
        }

        void replaceFile()
        {
            string temp = InputFolderReplace + "" + 1 + ".txt";
            string temp2 = InputFolderReplace + "" + 2 + ".txt";
            string temp3 = InputFolderReplace + "" + 3 + ".txt";
            string sourceFile = temp2;
            string destinationFile = InputFolderReplace + "2temp" + ".txt";
            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            { }

            if (File.Exists(temp))
            {
                System.IO.File.Delete(temp);
            }
            
             System.IO.File.Move(temp2, temp);


            if (File.Exists(destinationFile))
            {
                System.IO.File.Delete(destinationFile);
            }
            System.IO.File.Move(temp3, destinationFile);

            try
            {
                File.Copy(destinationFile, sourceFile, true);
            }
            catch (IOException iox)
            { }
            if (File.Exists(destinationFile))
            {
                System.IO.File.Delete(destinationFile);
            }

            path2 = InputFolder + "" + 3 + ".txt";
            InputFileSave(y,path2);

        }
        void InputFileSave(int y, string pathFile)
        {

            using (FileStream fs2 = File.Create(pathFile))
            {
                int i = 0;
                for (i = 0; i < NumberofEntries; i++)
                {
                    AddText(fs2, DataEntry[i, j] + "" + DataEntry[i, j + 1] + "\n");
                }
                if (i >= NumberofEntries)
                {
                    filecreated1 = true;
                    fs2.Dispose();
                }

            }

            fileExists1 = File.Exists(pathFile);// to see if file is created
        }

        void saveData()
        {

            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }

            fileNameExt = Time.time;
            // path = root  + filename + fileNameExt + ".txt";  //to be used later if required
            path = root + filename + ".txt";
            using (FileStream fs = File.Create(path))
            {
                AddText(fs, "Vehicle Type:" + PanelChange.vehicalType + "\n");
                int i = 0;
                for (i = 0; i < NumberofEntries; i++)
                {
                    AddText(fs, DataEntry[i, j] + "" + DataEntry[i, j + 1] + "\n");
                }
                if (i >= NumberofEntries)
                {

                    fileExists = File.Exists(path);// to see if file is created
                    if (fileExists)
                    {
                        filecreated = true;
                        fs.Dispose();
                    }
                    else
                    {
                    }
                }

            }

            if(File.Exists(fp))
            {
                File.Delete(fp);    //commenting the code
            }
            x = 0;
        }

        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}