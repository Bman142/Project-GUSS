using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int SceneIndex;

    public void onSceneChange(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
