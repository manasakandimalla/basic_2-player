using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour {

    public int score1;
    public int score2;

    private Rigidbody rb;

    public float time_remaining;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "goal1")
        {
            //Debug.Log("Goal for player 1!!!");
           transform.position = GameObject.Find("ballposition").transform.position;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            score2 += 1;
        }
        if (other.gameObject.tag == "goal2")
        {
           //Debug.Log("Goal for player 2!!!");
            transform.position = GameObject.Find("ballposition").transform.position;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            score1 += 1;
        }
    }
    
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
    
	void Update () {

        time_remaining -= Time.deltaTime;

        GameObject.Find("score2").GetComponent<TextMesh>().text = score2 + "";
        GameObject.Find("score1").GetComponent<TextMesh>().text = score1 + "";

        if(time_remaining >0)
        {
            GameObject.Find("Timer").GetComponent<TextMesh>().text = "    " + (int)time_remaining + "";
        }
        else
        {
            if(score1 > score2)
            {
                GameObject.Find("Timer").GetComponent<TextMesh>().text = "player1 wins";
            }
            if (score1 < score2)
            {
                GameObject.Find("Timer").GetComponent<TextMesh>().text = "player2 wins";
            }
            if (score1 == score2)
            {
                GameObject.Find("Timer").GetComponent<TextMesh>().text = "draw !!!";
            }

            Destroy(this.gameObject);

        }


    }
}
