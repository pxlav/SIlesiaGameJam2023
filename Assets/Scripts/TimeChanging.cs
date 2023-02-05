using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeChanging : MonoBehaviour
{
    public int wichTimeStand; //0 - before 1 - after
    public float waitChangeTimer;
    public bool isChangingTime;
    public bool changingInProgress;
    public GameObject[] mapObjects; // 0 - before 1 - after
    public GameObject timeVignette;
    
    void Start()
    {
        isChangingTime = false;
        timeVignette.SetActive(false);
        waitChangeTimer = 1.0f;
        changingInProgress = false;
        if(wichTimeStand == 0)
        {
            mapObjects[0].SetActive(true);
            mapObjects[1].SetActive(false);
        }
        if(wichTimeStand == 1)
        {
            mapObjects[0].SetActive(false);
            mapObjects[1].SetActive(true);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && isChangingTime == false)
        {
            isChangingTime = true;
        }
        if(isChangingTime == true && waitChangeTimer == 1.0f)
        {
            changingInProgress = true;
        }
        if(changingInProgress == true)
        {
            ChangeTheTime();
        }
    }
    public void ChangeTheTime()
    {
         waitChangeTimer -= Time.deltaTime;
         timeVignette.SetActive(true);
            if(waitChangeTimer <= 0)
            {   
                timeVignette.SetActive(false);
                
                if(wichTimeStand == 0)
                {
                    wichTimeStand = 1;
                    waitChangeTimer = 1.0f;
                    mapObjects[0].SetActive(false);
                    mapObjects[1].SetActive(true);
                    isChangingTime = false;
                    changingInProgress = false;
                }
                else if(wichTimeStand == 1)
                {
                    wichTimeStand = 0;
                    waitChangeTimer = 1.0f;
                    mapObjects[0].SetActive(true);
                    mapObjects[1].SetActive(false);
                    isChangingTime = false;
                    changingInProgress = false;
                }
            }
    }
}
