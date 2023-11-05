using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupUIController : MonoBehaviour
{
    public GameObject[] popups; 
    private int currentPopupIndex = -1; 

    // �˾��� ����
    public void ShowPopup(int popupIndex)
    {
        if (popupIndex >= 0 && popupIndex < popups.Length)
        {
            popups[popupIndex].SetActive(true);
            currentPopupIndex = popupIndex;
        }
    }

    // �˾� �ݱ�
    public void ClosePopup()
    {
        if (currentPopupIndex >= 0 && currentPopupIndex < popups.Length)
        {
            popups[currentPopupIndex].SetActive(false);
            currentPopupIndex = -1;
        }
    }
}