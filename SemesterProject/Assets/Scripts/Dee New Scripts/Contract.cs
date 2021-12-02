using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Contract : MonoBehaviour
{
  
    public GameObject textMeshpro;
    public GameObject button;

    public void Start()
    {
        button.SetActive(false);
    }

    public void Update()
    {
        CreateAName();
    }
    public void CreateAName()
    {
        string newName =  textMeshpro.GetComponent<TMP_InputField>().text;
        
        ;
        if (!string.IsNullOrWhiteSpace(newName))
        {
            button.SetActive(true);
        }
        else
        {
           
        }
    }
}
