using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseScreen : MonoBehaviour
{
    [SerializeField] GameObject _panel;
    
    public void Close()
    {
        _panel.SetActive(false);
    }
}
