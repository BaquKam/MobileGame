using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        velocity = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, velocity, speed * Time.deltaTime);
        print(velocity);
    }

    public void MoveLeft()
    {
        if(velocity.x > -1)
        {
            velocity += Vector3.left;
        }
    }
    public void MoveRight()
    {
        if (velocity.x < 1)
        {
            velocity += Vector3.right;
        }
    }

}
