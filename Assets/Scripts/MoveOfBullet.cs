using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveBullet : MonoBehaviour
{
    public float speed;
    public Transform EndPoint;
    public Transform StartPoint;
    public Transform MidlePoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, EndPoint.position, speed * Time.deltaTime);
        if (transform.position == EndPoint.position)
        {
            transform.position = Vector3.MoveTowards(StartPoint.position, EndPoint.position, speed * Time.deltaTime);
        }
     
    }

   
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E))
        {
            MidlePoint = StartPoint;
            StartPoint = EndPoint;
            EndPoint = MidlePoint;

        }
    }
}

