using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Header("Layers Masks")]
        [SerializeField]private LayerMask platformsLayerMask;
        [SerializeField] private LayerMask deathLayerMask;

    public Rigidbody2D myRigidbody;
    public BoxCollider2D boxCollider2D;
    public GameManager gameManager;
    public float timeLimitJump = 0.2f;
    private float jumpVelocity = 6f;
    private float moveSpeed =1f;
    public ColorType colorType;
    private int controlsColorNumber = 0;
    private float timeJump;
    

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);
    }
    private bool IsOnDeath()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, deathLayerMask);
        if (raycastHit2D.collider != null)
        {
            Debug.DrawLine(gameObject.transform.position, raycastHit2D.point, Color.green, 100f);
        }
        return raycastHit2D.collider != null;
    }
    private bool IsGrounded()
    {
       RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, platformsLayerMask);
        if (raycastHit2D.collider != null)
        {
            Debug.DrawLine(gameObject.transform.position, raycastHit2D.point, Color.green, 100f);
        }
        return raycastHit2D.collider != null;
    }
    private bool IsAgainstWallRight()
    {
        RaycastHit2D raycastHit2D = Physics2D.Raycast(gameObject.transform.position, Vector2.right, 0.50f, platformsLayerMask);
        if (raycastHit2D.collider != null) {
            Debug.DrawLine(gameObject.transform.position, raycastHit2D.point, Color.green, 100f);
        }
        return raycastHit2D.collider != null;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("[Collision] Testing if Game Over");
        GameObject collider = collision.gameObject;
        if (IsAgainstWallRight() || IsOnDeath())
        {
            Debug.Log("[Collision] Game Over Wall Right");
            GameOver();
        }
        else
        {
            Platform platform = collider.GetComponent<Platform>();
            if (platform != null)
            {
                if(platform.colorType != ColorType.Null && platform.colorType != colorType)
                {
                    Debug.Log("[Collision] Game Over Wrong Color");
                    GameOver();
                }
            }
        }
    }

    private void GameOver()
    {
        
        gameManager.GameOver();
    }
    public void OnJump(InputValue input)
    {
        Debug.Log("[Controls] jump");
        if (IsGrounded() && input.isPressed)
        {

            myRigidbody.velocity = Vector2.up * jumpVelocity;
            timeJump = Time.time;

        }
        else
        {
            //Debug.Log(timeJump +" " + timeLimitJump + " " + " ");
            if (timeJump + timeLimitJump > Time.time)
            {
                Debug.Log("[Controls] Small Jump");
                myRigidbody.velocity += Vector2.down * jumpVelocity/2;
            }
        }
        
    }
    public void OnYellow(InputValue input)
    {
        ColorChange(input, ColorType.Yellow);
    }
    public void OnBlue(InputValue input)
    {
        ColorChange(input, ColorType.Blue);
    }
    public void OnRed(InputValue input)
    {
        ColorChange(input, ColorType.Red);
    }
    public void OnGreen(InputValue input)
    {
        ColorChange(input, ColorType.Green);
    }
    private void ColorChange(InputValue input, ColorType colorToChange) 
    {
        if (input.isPressed)
        {
            colorType = colorToChange;
            controlsColorNumber++;
        }
        else
        {
            controlsColorNumber--;
            if (controlsColorNumber == 0)
            {
                colorType = ColorType.Null;
            }
        }
        Debug.Log("[Controls] : number of color pressed = " + controlsColorNumber);
        Debug.Log("[Controls] : Actual Color Type " + colorType);
    }
}
