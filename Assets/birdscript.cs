using UnityEngine;
using UnityEngine.InputSystem;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D BirdRigidBody;
    public int jump_strength = 6;
    public LogicScript logic;

    public AudioSource jumpSound;

    public AudioSource squawkSound;

    public bool isDead = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead && Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Flap();
        }
    }
    private void Flap()
    {
        BirdRigidBody.linearVelocity = Vector2.up * jump_strength;
        GetComponent<Animator>().SetTrigger("Flap");
        jumpSound.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead)
        {
            return;
        }

        logic.gameOver();
        isDead = true;
        squawkSound.Play();
    }
}
