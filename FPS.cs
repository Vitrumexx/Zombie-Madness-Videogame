using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FPS : MonoBehaviour
{
    private float fps;
    public TextMeshProUGUI TextFPS;


    private void Start()
    {
        StartCoroutine(CountFPS());
    }

    void ShowFPS()
    {
        fps = 1.0f / Time.deltaTime;
        TextFPS.SetText("FPS: " + fps.ToString());
    }

    IEnumerator CountFPS()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            ShowFPS();
        }
    }
}
