using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellicopterControl : MonoBehaviour
{
    [SerializeField] float controlSpeed = 16f;

    
    float xThrow;
    float yThrow;
    float nowy;
    float nowy2;

    Rigidbody rb;

    [SerializeField] float pitchFactor = -2f;
    [SerializeField] float pitchFactorThrow = 10f;


    [SerializeField] float rollFactorThrow = -15f;

    [SerializeField] float yawFactor = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Translation();
    }

    void Translation()
    {
        xThrow = Input.GetAxis("Horizontal");
        yThrow = Input.GetAxis("Vertical");

        rb.AddRelativeForce(new Vector3(xThrow*1.5f, 0, yThrow*1.5f));
        nowy2 += xThrow/5f ;

        transform.localRotation = Quaternion.Euler(pitchFactor + yThrow /2 * pitchFactorThrow, nowy2, xThrow * rollFactorThrow );
        
    }



    
}
