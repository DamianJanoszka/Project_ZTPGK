using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLine : MonoBehaviour
{

    float rising = 1;
    LineRenderer lineRenderer;
    Vector3 down;
    Vector3[] positions;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();


        Vector3[] positions = { Vector3.zero, new Vector3(0, 0, 1) };
        lineRenderer.SetPositions(positions);
        Debug.Log(positions);
    }

    // Update is called once per frame
    void Update()
    {
        rising += 0.001f;
        down = new Vector3(0, 0, 10);

        //Vector3[] positions = { Vector3.zero, new Vector3(0, 0, rising) };
        // lineRenderer.SetPositions(positions);


        Debug.Log(positions);
        
    }
}
