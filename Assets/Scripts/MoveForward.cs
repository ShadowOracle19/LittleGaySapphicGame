using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    public GameObject steringWheel;
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;

        float h = Input.GetAxisRaw("Horizontal");

        
    }
}
