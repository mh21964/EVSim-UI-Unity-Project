using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

using VDProject;

namespace VDProject
{
    public class MotoSize : MonoBehaviour
    {
        public TMP_InputField Motor;
        public Text Motor1;
        private float num;
        public int b = 1000;
        const string error = "Please insert the value";
        const string error2 = "";
        private Payload A1;
        private AirConditioner B1;
        public GameObject thePlayer;
        public GameObject thePlayer1;
        public int a = 10;
        public int c;
        public int d;
        int i = 6;
        public TextMeshProUGUI errorMessage;
        public static bool mot = false;

        void Update()
        {
            A1 = thePlayer.GetComponent<Payload>();
            B1 = thePlayer1.GetComponent<AirConditioner>();
            if (A1.d == 0)
            {
                if (A1.c == 0)
                {
                    Motor.enabled = false;
                }
                else
                {
                    Motor.enabled = true;
                }
            }
            else
            {
                if (B1.Val == 0)
                {
                    Motor.enabled = false;
                }
                else
                {
                    Motor.enabled = true;
                }
            }
        }

        //2 Wheeler
        public void checkErrorBike()
        {
            num = float.Parse(Motor.text);
            //a = 2;
            //b = 8;
            d = 0;
            if (num < a || num > b)
            {
                errorMessage.text = "Error: The motor size should be between 10 - 1000 kW";
                c = 0;
            }
            else
            {
                errorMessage.text = error2;
                c = 1;
                FileCreate.DataEntry[i, 0] = "Motor Size:";
                FileCreate.DataEntry[i, 1] = "" + num + " kW";
            }
        }

        //3 Wheeler
        public void checkErrorRickshaw()
        {
            num = float.Parse(Motor.text);
            //a = 1;
            //b = 3;
            d = 0;

            if (num < a || num > b)
            {
                errorMessage.text = "Error: The motor size should be between 10 - 1000 kW";
                c = 0;
            }
            else
            {
                errorMessage.text = error2;
                c = 1;
                FileCreate.DataEntry[i, 0] = "Motor Size:";
                FileCreate.DataEntry[i, 1] = "" + num + " kW"; //can remove unit if needed
            }
        }

        //4 Wheeler
        public void checkErrorCar()
        {
            num = float.Parse(Motor.text);
            //a = 50;
            //b = 300;
            d = 1;

            if (num < a || num > b)
            {
                errorMessage.text = "Error: The motor size should be between 10 - 1000 kW";
                c = 0;
            }
            else
            {
                errorMessage.text = error2;
                c = 1;
                FileCreate.DataEntry[i, 0] = "Motor Size:";
                FileCreate.DataEntry[i, 1] = "" + num + " kW"; //can remove unit if needed
            }
        }
    }
}
