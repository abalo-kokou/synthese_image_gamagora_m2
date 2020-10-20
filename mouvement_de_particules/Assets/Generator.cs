using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject cube;
    public int min, max, numberOfCubes;
    public Vector3 gravity, velocity;
    protected List<GameObject> listeOfCubes = new List<GameObject>();
    int x, y;

    // Start is called before the first frame update
    void Start()
    {
        PlaceCubes();
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var cube in listeOfCubes)
        {
            x = Random.Range(-10, 10);
            y = Random.Range(-10, 10);
            velocity = new Vector3(x, y, 0);
            cube.transform.position += velocity * Time.deltaTime;

            //if (cube.transform.position.y < 0) cube.transform.position
        }
    }

    Vector3 GeneratedPosition()
    {
        int x, y, z;
        x = Random.Range(min, max);
        y = Random.Range(min, max);
        z = Random.Range(min, max);
        return new Vector3(x, y, z);
    }
    void PlaceCubes()
    {
        for (int i = 0; i < numberOfCubes; i++)
        {
            // Instantiate(cube, GeneratedPosition(), Quaternion.identity);
            listeOfCubes.Add(Instantiate(cube, GeneratedPosition(), Quaternion.identity));
        }
    }
}


