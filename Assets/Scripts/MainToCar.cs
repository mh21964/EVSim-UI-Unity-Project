﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

using VDProject;

namespace VDProject
{
    public class MainToCar : MonoBehaviour
    {
        public void ChangeToScene(string SceneChange)
        {
            SceneManager.LoadScene(SceneChange);
        }
    }
}