using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private LayerMask platformsLayerMask;
    [SerializeField] private LayerMask deathLayerMask;
    public new Rigidbody2D rigidbody;
    public BoxCollider2D boxCollider2D;
    public GameManager gameManager;
    private float jumpVelocity = 6f;
    private float moveSpeed =1f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.up * jumpVelocity;
        }
        rigidbody.velocity = new Vector2(moveSpeed, rigidbody.velocity.y);
        
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
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size*0.9f, 0f, Vector2.right, 0.10f, platformsLayerMask);
        Debug.DrawLine(gameObject.transform.position, raycastHit2D.point, Color.green, 100f);
        return raycastHit2D.collider != null;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (IsAgainstWallRight() || IsOnDeath())
        {
            gameManager.GameOver();
        }
    }
}
