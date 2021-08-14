using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    Rigidbody fiz;
    public int hiz=1;
    int score = 0;
    public int allBalls;
    public Text scoreText;
    public Text gameOverText;


    // Start is called before the first frame update
    void Start()
    {
        fiz = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        Debug.Log(hor);
        Debug.Log(ver);

        Vector3 vec = new Vector3(hor,0,ver);

        fiz.AddForce(vec*hiz);
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            other.gameObject.SetActive(false);
            //Destroy(other.gameObject);

            score++;

        }

        scoreText.text = "Score : " + score;

        if (score == allBalls) {

            gameOverText.text = "Game Over";
           // Debug.Log("Game Finished!");
        }
    }
}
