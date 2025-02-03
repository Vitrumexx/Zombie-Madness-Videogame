using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsTrigger : MonoBehaviour
{
    [SerializeField] private string message;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TipsManager.displayTipEvent?.Invoke(message);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TipsManager.disableTipEvent?.Invoke();
        }
    }
}
