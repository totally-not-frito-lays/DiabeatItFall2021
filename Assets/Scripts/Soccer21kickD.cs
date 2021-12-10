using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soccer21kickD : MonoBehaviour
{
    public AudioSource SFX;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(kick());
    }

    public IEnumerator kick() {
      yield return new WaitForSeconds(0.05f);
      SFX.Play();
    }

}
