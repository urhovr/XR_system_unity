using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI myText;

    // Start is called before the first frame update
    public void AddScoreText()
    {
        score = score + 1;
        myText.text = $"{score}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
