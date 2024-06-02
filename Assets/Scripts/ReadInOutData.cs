using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using VDProject;
using UnityEngine.UI;
using System.Linq;

namespace VDProject
{

    public class ReadInOutData : MonoBehaviour
    {

        string pathInput;
        string pathOutput;
        public string path1;
        public string path2;
        public bool fileExists1;
        public bool fileExists2;

        //First Col Input
        public Text VS1;
        public Text P1;
        public Text PM1;
        public Text Payload1;
        public Text RB1;
        public Text AC1;
        public Text MS1;
        public Text B1;
        public Text TS1;
        public Text BV1;

        //2nd Col Input
        public Text VS2;
        public Text P2;
        public Text PM2;
        public Text Payload2;
        public Text RB2;
        public Text AC2;
        public Text MS2;
        public Text B2;
        public Text TS2;
        public Text BV2;

        //3rd Col Input
        public Text VS3;
        public Text P3;
        public Text PM3;
        public Text Payload3;
        public Text RB3;
        public Text AC3;
        public Text MS3;
        public Text B3;
        public Text TS3;
        public Text BV3;
        public string[] col;
        public string[] lines;


        //First Col Output
        public Text RC1;
        public Text RH1;
        public Text TopS1;
        public Text TSG1;
        public Text T100_1;
        public Text T4_1;
        public Text T50_1;
        public Text RBx1;
        public Text TDx1;


        //2nd Col Output
        public Text RC2;
        public Text RH2;
        public Text TopS2;
        public Text TSG2;
        public Text T100_2;
        public Text T4_2;
        public Text T50_2;
        public Text RBx2;
        public Text TDx2;

        //3rd Col Output
        public Text RC3;
        public Text RH3;
        public Text TopS3;
        public Text TSG3;
        public Text T100_3;
        public Text T4_3;
        public Text T50_3;
        public Text RBx3;
        public Text TDx3;

        void Start()
        {
            pathInput = FileCreate.InputFolder;
            pathOutput = ReadOutputFile.OutputFolder;
            ReadFiles();
        }



