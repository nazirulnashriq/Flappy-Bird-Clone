using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float speed = 5;
    public float deleteZone = -19;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime;

        if (transform.position.x < deleteZone)
        {
            Debug.Log("Pipe X: " + transform.position.x
                      + ", Delete Zone: " + deleteZone);

            Destroy(gameObject);
        }
    }
}
