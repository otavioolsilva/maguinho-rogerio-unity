using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCollider : MonoBehaviour {

    [SerializeField] private BoxCollider2D BoxCollider;
    [SerializeField] private Transform BoxPosition;
    [SerializeField] private Transform GroundCheck;

    private void Awake ()
    {
        BoxCollider.enabled = false;
    }

    private void Update ()
    {
        if((GroundCheck.position.y + 0.08f) > BoxPosition.position.y && !Input.GetKey("down"))
            BoxCollider.enabled = true;
        else
            BoxCollider.enabled = false;
    }
}