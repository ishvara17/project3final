using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quit_game : MonoBehaviour
{
        public void QuitGame ()
        {
            Debug.Log ("QUIT!");
            Application.Quit();
        }
    
}
