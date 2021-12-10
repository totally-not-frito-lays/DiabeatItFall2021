using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial1 : MonoBehaviour
{
  public void sceneTutorial1Transition() {
    SceneManager.LoadScene("Tutorial1");
  }
}
