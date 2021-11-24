using UnityEngine;

public class ChurchFrontHide : MonoBehaviour
{
    [SerializeField] private SpriteRenderer SpriteRenderer;

    private void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "INT_church")
            SpriteRenderer.enabled = false;
        else
            SpriteRenderer.enabled = true;
    }
}
