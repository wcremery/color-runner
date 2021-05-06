using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDetector : MonoBehaviour
{
    public Transform player;
    [SerializeField] private int OFFSET = 10;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        FollowPlayer();
    }
    public void UpdateY()
    {
        transform.position = new Vector3(transform.position.x, player.position.y-OFFSET, transform.position.z);
    }
    private void FollowPlayer()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("[Recycle] Platform detected");
        GameObject collider = collision.gameObject;


    }
}
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("[Recycle] Platform detected");
    //    GameObject collider = collision.gameObject;
    //    toRecycle.Add(collider);
    //}
