using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textManager : MonoBehaviour
{
    public TextMeshProUGUI textMesh;

    public static textManager instance;

    int score;

    public void increaseScore()
    {
        score++;
        instance.textMesh.text = "Altcoin bag: " + score;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
