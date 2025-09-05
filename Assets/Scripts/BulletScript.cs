using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public bool enemyBullet;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            other.GetComponent<EnemyScriptController>().enemyHealth--;
            if(other.gameObject.GetComponent<EnemyScriptController>().enemyHealth <= 0)
            {
                SoundManager.Instance.PlaySound2D("EnemyDead");
                Destroy(other.gameObject);
            }
        }
    }
}
