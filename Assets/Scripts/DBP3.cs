using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DBP3 : MonoBehaviour
{
  public void pressedDelay()
  {
      StartCoroutine(sceneThreeTransition());
  }

  public void sceneThreeTransitionNoDelay() {
    SceneManager.LoadScene("DBP3");
  }

  public IEnumerator sceneThreeTransition() {
    yield return new WaitForSeconds(2f);
    SceneManager.LoadScene("DBP3");
  }
}
