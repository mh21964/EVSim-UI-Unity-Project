using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

using VDProject;


namespace VDProject
{

    public class FrontalArea : MonoBehaviour
    {
        public TMP_InputField FrontalA;
        public Text D;
        private float num1;
        public int b = 5;
        const string error = "Please insert the value";
        const string error2 = "";
        private Drag A1;
        public GameObject thePlayer;
        public int a = 0;
        public int c;
        int i = 11;
        public TextMeshProUGUI errorMessage;
        public static bool frontalarea = false;

        void Update()
        {
            A1 = thePlayer.GetComponent<Drag>();
            if (A1.c == 0)
            {
                FrontalA.enabled = false;
            }
            else
            {
                FrontalA.enabled = true;
            }
        }

        public void checkError()
        {
            num1 = float.Parse(FrontalA.text);
            if (num1 < a || num1 > b)
            {
                errorMessage.text = "Error: The frontal area should be between 0 - 5";
                c = 0;
            }
            else
            {
                errorMessage.text = error2;
                c = 1;
                FileCreate.DataEntry[i, 0] = "Frontal Area:";
                FileCreate.DataEntry[i, 1] = "" + num1;

            }
        }
    }
}
