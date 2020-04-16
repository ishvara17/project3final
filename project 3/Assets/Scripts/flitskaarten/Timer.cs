using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;
    private GameManager gameManager;
    [SerializeField] TextMeshProUGUI countText;
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        currentTime = startingTime;
    }

   //timer
    void Update()
    {
        currentTime -= +1 * Time.deltaTime;
        countText.text = currentTime.ToString("f0");

        //als tijd meer is dan 110 seconden dan krijg je een game over scherm.
        if (currentTime < 0)
        {
            gameManager.Gameover();
        }
    }
}
