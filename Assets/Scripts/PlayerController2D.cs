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
    public GameObject[] playerSides; // 0-init 1-left 2-right
    public int wichPlayerSide;

    void Start()
    {
        jumpTimer = 0.8f;
        canJump = true;
        isJumping = false;
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
        if(!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            wichPlayerSide = 0;
        }
        if(wichPlayerSide == 0)
        {
            playerSides[0].SetActive(true);
            playerSides[1].SetActive(false);
            playerSides[2].SetActive(false);
        }
        if(wichPlayerSide == 1)
        {
            playerSides[0].SetActive(false);
            playerSides[1].SetActive(true);
            playerSides[2].SetActive(false);
        }
        if(wichPlayerSide == 2)
        {
            playerSides[0].SetActive(false);
            playerSides[1].SetActive(false);
            playerSides[2].SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            wichPlayerSide = 1;
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            wichPlayerSide = 2;
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            wichPlayerSide = 1;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            wichPlayerSide = 2;
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