        void ReadFiles()
        {
            if (PanelChange.vehicalType == "Car")
            {
                int y = 1;
                path1 = pathInput + "" + y + ".txt";
                path2 = pathOutput + "" + y + ".txt";

                //surround in a while loop
                fileExists1 = File.Exists(path1);// to see if input file exists
                fileExists2 = File.Exists(path2);// to see if input file exists
                if (fileExists1 && fileExists2)
                {
                    //read data Input 
                    lines = File.ReadAllLines(path1);
                    col = lines[0].Split(':');
                    VS1.text = col[1];
                    col = lines[1].Split(':');
                    P1.text = col[1];
                    col = lines[2].Split(':');
                    PM1.text = col[1];
                    col = lines[3].Split(':');
                    Payload1.text = col[1];
                    col = lines[4].Split(':');
                    RB1.text = col[1];
                    col = lines[5].Split(':');
                    AC1.text = col[1];
                    col = lines[6].Split(':');
                    MS1.text = col[1];
                    col = lines[7].Split(':');
                    B1.text = col[1];
                    col = lines[8].Split(':');
                    TS1.text = col[1];
                    col = lines[9].Split(':');
                    BV1.text = col[1];

                    //read data Input 
                    lines = File.ReadAllLines(path2);
                    col = lines[1].Split(':');
                    RC1.text = col[1];
                    col = lines[2].Split(':');
                    RH1.text = col[1];
                    col = lines[3].Split(':');
                    TopS1.text = col[1];
                    col = lines[4].Split(':');
                    TSG1.text = col[1];
                    col = lines[5].Split(':');
                    T100_1.text = col[1];
                    col = lines[6].Split(':');
                    T4_1.text = col[1];
                    col = lines[7].Split(':');
                    T50_1.text = col[1];
                    col = lines[8].Split(':');
                    RBx1.text = col[1];
                    col = lines[9].Split(':');
                    TDx1.text = col[1];
                }
                else
                {
                    UnityEngine.Debug.Log("");
                }

                y++;
                path1 = pathInput + "" + y + ".txt";
                path2 = pathOutput + "" + y + ".txt";

                fileExists1 = File.Exists(path1);// to see if input file exists
                fileExists2 = File.Exists(path2);// to see if input file exists

                if (fileExists1 && fileExists2)
                {
                    //read data Input 
                    lines = File.ReadAllLines(path1);
                    col = lines[0].Split(':');
                    VS2.text = col[1];
                    col = lines[1].Split(':');
                    P2.text = col[1];
                    col = lines[2].Split(':');
                    PM2.text = col[1];
                    col = lines[3].Split(':');
                    Payload2.text = col[1];
                    col = lines[4].Split(':');
                    RB2.text = col[1];
                    col = lines[5].Split(':');
                    AC2.text = col[1];
                    col = lines[6].Split(':');
                    MS2.text = col[1];
                    col = lines[7].Split(':');
                    B2.text = col[1];
                    col = lines[8].Split(':');
                    TS2.text = col[1];
                    col = lines[9].Split(':');
                    BV2.text = col[1];

                    //read data Input 
                    lines = File.ReadAllLines(path2);
                    col = lines[1].Split(':');
                    RC2.text = col[1];
                    col = lines[2].Split(':');
                    RH2.text = col[1];
                    col = lines[3].Split(':');
                    TopS2.text = col[1];
                    col = lines[4].Split(':');
                    TSG2.text = col[1];
                    col = lines[5].Split(':');
                    T100_2.text = col[1];
                    col = lines[6].Split(':');
                    T4_2.text = col[1];
                    col = lines[7].Split(':');
                    T50_2.text = col[1];
                    col = lines[8].Split(':');
                    RBx2.text = col[1];
                    col = lines[9].Split(':');
                    TDx2.text = col[1];
                }
                y++;
                path1 = pathInput + "" + y + ".txt";
                path2 = pathOutput + "" + y + ".txt";

                fileExists1 = File.Exists(path1);// to see if input file exists
                fileExists2 = File.Exists(path2);// to see if input file exists

                if (fileExists1 && fileExists2)
                {
                    //read data Input 
                    lines = File.ReadAllLines(path1);
                    col = lines[0].Split(':');
                    VS3.text = col[1];
                    col = lines[1].Split(':');
                    P3.text = col[1];
                    col = lines[2].Split(':');
                    PM3.text = col[1];
                    col = lines[3].Split(':');
                    Payload3.text = col[1];
                    col = lines[4].Split(':');
                    RB3.text = col[1];
                    col = lines[5].Split(':');
                    AC3.text = col[1];
                    col = lines[6].Split(':');
                    MS3.text = col[1];
                    col = lines[7].Split(':');
                    B3.text = col[1];
                    col = lines[8].Split(':');
                    TS3.text = col[1];
                    col = lines[9].Split(':');
                    BV3.text = col[1];

                    //read data Input 
                    lines = File.ReadAllLines(path2);
                    col = lines[1].Split(':');
                    RC3.text = col[1];
                    col = lines[2].Split(':');
                    RH3.text = col[1];
                    col = lines[3].Split(':');
                    TopS3.text = col[1];
                    col = lines[4].Split(':');
                    TSG3.text = col[1];
                    col = lines[5].Split(':');
                    T100_3.text = col[1];
                    col = lines[6].Split(':');
                    T4_3.text = col[1];
                    col = lines[7].Split(':');
                    T50_3.text = col[1];
                    col = lines[8].Split(':');
                    RBx3.text = col[1];
                    col = lines[9].Split(':');
                    TDx3.text = col[1];
                }
            }
            else
            {
                int y = 1;
                path1 = pathInput + "" + y + ".txt";
                path2 = pathOutput + "" + y + ".txt";

                //surround in a while loop
                fileExists1 = File.Exists(path1);// to see if input file exists
                fileExists2 = File.Exists(path2);// to see if input file exists
                if (fileExists1 && fileExists2)
                {
                    //read data Input 
                    lines = File.ReadAllLines(path1);
                    col = lines[0].Split(':');
                    VS1.text = col[1];
                    col = lines[1].Split(':');
                    P1.text = col[1];
                    col = lines[2].Split(':');
                    PM1.text = col[1];
                    col = lines[3].Split(':');
                    Payload1.text = col[1];
                    col = lines[4].Split(':');
                    RB1.text = col[1];
                    col = lines[6].Split(':');
                    MS1.text = col[1];
                    col = lines[7].Split(':');
                    B1.text = col[1];
                    col = lines[8].Split(':');
                    TS1.text = col[1];
                    col = lines[9].Split(':');
                    BV1.text = col[1];

                    //read data Input 
                    lines = File.ReadAllLines(path2);
                    col = lines[1].Split(':');
                    RC1.text = col[1];
                    col = lines[2].Split(':');
                    RH1.text = col[1];
                    col = lines[3].Split(':');
                    TopS1.text = col[1];
                    col = lines[4].Split(':');
                    TSG1.text = col[1];
                    col = lines[5].Split(':');
                    T100_1.text = col[1];
                    col = lines[6].Split(':');
                    T4_1.text = col[1];
                    col = lines[7].Split(':');
                    T50_1.text = col[1];
                    col = lines[8].Split(':');
                    RBx1.text = col[1];
                    col = lines[9].Split(':');
                    TDx1.text = col[1];

                }
                else
                {
                  //  UnityEngine.Debug.Log("");
                }

                y++;
                path1 = pathInput + "" + y + ".txt";
                path2 = pathOutput + "" + y + ".txt";

                fileExists1 = File.Exists(path1);// to see if input file exists
                fileExists2 = File.Exists(path2);// to see if input file exists

                if (fileExists1 && fileExists2)
                {
                    //read data Input 
                    lines = File.ReadAllLines(path1);
                    col = lines[0].Split(':');
                    VS2.text = col[1];
                    col = lines[1].Split(':');
                    P2.text = col[1];
                    col = lines[2].Split(':');
                    PM2.text = col[1];
                    col = lines[3].Split(':');
                    Payload2.text = col[1];
                    col = lines[4].Split(':');
                    RB2.text = col[1];
                    col = lines[6].Split(':');
                    MS2.text = col[1];
                    col = lines[7].Split(':');
                    B2.text = col[1];
                    col = lines[8].Split(':');
                    TS2.text = col[1];
                    col = lines[9].Split(':');
                    BV2.text = col[1];

                    //read data Output 
                    lines = File.ReadAllLines(path2);
                    col = lines[1].Split(':');
                    RC2.text = col[1];
                    col = lines[2].Split(':');
                    RH2.text = col[1];
                    col = lines[3].Split(':');
                    TopS2.text = col[1];
                    col = lines[4].Split(':');
                    TSG2.text = col[1];
                    col = lines[5].Split(':');
                    T100_2.text = col[1];
                    col = lines[6].Split(':');
                    T4_2.text = col[1];
                    col = lines[7].Split(':');
                    T50_2.text = col[1];
                    col = lines[8].Split(':');
                    RBx2.text = col[1];
                    col = lines[9].Split(':');
                    TDx2.text = col[1];
                }
                y++;
                path1 = pathInput + "" + y + ".txt";
                path2 = pathOutput + "" + y + ".txt";

                fileExists1 = File.Exists(path1);// to see if input file exists
                fileExists2 = File.Exists(path2);// to see if input file exists

                if (fileExists1 && fileExists2)
                {
                    //read data Input 
                    lines = File.ReadAllLines(path1);
                    col = lines[0].Split(':');
                    VS3.text = col[1];
                    col = lines[1].Split(':');
                    P3.text = col[1];
                    col = lines[2].Split(':');
                    PM3.text = col[1];
                    col = lines[3].Split(':');
                    Payload3.text = col[1];
                    col = lines[4].Split(':');
                    RB3.text = col[1];
                    col = lines[6].Split(':');
                    MS3.text = col[1];
                    col = lines[7].Split(':');
                    B3.text = col[1];
                    col = lines[8].Split(':');
                    TS3.text = col[1];
                    col = lines[9].Split(':');
                    BV3.text = col[1];

                    //read data Output 
                    lines = File.ReadAllLines(path2);
                    col = lines[1].Split(':');
                    RC3.text = col[1];
                    col = lines[2].Split(':');
                    RH3.text = col[1];
                    col = lines[3].Split(':');
                    TopS3.text = col[1];
                    col = lines[4].Split(':');
                    TSG3.text = col[1];
                    col = lines[5].Split(':');
                    T100_3.text = col[1];
                    col = lines[6].Split(':');
                    T4_3.text = col[1];
                    col = lines[7].Split(':');
                    T50_3.text = col[1];
                    col = lines[8].Split(':');
                    RBx3.text = col[1];
                    col = lines[9].Split(':');
                    TDx3.text = col[1];
                }
            }
        }
    }
}