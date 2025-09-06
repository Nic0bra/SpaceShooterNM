using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyScriptController : MonoBehaviour
{
    public int enemyHealth = 2;
    public float shipMoveSpeed = -3f;

    //Control Sine Movement
    public float _frequency = 6f;
    public float _distance = .75f;
    public float rotateSpeed;

    private float _spawnX;
    //variable to give each enemy their own sine way down
    private float _phase;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _spawnX = transform.position.x;

        //random rotation speed
        rotateSpeed = Random.Range(450f, 750f);
        //random frequency variation
        _frequency = Random.Range(4f, 8f);
        //slight amplitude variation
        _distance = Random.Range(.5f, 1f);
        //different start point
        _phase = Random.Range(0f, Mathf.PI * 2);
    }

    // Update is called once per frame
    void Update()
    {
        //move downward
        transform.Translate(0, shipMoveSpeed * Time.deltaTime, 0);
        //add rotation
        transform.Rotate(0 , rotateSpeed * Time.deltaTime, 0);
        //keep the x spawn and add the sine offset
        transform.position = new Vector3(_spawnX + XSine(), 
            transform.position.y,
            transform.position.z);
    }
    public float XSine()
    {
        return Mathf.Sin(_phase + Time.time * _frequency) * _distance;
    }
}
