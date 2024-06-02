using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

using VDProject;

namespace VDProject
{
    public class BatterySize : MonoBehaviour
    {

        public TMP_InputField Battery;
        public Text Batt;
        private float num1;
        public int b;
        const string error = "Please insert the value";
        const string error2 = "";
        private MotoSize A1;
        public GameObject thePlayer;
        public int a = 0;
        public int c;
        int i = 7;
        public TextMeshProUGUI errorMessage;
        public static bool batterysize = false;

        void Update()
        {
            A1 = thePlayer.GetComponent<MotoSize>();
            if (A1.c == 0)
            {
                Battery.enabled = false;
            }
            else
            {
                Battery.enabled = true;
            }
        }

        //2 Wheeler
        public void checkErrorBike()
        {
            num1 = float.Parse(Battery.text);
            b = 20;
            if (num1 < a || num1 > b)
            {
                errorMessage.text = "Error: The battery size should be between 0 - 20 kWh";
                c = 0;
            }
            else
            {
                errorMessage.text = error2;
                c = 1;
                FileCreate.DataEntry[i, 0] = "Battery Size:";
                FileCreate.DataEntry[i, 1] = "" + num1 + " kWh";

            }
        }

        //3 Wheeler
        public void checkErrorRickshaw()
        {
            num1 = float.Parse(Battery.text);
            b = 20;
            if (num1 < a || num1 > b)
            {
                errorMessage.text = "Error: The battery size should be between 0 - 20 kWh";
                c = 0;
            }
            else
            {
                errorMessage.text = error2;
                c = 1;
                FileCreate.DataEntry[i, 0] = "Battery Size:";
                FileCreate.DataEntry[i, 1] = "" + num1 + " kWh";
            }
        }

        //4 Wheeler
        public void checkErrorCar()
        {
            num1 = float.Parse(Battery.text);
            b = 100;
            if (num1 < a || num1 > b)
            {
                errorMessage.text = "Error: The battery size should be between 0 - 100 kWh";
                c = 0;
            }
            else
            {
                errorMessage.text = error2;
                c = 1;
                FileCreate.DataEntry[i, 0] = "Battery Size:";
                FileCreate.DataEntry[i, 1] = "" + num1 + " kWh";
            }
        }
    }
}
