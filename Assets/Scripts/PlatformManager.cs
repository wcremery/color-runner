using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class PlatformManager : MonoBehaviour
{
    #region sprites
    public Sprite blueSprite;
    public Sprite greenSprite;
    public Sprite redSprite;
    public Sprite yellowSprite;
    #endregion

    #region constants
    private const int NUMBER_PLATFORMS = 2;
    #endregion

    #region properties
    private ColorType platformColorType;
    private Sprite platformSprite;
    private float platformPositionOnX;
    private float platformPositionOnY;
    private float platformWidth;
    private float platformHeight;
    private GameObject[] nextPlatformsArray = new GameObject[NUMBER_PLATFORMS];
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
        Debug.Log(platformPlayerIsOn.transform.position.x - 5);
        if (playerPositionOnX >= platformPlayerIsOn.transform.position.x - 5)
        {
            GenerateNextPlatforms();
        }
    }

    #region platform's creation
    /// <summary>
    /// Generating the two next platforms
    /// </summary>
    private void GenerateNextPlatforms()
    {
        for (int i = 0; i < nextPlatformsArray.Length; ++i)
        {
            CreateNewPlatform();
        }
    }

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
        float spacement = 6f;
        platformPositionOnX = platformPlayerIsOn.GetComponent<Platform>().PositionOnX + spacement;
    }

    /// <summary>
    /// Determine the platform width and height
    /// </summary>
    private void DeterminePlatformSize()
    {
        platformWidth = 4.02f;
        platformHeight = 1.93f;
    }

    /// <summary>
    /// Select the sprite that will be applied to the platform
    /// </summary>
    private void SelectPlatformColorType()
    {
        switch (platformColorType)
        {
            case ColorType.Blue:
                platformSprite = blueSprite;
                break;
            case ColorType.Green:
                platformSprite = greenSprite;
                break;
            case ColorType.Red:
                platformSprite = redSprite;
                break;
            case ColorType.Yellow:
                platformSprite = yellowSprite;
                break;
            default:
                platformSprite = redSprite;
                //Debug.Log("None sprite selected");
                break;
        }
    }
    #endregion
}
