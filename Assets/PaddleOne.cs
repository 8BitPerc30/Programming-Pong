using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PaddleOne : MonoBehaviour
{
    private float speed = 10f;
    Vector2 direction = Vector2.right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
            if (transform.position.y > screenBounds.y)
            {
                transform.position = new Vector3(transform.position.x, screenBounds.y, transform.position.z);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
            if (transform.position.y < -screenBounds.y)
            {
                transform.position = new Vector3(transform.position.x, -screenBounds.y, transform.position.z);
            }
        }
    }
}
