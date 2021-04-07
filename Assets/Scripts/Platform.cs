using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Platform : Element
{
    #region components
    private SpriteRenderer platformSpriteRenderer;
    private BoxCollider2D boxCollider2d;
    #endregion

    #region properties
    private ColorType colorType;
    private float width = 4.02f;
    private float height = 1.93f;
    private float positionOnX;
    private float positionOnY;
    #endregion

    #region accessors
    public ColorType ColorType { get => colorType; set => colorType = value; }
    public SpriteRenderer SpriteRenderer { get => platformSpriteRenderer; set => platformSpriteRenderer = value; }    
    public float Width { get => width; set => width = value; }
    public float Height { get => height; set => height = value; }
    public float PositionOnX { get => positionOnX; set => positionOnX = value; }
    public float PositionOnY { get => positionOnY; set => positionOnY = value; }
    #endregion

    private void Awake()
    {
        positionOnX = transform.position.x;
        positionOnY = transform.position.y;
        platformSpriteRenderer = GetComponent<SpriteRenderer>();
        platformSpriteRenderer.drawMode = SpriteDrawMode.Sliced;
        boxCollider2d = GetComponent<BoxCollider2D>();
    }

    private void Start()
    {
        transform.position = new Vector3(positionOnX, positionOnY, 0);
        platformSpriteRenderer.size = new Vector2(width, height);
        boxCollider2d.size = new Vector2(width, height);
    }
}
