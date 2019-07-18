using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick_01 : MonoBehaviour {
   private int maxHit;
    private int currHit;
    public LevelManager levelManager;
    public SenceLoader senceLoader;
    public Sprite[] hitBrick;
    public static int brickCount = 0;
    public bool is_brickable;
    
    // Use this for initialization
    void Start () {
        
        is_brickable = (this.GetComponent<Transform>().tag == "Breakable");
        currHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        senceLoader = GameObject.FindObjectOfType<SenceLoader>();
        if (is_brickable)
            brickCount++;
        
    }
	
	// Update is called once per frame
	void Update () {
    
      

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        bool is_brickable = (this.GetComponent<Transform>().tag == "Breakable");
        if(is_brickable)
        {
            
            When_its_breakable();
        }

    }
    void When_its_breakable()
    {
        currHit++;
        maxHit = hitBrick.Length + 1;
       
        if (currHit >= maxHit)
        {
           
            brickCount--;
            Debug.Log(brickCount);
            Destroy(gameObject);
           
            levelManager.BrickDestroy();
        }
        else
        {
            
            LoadBrick();
        }
    }

    void  LoadBrick()
    {
        int i = currHit-1;
        this.GetComponent<SpriteRenderer>().sprite = hitBrick[i];


    }
    void Winning()
    {

        SenceLoader.LoadNextScene();

    }

}
