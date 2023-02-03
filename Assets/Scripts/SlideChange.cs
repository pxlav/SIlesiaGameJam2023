using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideChange : MonoBehaviour
{
    public float slideTimer;
    public GameObject slides;
    public GameObject bckgObj;
    public GameObject[] listObj;
    public int wichSlide;
    
    void Start()
    {
        listObj[0].SetActive(false);
        listObj[1].SetActive(false);
        bckgObj.SetActive(true);
    }

    void Update()
    {
        
        slideTimer += Time.deltaTime;
        if(slideTimer > 11)
        {
            slides.SetActive(false);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                wichSlide ++;
            }
            if(wichSlide == 0)
            {
                listObj[0].SetActive(true);
                listObj[1].SetActive(false);
            }
            if(wichSlide == 1)
            {
                listObj[0].SetActive(false);
                listObj[1].SetActive(true);
            }
            if(wichSlide == 2)
            {
                listObj[0].SetActive(false);
                listObj[1].SetActive(false);
                bckgObj.SetActive(false);

            }
            
        }
    }
}
