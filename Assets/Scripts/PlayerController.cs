using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public Rigidbody2D rb;
    public int jumpForce = 25;
    public bool isOnGround = true;
    public float gravityModifier;
    public bool hasPowerup = false; 
    private bool jumpHigh; 
    private bool destroyEnemy;

    delegate void PowerupDelegate();
    PowerupDelegate powerupDelegate; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {
        KeepInBounds(); 
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed); 
        if (Input.GetKeyDown(KeyCode.UpArrow) && isOnGround)
        {
             rb.AddForce(Vector2.up *jumpForce, ForceMode2D.Impulse);
             isOnGround = false;
         }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        isOnGround = true;
    }

    void KeepInBounds(){
        if (transform.position.x < -6)
        {
            transform.position = new Vector2(-6, transform.position.y);
        }

        if (transform.position.x > 22)
        {
            transform.position = new Vector2(22, transform.position.y);
        }
    }
}