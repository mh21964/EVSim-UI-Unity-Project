using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

using VDProject;

public class RegenBraking : MonoBehaviour
{
    public Text RB;
    public Text TD;
    public int Val;
    public Dropdown mydd;
    private PerformanceMetric1 A1;
    public GameObject thePlayer;

    int i = 4;
    void Update()
    {
        A1 = thePlayer.GetComponent<PerformanceMetric1>();
        if (A1.Z == 0)
        {
            mydd.enabled = false;
            TD.color = new Color32(154, 154, 154, 255);
        }
        else
        {
            mydd.enabled = true;
            TD.color = new Color32(0, 0, 0, 255);
        }
    }

    public void TextChange6(Dropdown mydd)
    {
        Val = mydd.value;

        if (mydd.value > 0)
        {
            if (mydd.value == 1)
            {
                RB.color = new Color32(0, 0, 0, 255);
            }
            else
            {
                RB.color = new Color32(154, 154, 154, 255);
            }

            FileCreate.DataEntry[i, 0] = "Regen Braking:";
            FileCreate.DataEntry[i, 1] = "" + mydd.options[mydd.value].text; //can remove unit if needed
        }
        else
        {
            RB.color = new Color32(154, 154, 154, 255);
        }
    }
}
