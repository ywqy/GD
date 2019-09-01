using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public Vector2Int size;

    public Map curMap;

    public void Work() {
        curMap.Create();
    }
}
