using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyBoards : MonoBehaviour
{
    public WhiteBoard Board;


    // Start is called before the first frame update
    void Start()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.mainTexture = Board.texture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
