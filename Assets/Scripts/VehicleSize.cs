using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using VDProject;

namespace VDProject
{


    public class VehicleSize : MonoBehaviour
    {
        public Image oldimage;
        public Sprite[] Img;
        public Text Req;
        public Image Front;
        public Image Back;
        public int Val;
        public Dropdown mydd;
        public Text Desc;
        int i = 0;

        //2 Wheeler
        public void ImageChangeBike(Dropdown mydd)
        {
            Front.enabled = false;
            Back.enabled = false;
            Val = mydd.value;

            if (mydd.value > 0)
            {
                if (mydd.value == 1)
                {
                    Front.rectTransform.anchoredPosition = new Vector2(88, -376);
                    Front.rectTransform.sizeDelta = new Vector2(200, 260);
                    Back.rectTransform.anchoredPosition = new Vector2(-180, -372);
                    Back.rectTransform.sizeDelta = new Vector2(130, 200);
                    Desc.text = mydd.options[mydd.value].text + " is similar to 70cc";
                }
                if (mydd.value == 2)
                {
                    Front.rectTransform.anchoredPosition = new Vector2(139, -353);
                    Front.rectTransform.sizeDelta = new Vector2(180, 210);
                    Back.rectTransform.anchoredPosition = new Vector2(-171, -358);
                    Back.rectTransform.sizeDelta = new Vector2(180, 200);
                    Desc.text = mydd.options[mydd.value].text + " is similar to 100cc";
                }
                if (mydd.value == 3)
                {
                    Front.rectTransform.anchoredPosition = new Vector2(79, -340);
                    Front.rectTransform.sizeDelta = new Vector2(160, 260);
                    Back.rectTransform.anchoredPosition = new Vector2(-144, -298);
                    Back.rectTransform.sizeDelta = new Vector2(100, 200);
                    Desc.text = mydd.options[mydd.value].text + " is similar to 122cc";
                }
                oldimage.sprite = Img[mydd.value];

                FileCreate.DataEntry[i, 0] = "Vehicle Size:";
                FileCreate.DataEntry[i, 1] = mydd.options[mydd.value].text;
            }
            else
            {
                oldimage.enabled = false;
                Desc.text = "";
            }
        }
        //3 Wheeler
        public void ImageChangeRickshaw(Dropdown mydd)
        {
            Front.enabled = false;
            Back.enabled = false;
            Val = mydd.value;
            if (mydd.value > 0)
            {
                if (mydd.value == 1)
                {
                    Front.rectTransform.anchoredPosition = new Vector2(138, -421);
                    Front.rectTransform.sizeDelta = new Vector2(170, 150);
                    Back.rectTransform.anchoredPosition = new Vector2(-198, -385);
                    Back.rectTransform.sizeDelta = new Vector2(120, 120);
                }
                if (mydd.value == 2)
                {
                    Front.rectTransform.anchoredPosition = new Vector2(92, -421);
                    Front.rectTransform.sizeDelta = new Vector2(150, 180);
                    Back.rectTransform.anchoredPosition = new Vector2(-207, -385);
                    Back.rectTransform.sizeDelta = new Vector2(130, 150);
                }

                oldimage.sprite = Img[mydd.value];
                FileCreate.DataEntry[i, 0] = "Vehicle Size:";
                FileCreate.DataEntry[i, 1] = mydd.options[mydd.value].text;
            }
            else
            {
                oldimage.enabled = false;
            }
        }
        //4 Wheeler
        public void ImageChangeCar(Dropdown mydd)
        {
            Front.enabled = false;
            Back.enabled = false;
            Val = mydd.value;
            if (mydd.value > 0)
            {
                if (mydd.value == 1)
                {
                    Front.rectTransform.anchoredPosition = new Vector2(97, -376);
                    Front.rectTransform.sizeDelta = new Vector2(60, 140);
                    Back.rectTransform.anchoredPosition = new Vector2(184, -339);
                    Back.rectTransform.sizeDelta = new Vector2(30, 100);
                }
                if (mydd.value == 2)
                {
                    Front.rectTransform.anchoredPosition = new Vector2(5, -376);
                    Front.rectTransform.sizeDelta = new Vector2(60, 140);
                    Back.rectTransform.anchoredPosition = new Vector2(184, -376);
                    Back.rectTransform.sizeDelta = new Vector2(40, 100);
                }
                if (mydd.value == 3)
                {
                    Front.rectTransform.anchoredPosition = new Vector2(0, -325);
                    Front.rectTransform.sizeDelta = new Vector2(70, 130);
                    Back.rectTransform.anchoredPosition = new Vector2(-198, -302);
                    Back.rectTransform.sizeDelta = new Vector2(40, 100);
                }

                oldimage.sprite = Img[mydd.value];

                FileCreate.DataEntry[i,0] = "Vehicle Size:";
                FileCreate.DataEntry[i, 1] = mydd.options[mydd.value].text;

            }
            else
            {
                oldimage.enabled = false;
            }
        }
    }
}