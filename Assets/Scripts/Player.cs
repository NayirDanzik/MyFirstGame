using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    [SerializeField] Vector3 moveDirection;
    [SerializeField] Vector3 moveDirection2;
    public int health;
    public Text HPtext;

    void Start()
    {
        HPtext.text = health.ToString();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().velocity += moveDirection2;
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection2;
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }



    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

        if (this.CompareTag("Player") && other.CompareTag("HealingSlave"))
        {
            {
                health = health + 50;
                HPtext.text = health.ToString();

            }
        }

        if (this.CompareTag("Player") && other.CompareTag("Bullet"))
        {
            {
                health = health - 50;
                HPtext.text = health.ToString();

                if (health == 0)
                {

                    Destroy(gameObject);
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                }

            }
        }

    }
}