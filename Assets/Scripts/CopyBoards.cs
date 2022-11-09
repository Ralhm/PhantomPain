using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyBoards : MonoBehaviour
{
    public WhiteBoard Board;


    // Start is called before the first frame update
    void Start()
    {
        Board = GameObject.FindObjectOfType<WhiteBoard>().GetComponent<WhiteBoard>(); //I don't wanna have to drag the whiteboard ref into all of the copy boards
        Renderer rend = GetComponent<Renderer>();
        rend.material.mainTexture = Board.texture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
