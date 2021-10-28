using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string scene_to_load = null;

    public void PlayGame()
    {
        SceneManager.LoadScene(scene_to_load);
    }
}
