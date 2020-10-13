using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderer : MonoBehaviour
{
    public LineRenderer lineRenderer; //This will be available in the inspector
    float length;
    Vector3 startPoint;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        //startPoint = lineRenderer.GetPosition(0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
