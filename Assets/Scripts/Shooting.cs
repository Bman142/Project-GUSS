using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] float projectileFrequency = 0;
    [SerializeField] GameObject projectile;
    enum Direction { MC, Enemy}
    [SerializeField] Direction direction;
    public enum shooter { MC, Enemy}
    [SerializeField] shooter Shooter;
    Vector3 shotDirection;
    float time;
    float timeToNextShot = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (direction == Direction.Enemy)
        {
            shotDirection = -this.transform.up *2;
        }
        else
        {
            shotDirection = this.transform.up;
        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (timeToNextShot <= time)
        {
            GameObject newProjectile = Instantiate(projectile);
            newProjectile.transform.position = this.transform.position + shotDirection;
            newProjectile.gameObject.GetComponent<Projectile>().direction = shotDirection;
            newProjectile.gameObject.GetComponent<Projectile>().shooter = Shooter;
            newProjectile.transform.rotation = this.transform.rotation;
            newProjectile.SetActive(true);

            timeToNextShot = time + projectileFrequency;
        }
        //this.transform.position = new Vector3(9, 0, 0);
    }
}
