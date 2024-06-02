using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

using VDProject;

namespace VDProject
{
    public class Payload : MonoBehaviour
    {
        public TMP_InputField Pay;
        public Text Pay1;
        private float num;
        public int b;
        const string error = "Please insert the value";
        const string error2 = "";
        private RegenBraking A1;
        public GameObject thePlayer;
        public int a = 0;
        public int c;
        public int d;
        int i = 3;
        public TextMeshProUGUI errorMessage;
        public static bool payload = false;

        void Update()
        {
            A1 = thePlayer.GetComponent<RegenBraking>();
            if (A1.Val == 0)
            {
                Pay.enabled = false;
            }
            else
            {
                Pay.enabled = true;
            }
        }
        //2 Wheeler
        public void checkErrorBike()
        {
            num = float.Parse(Pay.text);
            b = 150;
            d = 0;
            if (num < a || num > b)
            {
                errorMessage.text = "Error: The payload should be between 0 - 150 kgs";
                c = 0;
            }
            else
            {
                errorMessage.text = error2;
                c = 1;
                FileCreate.DataEntry[i, 0] = "Payload:";
                FileCreate.DataEntry[i, 1] = "" + num + " kg"; 
            }
        }

        //3 Wheeler
        public void checkErrorRickshaw()
        {
            num = float.Parse(Pay.text);
            b = 500;
            d = 0;

            if (num < a || num > b)
            {
                errorMessage.text = "Error: The payload should be between 0 - 500 kgs";
                c = 0;
            }
            else
            {
                errorMessage.text = error2;
                c = 1;
                FileCreate.DataEntry[i, 0] = "Payload:";
                FileCreate.DataEntry[i, 1] = "" + num + " kg"; //can remove unit if needed
            }
        }

        //4 Wheeler
        public void checkErrorCar()
        {
            num = float.Parse(Pay.text);
            b = 1500;
            d = 1;

            if (num < a || num > b)
            {
                errorMessage.text = "Error: The payload should be between 0 - 1500 kgs";
                c = 0;
            }
            else
            {
                errorMessage.text = error2;
                c = 1;
                FileCreate.DataEntry[i, 0] = "Payload:";
                FileCreate.DataEntry[i, 1] = ""+num + " kg"; //can remove unit if needed
            }
        }
    }
}