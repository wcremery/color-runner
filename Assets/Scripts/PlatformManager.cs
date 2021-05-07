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
    private List<GameObject> createdPlatforms = new List<GameObject>();

    #endregion

    #region properties

    private Sprite platformSprite;
    private float platformPositionOnX;
    private float platformPositionOnY;
    private float platformWidth;
    private ColorType.ColorList platformColorType;
    private GameObject platformPlayerIsOn;

    #endregion

    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player").gameObject;
        InitStartPlatform();
    }

    public void Restart()
    {
        foreach (GameObject plat in createdPlatforms)
        {
            Destroy(plat);
        }

        createdPlatforms = new List<GameObject>();
        InitStartPlatform();
    }

    /// <summary>
    /// Initialize the start platform
    /// </summary>
    public void InitStartPlatform()
    {
        GameObject start = Instantiate(platforms[3]);
        start.transform.parent = gameObject.transform;
        start.name = "Start";
        platformPlayerIsOn = start;
        platform = platformPlayerIsOn.GetComponent<Platform>();
        platformPositionOnX = 9;
        platformPositionOnY = -1.5f;
        platformWidth = platform.Length;
        ModifyPlatformPosition(ref platform);
        createdPlatforms.Add(start);
    }

    void Update()
    {
        float playerPositionOnX = player.transform.position.x;
        float lol = platformPlayerIsOn.transform.position.x - (platformWidth / 2);

        // Debug.Log(playerPositionOnX + "\n" + lol);
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
        DeterminePlatformPosition(ref platform);
        ModifyPlatformProperties(ref platform);

        platformWidth = platform.Length;
        platformPlayerIsOn = nextPlatformToCreate;
        createdPlatforms.Add(nextPlatformToCreate);
    }

    public void UpdatePlatformPos()
    {
        // DeterminePlatformPosition();
        // ModifyPlatformPosition(platformPlayerIsOn.GetComponent<Platform>());
    }

    /// <summary>
    /// Update the properties of the platform that will be generated
    /// </summary>
    /// <param name="_platform">the platform</param>
    private void ModifyPlatformProperties(ref Platform _platform)
    {
        _platform.TextureSprite = platformSprite;
        _platform.ColorType = platformColorType;
        _platform.PositionOnX = platformPositionOnX;
        _platform.PositionOnY = platformPositionOnY;
    }

    private void ModifyPlatformPosition(ref Platform _platform)
    {
        _platform.PositionOnX = platformPositionOnX;
        _platform.PositionOnY = platformPositionOnY;
    }

    /// <summary>
    /// Determine the platform position on X and Y
    /// </summary>
    /// <param name="nextPlatform"></param>
    private void DeterminePlatformPosition(ref Platform nextPlatform)
    {
        platformPositionOnX = platformPlayerIsOn.GetComponent<Platform>().PositionOnX + (platformWidth / 2) +
                              (nextPlatform.Length / 2) +
                              Random.Range(2, 4);
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
                platformColorType = ColorType.ColorList.Blue;
                platformSprite = blueSprite;
                break;
            case 2:
                platformColorType = ColorType.ColorList.Green;
                platformSprite = greenSprite;
                break;
            case 3:
                platformColorType = ColorType.ColorList.Red;
                platformSprite = redSprite;
                break;
            case 4:
                platformColorType = ColorType.ColorList.Yellow;
                platformSprite = yellowSprite;
                break;
            default:
                platformColorType = ColorType.ColorList.Null;
                Debug.Log("None sprite selected");
                break;
        }
    }

    /// <summary>
    /// Select the platform length
    /// </summary>
    private GameObject SelectPlatformLength()
    {
        int index = Random.Range(1, 4);
        return platforms[index];
    }

    #endregion
}