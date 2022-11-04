using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("UI")]
    public GameObject phonePanel;
    private bool enablePhone = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            enablePhone = !enablePhone;
            phonePanel.SetActive(enablePhone);
        }
    }
}
