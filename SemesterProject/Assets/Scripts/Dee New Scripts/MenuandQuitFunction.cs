using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuandQuitFunction : MonoBehaviour
{
    public GameObject mainMenuAsk;
    public GameObject quitAsk;
    public GameObject howToPlayAsk;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void no()
    {
        mainMenuAsk.SetActive(false);
        quitAsk.SetActive(false);
        howToPlayAsk.SetActive(false);
    }
}
