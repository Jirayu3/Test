using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _width = 4;
    [SerializeField] private int _height = 4;
    [SerializeField] public Node _nodePrefab;
    [SerializeField] private Block _blockPrefab;
    [SerializeField] private SpriteRenderer _boardPrefab;

   
    private List<Node> _nodes;
    private List<Block> _blocks;


    private void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        _nodes = new List<Node>();
        _blocks = new List<Block>();
        for(int x = 0; x< _width; x++)
        {
            for(int y = 0; y< _height; y++)
            {
                var node = Instantiate(_nodePrefab, new Vector2(x, y), Quaternion.identity);
                _nodes.Add(node);

            }
        }
        var center = new Vector2((float) _width /2 - 0.5f, _height /2 -0.5f );

        var board = Instantiate(_boardPrefab, center, Quaternion.identity);

        board.size = new Vector2(_width, _height);


        Camera.main.transform.position = new Vector3(center.x, center.y, -10);


    }

    void SpwanBlocks(int amount)
    {
        //var freeNodes = _nodes.Where(n=>n.OccupiedBlock == null).OrderBy(b=>Random.value);

        for (int i = 0; i < amount; i++){
            var block = Instantiate(_blockPrefab);
        }
    }



    
}
