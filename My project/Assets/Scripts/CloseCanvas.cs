using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CloseCanvas : MonoBehaviour
{
    public GameObject canvasShutdown;
    public void OnExitButtonClicked()
    {
        canvasShutdown.SetActive(false);
    }
}
