using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject slicedPrefab;
    public float sliceForce = 5f;
    public float destroyTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword"))
        {
            Vector3 swordDirection = other.GetComponent<Rigidbody>().velocity.normalized;
            Slice(swordDirection);
        }
    }

    void Slice(Vector3 direction)
    {
        GameObject slicedInstance = Instantiate(slicedPrefab, transform.position, transform.rotation);
        Rigidbody[] slices = slicedInstance.GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody slice in slices)
        {
            Vector3 forceDirection = (slice.transform.position - transform.position).normalized + direction * 0.5f; 
            slice.AddForce(forceDirection * sliceForce, ForceMode.Impulse); 
            slice.AddTorque(Random.insideUnitSphere * sliceForce, ForceMode.Impulse); 
        }


        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
