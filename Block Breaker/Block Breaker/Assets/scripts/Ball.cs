using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Paddle paddle;
    private Vector3 paddleToBallVector;
    private bool hasStarted=false;
    // Use this for initialization
    private Rigidbody2D rigi;
    private AudioSource bounceSound;
    private void Awake()
    {
        rigi = GetComponent<Rigidbody2D>();
    }
    void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
        bounceSound = this.GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
        if(!hasStarted)
        {
        this.transform.position = paddle.transform.position + paddleToBallVector;
            if(Input.GetMouseButtonDown(0))
            {
                hasStarted = true;
                rigi.velocity = new Vector2(2f, 10f);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 change = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));
       
        if(hasStarted)
        {
            rigi.velocity += change;
            bounceSound.Play();
        }
           
        
    }
}
