using UnityEngine;
using System.Collections;
public struct cell
{
public	int xPos;
public	int yPos;
public	bool canHaveTower;


}




public class Grid : MonoBehaviour {
	cell[,] cells;
	 int gridWidth =16;
	 int gridHeight=9;
public	GameObject cellObject;

	// Use this for initialization
	void Start () {
		GenerateMap();
	}
	
	// Update is called once per frame
	void Update () {
	

	}
	void GenerateMap(){
		cells = new cell[gridWidth,gridHeight];
		//nested loop
		for(int i = 0; i < gridWidth; i++)
		{
			for(int j = 0; j < gridHeight; j++)
			{
				cells[i,j].xPos= i;
				cells[i,j].yPos= j;
				cells[i,j].canHaveTower = false;

			}
		}
			for (int i = 0;i < gridWidth; i++)
			{
				for(int j =0;j< gridHeight; j++)
				{
					Instantiate(cellObject, new Vector3(i,j,0),Quaternion.identity);
				}
			}
	}

}


