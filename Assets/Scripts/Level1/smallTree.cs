using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallTree : MonoBehaviour
{
    public Tree m_tree;
    public PushPull m_pushPull;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "PushPullObj")
        {
            m_pushPull.isTaken = false;
            m_pushPull.takingObj = null;
            m_tree.isCuted = true;
        }
    }
}
