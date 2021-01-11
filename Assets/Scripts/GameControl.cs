using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{   //bool
    public bool gameOver = false;
    public readonly float scrollSpeed = -1.5f;
    //GameObjects
    public GameObject gameOverText;
    public static GameControl instance;

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

    //Set bird dead
    public void BirdDied()
    {
        gameOver = true;
        gameOverText.SetActive(true);
    }
}
