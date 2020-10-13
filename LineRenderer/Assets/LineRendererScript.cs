using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererScript : MonoBehaviour
{
    public LineRenderer lnR; //This will be available in the inspector
    float length;
    Vector3 startPoint;
    // Start is called before the first frame update
    void Start()
    {
        lnR = gameObject.GetComponent<LineRenderer>();
        startPoint = lnR.GetPosition(0);
    }

    // Update is called once per frame
    void Update()
    {
        lnR = gameObject.GetComponent<LineRenderer>();

        //GET TARGET POSITION
        Vector3 target = GameObject.Find("goal").transform.position;

        length = (lnR.GetPosition(lnR.positionCount - 1) - lnR.GetPosition(lnR.positionCount - 2)).magnitude; // The magnitude Returns the length of a vector
                                                                                                              // distance between the vector's origin (0,0,0) and its endpoint
        lnR.SetPosition(lnR.positionCount - 1, target);

        for (int i = lnR.positionCount - 2; i >= 0; i--)
        {
            Vector3 before_last;
            before_last = (lnR.GetPosition(i) - lnR.GetPosition(i + 1)).normalized * length;
            Vector3 newtarget = lnR.GetPosition(i + 1) + before_last;
            lnR.SetPosition(i, newtarget);
        }

        Vector3 translate = (startPoint - lnR.GetPosition(0)).normalized * (lnR.GetPosition(0) - startPoint).magnitude;

        for (int i = 0; i < lnR.positionCount; i++)
        {
            lnR.SetPosition(i, lnR.GetPosition(i) + translate);
        }
        //Debug.Log(Input.mousePosition / 1000);

    }
}