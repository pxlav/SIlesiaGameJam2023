using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public bool isOn;
    [SerializeField] GameObject menuObj;
    void Update()
    {
        if(isOn == true)
        {
            menuObj.SetActive(true);
            Time.timeScale = 0;
        }
        if(isOn == false)
        {
            menuObj.SetActive(false);
            Time.timeScale = 1;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isOn = !isOn;
        }
    }
    public void PlayButton()
    {
        isOn = false;
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
