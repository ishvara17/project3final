using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float SpawnRate = 1.0f;
    private int score;
    public TextMeshProUGUI scoreText;
    public GameObject GameOver;
    public GameObject titleScreen;
    private float spawnRangeX = 24;
    private float spawnPosZ = 80;
    float currentdelay=4;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", currentdelay, 3f);
        score = 0;
        UpdateScore(0);
    }

    private void Update()
    {

 
            currentdelay += Time.deltaTime * Time.deltaTime;
 
    }

    void SpawnRandomAnimal()
    {
   

            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        

    }

    // Update is called once per frame
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "score: " + score;
    }

    public void Gameover()
    {
        GameOver.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame(int difficulty)
    {
        SpawnRate /= difficulty;
        score = 0;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
    }

}