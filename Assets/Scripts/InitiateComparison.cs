using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VDProject;
namespace VDProject
{
    public class InitiateComparison : MonoBehaviour
    {
        public static string CurrentSceneComparison = "";

        // Start is called before the first frame update
        void Start()
        {
            CurrentSceneComparison = PanelChange.vehicalType;
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void ChangeToSceneToCompare(string SceneChange)
        {
            SceneManager.LoadScene(SceneChange);
        }
    }
}