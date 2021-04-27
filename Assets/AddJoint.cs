using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddJoint : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject Line;

    private bool isDropping;

    Rigidbody rb;
    void Start()
    {
        rb = Line.GetComponent<Rigidbody>();
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Line") && !isDropping)
        {
            gameObject.AddComponent<FixedJoint>();
            gameObject.GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
            collision.rigidbody.isKinematic = true;
            isDropping = false;
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        ReleasePackage();
    }

    private void ReleasePackage()
    {
        if (Input.GetKeyDown(KeyCode.R) && gameObject.GetComponent<FixedJoint>())
        {
            Destroy(GetComponent<FixedJoint>());
            Destroy(Line);
            isDropping = true;
        }
    }
}
