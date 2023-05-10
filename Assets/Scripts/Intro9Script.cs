using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro9Script : MonoBehaviour
{
    public static string selectedAnswer;
    public Intro9Script() {
        
    }
    public void setAnswer(string answer) {
        selectedAnswer = answer;
        Debug.Log("Current answer: " + selectedAnswer);
    }
    public void loadNextScene() {
        if (selectedAnswer == "rightAnswer") SceneManager.LoadScene("Intro10");
        else if (selectedAnswer == "wrongAnswer") SceneManager.LoadScene("Intro11");
        else SceneManager.LoadScene("Intro11");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
