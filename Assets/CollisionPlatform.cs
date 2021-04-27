using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionPlatform : MonoBehaviour
{

    [SerializeField] Text text;
    // Start is called before the first frame update
    string win = "Brawo! Udalo Ci sie";
   
    void Start()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {

            text.text = win;
            Invoke("LoadMyScene",4);
            Debug.Log("Paczka dotarla");
            

        }

    }
    void LoadMyScene()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
