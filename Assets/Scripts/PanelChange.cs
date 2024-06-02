using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using VDProject;

namespace VDProject
{
    public class PanelChange : MonoBehaviour
    {
        public Button button;
        private FrontalArea A1;
        public GameObject thePlayer;
        public static bool buttonclicked = false;
        Scene m_Scene;
        public static string vehicalType;  //scene Name

        void Awake()
        {
            button = GetComponent<Button>();

            m_Scene = SceneManager.GetActiveScene();
            vehicalType = m_Scene.name;
        }

        void Update()
        {
            A1 = thePlayer.GetComponent<FrontalArea>();
            if (A1.c == 0)
            {
                button.interactable = false;
            }
            else
            {
                button.interactable = true;
            }
           
        }
        
        public void ChangeToScene(string SceneChange)
        {
            buttonclicked = true;
        }
    }
}