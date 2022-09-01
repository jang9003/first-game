using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    [SerializeField]
    private GameObject TilePrefab;

    private Vector2 PuzzleSize = new Vector2(4, 4);

    // Start is called before the first frame update
    void Start()
    {
        SpawnTiles();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 초기 셋팅?
    private void SpawnTiles()
    {
        for (int y = 0; y < PuzzleSize.y; y++)
        {
            for (int x = 0; x < PuzzleSize.x; x++)
            {
                Instantiate(TilePrefab, this.transform);
            }
        }
    }

    // 셔플


}
