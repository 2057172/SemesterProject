using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay_beginning : MonoBehaviour
{
    public GameObject tutorial;

    void Start()
    {
        tutorial.SetActive(true);
        StartCoroutine(timePopUp());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public IEnumerator timePopUp() {

        yield return new WaitForSeconds(7);
        tutorial.SetActive(false);
    }
}
