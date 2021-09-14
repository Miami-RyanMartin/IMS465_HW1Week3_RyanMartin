using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidBody = null;

    //TODO: Add code to move ball along with code to delete pieces upon colliding with one
    //Ball should only move once its been launched

    [SerializeField] private float speed = 1.0f;
    private Vector3 currentDirection = Vector3.zero;
    Paddle paddlePrefab = null;
    public bool outOfPlay;
    GameObject ballLauncher = null;
    
    

    void Awake()
    {
            currentDirection = new Vector3(0, 1.0f, 0).normalized;
    }

    private void Start()
    {
        Debug.Log(outOfPlay);
        paddlePrefab = FindObjectOfType<Paddle>();
        ballLauncher = paddlePrefab.transform.Find("BallLauncher").gameObject;
    }

    void Update()
    {
        //transform.Translate(currentDirection * Time.deltaTime * speed);   
        if (!outOfPlay)
        {
            transform.position = new Vector3(paddlePrefab.transform.position.x,ballLauncher.transform.position.y,0);
            Debug.Log("not in play");
       }
        else
        {
            Debug.Log("In play");
        }
    }

    void FixedUpdate()
    {
         if(outOfPlay)
         {
            Debug.Log("I can move");
            var newDelta = currentDirection * Time.deltaTime * speed;
            rigidBody.MovePosition(transform.position + newDelta);
         }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            Debug.Log("Collision Occured");
            currentDirection = Vector2.Reflect(currentDirection, collision.contacts[0].normal);
            if(collision.gameObject.CompareTag("Piece"))
            {
                Destroy(collision.gameObject);

            }
            
    }


}

