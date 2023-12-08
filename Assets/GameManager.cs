using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{   public static  GameManager instance { get; private set; }
    public float gameSpeed {  get; private set; }
    public float gameSpeedIncrease = 0.1f;
    public float initialGameSpeed = 5f;
    private Player  player;
    private Spawner spawner;

    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiscoreText;
    public Button retryButton;
    private float score;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else DestroyImmediate(gameObject); 
    }
    private void OnDestroy()
    {
        if (instance != null) instance = null;
    }

    private void Start()
    {
        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<Spawner>();
            
        NewGame();
    }
    public void NewGame()
    {
        Obstacle[] obstacles  = FindObjectsOfType<Obstacle>();
        foreach (var obstacle in obstacles) 
        {
            Destroy(obstacle.gameObject);
        }

        score = 0f;
        gameSpeed = initialGameSpeed;
        enabled = true;

        player.gameObject.SetActive(true);
        spawner.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(false);
        retryButton.gameObject.SetActive(false);
        updateHighScore();



    }
    private void Update()
    {
        gameSpeed += gameSpeedIncrease * Time.deltaTime;
        score += gameSpeed * Time.deltaTime;
        scoreText.text = Mathf.FloorToInt(score).ToString("D5");
    }
    public void GameOver()
    {
        gameSpeed = 0f;
        enabled = false;  
        player.gameObject.SetActive(false);
        spawner.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(true);
        retryButton.gameObject.SetActive(true);
        updateHighScore();  
    }

    public  void updateHighScore()
    {
        float hiscore = PlayerPrefs.GetFloat("hiscore", 0);
        if (score > hiscore)
        {
            hiscore = score;
            PlayerPrefs.SetFloat("hiscore", hiscore);
        }
        hiscoreText.text = Mathf.FloorToInt(hiscore).ToString("D5");
    }
}
