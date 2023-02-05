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
    public GameObject pressEObj;

    void Start()
    {
        pressEObj.SetActive(false);
    }

    void Update()
    {
        if(takingObj != null && Input.GetKeyDown(KeyCode.E) && isTaken == false)
        {
            isTaken = true;
        }
        else if(isTaken == true && Input.GetKeyDown(KeyCode.E))
        {
            isTaken = false;
            takingObj = null;
        }
        if(takingObj != null)
        {
        if(isTaken == true)
        {   
            objCollision.isTrigger = true;
            takingObj.transform.parent = handParent.transform.parent;
            takingObj.transform.position = handParent.transform.position;
            isTaken = true;
            pressEObj.SetActive(false);
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
        if(other.tag == "PushPullObj" && isTaken == false)
        {
            takingObj = other.gameObject;
            pressEObj.SetActive(true);
            objCollision = other.GetComponent<BoxCollider2D>();
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "PushPullObj" && isTaken == false)
        {
            takingObj = null;
            pressEObj.SetActive(false);
        }
    }
}
