using System.Collections;
using UnityEngine;

public class spanwManagerSpehere : MonoBehaviour
{
    public GameObject sphere;

    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
    }

    void SpawnObject()
    {
        float x = Random.Range(-5.0f, 5.0f);
        float z = Random.Range(-5.0f, 5.0f);
        Instantiate(sphere, new Vector3(x, 10, z), Quaternion.identity);
    }
}
