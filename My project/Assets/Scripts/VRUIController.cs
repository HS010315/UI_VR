using UnityEngine;
using UnityEngine.UI;

public class VRUIController : MonoBehaviour
{
    public GameObject panels1;
    public GameObject panels2;
    public GameObject panels3;
    public GameObject panels4;
    public GameObject CancelWhat;
    public GameObject[] panels;
    public GameObject[] previewImages;
    public GameObject popupImages1;
    public GameObject popupImages2;
    public GameObject popupImages3;
    public void OnButtonClick(int panelIndex)
    {
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }

        panels[panelIndex].SetActive(true);
    }

    public void OnClickanything()
    {
        panels1.SetActive(false);
        panels2.SetActive(false);
        panels3.SetActive(false);
        panels4.SetActive(false);
    }
    public void OnClickCancel()
    {
        CancelWhat.SetActive(false);
    }

    public void OnClickPreview1()
    {
        popupImages1.SetActive(true);
        popupImages2.SetActive(false);
        popupImages3.SetActive(false);
    }

    public void OnClickPreview2()
    {
        popupImages1.SetActive(false);
        popupImages2.SetActive(true);
        popupImages3.SetActive(false);
    }

    public void OnClickPreview3()
    {
        popupImages1.SetActive(false);
        popupImages2.SetActive(false);
        popupImages3.SetActive(true);
    }
}