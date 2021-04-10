using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Layers Masks")]
        [SerializeField]private LayerMask platformsLayerMask;
        [SerializeField] private LayerMask deathLayerMask;
    public Rigidbody2D myRigidbody;
    public BoxCollider2D boxCollider2D;
    public Animator animator;
    public GameManager gameManager;
    private float jumpVelocity = 6f;
    private float moveSpeed =1f;
    private bool run = false;
    public ColorType colorType;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (run)
        {
            if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
            {
                myRigidbody.velocity = Vector2.up * jumpVelocity;
            }
            myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);
        }
        
    }
    private void StartRunning()
    {
        run = true;
        animator.SetBool("Run", run);
    }
    private bool IsOnDeath()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, deathLayerMask);
        Debug.DrawLine(gameObject.transform.position, raycastHit2D.point, Color.green, 100f);
        return raycastHit2D.collider != null;
    }
    private bool IsGrounded()
    {
       RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, platformsLayerMask);
        Debug.DrawLine(gameObject.transform.position, raycastHit2D.point, Color.green, 100f);
        return raycastHit2D.collider != null;
    }
    private bool IsAgainstWallRight()
    {
        RaycastHit2D raycastHit2D = Physics2D.Raycast(gameObject.transform.position, Vector2.right, 0.10f, platformsLayerMask);
        Debug.DrawLine(gameObject.transform.position, raycastHit2D.point, Color.green, 100f);
        return raycastHit2D.collider != null;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collider = collision.gameObject;
        if (IsAgainstWallRight() || IsOnDeath())
        {
            GameOver();
        }
        else
        {
            Platform platform = collider.GetComponent<Platform>();
            if (platform != null)
            {
                if(platform.colorType != ColorType.Null && platform.colorType != colorType)
                {
                    GameOver();
                }
            }
        }
    }

    private void GameOver()
    {
        gameManager.GameOver();
    }
    
}
