using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeMovement : MonoBehaviour
{
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; 
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
       Score.instance.IncreaseScore(1);
    }
}
