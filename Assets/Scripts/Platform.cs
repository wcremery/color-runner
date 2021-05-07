using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Platform : MonoBehaviour
{
    #region properties
    public GameObject spriteHolderPrefab;
    private GameObject spriteHolderInstance;
    public ColorType.ColorList colorType;
    private BoxCollider2D boxCollider;
    private float length;
    private float positionOnX;
    private float positionOnY;
    private Sprite textureSprite;

    #endregion

    #region accessors
    public Sprite TextureSprite
    {
        get => textureSprite;
        set => textureSprite = value;
    }
    
    public ColorType.ColorList ColorType { get => colorType; set => colorType = value; }
    public float PositionOnX { get => positionOnX; set => positionOnX = value; }
    public float PositionOnY { get => positionOnY; set => positionOnY = value; }
    public float Length { get => length; }
    #endregion

    void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        length = boxCollider.size.x;
    }
    
    void Start()
    {
        transform.localPosition = new Vector3(positionOnX, positionOnY, 0);
        InstantiateAllPrefabHolder();
    }

    /// <summary>
    /// Retrieve the sprite renderer of each sprite that compose the platform
    /// </summary>
    private void InstantiateAllPrefabHolder()
    {
        var nSprites = transform.childCount;
        for (var i = 0; i < nSprites; ++i)
        {
            spriteHolderInstance = Instantiate(spriteHolderPrefab);
            spriteHolderInstance.transform.parent = gameObject.transform.GetChild(i);
            spriteHolderInstance.transform.localPosition = new Vector3(0f, .95f, 0f);
            spriteHolderInstance.GetComponentInChildren<SpriteRenderer>().sprite = textureSprite;
        }
    }
}
