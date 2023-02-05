using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public float jumpTimer;
    public float jumpSpeed;
    public bool canJump;
    public bool isJumping;
    public Jumping m_jumping;
    [SerializeField]float lastFrameSpeed;
    public GameObject[] playerSidesBefore; // 0-init 1-left 2-right 3 - back
    public GameObject[] playerSidesAfter; // 0-init 1-left 2-right 3 - back
    public int wichPlayerSideBefore;
    public int wichPlayerSideAfter;
    public TimeChanging m_timeChanging;
    public GameObject playerBeforeObj;
    public GameObject playerAfterObj;
    public GameObject playerTimeChangeBefore;
    public GameObject playerNotTimeBefore;
    public GameObject playerNotTimeAfter;
    public GameObject playerTimeChangeAfter;
    public GameObject walkingAudio;

    void Start()
    {
        jumpTimer = 0.8f;
        canJump = true;
        isJumping = false;
        playerNotTimeBefore.SetActive(true);
        playerTimeChangeBefore.SetActive(false);
        playerNotTimeAfter.SetActive(true);
        playerTimeChangeAfter.SetActive(false);
        walkingAudio.SetActive(false);
    }
    const float halfPlayerWidth = 0.2f;
    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position - new Vector3(halfPlayerWidth, 1f, 0f), Vector3.down, Color.yellow);
        Debug.DrawRay(transform.position + new Vector3(halfPlayerWidth, 1f, 0f), Vector3.down, Color.yellow);
    }
    private void LateUpdate()
    {
        lastFrameSpeed = rb.velocity.y;
    }
    void Update()
    {   
        if(m_timeChanging.waitChangeTimer == 1.0f)
        {
                playerNotTimeBefore.SetActive(true);
                playerTimeChangeBefore.SetActive(false);
                playerNotTimeAfter.SetActive(true);
                playerTimeChangeAfter.SetActive(false);
        }
        if(m_timeChanging.waitChangeTimer < 1.0f)
        {
            if(m_timeChanging.wichTimeStand == 0)
            {
                playerNotTimeBefore.SetActive(false);
                playerTimeChangeBefore.SetActive(true);
            } 
            if(m_timeChanging.wichTimeStand == 1)
            {
                playerNotTimeAfter.SetActive(false);
                playerTimeChangeAfter.SetActive(true);
            } 
        }
        if(m_timeChanging.isChangingTime == false)
        {
            if(!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.W))
            {
                wichPlayerSideBefore = 0;
                wichPlayerSideAfter = 0;
                walkingAudio.SetActive(false);
            }
        if(m_timeChanging.wichTimeStand == 0)
        {
            playerBeforeObj.SetActive(true);
            playerAfterObj.SetActive(false);
            if(wichPlayerSideBefore == 0)
            {
                playerSidesBefore[0].SetActive(true);
                playerSidesBefore[1].SetActive(false);
                playerSidesBefore[2].SetActive(false);
                playerSidesBefore[3].SetActive(false);
            }
            if(wichPlayerSideBefore == 1)
            {
                playerSidesBefore[0].SetActive(false);
                playerSidesBefore[1].SetActive(true);
                playerSidesBefore[2].SetActive(false);
                playerSidesBefore[3].SetActive(false);
            }
            if(wichPlayerSideBefore == 2)
            {
                playerSidesBefore[0].SetActive(false);
                playerSidesBefore[1].SetActive(false);
                playerSidesBefore[2].SetActive(true);
                playerSidesBefore[3].SetActive(false);
            }
            if(wichPlayerSideBefore == 3)
            {
                playerSidesBefore[0].SetActive(false);
                playerSidesBefore[1].SetActive(false);
                playerSidesBefore[2].SetActive(false);
                playerSidesBefore[3].SetActive(true);
            }
            if(Input.GetKeyDown(KeyCode.A))
            {
                wichPlayerSideBefore = 1;
                walkingAudio.SetActive(true);
            }
            if(Input.GetKeyDown(KeyCode.D))
            {
                walkingAudio.SetActive(true);
                wichPlayerSideBefore = 2;
            }
            if(Input.GetKeyDown(KeyCode.W))
            {
                wichPlayerSideBefore = 3;
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                walkingAudio.SetActive(true);
                wichPlayerSideBefore = 1;
            }
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                walkingAudio.SetActive(true);
                wichPlayerSideBefore = 2;
            }
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                wichPlayerSideBefore = 3;
            }
        }
        if(m_timeChanging.wichTimeStand == 1)
        {
            playerBeforeObj.SetActive(false);
            playerAfterObj.SetActive(true);
            if(wichPlayerSideAfter == 0)
            {
                playerSidesAfter[0].SetActive(true);
                playerSidesAfter[1].SetActive(false);
                playerSidesAfter[2].SetActive(false);
                playerSidesAfter[3].SetActive(false);
            }
            if(wichPlayerSideAfter == 1)
            {
                playerSidesAfter[0].SetActive(false);
                playerSidesAfter[1].SetActive(true);
                playerSidesAfter[2].SetActive(false);
                playerSidesAfter[3].SetActive(false);
            }
            if(wichPlayerSideAfter == 2)
            {
                playerSidesAfter[0].SetActive(false);
                playerSidesAfter[1].SetActive(false);
                playerSidesAfter[2].SetActive(true);
                playerSidesAfter[3].SetActive(false);
            }
            if(wichPlayerSideAfter == 3)
            {
                playerSidesAfter[0].SetActive(false);
                playerSidesAfter[1].SetActive(false);
                playerSidesAfter[2].SetActive(false);
                playerSidesAfter[3].SetActive(true);
            }
            if(Input.GetKeyDown(KeyCode.A))
            {
                wichPlayerSideAfter = 1;
                walkingAudio.SetActive(true);
            }
            if(Input.GetKeyDown(KeyCode.D))
            {
                wichPlayerSideAfter = 2;
                walkingAudio.SetActive(true);
            }
            if(Input.GetKeyDown(KeyCode.W))
            {
                wichPlayerSideAfter = 3;
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                wichPlayerSideAfter = 1;
                walkingAudio.SetActive(true);
            }
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                wichPlayerSideAfter = 2;
                walkingAudio.SetActive(true);
            }
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                wichPlayerSideAfter = 3;
            }
        }
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false && m_jumping.canJump == true)
        {
            rb.velocity = new Vector2(0, jumpSpeed);
        }
        /*
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            isJumping = true;
            var hitLeft = Physics2D.Raycast(transform.position - new Vector3(halfPlayerWidth, 1f, 0f), Vector2.down, 1f);
            var hitRight = Physics2D.Raycast(transform.position + new Vector3(halfPlayerWidth, 1f, 0f), Vector2.down, 1f);

            if (hitLeft || hitRight)
            {
                isJumping = false;
                rb.velocity = new Vector2(0, jumpSpeed);
            }
        }
        */
        }
    }
}

