using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class ViewSwitch : MonoBehaviour
{
    public InputActionReference action;
    private bool onoff = false;
    private Vector3 pos1 = new Vector3 (0.0f, 3.6f, -4.0f);
    private Vector3 pos2 = new Vector3 (0.0f, 3.6f, -15.0f);
    // Start is called before the first frame update
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (onoff)
            {
                transform.position = pos1;
                onoff = false;
            }
            else
            {
                transform.position = pos2;
                onoff = true;
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
