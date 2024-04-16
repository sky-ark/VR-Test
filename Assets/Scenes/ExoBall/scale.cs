using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{

    private static scale instance;

    public static scale Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<scale>();
            }

            return instance;
        }
    }
    
    public void ScaleUp()
    {
        transform.localScale = transform.localScale * 2; 
    }

    public void UnscaleUp()
    {
        transform.localScale = transform.localScale / 2;
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}
