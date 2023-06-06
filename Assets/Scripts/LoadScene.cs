using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadThisScene(string scene) {
        SceneManager.LoadScene(scene);
        Debug.Log("Loading scene " + scene);
    }
}
