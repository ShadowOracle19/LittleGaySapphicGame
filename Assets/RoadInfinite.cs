using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadInfinite : MonoBehaviour
{
    //this variable will move the road by what its set to
    [SerializeField]
    private float offsetBy;

    private void OnTriggerEnter(Collider other)
    {
        //whenever player enters trigger move road behind them forward
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + offsetBy);
    }
}
