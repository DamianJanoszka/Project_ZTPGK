using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    LineRenderer line;
    private bool isExpandingOn;
    private bool isRollingUp;
    private bool pickUp = false;
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        TurnOnExpandingRope();
        ExpandRope();
        PickUp();
        //Debug.Log(gameObject.transform.localScale == new Vector3(0, 0, 0));
    }

    private void ExpandRope()
    {
        if (isExpandingOn)
        {
            gameObject.transform.localScale += new Vector3(0, 0, 10f * Time.deltaTime);
        }
        else if (isRollingUp)
        {
            gameObject.transform.localScale += new Vector3(0, 0, -5f * Time.deltaTime);

            if (gameObject.transform.localScale.z < 0.1f)
            {
                isRollingUp = false;
                pickUp = false;
            }
        }

    }

    private void TurnOnExpandingRope()
    {
        if (Input.GetKeyDown(KeyCode.E) && !pickUp)
        {
            isExpandingOn = !isExpandingOn;
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        isExpandingOn = false;
        isRollingUp = true;

        Debug.Log("Hitttt");
        if (collision.gameObject.CompareTag("Box"))
        {
            isRollingUp = false;
            pickUp = true;
        }

    }

    private void PickUp()
    {
        if(pickUp && transform.localPosition.y < 35f)
        {
            if(gameObject.CompareTag("Line1"))
            {
                isRollingUp = true;
            }
            else if(gameObject.CompareTag("Line"))
            {
                gameObject.transform.localPosition += new Vector3(0, 5f * Time.deltaTime, 0);
            }
            
            
        }
    }



}
