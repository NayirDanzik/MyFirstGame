using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealingSlave : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {


        if (this.CompareTag("HealingSlave") && other.CompareTag("Player"))
        {
            {
                Destroy(gameObject);

            }
        }

    }
}
