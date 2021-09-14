using UnityEngine;

public class Paddle : MonoBehaviour
{
    //TODO
    // Move paddle left and right using keyboard keys, mapping is up to you
    // Paddle should be able to launch the ball upon space bar being pressed
    // A launched ball will then bounce around, changing its direction upon any collision

    [SerializeField]
    private float speed = 10.0f;
    [SerializeField]
    public Ball ballPrefab;
    [SerializeField] GameObject ballLauncher;


    private void Start()
    {
        ballPrefab = Instantiate(ballPrefab, new Vector3(ballLauncher.transform.position.x, ballLauncher.transform.position.y, 0), Quaternion.identity);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
        }

        var xPosition = Mathf.Clamp(transform.position.x, -5.35f, 5.35f);
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);


        if(Input.GetKeyDown(KeyCode.Space))
        {
            ballPrefab.outOfPlay = true;
            Debug.Log("Pressed Space");
        }

    }

}
