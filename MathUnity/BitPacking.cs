using System;
using System.Collections;
using UnityEngine;

public class BitPacking : MonoBehaviour {

    /// This Class is Simply for Packing the bit into a small chunk
    /// Using the bitwise operation !

    string A = "110111"; // 6 Bytes; 
    string B = "10001"; // 5 Bytes;
    string C = "1101"; // 4 Bytes;
    int maskA = 1;//  1111 1111 1000 0000 0000 0000 0000 0000; Mask A Gw males ngitung 
    int maskB = 1; // 0000 0000 0111 1100 0000 0000 0000 0000; Mask B  
    int maskC = 1; // 0000 0000 0000 0011 1100 0000 0000 000 ; Mask C
    // Convert each String to Integer but with Bit representation
    int aBits = Convert.ToInt32(A, 2);
    int bBits = Convert.ToInt32(B, 2);
    int cBits = Convert.ToInt32(C,2);

    // 32 bit , all zero representation
    int packed = 0;

    // Lets Do this 
    // Figure Out where Each bits Occupy the place
    // Count Bits from C to B then  C, B to A ( 32 - 9, 32 - 9 - 5,  32 - 9 - 5 - 4 )
    // A will be shifted left 9 bits
    // B Will Be Shifted left 4 bits 
    void UnpackThebit(int bits, int maskA, int maskB, int maskC) 
    {
        /*
            This for UNpacking the bits sequence            
        */
        // (bits = 1101 1110 0011 1010 0000 0000 0000 0000)
        // (mask = 1111 1111 1000 0000 0000 0000 0000 0000)
        // Result= 1101 1110 0000 0000 0000 0000 0000 0000 ( Same representation as the first one right ?)
        // Result >> 9 = 0000 0000 1101 1110 0000 0000 0000 0000 ( Result / 2^9)
        int theA = (bits & maskA) >> 9 ;
        int theB = (bits & maskB) >> 4 ;
        int theC = (bits & maskC);
    }
    void Start() 
    {
        // Do the OR Operation 
        packed = packed | (aBits << 26);
        packed = packed | (bBits << 21);
        packed = packed | (cBits << 17);
        // Result :
        // 1101 1110 0011 1010 0000 0000 0000 0000
        Debug.Log(Convert.ToString(packed, 2).PadLeft(32, '0'));

        // Another
        /*
            packed = 0;
            string A = "1111";
            string B = "101;
            string C = "11011";

            
            int aBits = Convert.ToInt32(A, 2);
            int bBits = Convert.ToInt32(B, 2);
            int cBits = Convert.ToInt32(C,2);

            packed = packed | (aBits << 28);
            packed = packed | (bBits << 25);
            packed = packed | (cBits << 20);

        */

    }

    void Update() 
    {

    }
}