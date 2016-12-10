using UnityEngine;
using System.Collections;

public class GridPoint
{
    public int x { get; set; }
    public int y { get; set; }

    public GridPoint(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

}

public class Grid : MonoBehaviour {

    public int gridLength;
    public int gridWidth;
    public float gridScale;

    //center of the bottom-left sprite
    public Vector3 gridOrigin;

    private GameObject[,] grid;

	// Use this for initialization
	void Start () {
        grid = new GameObject[gridLength, gridWidth];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void addToGrid(GameObject obj)
    {
        GridPoint pt = worldToGrid(obj.transform.position);
        grid[pt.x, pt.y] = obj;
    }

    public GridPoint worldToGrid(Vector3 position)
    {
        return new GridPoint(0, 0);
    }

    public Vector3 gridToWorld(GridPoint point)
    {
        return new Vector3(0, 0, 0);
    }
}
