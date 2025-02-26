using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{
    public string stringText;
    public TextMeshProUGUI myText;

    public void ChangeText() 
    {
        myText.text = stringText;
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
