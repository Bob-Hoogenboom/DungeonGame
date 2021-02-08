using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEditor;

public class FarmGeneration : MonoBehaviour
{
    [Range(0, 1000)]
    [SerializeField] int _iniChance;

    [Range(1, 8)]
    [SerializeField] int _grassLimit;

    [Range(1, 8)]
    [SerializeField] int _pathlimit;

    [Range(1, 10)]
    [SerializeField] int _numR;
    [SerializeField] int _count = 0;

    [SerializeField] int[,] _terrainmap;
    [SerializeField] Vector3Int _tMapSize;

    [SerializeField] Tilemap _topMap;
    [SerializeField] Tilemap _bottommap;

    [SerializeField] Tile _topTile;
    [SerializeField] Tile _botTile;

    int _width;
    int _height;



    public void Generate(int _numR)
    {
        ClearMaps(false);
        _width = _tMapSize.x;
        _height = _tMapSize.y;
    }


    public void ClearMaps(bool complete)
    {
        _topMap.ClearAllTiles();
        _bottommap.ClearAllTiles();

        if(complete)
        {
            _terrainmap = null;
        }
    }





    /*    [SerializeField] int _width;
        [SerializeField] int _height;
        [SerializeField] GameObject _grass;

        private void Start()
        {
            Generation();
        }

        void Generation()
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                    Instantiate(_grass, new Vector2(x, y), Quaternion.identity);
            }
        }*/
}
 