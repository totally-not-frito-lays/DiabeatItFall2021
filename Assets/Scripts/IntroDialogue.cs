using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroDialogue : MonoBehaviour
{
  public void sceneIntroDialogueTransition() {
    SceneManager.LoadScene("IntroDialogue");
  }
}
