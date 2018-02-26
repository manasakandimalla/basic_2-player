using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{

    public Animator anim1;

    public string score1;
    private string x;

    private GameObject player1;

    // Use this for initialization
    void Start()
    {

        player1 = this.gameObject;

        anim1 = GetComponent<Animator>();

        //Debug.Log("zeroth time here");

        score1 = GameObject.Find("score1").GetComponent<TextMesh>().text;
        x = score1;

        //Debug.Log("first time here");
        //Debug.Log(score1);
        //Debug.Log(x);

    }

    // Update is called once per frame
    void Update()
    {
        score1 = GameObject.Find("score1").GetComponent<TextMesh>().text;
        if (Input.GetKeyDown(KeyCode.W))
        {
            //Debug.Log("running");
            anim1.Play("run", -1, 0f);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim1.Play("backwards-run", -1, 0f);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            // Debug.Log("stop running");
            anim1.Play("idle", -1, 0f);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim1.Play("idle", -1, 0f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            player1.transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            player1.transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);
        }
        //Debug.Log("Check print now");
        //Debug.Log(score1);
        //Debug.Log(x);
        if (x != score1)
        {
            //Debug.Log("Player should jump!");
            anim1.Play("jump-up", -1, 0f);
            x = score1;

        }
    }
}
