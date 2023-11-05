using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBarPosition : MonoBehaviour
{
    public ScrollRect myScrollRect;
    public Scrollbar newScrollBar;

    public void Start()
    {
        myScrollRect.verticalNormalizedPosition = 1f;
    }
}