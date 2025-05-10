using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevel : MonoBehaviour
{
    public string Nextlevel = "Lev 2";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish") 
        {
            SceneManager.LoadScene(Nextlevel);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
