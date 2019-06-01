using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextscene : MonoBehaviour
{
    Scene scene;
    public void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    public void ButtonPush()
    {

        if (SceneManager.sceneCountInBuildSettings-1 == scene.buildIndex)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(scene.buildIndex + 1);
        }
    }
}
