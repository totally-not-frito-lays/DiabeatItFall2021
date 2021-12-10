using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSFX : MonoBehaviour
{
    public AudioSource SFX;

    public void playFX() {
      SFX.Play();
    }
}
