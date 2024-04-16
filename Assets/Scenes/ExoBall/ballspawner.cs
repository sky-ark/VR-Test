using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballspawner : MonoBehaviour
{

    public GameObject BallDirect;
    public GameObject BallRay;
    public void spawnBallDirect()
    {
        Instantiate(BallDirect, transform.position, Quaternion.identity);
    }

    public void spawnBallRay()
    {
        Instantiate(BallDirect, transform.position, Quaternion.identity);
    }
    
}
