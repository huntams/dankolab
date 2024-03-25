using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScreen : MonoBehaviour
{
    [SerializeField] GameObject _panel;

    public void Open()
    {
        _panel.SetActive(true);
    }
}
