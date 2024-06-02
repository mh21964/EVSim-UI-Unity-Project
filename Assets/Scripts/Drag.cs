using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

using VDProject;


namespace VDProject
{
    public class Drag : MonoBehaviour
    {
        public TMP_InputField DragCoeff;
        public Text D;
        private float num1;
        public int b = 1;
        const string error = "Please insert the value";
        const string error2 = "";
        private TireSize A1;
        public GameObject thePlayer;
        public int a = 0;
        public int c;
        int i = 10;
        public TextMeshProUGUI errorMessage;
        public static bool dragcoefficient = false;

        void Update()
        {
            A1 = thePlayer.GetComponent<TireSize>();
            if (A1.Val == 0)
            {
                DragCoeff.enabled = false;
            }
            else
            {
                DragCoeff.enabled = true;
            }
        }

        public void checkError()
        {
            num1 = float.Parse(DragCoeff.text);
            if (num1 < a || num1 > b)
            {
                errorMessage.text = "Error: The drag coefficient should be between 0 - 1";
                c = 0;
            }
            else
            {
                errorMessage.text = error2;
                c = 1;
                FileCreate.DataEntry[i, 0] = "Drag Coefficient:";
                FileCreate.DataEntry[i, 1] = "" + num1;

            }
        }
    }
}
