using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPull : MonoBehaviour
{
    public GameObject objectToPushPull;
    public Transform playerParent;
    public Transform worldParent;
    [SerializeField] bool canPushPull;
    void Update()
    {
        if(objectToPushPull == null)
        {
            canPushPull = false;
        }else
        {
            canPushPull = true;
        }
        if(canPushPull == true && Input.GetKeyDown(KeyCode.E))
        {
            objectToPushPull.transform.parent = playerParent.transform.parent;
        }else if(canPushPull == true && Input.GetKeyDown(KeyCode.E))
        {
            objectToPushPull.transform.parent = worldParent.transform.parent;
        }
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "PushPullObj")
        {
            objectToPushPull = other.gameObject;
            canPushPull = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {   
        if(other.tag == "PushPullObj")
        {
            objectToPushPull = null;
            canPushPull = false;
        }
    }
}
