using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class LensBehavior : MonoBehaviour
{
    public Camera userCamera; 
    public Transform lensTransform;

    // Start is called before the first frame update
    void Start()
    {
        userCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = transform.position - userCamera.transform.position;
        Quaternion lookAtRotation = Quaternion.LookRotation(direction);
        float roll = lensTransform.eulerAngles.z;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(lookAtRotation.eulerAngles.x, lookAtRotation.eulerAngles.y, roll), Time.deltaTime * 5f);
    }
}
