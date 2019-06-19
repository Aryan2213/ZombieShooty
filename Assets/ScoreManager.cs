using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int value;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = value+(".");
    }
}
