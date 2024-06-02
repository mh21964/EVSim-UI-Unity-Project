using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

using VDProject;

namespace VDProject
{
    public class PerformanceMetric2 : MonoBehaviour
    {
        public Toggle First;
        public Toggle Second;
        public Toggle Third;
        public Toggle Forth;
        public Toggle Fifth;
        public Toggle Sixth;
        public Toggle Seventh;

        public Text first;
        public Text second;
        public Text third;
        public Text forth;
        public Text fifth;
        public Text sixth;
        public Text seventh;

        public Text buttonDD;
        public string Data1;
        public int Ai = 0;
        public bool once = false;
        public static string A = "Range (km) - City";
        public static string B = "Range (km) - Hwy (or Mwy)";
        public static string C = "Top Speed (kph) 0% grade";
        public static string D = "Top Speed (kph) x% grade";
        public static string E = "Time (sec) 0 - 100 kph";
        public static string F = "Time (sec) 0.4 km";
        public static string G = "Time (sec) 50 - 80 kph";
        public static string temp2 = "";


        public static List<string> temp = new List<string>();

        int i = 2;
        public int y = 0;
        void Start()
        {
            FileCreate.DataEntry[i, 0] = "Performance Metric:";
            FileCreate.DataEntry[i, 1] = "";
        }
        public void Toggle_Changed()
        {
            if (First.isOn)
            {
                first.color = new Color32(0, 0, 0, 255);
                if (!temp.Contains(A))
                {
                    temp.Add(A);
                }
            }
            else if (!First.isOn)
            {
                first.color = new Color32(154, 154, 154, 255);
                if (temp.Contains(A))
                {
                    temp.RemoveAll(x => x == A);
                } 
            }
            else
            { }

            if (Second.isOn)
            {
                second.color = new Color32(0, 0, 0, 255);
                if (!temp.Contains(B))
                {
                    temp.Add(B);
                }
            }
            else if (!Second.isOn)
            {
                second.color = new Color32(154, 154, 154, 255);
                if (temp.Contains(B))
                {
                    temp.RemoveAll(x => x == B);
                }
            }
            else
            { }

            if (Third.isOn)
            {
                third.color = new Color32(0, 0, 0, 255);
                if (!temp.Contains(C))
                {
                    temp.Add(C);
                }
            }
            else if (!Third.isOn)
            {
                third.color = new Color32(154, 154, 154, 255);
                if (temp.Contains(C))
                {
                    temp.RemoveAll(x => x == C);
                }
            }
            else
            { }
            
            if (Forth.isOn)
            {
                forth.color = new Color32(0, 0, 0, 255);
                if (!temp.Contains(D))
                {
                    temp.Add(D);
                }
            }
            else if (!Forth.isOn)
            {
                forth.color = new Color32(154, 154, 154, 255);
                if (temp.Contains(D))
                {
                    temp.RemoveAll(x => x == D);
                }
            }
            else
            { }

            if (Fifth.isOn)
            {
                fifth.color = new Color32(0, 0, 0, 255);
                if (!temp.Contains(E))
                {
                    temp.Add(E);
                }
            }
            else if (!Fifth.isOn)
            {
                fifth.color = new Color32(154, 154, 154, 255);
                if (temp.Contains(E))
                {
                    temp.RemoveAll(x => x == E);
                }
            }
            else
            { }

            if (Sixth.isOn)
            {
                sixth.color = new Color32(0, 0, 0, 255);
                if (!temp.Contains(F))
                {
                    temp.Add(F);
                }
            }
            else if (!Sixth.isOn)
            {
                sixth.color = new Color32(154, 154, 154, 255);
                if (temp.Contains(F))
                {
                    temp.RemoveAll(x => x == F);
                }
            }
            else
            { }

            if (Seventh.isOn)
            {
                seventh.color = new Color32(0, 0, 0, 255);
                if (!temp.Contains(G))
                {
                    temp.Add(G);
                }
            }
            else if (!Seventh.isOn)
            {
                seventh.color = new Color32(154, 154, 154, 255);
                if (temp.Contains(G))
                {
                    temp.RemoveAll(x => x == G);
                }
            }
            else
            { }

            if (First.isOn || Second.isOn || Third.isOn || Forth.isOn || Fifth.isOn || Sixth.isOn || Seventh.isOn)
            {
                buttonDD.text = "  Selected";
            }
            else
            {
                buttonDD.text = "  Choose";
            }
        }

        void Joining()
        {
            if (Ai == 0) {
                for (int k = 0; k < temp.Count; k++)
                {
                    UnityEngine.Debug.Log("ABC Final THis:" + temp[k]);
                }
                temp2 = string.Join(",", temp);
                Ai = 1;
                string output = string.Join(",", temp2.Split(',').Distinct().ToArray());

                UnityEngine.Debug.Log("CDE The output is: " + output);
                FileCreate.DataEntry[i, 1] = output;
               
            }
        }
        void Update()
        { }
    }
}
