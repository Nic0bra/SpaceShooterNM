using UnityEngine;

public class EnemyShootScript : MonoBehaviour
{
    [SerializeField] GameObject enemyBullet;
    [SerializeField] Transform firePoint;
    [SerializeField] float bulletSpeed = 10f;
    [SerializeField] float initialShot;
    [SerializeField] float repeatShotRate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialShot = Random.Range(.5f, 2f);
        repeatShotRate = Random.Range(1f, 3f);
        InvokeRepeating(nameof(Fire), initialShot, repeatShotRate);
    }

    void Fire()
    {
        GameObject bullet = Instantiate(enemyBullet, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.down * bulletSpeed;
    }
}
