using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballspawner : MonoBehaviour
{

    public GameObject Ball;
    public void spawnBall()
    {
        Instantiate(Ball, transform.position, Quaternion.identity);
    }
}
