using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.relativeVelocity.y <= 0f)   //Platforma çarpan cismin relative(göreli) hızı 0'dan küçükse {...}
        {
            Rigidbody2D rb = col.collider.GetComponent<Rigidbody2D>();      //platforma çarpan cismin rigidbody'sini aldık
            Vector2 velocity = rb.velocity;
            velocity.y = jumpForce;
            rb.velocity = velocity;            
        }                 
    }        
}
