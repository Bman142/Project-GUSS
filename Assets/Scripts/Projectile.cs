using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] float despawnTime = 1;

    [SerializeField] ScoreManager manager;

    public Vector3 direction;
    float time;

    public Shooting.shooter shooter;

    [SerializeField] SceneLoader SceneManager;
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] int EndScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        this.transform.position += direction * speed * Time.deltaTime;
        if (time >= despawnTime)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && shooter != Shooting.shooter.Enemy)
        {
            GetComponent<AudioSource>().Play();
            collision.gameObject.GetComponent<EnemyAnthony>().TakeDamage(1);

        }
        if (collision.gameObject.tag == "Player" && shooter != Shooting.shooter.MC)
        {
            scoreManager.GetComponent<ScoreManager>().SaveHighScore();
            Destroy(collision.gameObject);
            SceneManager.GetComponent<SceneLoader>().onSceneChange(EndScene);
        }
    }
}
