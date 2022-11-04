using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadInfinite : MonoBehaviour
{
    //this variable will move the road by what its set to
    [SerializeField]
    private float offsetBy;

    public GameObject levelPlate;

    private void OnTriggerEnter(Collider other)
    {
        //whenever player enters trigger move road behind them forward
        levelPlate.transform.position = new Vector3(levelPlate.transform.position.x, levelPlate.transform.position.y, levelPlate.transform.position.z + offsetBy);
    }
}
