using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerFollowPlayer : MonoBehaviour
{
    public GameObject playercube;

    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //offset = transform.position - playercube.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playercube.transform.position + offset; // Camera follows players transform.
    }
}
