using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    //Scoreを表示するテキスト
    private GameObject scoretext;

    private int score = 0;

    //Score Small Star
    private int score_smallstar = 10;

    //Score Large Star
    private int score_largestar = 20;

    //Score Small Cloud
    private int score_smallcloud = 5;

    //Score Large Cloud
    private int score_largecloud = 15;

    // Use this for initialization
    void Start () {

        score = 0;
        SetScore();   //初期スコアを代入して表示

        this.scoretext = GameObject.Find("Score");


    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "SmallStarTag")
        {
            score = score + score_smallstar;
            SetScore();
            

        }

        if (collision.gameObject.tag == "LargeStarTag")
        {
            score = score + score_largestar;
            SetScore();

        }

    }

    void SetScore()
    {
        this.scoretext.GetComponent<Text>().text = "score";
    }
}
