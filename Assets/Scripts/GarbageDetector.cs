using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageDetector : MonoBehaviour
{
    private List<GameObject> toRecycle;
    public Transform player;
    [SerializeField]private int OFFSET = 10;
    // Start is called before the first frame update

    void Start()
    {
        toRecycle = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i< toRecycle.Count; i++)
        {
            //Debug.Log("[Recycle] Starting to look list, number = "+ toRecycle.Count);
            GameObject entity = toRecycle[i];
             Debug.Log(entity.name + " is visible = " + entity.GetComponent<Renderer>().isVisible);
            //WARNING Not working when in EDITOR
            if (!entity.GetComponent<Renderer>().isVisible)
            {
                Debug.Log("[Recycle] Recycling object ");
                
                Recycle(entity);
                toRecycle.RemoveAt(i);
            }

        }
        FollowPlayer();
    }
    private void FollowPlayer()
    {
        transform.position = new Vector3(player.position.x-OFFSET, 0, transform.position.z);
    }
    private void Recycle(GameObject entity)
    {
        //TODO Real recycling, because we are sooo green
        Destroy(entity);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("[Recycle] Platform detected");
        GameObject collider = collision.gameObject;
        toRecycle.Add(collider);

    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("[Recycle] Platform detected");
    //    GameObject collider = collision.gameObject;
    //    toRecycle.Add(collider);
    //}
}
