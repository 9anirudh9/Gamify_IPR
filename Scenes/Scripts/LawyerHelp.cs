using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LawyerHelp : MonoBehaviour
{
    // Start is called before the first frame update
    public int PrevioussceneIndex;
    public void NextScene()
    {
        PrevioussceneIndex  = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("PreviousScene", PrevioussceneIndex);
        SceneManager.LoadScene("AIhelpDesk");
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
