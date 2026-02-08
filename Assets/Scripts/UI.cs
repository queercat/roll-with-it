using System;
using System.Text;
using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    private int _glorped = 0;
    private Label _label; 

    private void Start()
    {
        var uiDocument = GetComponent<UIDocument>();
        _label = uiDocument.rootVisualElement.Q("label") as Label;
        _label.text = string.Format("Glorped: {0}", _glorped);

        EventManager.Instance.OnGlorpEvent += HandleGlorp;
    }

    private void HandleGlorp()
    {
        _glorped++;
        _label.text = string.Format("Glorped: {0}", _glorped);
    }
}
