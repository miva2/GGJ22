using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid: MonoBehaviour
{

    public int width;
    public int height;
    // public float cellSize;
    private GameObject[,] gridArray;
    public GameObject terrain;

    void Start()
    {
        gridArray = new GameObject[width, height];
      for(int x=0; x < width; x++)
      {
          for(int z = 0; z < height; z++)
          {
              Vector3 position = new Vector3(x, 0, z);
              gridArray[x, z] = Instantiate(terrain, position, Quaternion.identity, transform);
          }
      }

    }

}
