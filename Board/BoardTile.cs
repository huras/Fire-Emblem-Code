using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardTile : BoardObject
{
    public BoardTerrain.Type terrain;
    public List<BoardUnit> units;
    public List<BoardArtifact> artifacts;
}
