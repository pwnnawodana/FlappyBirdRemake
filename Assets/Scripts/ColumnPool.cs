using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    //common
    private readonly int COLUMN_POOL_SIZE = 5;
    private int currentColumn = 0;
    private float SPAWN_RATE = 4f;
    private float timeSinceLastSpawn;
    private float COLUMN_MIN = -1f;
    private float COLUMN_MAX = 3.5f;
    private float SPAWN_X_POS = 11.0f;

    //unity
    public GameObject columnPrefab;
    public GameObject[] columns;
    private Vector2 OBJECT_POOL_POSITION = new Vector2(-15f, -25f);

    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[COLUMN_POOL_SIZE];
        for (int i = 0; i < COLUMN_POOL_SIZE; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, 
                OBJECT_POOL_POSITION, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (GameControl.instance.gameOver.Equals(false) && timeSinceLastSpawn >= SPAWN_RATE)
        {
            timeSinceLastSpawn = 0;
            float spawnYPosition = Random.Range(COLUMN_MIN, COLUMN_MAX);
            columns[currentColumn].transform.position = new Vector2(SPAWN_X_POS, spawnYPosition);
            currentColumn++;
            if (currentColumn >= COLUMN_POOL_SIZE)
            {
                currentColumn = 0;
            }
        }


    }
}
