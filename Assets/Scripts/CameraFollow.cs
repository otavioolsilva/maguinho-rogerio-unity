using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float maximoX;
    [SerializeField] private float minimoX;
    [SerializeField] private float maximoY;
    [SerializeField] private float minimoY;

    public Transform player;

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, minimoX, maximoX),Mathf.Clamp(player.position.y, minimoY, maximoY),-10);
    }
}
