using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particules : MonoBehaviour
{
    //public Vector3 gravity, velocity;
    //public Vector3 gravity, velocity;
    float FORCE_OF_GRAVITY = 9.8F;
    public Collider[] neighbors;
    public float h;
    public Vector3 speed;

    // Start is called before the first frame update
    void Start()
    {
       // gravity = new Vector3(0, FORCE_OF_GRAVITY*(-1), 0);
    }

    public void Border()
    {
        if (transform.position.y <= -5)
            transform.position = new Vector3(transform.position.x, -4.9f, transform.position.z);
        if (transform.position.y >= 5)
            transform.position = new Vector3(transform.position.x, 4.9f, transform.position.z);

        if (transform.position.x <= -10)
            transform.position = new Vector3(-9.9f, transform.position.y, transform.position.z);
        if (transform.position.x >= 10)
            transform.position = new Vector3(9.9f, transform.position.y, transform.position.z);

        if (transform.position.z <= -4)
            transform.position = new Vector3(transform.position.x, transform.position.y, -3.9f);
        if (transform.position.z >= 4)
            transform.position = new Vector3(transform.position.x, transform.position.y, 3.9f);
    }
    public void CheckNeighbors()
    {
        neighbors = Physics.OverlapSphere(transform.position, h);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed;
        Border();
    }
}