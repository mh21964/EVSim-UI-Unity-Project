using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using VDProject;

namespace VDProject
{
    public class SaveButtonDetect : MonoBehaviour
    {
        public static bool saveButtonClicked = false;
        public Button saveButton;
        int x = 0;
        // Start is called before the first frame update
        void Start()
        {
            saveButtonClicked = false;
            saveButton.interactable = false;
            x = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if (x == 0)
            {
                if (ReadOutputFile.outputFetched)
                {
                    saveButton.interactable = true;
                    saveButton.onClick.AddListener(TaskOnClick);
                    x = 1;
                }
                else
                {
                    saveButton.interactable = false;
                }
            }
        }
        void TaskOnClick()
        {
            saveButtonClicked = true;
            saveButton.interactable = false;
        }
    }
}