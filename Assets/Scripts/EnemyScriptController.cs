using JetBrains.Annotations;
using UnityEngine;

public class EnemyScriptController : MonoBehaviour
{
    public int enemyHealth = 2;
    public float shipDropSpeed = -3/*Random.Range(2f, 6f)*/;

    //Control Sine Movement
    public float _frequency = 6f;
    public float _distance = .75f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, shipDropSpeed * Time.deltaTime, 0);
        transform.position = new Vector3(XSine(), 
            transform.position.y,
            transform.position.z);
    }
    public float XSine()
    {
        return Mathf.Sin(Time.time * _frequency) * _distance;
    }
}
