using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

    public Animator anim1;
    public string score2;
    private string x ;
    

    private GameObject player1;

	// Use this for initialization
	void Start () {

        player1 = this.gameObject;

        anim1 = GetComponent<Animator>();

        //Debug.Log("zeroth time here");

        score2 = GameObject.Find("score2").GetComponent<TextMesh>().text;
        x = score2;

        //Debug.Log("first time here");
        //Debug.Log(score2);
        //Debug.Log(x);

    }
	
	// Update is called once per frame
	void Update () {

        score2 = GameObject.Find("score2").GetComponent<TextMesh>().text;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           //Debug.Log("running");
            anim1.Play("run", -1, 0f);
            

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim1.Play("backwards-run", -1, 0f);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
           // Debug.Log("stop running");
            anim1.Play("idle 0", -1, 0f);

        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim1.Play("idle 0", -1, 0f);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            player1.transform.Rotate(transform.rotation.x, transform.rotation.y-90, transform.rotation.z);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            player1.transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);
        }
        //Debug.Log("Check print now");
        //Debug.Log(score2);
        //Debug.Log(x);
        if(x != score2)
        {
            //Debug.Log("Player should jump!");
            anim1.Play("jump-up",-1,0f);
            x = score2;

        }
    }
}
