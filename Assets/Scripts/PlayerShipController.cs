using System.Collections;
using UnityEngine;

public class PlayerShipController : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 3f;

    //Control ship move distance
    public float xMin, xMax;

    //Bullet Variables
    public Rigidbody playerBullet;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 30f;
    public float shotTime = .25f;
    public bool canShoot;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");

        transform.Translate(xMove * moveSpeed * Time.deltaTime, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax),
            transform.position.y,
            transform.position.z);

        if (Input.GetButton("Fire1") && canShoot)
        {
            StartCoroutine(FireSpeed());
            Rigidbody _bullet;
            _bullet = Instantiate(playerBullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation) as Rigidbody;
            _bullet.AddForce(bulletSpawnPoint.up * bulletSpeed);
        }

    }

    IEnumerator FireSpeed()
    {
        canShoot = false;
        yield return new WaitForSeconds(shotTime);
        canShoot = true;
    }
}
