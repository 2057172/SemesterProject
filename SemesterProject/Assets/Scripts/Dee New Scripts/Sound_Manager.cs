using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manager : MonoBehaviour
{
    public AudioSource rocketSound;
    public AudioSource buttonSound;
    public AudioSource warningSound;
    public AudioSource orderPostiveSound;
    public AudioSource purchasePositiveSound;
    public AudioSource musicSound;
    public AudioSource negativeSound;

    public void rocket()
    {
        rocketSound.Play();
    }

    public void button()
    {
        buttonSound.Play();
    }

    public void warning()
    {
        warningSound.Play();
    }

    public void orderPositive()
    {
        orderPostiveSound.Play();
    }

    public void purchasePositive()
    {
        purchasePositiveSound.Play();
    }

    public void music()
    {
        musicSound.Play();
    }

    public void negative()
    {
        negativeSound.Play();
    }
}
