using UnityEngine;

public class GameManager : MonoBehaviour
{
    public const float ROW_HEIGHT = 0.48f;
    public const int PIECE_COUNT_PER_ROW = 13;
    public const float PIECE_LENGTH = 0.96f;
    public const int TOTAL_ROWS = 10;

    [SerializeField]
    private Transform pieces = null;

    [SerializeField]
    private GameObject piecePrefab = null;

    [SerializeField]
    private EdgeCollider2D border;


    //TODO
    //Using const data defined above "Instantiate" new pieces to fill the view with



    private void Start()
    {
        for(int i = 0; i < TOTAL_ROWS; i++)
        {
            for(int k = 0; k < PIECE_COUNT_PER_ROW; k++)
            {
                Instantiate(piecePrefab, new Vector3((PIECE_LENGTH * k)-6.0f, ROW_HEIGHT * i, 0), Quaternion.identity);
            }
        }
    }

}
