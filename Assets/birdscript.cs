using UnityEngine;
using UnityEngine.InputSystem;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D BirdRigidBody;
    public int jump_strength = 6;
    public LogicScript logic;

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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isDead = true;
    }
}
