using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public void NextLevelButton(int index)
    {
        SceneManager.LoadScene(1);
    }

    public void NextLevelButton(string levelName)
    {
        SceneManager.LoadScene(1);
        SceneManager.LoadScene("Samplescene");
    }
}