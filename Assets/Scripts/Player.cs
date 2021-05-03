using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Header("Layers Masks")]
        [SerializeField]private LayerMask platformsLayerMask;
        [SerializeField] private LayerMask deathLayerMask;
    [Header("2D collision")]
        public Rigidbody2D myRigidbody;
        public BoxCollider2D boxCollider2D;
        public GameManager gameManager;
    [Header("Player Animation")]
        public SpriteRenderer spriteRenderer;
        public Animator animator;

    public ColorReference colorType;
    public float timeLimitJump = 0.2f;

    private float jumpVelocity = 10f;
    private float moveSpeed =6f;
    private bool run = true;
  
    private int controlsColorNumber = 0;
    private float timeJump;
    private bool smallJumpDetector = false;




    // Update is called once per frame
    void Update()
    {
        if (run)
        {
            myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);
        }
        /*if (myRigidbody.velocity.y > 0)
        {
           animator..time = desired_play_time;
            animation["MyAnimation"].speed = 0.0;
        }
        else if(myRigidbody.velocity.y < 0)
        {
            animator.SetBool("Jump", true);
        }*/
    }
    private void StartRunning()
    {
        run = true;
        animator.SetBool("Run", run);
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
        if (IsGrounded())
        {
            smallJumpDetector = false;
            animator.SetBool("Jump", false);
        }
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
                if(platform.colorType != ColorType.ColorList.Null && platform.colorType != colorType.Value)
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
        if (run && IsGrounded() && input.isPressed)
        {
            myRigidbody.velocity = Vector2.up * jumpVelocity;
            timeJump = Time.time;
            smallJumpDetector = true;
            animator.SetBool("Jump", true);
        }
        else
        {
            //Debug.Log(timeJump +" " + timeLimitJump + " " + " ");
            if (timeJump + timeLimitJump > Time.time && smallJumpDetector)
            {
                smallJumpDetector = false;
                Debug.Log("[Controls] Small Jump");
                myRigidbody.velocity += Vector2.down * jumpVelocity/2;
            }
        }
        
    }

    //FFFFFF
    public void OnYellow(InputValue input)
    {
        ColorChange(input, ColorType.ColorList.Yellow);
        //ffff00
        
        
    }
    public void OnBlue(InputValue input)
    {
        ColorChange(input, ColorType.ColorList.Blue);
        //0000FF
   
    }
    public void OnRed(InputValue input)
    {
        ColorChange(input, ColorType.ColorList.Red);
        //FF0000
    
    }
    public void OnGreen(InputValue input)
    {
        ColorChange(input, ColorType.ColorList.Green);
        //00FF00
       
    }
    private void ColorChange(InputValue input, ColorType.ColorList colorToChange) 
    {
        if (input.isPressed)
        {
            colorType.Variable.value = colorToChange;
            controlsColorNumber++;
        }
        else
        {
            controlsColorNumber--;
            if (controlsColorNumber == 0)
            {
                colorType.Variable.value = ColorType.ColorList.Null;
                
            }
        }
        Debug.Log("[Controls] : number of color pressed = " + controlsColorNumber);
        Debug.Log("[Controls] : Actual Color Type " + colorType);
        updateColor();
    }
    private void updateColor()
    {
        spriteRenderer.color = ColorType.getColor(colorType.Value);
    }
}


