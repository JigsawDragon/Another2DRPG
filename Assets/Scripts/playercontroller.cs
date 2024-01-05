using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public static playercontroller instance;
    public float speed;
    public Rigidbody2D rb;
    Vector2 velocity;
    public Animator anim;
    public float animatorspeedmultiplier;

    public int direction;

    public KeyCode InteractKey;
    public bool ispressinginteract;

    public NPC CurrentNPC;


    public void setNPC(NPC C)
    {
        CurrentNPC = C;
    }


    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction = 1;
            velocity.y = speed;
            anim.SetInteger("State", 2);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction = 0;
            velocity.y = -speed;
            anim.SetInteger("State", 1);
        }
        else
            velocity.y = 0;

        if (Input.GetKey(KeyCode.D))
        {
            direction = 3;
            velocity.x = speed;
            anim.SetInteger("State", 4);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            direction = 2;
            velocity.x = -speed;
            anim.SetInteger("State", 3);
        }
        else
            velocity.x = 0;

        if (Input.GetKey(InteractKey))
        {
            ispressinginteract = true;
        }
        else
        {
            ispressinginteract = false;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(CurrentNPC != null)
            {
                CurrentNPC.ContinueText();

            }
        }

        if (rb.velocity == Vector2.zero)
        {
            if(direction == 0)
            {
                anim.SetInteger("State", 5);
            }
            if (direction == 1)
            {
                anim.SetInteger("State", 6);
            }
            if (direction == 2)
            {
                anim.SetInteger("State", 7);
            }
            if (direction == 3)
            {
                anim.SetInteger("State", 8);
            }


        }
        else
        {
            anim.speed = rb.velocity.magnitude * animatorspeedmultiplier;

        }
        
        if(velocity.y > 0 || velocity.y < 0)
        {
            if(velocity.x > 0 || velocity.x < 0)
            {
                velocity.x = velocity.x / 1.5f;
                velocity.y = velocity.y / 1.5f;
            }

            
        }

        rb.velocity = velocity;
    }
}
