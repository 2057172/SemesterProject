using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuandQuitFunction : MonoBehaviour
{
    public GameObject mainMenuAsk;
    public GameObject quitAsk;
    public GameObject howToPlayAsk;
    public GameObject orderScreenGO;

    void Start()
    {
        orderScreenGO.SetActive(false);
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

    public void orderScreen()
    {
        orderScreenGO.SetActive(true);
    }
}
