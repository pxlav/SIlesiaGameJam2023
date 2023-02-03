using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScreen : MonoBehaviour
{
    public int isViewed;
    public GameObject tutorialScreen;
    [SerializeField]bool[] isButtonClicked;

    void Start()
    {
        tutorialScreen.SetActive(true);
    }
    void Update()
    {
        if(isViewed == 0)
        {
            if(Input.GetKeyDown(KeyCode.A))
            {
                isButtonClicked[0] = true;
            }
            if(Input.GetKeyDown(KeyCode.D))
            {
                isButtonClicked[1] = true;
            }
            if(Input.GetKeyDown(KeyCode.Space))
            {
                isButtonClicked[2] = true;
            }
        }else
        {
            tutorialScreen.SetActive(false);
        }
        if(isButtonClicked[0] == true && isButtonClicked[1] == true && isButtonClicked[2] == true && isViewed == 0)
        {
            isViewed = 1;
        }
    }
}
