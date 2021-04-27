using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{

    [SerializeField] Camera Cam1;
    [SerializeField] Camera Cam2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ToggleBetweenCameras();
    }

    private void ToggleBetweenCameras()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Cam1.enabled = !Cam1.enabled;
            Cam2.enabled = !Cam2.enabled;
        }
    }
}
