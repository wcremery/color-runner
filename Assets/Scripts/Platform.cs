using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Platform : Element
{
    public ColorType.ColorList colorType = ColorType.ColorList.Null;
    public SpriteAtlas spriteAtlas;
    private Sprite[] _sprites;
    private void Start()
    {
        /*SpriteRenderer spriteRenderer= gameObject.GetComponent<SpriteRenderer>();
        Debug.Log(spriteRenderer);
        spriteAtlas.GetSprites(_sprites);
        spriteRenderer.sprite = _sprites[1];*/
    }

}
