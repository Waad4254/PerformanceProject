using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
    private Text text;
    private int score;

    // Use this for initialization
    void Start()
    {
        text = GetComponentInChildren<Text>();
    }

    // Update is called once per frame

    void Update() {
        if (score != gameManager.score)
            text.text = "Score: " + gameManager.score.ToString();
	}
}
