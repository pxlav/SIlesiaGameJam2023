using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public bool isCuted;
    public GameObject[] beforeObjs;
    public GameObject[] afterObjs;
    public GameObject shovelObj;
    
    void Update()
    {
        if(isCuted == true)
        {
            beforeObjs[0].SetActive(false);
            beforeObjs[1].SetActive(true);
            afterObjs[0].SetActive(false);
            afterObjs[1].SetActive(true);
            shovelObj.SetActive(false);
        }else
        {
            beforeObjs[0].SetActive(true);
            beforeObjs[1].SetActive(false);
            afterObjs[0].SetActive(true);
            afterObjs[1].SetActive(false);
            shovelObj.SetActive(true);
        }
    }
}
