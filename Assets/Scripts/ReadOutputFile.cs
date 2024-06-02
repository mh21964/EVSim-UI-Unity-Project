
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Linq;
using System.Collections;

using System.Collections.Generic;
using System;
using System.IO;
using System.Text;

using VDProject;


namespace VDProject
{

    //Reading specifically CSV File
    public class ReadOutputFile : MonoBehaviour
    {

        public Text first;
        public Text second;
        public Text third;
        public Text fourth;
        public Text fifth;
        public Text sixth;
        public Text seventh;
        public Text eigth;
        public Text nine;

        public Image box1;
        public Image box2;
        public Image box3;
        public Image box4;
        public Image box5;
        public Image box6;
        public Image box7;
        public Image box8;
        public Image box9;

        string lastLine;

        int j = 0;
        private IEnumerator coroutine;

        public static int NumberofEntries = 8;
        public static int x = 0;
        public static bool started = false;
        public static bool outputFetched = false;

        public static bool filecreated1 = false;
        public static string[,] DataEntry = new string[11, 2];
        public static string OutputFolder;
        public static string OutputFolderReplace;
        string path2;

        public Text SimButtonText;
        public static bool fileExists1 = false;
        int y = 1; // file number

        int k = 0;

        // AudioSource ComputingSound;
        public static bool filefound2 = false;
        public static string pathToCSVFilePerformance2 = @"F:\Vehicle Developement Data\" + "PerformanceMetric.csv";//F
        void Start()
        {
            started = true;
            filefound2 = false;
            outputFetched = false;

            OutputFolder = @"F:\Vehicle Developement Data\Outputs\" + PanelChange.vehicalType + @"\";//F
            OutputFolderReplace = @"F:\Vehicle Developement Data\Outputs\" + PanelChange.vehicalType + @"\";//F
            k = 0;
            y = 1;
        }

        void Update()
        {
            if (started)
            {
                if ((!filefound2) && (FileCreate.filecreated) && (PanelChange.buttonclicked))
                {
                    ReaderPerformance();
                    x = 1;

                }
            }
            if ((k == 0) && (SaveButtonDetect.saveButtonClicked))
            {
                k = 1;
                OutputFileSavePath();
            }
        }
        void ReaderPerformance()
        {
            filefound2 = File.Exists(pathToCSVFilePerformance2);
            if (filefound2)
            {
                StartCoroutine(coroutineA());
            }
        }

        IEnumerator coroutineA()
        {
            yield return new WaitForSeconds(3.0f);
            lastLine = File.ReadLines(pathToCSVFilePerformance2).Last();
            var data_values = lastLine.Split(',');
            if (!String.IsNullOrEmpty(data_values[0].ToString()) && !(data_values[0].ToString().Equals("0"))){
                box1.color = new Color32(54, 155, 234, 255);
                first.text = data_values[0].ToString() + " km";
            }

            if (!String.IsNullOrEmpty(data_values[1].ToString()) && !(data_values[1].ToString().Equals("0")))
            {
                box2.color = new Color32(54, 155, 234, 255);
                second.text = data_values[1].ToString() + " km";
            }

            if (!String.IsNullOrEmpty(data_values[2].ToString()) && !(data_values[2].ToString().Equals("0")))
            {
                box3.color = new Color32(54, 155, 234, 255);
                third.text = data_values[2].ToString() + " km/hr";
            }

            if (!String.IsNullOrEmpty(data_values[3].ToString()) && !(data_values[3].ToString().Equals("0")))
            {
                box4.color = new Color32(54, 155, 234, 255);
                fourth.text = data_values[3].ToString() + " km/hr";
            }
            if (!String.IsNullOrEmpty(data_values[4].ToString()) && !(data_values[4].ToString().Equals("0")))
            {
                box5.color = new Color32(54, 155, 234, 255);
                fifth.text = data_values[4].ToString() + " sec";
            }
            if (!String.IsNullOrEmpty(data_values[5].ToString()) && !(data_values[5].ToString().Equals("0")))
            {
                box6.color = new Color32(54, 155, 234, 255);
                sixth.text = data_values[5].ToString() + " sec";
            }
            if (!String.IsNullOrEmpty(data_values[6].ToString()) && !(data_values[6].ToString().Equals("0")))
            {
                box7.color = new Color32(54, 155, 234, 255);
                seventh.text = data_values[6].ToString() + " sec";
            }

            if (!String.IsNullOrEmpty(data_values[7].ToString()) && !(data_values[7].ToString().Equals("0")))
            {
                box8.color = new Color32(54, 155, 234, 255);
                eigth.text = data_values[7].ToString() + " kWh";
            }

            if (!String.IsNullOrEmpty(data_values[8].ToString()) && !(data_values[8].ToString().Equals("0")))
            {
                box9.color = new Color32(54, 155, 234, 255);
                nine.text = data_values[8].ToString() + " km";
            }

            outputFetched = true;

            SimButtonText.text = "Simulation complete";
            started = false;
            PanelChange.buttonclicked = false;
            StopCoroutine(coroutineA());
        }

        void OutputFileSavePath()
        {
            // If directory does not exist, create it. 
            if (!Directory.Exists(OutputFolder))
            {
                Directory.CreateDirectory(OutputFolder);
            }

            path2 = OutputFolder + "" + y + ".txt";
            fileExists1 = File.Exists(path2);// to see if file is created
            while (fileExists1)
            {
                y++;

                path2 = OutputFolder + "" + y + ".txt";
                fileExists1 = File.Exists(path2);// to see if file is created
                if (y > 3)
                {
                    replaceFile();  // replace file
                    break;
                }
            }

            if ((y <= 3) && (!fileExists1))  // if file does not exist

            {
                path2 = OutputFolder + "" + y + ".txt";
                OutputFileSave(y, path2);
                fileExists1 = File.Exists(path2);// to see if file is created
            }
            y = 1;
        }

        void replaceFile()
        {
            string temp = OutputFolderReplace + "" + 1 + ".txt";
            string temp2 = OutputFolderReplace + "" + 2 + ".txt";
            string temp3 = OutputFolderReplace + "" + 3 + ".txt";
            string sourceFile = temp2;
            string destinationFile = OutputFolderReplace + "2temp" + ".txt";
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

            path2 = OutputFolder + "" + 3 + ".txt";
            OutputFileSave(y, path2);
        }
        void OutputFileSave(int y, string pathFile)
        {
            var data_values = lastLine.Split(',');
            using (FileStream fs2 = File.Create(pathFile))
            {
                int i = 0;
                AddText(fs2, "Vehicle Type:" + PanelChange.vehicalType + "\n");
                AddText(fs2, "Range City:" + data_values[i].ToString() + "\n"); i++;
                AddText(fs2, "Range Hwy:" + data_values[i].ToString() + "\n"); i++;
                AddText(fs2, "Top Speed (0% grade):" + data_values[i].ToString() + "\n"); i++;
                AddText(fs2, "Top Speed (x% grade):" + data_values[i].ToString() + "\n"); i++;
                AddText(fs2, "Time (0-100 kph):" + data_values[i].ToString() + "\n"); i++;
                AddText(fs2, "Time 0.4 km:" + data_values[i].ToString() + "\n"); i++;
                AddText(fs2, "Time (50-80 kph):" + data_values[i].ToString() + "\n"); i++;
                AddText(fs2, "Regen Braking:" + data_values[i].ToString() + "\n"); i++;
                AddText(fs2, "Total Distance:" + data_values[i].ToString() + "\n"); i++;

                filecreated1 = true;
                fs2.Dispose();
            }
            fileExists1 = File.Exists(pathFile);// to see if file is created
        }

        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}
