using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particules : MonoBehaviour
{
    public Vector3 gravity, velocity;
    float FORCE_OF_GRAVITY = 9.8F;

    // Start is called before the first frame update
    void Start()
    {
        gravity = new Vector3(0, FORCE_OF_GRAVITY*(-1), 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += gravity*Time.deltaTime;
    }
}