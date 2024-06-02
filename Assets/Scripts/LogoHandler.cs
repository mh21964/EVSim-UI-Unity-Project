using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using VDProject;

namespace VDProject
{
    public class LogoHandler : MonoBehaviour
    {
        public Animator TransitionAnim;
        public string SceneName;

        void Update()
        {
            StartCoroutine(LoadScene());
        }

        IEnumerator LoadScene()
        {
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene(SceneName);
        }
    }
}