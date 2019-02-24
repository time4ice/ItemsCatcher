using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject rightPoint;

    public GameObject[] fallingThings;

    public float delay, repeatTime;

    private void Start ()
    {
        InvokeRepeating("Spawn", delay, repeatTime);
    }

    private void Spawn()
    {
        Vector3 position = new Vector3(Random.Range(transform.position.x,
                                                    rightPoint.transform.position.x),
                                       transform.position.y, 1);
        GameObject spawnObj = Instantiate(fallingThings[Random.Range(0, fallingThings.Length)], position, transform.rotation);
        spawnObj.transform.SetParent(transform.parent);
    }   

}
