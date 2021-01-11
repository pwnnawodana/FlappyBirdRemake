using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{   //common
    public bool gameOver = false;
    private int score = 0;
    public readonly float scrollSpeed = -1.5f;
    //unity
    public GameObject gameOverText;
    public static GameControl instance;
    public Text scoreText;

    // Awake is called before the start function
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score : " + score;
    }

    //Set bird dead
    public void BirdDied()
    {
        gameOver = true;
        gameOverText.SetActive(true);
    }
}
