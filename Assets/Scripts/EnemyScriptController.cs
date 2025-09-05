using UnityEngine;

public class EnemyScriptController : MonoBehaviour
{
    public int enemyHealth = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -2.5f * Time.deltaTime, 0);
    }
}
