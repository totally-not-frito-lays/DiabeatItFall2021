using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAnimation : MonoBehaviour
{
    public GameObject obj;
    static int changeCount = 0;
    
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }

    public void triggerAnim(string anim) {
        if (changeCount == 0) {
            Debug.Log("No animation played");
            changeCount++;
        }
        else {
            Debug.Log("Playing animation for other object");
            obj.GetComponent<Animator>().Play(anim);   //Plays state name
        }
    }
}
