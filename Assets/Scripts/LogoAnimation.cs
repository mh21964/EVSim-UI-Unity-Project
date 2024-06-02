using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using VDProject;

namespace VDProject
{
    public class LogoAnimation : MonoBehaviour
    {
        //Attach an Image you want to fade in the GameObject's Inspector

        //Use this to tell if the toggle returns true or false
        public List<Image> LogoImages = new List<Image>();
        public float speed;
        bool fadeCompleted = false;
        public Text SimButtonText;

        void Start()
        {
        }
        void Update()
        {
          if ((FileCreate.filecreated)&&(!fadeCompleted)&&(!ReadOutputFile.filefound2)  ) //set condition of when to start later
          {
                fadeCompleted = true;
                SimButtonText.text = "Simulation running";
                StartCoroutine(FadeAnim());
          }
            else 
            {
                StopCoroutine(FadeAnim());
            }
        }

        IEnumerator FadeAnim()
        {
            for (int i = 0; i < LogoImages.Count; i++)
            {
                float alpha = LogoImages[i].color.a;
                while (alpha < 1)
                {
                    alpha += Time.deltaTime * speed;
                    LogoImages[i].color = new Color(LogoImages[i].color.r, LogoImages[i].color.g, LogoImages[i].color.b, alpha);
                    yield return null;
                }

            }


            for (int i = LogoImages.Count - 1; i >= 0; i--)
            {
                float alpha = LogoImages[i].color.a;

                while (alpha > 0)
                {
                    alpha -= Time.deltaTime * speed;

                    LogoImages[i].color = new Color(LogoImages[i].color.r, LogoImages[i].color.g, LogoImages[i].color.b, alpha);
                    yield return null;
                }

            }

            fadeCompleted = false;

            yield return null;
        }

    }
}
