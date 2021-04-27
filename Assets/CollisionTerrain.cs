using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CollisionTerrain : MonoBehaviour
{
    [SerializeField] Terrain terrain;

    [SerializeField] Text text;

    string lose = "Sprobuj ponownie";
    void Start()
    {
        terrain = terrain.GetComponent<Terrain>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        text.text = lose;
        Invoke("LoadMyScene", 6);
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
