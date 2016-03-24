/*
using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	public float JumpSpeed = 400.0f;
    public bool jump;
	public float raycastRange = 1f;
	public float speed;
    public float MaxSpeed;
    public bool doubleJump = false;
	  private Rigidbody2D rb;


  

    void Start()
	{
		 rb = GetComponent<Rigidbody2D>();
	}

    void isGround()
    {
    

        //TODO:
        //Funktionierende Ground abfrage


    }
    void Update()
	{
      isGround();
        Move(1, false, jump);

        if ((m_Grounded || !doubleJump) && Input.GetKeyDown("space"))
            
        {
            Jump();
        }
        

        //this.rb.velocity = new Vector3(speed, 0, 0);
        //  	Vector3 movement = new Vector3 (speed, 0.0f, 1);
        //     rb.AddForce(movement);



    }

 /*   void OnCollisionStay2D(Collision2D coll)
    {
        if (Input.GetKeyDown("space"))
        {
            Jump();

        }

    }
    
    public void Move(float move, bool crouch, bool jump)
    {
        rb.velocity = new Vector2(move *MaxSpeed, rb.velocity.y);
      

    }

    void Jump()
	{
       // rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(new Vector2(0f, JumpSpeed));
        if (!m_Grounded)
        {
            doubleJump = true;
        }
        //GetComponent<Rigidbody2D>().AddForce (rb.velocity * JumpSpeed);
    }
	


}
*/