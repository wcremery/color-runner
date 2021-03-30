using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    private const int RESETLIMIT = 1000;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > RESETLIMIT)
        {
            Debug.Log("[RELOAD] X reset");
            GameObject[] gameObjects = FindObjectsOfType<GameObject>();
            foreach(GameObject entity in gameObjects)
            {
                entity.transform.position = new Vector3(entity.transform.position.x - RESETLIMIT, entity.transform.position.y, entity.transform.position.z);
            }
        }
        if(player.transform.position.y> RESETLIMIT)
        {
            Debug.Log("[RELOAD] Y reset");
            GameObject[] gameObjects = FindObjectsOfType<GameObject>();
            foreach (GameObject entity in gameObjects)
            {
                entity.transform.position = new Vector3(entity.transform.position.x, entity.transform.position.y - RESETLIMIT, entity.transform.position.z);
            }
        }
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
    }
}
