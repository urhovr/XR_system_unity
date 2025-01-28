using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class rotation : MonoBehaviour
{
    private float y = 0.0f;
    private float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y += Time.deltaTime * speed;
        transform.localRotation = Quaternion.Euler(0, y, 0);
    }
}
