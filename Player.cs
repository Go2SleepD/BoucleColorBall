using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpForce = 10f;

    public Rigidbody2D rb;
    private Menu m;

    public string currentColor;

    public Color colorYellow;
    public Color colorBlue;
    public Color colorRed;
    public Color colorGreen;

    public Transform groundCheck;
    public bool isGrounded;
    public LayerMask whatIsGround;

    void Start()
    {
        
        SetRandomColor();
        m = GameObject.FindGameObjectWithTag("Menu").GetComponent<Menu>();
    }

    void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.7f, whatIsGround);     //check when platform close

        if(isGrounded)      //check on platform or not
        {
            GetComponent<Collider2D>().isTrigger = false;       //turn off Trigger, when platform close
        }
        else
        {
            GetComponent<Collider2D>().isTrigger = true;        //turn off, when far
        }
    }
     void colorSet(Color colorName)
    {
        GetComponent<Renderer>().material.color = colorName;      //set color
        GetComponent<TrailRenderer>().startColor = colorName;     //set trail color
    }

    void SetRandomColor()
    {
        string oldcolor = currentColor;     //var for non-repeat color switch
        while (currentColor == oldcolor)        //if last color = new color -> new random
        {
            int index = Random.Range(0, 4);
            switch (index)
            {
                case 0:
                    currentColor = "Yellow";        //set tag of color
                    colorSet(colorYellow);
                    break;
                case 1:
                    currentColor = "Red";
                    colorSet(colorRed);
                    break;
                case 2:
                    currentColor = "Blue";
                    colorSet(colorBlue);
                    break;
                case 3:
                    currentColor = "Green";
                    colorSet(colorGreen);
                    break;
            }
        }
    }

    void OnTriggerEnter2D (Collider2D col)      //check with which obj ball collides
    {
        switch (col.tag)
        {
            case ("ColorChanger"):      //if it's color changer
                SetRandomColor();
                Destroy(col.gameObject);
                break;

            case ("ColorChangerNonDead"):       //if it's multi use color changer
                SetRandomColor();
                break;

            case ("Win"):       //if it's win circle
                SceneManager.LoadScene("Win");
                break;

            default:        //else cases
                if (col.tag != currentColor)
                m.GameOver();
                break;
        }
        
    }

}

