using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using Random = UnityEngine.Random;

public class PlatformManager : MonoBehaviour
{
    #region sprites
    public Sprite blueSprite;
    public Sprite greenSprite;
    public Sprite redSprite;
    public Sprite yellowSprite;
    #endregion

    #region properties
    private Sprite platformSprite;
    private float platformPositionOnX;
    private float platformPositionOnY;
    private float platformWidth;
    private float platformHeight;
    private ColorType platformColorType;
    private GameObject platformPlayerIsOn; // platform before the two next one
    #endregion

    private GameObject player;

    private void Awake()
    {
        platformPlayerIsOn = transform.Find("Platform").gameObject;
    }

    private void Start()
    {
        player = GameObject.Find("Player").gameObject;
    }

    private void Update()
    {
        float playerPositionOnX = player.transform.position.x;
        if (playerPositionOnX >= platformPlayerIsOn.transform.position.x - 5)
        {
            CreateNewPlatform();
        }
    }

    #region platform's creation
    /// <summary>
    /// Create a new a platform
    /// </summary>
    private GameObject CreateNewPlatform()
    {
        GameObject nextPlatform = new GameObject("Platform");
        nextPlatform.transform.parent = gameObject.transform;

        SelectPlatformColorType();
        DeterminePlatformPosition();  
        DeterminePlatformSize();  
        AddPlatformComponents(nextPlatform);
        ModifyPlatformProperties(nextPlatform);        
        platformPlayerIsOn = nextPlatform;
 
        return nextPlatform;
    }    

    /// <summary>
    /// Update the properties of the platform that will be generated
    /// </summary>
    /// <param name="nextPlatform">the platform's game object</param>
    private void ModifyPlatformProperties(GameObject nextPlatform)
    {
        nextPlatform.GetComponent<Platform>().SpriteRenderer.sprite = platformSprite;
        nextPlatform.GetComponent<Platform>().PositionOnX = platformPositionOnX;
        nextPlatform.GetComponent<Platform>().Width = platformWidth;
        nextPlatform.GetComponent<Platform>().Height = platformHeight;
        nextPlatform.GetComponent<Platform>().ColorType = platformColorType;
    }

    /// <summary>
    /// Add the components that the platform requires
    /// </summary>
    /// <param name="nextPlatform">the platform's game object</param>
    private static void AddPlatformComponents(GameObject nextPlatform)
    {
        nextPlatform.AddComponent<SpriteRenderer>();
        nextPlatform.AddComponent<BoxCollider2D>();
        nextPlatform.AddComponent<Platform>();
    }

    /// <summary>
    /// Determine the platform position on X and Y
    /// </summary>
    private void DeterminePlatformPosition()
    {
        float spacement = Random.Range(6, 9);
        platformPositionOnX = platformPlayerIsOn.GetComponent<Platform>().PositionOnX + spacement;
    }

    /// <summary>
    /// Determine the platform width and height
    /// </summary>
    private void DeterminePlatformSize()
    {
        platformWidth = Random.Range(2, 6);
        platformHeight = Random.Range(1, 6);
    }

    /// <summary>
    /// Select the sprite that will be applied to the platform
    /// </summary>
    private void SelectPlatformColorType()
    {
        int index = Random.Range(1, 5);
        switch (index)
        {
            case 1:
                platformColorType = ColorType.Blue;
                platformSprite = blueSprite;
                break;
            case 2:
                platformColorType = ColorType.Green;
                platformSprite = greenSprite;
                break;
            case 3:
                platformColorType = ColorType.Red;
                platformSprite = redSprite;
                break;
            case 4:
                platformColorType = ColorType.Yellow;
                platformSprite = yellowSprite;
                break;
            default:
                platformColorType = ColorType.Null;
                Debug.Log("None sprite selected");
                break;
        }
    }
    #endregion
}
