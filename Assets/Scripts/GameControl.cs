using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{   //bool
    private bool gameOver = false;
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

    }

    //Set bird dead
    public void BirdDied()
    {
        gameOver = true;
        gameOverText.SetActive(true);
    }
}
