using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovetoLibrary : MonoBehaviour
{
    public void OnMouseUpAsButton()
    {
        Debug.Log("Button Clicked");
       SceneManager.LoadScene("Library");
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
