using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject cube;
    public int min, max, numberOfCubes;
    public Vector3 gravity, velocity;
    [Range(0f, 2f)]
    public float h = 1f;
    //protected List<GameObject> listeOfCubes = new List<GameObject>();
    private GameObject[] tabOfCubes;
    int x, y;
    //public Vector3 gravity = new Vector3(0, -9.8f, 0);

    // Start is called before the first frame update
    void Start()
    {
        PlaceCubes();
        gravity = new Vector3(0, -9.8f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        //foreach (var cube in listeOfCubes)
        //{
        //    x = Random.Range(-10, 10);
        //    y = Random.Range(-10, 10);
        //    velocity = new Vector3(x, y, 0);
        //    cube.transform.position += velocity * Time.deltaTime;
        //    if (cube.transform.position.y < 0) 
        //    { cube.transform.position = new Vector3(0, 0, 0); }
        //}

        foreach (GameObject c in tabOfCubes)
        {
            Particules cObject = c.GetComponent<Particules>();
            cObject.speed += Time.deltaTime * gravity;
            cObject.CheckNeighbors();
            Debug.Log("cObject.speed " + cObject.speed);
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
        tabOfCubes = new GameObject[numberOfCubes];
        for (int i = 0; i < numberOfCubes; i++)
        {
            // Instantiate(cube, GeneratedPosition(), Quaternion.identity);
            tabOfCubes[i] = Instantiate(cube, GeneratedPosition(), Quaternion.identity);
            tabOfCubes[i].GetComponent<Particules>().h = h;
        }
    }
}


