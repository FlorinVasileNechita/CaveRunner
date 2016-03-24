using System;
using UnityEngine;


    public class PlatformerCharacter2D : MonoBehaviour
    {
        [SerializeField] private float m_MaxSpeed = 10f;                    // The fastest the player can travel in the x axis.
        [SerializeField] private float m_JumpForce = 400f;                  // Amount of force added when the player jumps.
        [SerializeField] private bool m_AirControl = false;                 // Whether or not a player can steer while jumping;
        [SerializeField] private LayerMask m_WhatIsGround;                  // A mask determining what is ground to the character

        private Transform m_GroundCheck;    // A position marking where to check if the player is grounded.
        const float k_GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
        private bool m_Grounded;            // Whether or not the player is grounded.
    
              // Reference to the player's animator component.
        private Rigidbody2D m_Rigidbody2D;
       
         bool doubleJump = false;
        private void Awake()
        {
            // Setting up references.
            m_GroundCheck = transform.Find("GroundCheck");
            m_Rigidbody2D = GetComponent<Rigidbody2D>();
        }


        private void FixedUpdate()
        {
            m_Grounded = false;

            // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
            // This can be done using layers instead but Sample Assets will not overwrite your project settings.
            Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i].gameObject != gameObject)
                    m_Grounded = true;
                    
            }

        if (m_Grounded)
        {
            doubleJump = false;

        }
      
        }


        public void Move(float move, bool crouch, bool jump)
        {
         
           

            //only control the player if grounded or airControl is turned on
            if (m_Grounded || m_AirControl)
            {
                      

                // Move the character
                m_Rigidbody2D.velocity = new Vector2(move*m_MaxSpeed, m_Rigidbody2D.velocity.y);

       
            }
            // If the player should jump...
            if ((m_Grounded || !doubleJump) && jump)
            {
                // Add a vertical force to the player.
                m_Grounded = false;

            m_Rigidbody2D.velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);
                m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
            if (!m_Grounded)
            {
                doubleJump = true;
            }
          
            }
        }


  
    }

