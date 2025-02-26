using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour
{
    public float deadTime = 1.0f;
    private bool deadTimeActive = false;

    public UnityEvent onPressed, onReleased;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Button" && !deadTimeActive)
        {
            onPressed?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Button" && !deadTimeActive)
        {
            onReleased?.Invoke();
            StartCoroutine(WaitForDeadTime());
        }
    }

    IEnumerator WaitForDeadTime() 
    {
        deadTimeActive = true;
        yield return new WaitForSeconds(deadTime);
        deadTimeActive = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
