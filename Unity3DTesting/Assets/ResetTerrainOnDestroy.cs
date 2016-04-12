using UnityEngine;
using System.Collections;

public class ResetTerrainOnDestroy : MonoBehaviour {

	#region Fields

	public Terrain terrain;

	private float[,] originalHeights;

	private void OnDestroy() {
		this.terrain.terrainData.SetHeights (0, 0, this.originalHeights);
	}

	// Use this for initialization
	void Start () {
		this.originalHeights = this.terrain.terrainData.GetHeights (0, 0, this.terrain.terrainData.heightmapWidth, this.terrain.terrainData.heightmapHeight);
	}

	#endregion
}
