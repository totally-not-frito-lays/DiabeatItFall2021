using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class dropBP : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData) {
      if (eventData.pointerDrag != null) {
        SceneManager.LoadScene("DBP10");
      }
    }
}
