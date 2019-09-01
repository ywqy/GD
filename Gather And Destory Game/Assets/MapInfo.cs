using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MapType {
    None,
}

public class MapInfo {
    public MapType mType; 
    public Vector2Int size;

    public MapInfo (MapType mapType) {
        mType = mapType;
    }

    public MapInfo (MapType mapType, Vector2Int size) {

    }
}
