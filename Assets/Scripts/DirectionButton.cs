using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class DirectionButton : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirY;
    private float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirY = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed;
        rb.velocity = new Vector2(0, dirY);
    }
}
