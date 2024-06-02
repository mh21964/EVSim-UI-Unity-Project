using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using VDProject;

namespace VDProject
{
    public class BackButton : MonoBehaviour
    {
        public string SceneChange;
        // Start is called before the first frame update
        void Start()
        {
            SceneChange = InitiateComparison.CurrentSceneComparison;
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void ChangeToScene()
        {
            SceneManager.LoadScene(SceneChange);
        }
    }
}
