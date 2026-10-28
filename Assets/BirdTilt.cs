
using UnityEngine;

public class BirdTilt : MonoBehaviour
{
    public Rigidbody2D rb;
    public float tiltSpeed = 5f;
    public float fallTiltSpeed = 0.2f;
    public float maxUpAngle = 30f;
    public float maxDownAngle = -90f;

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }

    void Update()
    {
        float targetAngle;

        float currentTiltSpeed;

        if (rb.linearVelocity.y > 0)
        {
            targetAngle = maxUpAngle;
            currentTiltSpeed = tiltSpeed;
        }
        else
        {
            targetAngle = maxDownAngle;
            currentTiltSpeed = fallTiltSpeed;
        }

        float angle = Mathf.LerpAngle(
            transform.eulerAngles.z,
            targetAngle,
            currentTiltSpeed * Time.deltaTime
        );

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
