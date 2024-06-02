using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using VDProject;

namespace VDProject
{
    public class Passengers : MonoBehaviour
    {
        public Text Pass;
        public int Val;
        public Dropdown mydd;
        private VehicleSize A1;
        public GameObject thePlayer;
        int i = 1;
        void Update()
        {
            A1 = thePlayer.GetComponent<VehicleSize>();
            if (A1.Val == 0)
            {
                mydd.enabled = false;
            }
            else
            {
                mydd.enabled = true;
            }
        }

        public void TextChange(Dropdown mydd)
        {
            Val = mydd.value;

            if (mydd.value > 0)
            {
                FileCreate.DataEntry[i, 0] = "Number of Passengers:";

                FileCreate.DataEntry[i, 1] = mydd.options[mydd.value].text;
            }
        }
    }
}