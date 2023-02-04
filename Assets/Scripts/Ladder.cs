using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public GameObject playerObj;
    [SerializeField] bool isTouchingPlayer;
    public Rigidbody2D playerRig;

    //public GameObject frontLeftRightPlayer;
    //public GameObject backPlayer;

    private void Start()
    {
        //backPlayer.SetActive(false);
        //frontLeftRightPlayer.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isTouchingPlayer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isTouchingPlayer = false;

        }
    }
    private void Update()
    {
        if(isTouchingPlayer == true)
        {
            Climbing(1.5f);
        }else
        {
            playerRig.gravityScale = 1;
            //backPlayer.SetActive(false);
            //frontLeftRightPlayer.SetActive(true);
        }
    }
    void Climbing(float speed)
    {
        if(Input.GetKey(KeyCode.W))
        {
            playerRig.velocity = new Vector2(0, speed);
            //backPlayer.SetActive(true);
            //frontLeftRightPlayer.SetActive(false);
        }else
        {
            //backPlayer.SetActive(false);
            //frontLeftRightPlayer.SetActive(true);
        }
    }

}
