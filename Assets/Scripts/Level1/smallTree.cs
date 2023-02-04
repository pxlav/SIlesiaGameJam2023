using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallTree : MonoBehaviour
{
    public Tree m_tree;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "PushPullObj")
        {
            m_tree.isCuted = true;
        }
    }
}
