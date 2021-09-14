using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    [SerializeField]
    private Ball ballPrefab;
    [SerializeField] GameObject ballLauncher;
    [SerializeField] Paddle paddle;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //TODO: Implement functionality to reset the game somehow.
        // Resetting the game includes destroying the out of bounds ball and creating a new one ready to be launched from the paddle

        if (collision.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            paddle.ballPrefab = Instantiate(ballPrefab, new Vector3(ballLauncher.transform.position.x, ballLauncher.transform.position.y, 0), Quaternion.identity);
        }
    }
}
