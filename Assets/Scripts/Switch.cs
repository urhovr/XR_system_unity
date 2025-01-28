using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.InputSystem;

public class Switch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    private bool onoff = false;
    Color color1;
    Color color2;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        ColorUtility.TryParseHtmlString("#EBFBFF", out color1);
        ColorUtility.TryParseHtmlString("#FF848A", out color2);
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (onoff)
            {
                light.color = color1;
                onoff = false;
            }
            else
            {
                light.color = color2;
                onoff = true;
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
