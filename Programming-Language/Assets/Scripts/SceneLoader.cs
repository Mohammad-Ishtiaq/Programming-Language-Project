using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string scene_to_load;

    public void PlayGame(string scene_to_load)
    {
        SceneManager.LoadScene(scene_to_load);
    }
}
