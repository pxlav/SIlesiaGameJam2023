using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPull : MonoBehaviour
{
    public GameObject takingObj;
    public Transform handParent;
    public Transform worldParent;
    public BoxCollider2D objCollision;
    public bool isTaken;

    void Update()
    {
        if(takingObj != null && Input.GetKeyDown(KeyCode.E) && isTaken == false)
        {
            isTaken = true;
        }
        else if(isTaken == true && Input.GetKeyDown(KeyCode.E))
        {
            isTaken = false;
        }
        if(takingObj != null)
        {
        if(isTaken == true)
        {   
            objCollision.isTrigger = true;
            takingObj.transform.parent = handParent.transform.parent;
            takingObj.transform.position = handParent.transform.position;
            isTaken = true;
        }else
        {
            objCollision.isTrigger = false;
            takingObj.transform.parent = worldParent.transform.parent;
            isTaken = false;
        }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "PushPullObj")
        {
            takingObj = other.gameObject;
            objCollision = other.GetComponent<BoxCollider2D>();
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "PushPullObj")
        {
            //takingObj = null;
        }
    }
}
