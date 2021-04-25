using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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

    #region platforms
    public GameObject[] platforms;
    private Platform platform;
    #endregion

    #region properties
    private Sprite platformSprite;
    private float platformPositionOnX;
    private float platformPositionOnY;
    private float platformWidth;
    private ColorType platformColorType;
    private GameObject platformPlayerIsOn;
    #endregion

    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player").gameObject;
        InitStartPlatform();
    }

    /// <summary>
    /// Initialize the start platform
    /// </summary>
    private void InitStartPlatform()
    {
        GameObject start = Instantiate(platforms[3]);
        start.transform.parent = gameObject.transform;
        start.name = "Start";
        platformPlayerIsOn = start;
        platform = platformPlayerIsOn.GetComponent<Platform>();
        platform.PositionOnX = 7;
        platform.PositionOnY = -1.5f;
        platformWidth = platform.Length;
    }

    void Update()
    {
        float playerPositionOnX = player.transform.position.x;
        float lol = platform.PositionOnX - platformWidth/2;

        Debug.Log(playerPositionOnX + "\n" + lol);
        if (playerPositionOnX > lol)
        {
            CreateNewPlatform();
            
        }
    }

    #region platform's creation
    /// <summary>
    /// Create a new a platform
    /// </summary>
    private void CreateNewPlatform()
    {
        GameObject nextPlatformToCreate = Instantiate(SelectPlatformLength());
        nextPlatformToCreate.transform.parent = gameObject.transform;
        nextPlatformToCreate.name = "Platform";
        platform = nextPlatformToCreate.GetComponent<Platform>();
        
        SelectPlatformColorType();
        DeterminePlatformPosition();
        ModifyPlatformProperties(platform);
        platformPlayerIsOn = nextPlatformToCreate;
        platformWidth = platform.Length;
    }    

    /// <summary>
    /// Update the properties of the platform that will be generated
    /// </summary>
    /// <param name="_platform">the platform</param>
    private void ModifyPlatformProperties(Platform _platform)
    {
        _platform.TextureSprite = platformSprite;
        _platform.ColorType = platformColorType;
        _platform.PositionOnX = platformPositionOnX;
        _platform.PositionOnY = platformPositionOnY;
    }

    /// <summary>
    /// Determine the platform position on X and Y
    /// </summary>
    private void DeterminePlatformPosition()
    {
        platformPositionOnX = platformPlayerIsOn.GetComponent<Platform>().PositionOnX + platformWidth + Random.Range(2, 4);
        platformPositionOnY = platformPlayerIsOn.GetComponent<Platform>().PositionOnY + Random.Range(-2, 2);
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
    
    /// <summary>
    /// Select the platform length
    /// </summary>
    private GameObject SelectPlatformLength()
    {
        int index = Random.Range(0, 4);
        return platforms[index];
    }
    #endregion
}
