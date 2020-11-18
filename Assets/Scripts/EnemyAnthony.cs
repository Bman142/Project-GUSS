﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnthony : MonoBehaviour
{
    public int score = 1;
    public float speed = 4f;
    public float ystart = 10;
    public float loop = 16f;
    public float yend = -10;
    public float xSpawn = -27f;
    [SerializeField] SceneLoader SceneManager;
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] int EndScene;
    [SerializeField] int health;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector2.up * speed * Time.deltaTime);

        if (transform.position.x > loop)
        {
            transform.position = new Vector2(xSpawn ,Random.Range(ystart,yend)) ;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            scoreManager.AddScore(score);
            Destroy(this.gameObject);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            scoreManager.GetComponent<ScoreManager>().SaveHighScore();
            Destroy(collision.gameObject);
            SceneManager.GetComponent<SceneLoader>().onSceneChange(EndScene);
        }
    }

}
