using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPfGamePlay : MonoBehaviour
{   
    public GameObject endObj;
    public bool isTaken;
    public bool isKurwagit;
    public GameObject[] klatkiEndingu;
    public float endingTImer;

    void Start()
    {
        endObj.SetActive(false);
    }
    private void Update()
    {
        if(isTaken == true)
        {
            endObj.SetActive(true);
            endingTImer += Time.deltaTime;
            if(endingTImer > 25)
            {
                Application.LoadLevel(0);
            }
        }
    }
}
