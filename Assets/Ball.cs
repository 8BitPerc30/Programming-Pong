using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector2 direction = Vector2.right;
    float speed = 4.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Uncomment to change direction of the ball using trigonometry
        float angle = 30.0f * Mathf.Deg2Rad;
        direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        // Homework: Prevent the ball from travelling off the screen by changing its direction

        // If the ball is too far right, make its x-direction negative (1% -- free)
        if (transform.position.x > 10.0f)
        {
            direction.x = -direction.x;
        }

        // If the ball is too far left, make its x-direction positive (1%)
        if (transform.position.x < -10.0f)
        {
            direction.x = -direction.x;
        }
        // If the ball is too far up, make its y-direction negative (1%)
        if (transform.position.y > 5.0f)
        {
            direction.y = -direction.y;
        }
        // If the ball is too far down, make its y-direction positive (1%)
        if (transform.position.y < -5.0f)
        {
            direction.y = -direction.y;
        }

        float dt = Time.deltaTime;
        Vector3 change = direction * speed * dt;
        transform.position += change;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the ball collides with "Player Two"
        if (collision.gameObject.name == "Player Two")
        {
            // Reverse direction on collision
            direction = Vector2.Reflect(direction, collision.contacts[0].normal);
        }
    }
}

// Just a heads up, this is the Ball.cs script from Blackboard so we'll have to tweak it to make it work
// The two paddle scripts allow the paddles to move up and down, but they still go off screen bc I haven't done the restriction yet
