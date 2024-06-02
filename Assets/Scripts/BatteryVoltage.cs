using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

using VDProject;

namespace VDProject
{
    public class BatteryVoltage : MonoBehaviour
    {

        public TMP_InputField Battery;
        public Text Batt;
        private float num1;
        public int b;
        const string error = "Please insert the value";
        const string error2 = "";
        private BatterySize A1;
        public GameObject thePlayer;
        public int a;
        public int c;
        int i = 9;
        public TextMeshProUGUI errorMessage;
        public static bool batteryvoltage = false;

        void Update()
        {
            A1 = thePlayer.GetComponent<BatterySize>();
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
            a = 48;
            b = 300;
            if (num1 < a || num1 > b)
            {
                errorMessage.text = "Error: The battery voltage should be between 48 - 300 V";
                c = 0;
            }
            else
            {
                errorMessage.text = error2;
                c = 1;
                FileCreate.DataEntry[i, 0] = "Battery Voltage:";
                FileCreate.DataEntry[i, 1] = "" + num1 + " V";

            }
        }

        //3 Wheeler
        public void checkErrorRickshaw()
        {
            num1 = float.Parse(Battery.text);
            a = 48;
            b = 300;
            if (num1 < a || num1 > b)
            {
                errorMessage.text = "Error: The battery voltage should be between 48 - 300 V";
                c = 0;
            }
            else
            {
                errorMessage.text = error2;
                c = 1;
                FileCreate.DataEntry[i, 0] = "Battery Voltage:";
                FileCreate.DataEntry[i, 1] = "" + num1 + " V";
            }
        }

        //4 Wheeler
        public void checkErrorCar()
        {
            num1 = float.Parse(Battery.text);
            a = 300;
            b = 600;
            if (num1 < a || num1 > b)
            {
                errorMessage.text = "Error: The battery voltage should be between 300 - 600 V";
                c = 0;
            }
            else
            {
                errorMessage.text = error2;
                c = 1;
                FileCreate.DataEntry[i, 0] = "Battery Voltage:";
                FileCreate.DataEntry[i, 1] = "" + num1 + " V";
            }
        }
    }
}
