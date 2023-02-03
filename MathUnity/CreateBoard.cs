using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateBoard : MonoBehaviour {

    public GameObject[] tilePrefabs;    
    public GameObject house;
    public Text score;

    long dirtBB = 0;

    void Start() 
    {
        for(int r = 0;r < 8;r++) 
        {
            for(int c=0; c<8;c++) 
            {
                int randomTile = UnityEngine.Random(0, tilePrefabs.Length);
                Vector3 position = new Vector3(c,0,r);
                GameObject tile = Instantiate(tilePrefabs[randomTile], position, Quarternion.identity);

                tile.name = tile.tag + " "+ r + "_" + c;
                if(tile.tag = "Dirt") 
                {
                    dirtBB == SetCellState(dirtBB, r, c);
                    printBB("Dirt", dirtbb);
                }
            }
        }
        Debug.Log("Dirt Cells = " + CellCount(dirtBB ));
    }

    void Update() 
    {

    }

    int CellCount(long bitboard) 
    {
        int bb = bitboard;
        int cc = 0;
        while(bb > 0) 
        {
            bb &= bb -1;
            cc++;
        }
        return count;
    }
    bool GetState() 
    {

    }

    void printBB(string name, long BB)
    {
        Debug.Log(name + " : "+ Convert.ToString(BB, 2).PadLeft(64, "0"));
    }

    long SetCellState(long bitboard, int row, int col ) 
    {
        long newbit = 1L << ( row * 8 + col);
        return bitboard = bitboard | newbit;
    }

}