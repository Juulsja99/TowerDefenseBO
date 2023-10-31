using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySword : MonoBehaviour
{
    public AudioSource attack;

    public void playSound()
    {
        attack.Play();
    }
}
