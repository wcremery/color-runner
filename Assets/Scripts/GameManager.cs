using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Player player;
    public TMP_Text score;
    private float scoreCount = 0f;
    private float multiplier = 0f;
    public float resetLimit = 1000f;
    public GameObject plateformes;
    public GameObject cameraObject;
    public GameObject gameOverScreen;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > resetLimit)
        {
            Debug.Log("[RELOAD] X reset");
            Transform[] gameObjects = plateformes.GetComponentsInChildren<Transform>(); /*FindObjectsOfType<GameObject>();*/
            foreach(Transform entity in gameObjects)
            {
                if (entity.name == "Start" || entity.name == "Platform")
                {
                    entity.position = new Vector3(entity.position.x - resetLimit, entity.position.y, entity.position.z);
                }
            }
            player.transform.position = new Vector3(player.transform.position.x - resetLimit, player.transform.position.y, player.transform.position.z);
            //Transform[] cameraObjects = camera.GetComponentsInChildren<Transform>(); /*FindObjectsOfType<GameObject>();*/
            //foreach (Transform entity in cameraObjects)
            //{

            //   entity.position = new Vector3(entity.position.x - resetLimit, entity.position.y, entity.position.z);

            //}
            cameraObject.transform.position = new Vector3(cameraObject.transform.position.x - resetLimit, cameraObject.transform.position.y, cameraObject.transform.position.z);
            multiplier++;
        }
        if(player.transform.position.y> resetLimit)
        {
            Debug.Log("[RELOAD] Y reset");
            Transform[] gameObjects = plateformes.GetComponentsInChildren<Transform>(); /*FindObjectsOfType<GameObject>();*/
            foreach (Transform entity in gameObjects)
            {
                entity.position = new Vector3(entity.position.x - resetLimit, entity.position.y, entity.position.z);
            }
            player.transform.position = new Vector3(player.transform.position.x - resetLimit, player.transform.position.y, player.transform.position.z);
        }
        if ((player.transform.position.x + (multiplier * resetLimit)) - scoreCount > 1)
        {
            scoreCount++;
            updateScore();
        }
        
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;

    }
    private void updateScore()
    {
        score.text = scoreCount.ToString();
    }
}
