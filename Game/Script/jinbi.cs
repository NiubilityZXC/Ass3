using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class jinbi : MonoBehaviour {
    public float rotateSpeed = 90.0f;
    public Tank tank;
    public int score;
    public Text ScoreUI;
    // Use this for initialization
    void Start()
    {
        tank.GetScore += Player_GetScore;
    }
    public void Player_GetScore(int score)
    {
        Score += score;
    }
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            
        }
    }
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, Time.deltaTime * rotateSpeed, 0, Space.World);
	}
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name=="Tank"||col.gameObject.name=="fire(Clone)")
        {
            Destroy(gameObject);
       //     score++;
       //     ScoreUI.text = score.ToString();
        }
    }
}
