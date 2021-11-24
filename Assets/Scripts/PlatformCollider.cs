using UnityEngine;

public class PlatformCollider : MonoBehaviour {

    [SerializeField] private BoxCollider2D BoxCollider;
    [SerializeField] private Transform BoxPosition;
    [SerializeField] private Transform GroundCheck;

    private void Start ()
    {
        BoxCollider.enabled = false;
    }

    private void Update ()
    {
        if((GroundCheck.position.y + 0.08f) > BoxPosition.position.y && !Input.GetButton("Vertical"))
            BoxCollider.enabled = true;
        else
            BoxCollider.enabled = false;
    }
}