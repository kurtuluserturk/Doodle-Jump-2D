using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]   //The RequireComponent attribute automatically adds required components as dependencies.
[RequireComponent(typeof(AudioSource))]
public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    float movement = 0f;
    float movementSpeed = 10f;
    public AudioClip jumpSoundClip;
    AudioSource jumpSoundSource;
    float mapWidth = 5.5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpSoundSource = GetComponent<AudioSource>();
    }            
    void FixedUpdate()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        Vector2 velocity = rb.velocity;         
        velocity.x = movement;         
        rb.velocity = velocity;
        //Aşağıdaki kod ile Player hareketini yatayda sınırlandırıyoruz 
        Vector2 newPosition = rb.position;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, +mapWidth);
        rb.position = newPosition;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Platform")
        {
            jumpSoundSource.PlayOneShot(jumpSoundClip);
        }        
    }
}