using UnityEngine;
using System.Collections;

public class MapLoader : MonoBehaviour {
    public static readonly string TERRAIN_ROOT = "FC/Models/Terrain/";
    public static readonly string UNIT_ROOT = "FC/Models/Units/";
    public char[][] MAP =
    {
        "MMGGWWWWWWWW".ToCharArray(),
        "MMGGWWWWWWWW".ToCharArray(),
        "MMGGGGGWWWWW".ToCharArray(),
        "MMMMMMGRRRRR".ToCharArray(),
        "MMGGGGGMMMMM".ToCharArray(),
        "MMGGMMMMMMMM".ToCharArray()
    };
    public string[][] UNIT_MAP = 
    {
        new string[]{null, null, null, null, null, null, null, null, "Sea/Fornalt-Class Battlecruiser/Rebel Fornalt-Class Battlecruiser", null, null, null},
        new string[]{"Land/Gruntman/Gruntman Rebel", null, null, null, null, null, null, null, null, null, null, null},
        new string[]{"Land/Gruntman/Gruntman Rebel", null, null, null, null, null, null, null, null, null, null, null},
        new string[]{null, null, null, null, null, null, null, null, null, null, null, null},
        new string[]{"Land/Gruntman/Gruntman Rebel", null, null, null, null, null, null, null, null, null, null, null},
        new string[]{null, null, null, null, null, null, null, null, null, null, null, null},
    };
    public GameObject[][] blocks;
    // Use this for initialization
	void Start () {
        GameObject terr = new GameObject("Terrain");
        terr.transform.position = Vector3.zero;
        blocks = new GameObject[MAP.Length][];
        for (int i = 0; i < MAP.Length; i++)
        {
            blocks[i] = new GameObject[MAP[i].Length];
            for (int b = 0; b < MAP[i].Length; b++)
            {
                GameObject gr = null;
                switch (MAP[i][b])
                {
                    case 'W':
                        gr = Resources.Load<GameObject>(TERRAIN_ROOT + "WaterBlock1/WaterBlock1");
                        break;
                    case 'G':
                        gr = Resources.Load<GameObject>(TERRAIN_ROOT + "GrassBlock1/GrassBlock1");
                        break;
                    case 'R':
                        gr = Resources.Load<GameObject>(TERRAIN_ROOT + "RoadBlock1/RoadBlock1");
                        break;
                    case 'M':
                        gr = Resources.Load<GameObject>(TERRAIN_ROOT + "MountainBlock1/MountainBlock1");
                        break;
                }
                gr.transform.localPosition = new Vector3(i, 0, b);
                gr = Instantiate(gr);
                gr.transform.SetParent(terr.transform);
                blocks[i][b] = gr;
                if (UNIT_MAP[i][b] != null)
                {
                    GameObject gu = Resources.Load<GameObject>(UNIT_ROOT + UNIT_MAP[i][b]);
                    gu = Instantiate(gu);
                    gu.transform.position = new Vector3(i, 0, b);
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
