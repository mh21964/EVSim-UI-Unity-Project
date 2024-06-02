using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using VDProject;

namespace VDProject
{
    public class TireSize : MonoBehaviour
    {
        public Text Tire;
        public Image Front;
        public Image Back;
        public int Val;
        public Dropdown mydd;
        private BatteryVoltage A1;
        public GameObject thePlayer;
        int i = 8;
        void Start()
        {
            Front.enabled = false;
            Back.enabled = false;
        }

        void Update()
        {
            A1 = thePlayer.GetComponent<BatteryVoltage>();
            if (A1.c == 0)
            {
                mydd.enabled = false;
            }
            else
            {
                mydd.enabled = true;
            }

            if (Front.enabled == true || Back.enabled == true)
            {
                Front.fillAmount -= 1.0f / 5 * Time.deltaTime;
                Back.fillAmount -= 1.0f / 5 * Time.deltaTime;
            }
        }

        public void TextChange5(Dropdown mydd)
        {
            Val = mydd.value;

            if (mydd.value > 0)
            {

                FileCreate.DataEntry[i, 0] = "Tire Size:";
                FileCreate.DataEntry[i, 1] = "" + mydd.options[mydd.value].text;
                Front.enabled = true;
                Back.enabled = true;
            }
            else
            {
                Front.enabled = false;
                Back.enabled = false;
            }
        }
    }
}