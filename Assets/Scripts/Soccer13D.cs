using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Soccer13D : MonoBehaviour
{
    public void delay() {
      StartCoroutine(Soccer13Transition());
    }

    public IEnumerator Soccer13Transition()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Soccer13");
    }
}
