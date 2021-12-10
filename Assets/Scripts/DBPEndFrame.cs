using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DBPEndFrame : MonoBehaviour
{
  public void sceneEndFrameTransition() {
    SceneManager.LoadScene("DBPEndFrame");
  }
}