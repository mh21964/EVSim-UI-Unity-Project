using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

using VDProject;

namespace VDProject
{
    public class PerformanceMetric3 : MonoBehaviour
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

        public static string temp2 = "";

        int i = 2;
        public int y = 0;
        void Start()
        {
            FileCreate.DataEntry[i, 0] = "Performance Metric:";
            FileCreate.DataEntry[i, 1] = "";
        }
      
        void Joining()
        {
            temp2 = string.Join(",", PerformanceMetric2.temp);
            string output = string.Join(",", temp2.Split(',').Distinct().ToArray());
            FileCreate.DataEntry[i, 1] = output;
        }
        void Update()
        {

            if ((y == 0) && (PanelChange.buttonclicked))
            {
                y = 1;

                Joining();
            }
        }
    }
}
