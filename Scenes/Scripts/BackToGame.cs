using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToGame : MonoBehaviour
{

    public int PrevioussceneIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        int PreviousSceneIndex = PlayerPrefs.GetInt("PreviousScene");
    }
     public void OnButtonClick()
    {
        
        SceneManager.LoadScene(PrevioussceneIndex);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
