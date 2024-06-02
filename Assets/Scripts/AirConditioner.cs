using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using VDProject;

namespace VDProject
{
    public class AirConditioner : MonoBehaviour
    {
        public Text AC;
        public int Val;
        public Dropdown mydd;
        private Payload A1;
        public GameObject thePlayer;

        int i = 5;
        void Update()
        {
            A1 = thePlayer.GetComponent<Payload>();
            if (A1.c == 0)
            {
                mydd.enabled = false;
            }
            else
            {
                mydd.enabled = true;
            }
        }

        public void TextChange6(Dropdown mydd)
        {
            Val = mydd.value;

            if (mydd.value > 0)
            {
                FileCreate.DataEntry[i, 0] = "Air Conditioner:";
                FileCreate.DataEntry[i, 1] = "" +mydd.options[mydd.value].text; //can remove unit if needed
            }
        }
    }
}