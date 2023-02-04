using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastLevelKey : MonoBehaviour
{
    public EndPfGamePlay m_endOfGameplay;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            m_endOfGameplay.isTaken = true;
            Destroy(this.gameObject);
        }
    }
}
