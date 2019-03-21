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
        score = gameManager.score;
        text = GetComponentInChildren<Text>();
    }

    // Update is called once per frame

    void Update() {
        if (score != gameManager.score)
        {
            score = gameManager.score;
            text.text = "Score: " + score.ToString();
        }
	}
}
