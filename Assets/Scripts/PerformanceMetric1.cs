using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using VDProject;

namespace VDProject
{
    public class PerformanceMetric1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public RectTransform Ccontainer;
        public Button PM;
        public bool abc;
        private Passengers A1;
        public GameObject thePlayer;
        public Toggle First;
        public Toggle Second;
        public Toggle Third;
        public Toggle Forth;
        public Toggle Fifth;
        public Toggle Sixth;
        public Toggle Seventh;
        public int Z = 0;

        // Start is called before the first frame update
        void Start()
        {
            Ccontainer = transform.Find("Container1").GetComponent<RectTransform>();
            abc = false;
            PM = GetComponent<Button>();
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 scale1 = Ccontainer.localScale;
            scale1.y = Mathf.Lerp(scale1.y, abc ? 1 : 0, Time.deltaTime * 12);
            Ccontainer.localScale = scale1;

            A1 = thePlayer.GetComponent<Passengers>();

            if (A1.Val == 0)
            {
                abc = false;
                Z = 0;
            }
            if (First.isOn || Second.isOn || Third.isOn || Forth.isOn || Fifth.isOn || Sixth.isOn || Seventh.isOn)
            {
                Z = 1;
            }
            else
            {
                Z = 0;
            }
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            abc = true;
            transform.SetAsLastSibling();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            abc = false;
        }
    }
}
