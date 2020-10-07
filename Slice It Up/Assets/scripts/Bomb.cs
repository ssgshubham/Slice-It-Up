using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Bomb : MonoBehaviour
{
    public int score = 100;
    private gmmanager Gmmanager;
    public GameObject Gameover;

    


    void Awake()
    {
        Gmmanager = GameObject.FindObjectOfType<gmmanager>();
    }

    public float StartForce = 15f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * StartForce, ForceMode2D.Impulse);


		
	}



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            Debug.Log("Death");
            Instantiate(Gameover);
          
            Time.timeScale = 0f;
        }
    }

    public void watchedad()
    {
        Destroy(gameObject);

        Time.timeScale = 1f;
    }

	

}
  