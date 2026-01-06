using UnityEngine;

public class Number : MonoBehaviour
{
    int Number1 = 10;
    int Number2 = 7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Debug.Log("Hallo..");
        Debug.Log(Number1);
        Debug.Log(Number2);
        // menambahkan sesuatu
        int Result = Number1 + Number2;
        Debug.Log(Result);
        // mengurangi sesuatu
        int Result1 = Number1 - Number2;
        Debug.Log(Result1);
        // mengkalikan sesuatu
        int Result2 = Number1 * Number2;
        Debug.Log(Result2);
        //membagi sesuatu
        int Result3 = Number1 / Number2;
        Debug.Log(Result3);
        //memperlihatkan hasil sisa bagi
        int Result4 = Number1 % Number2;
        Debug.Log(Result4);

        bool hasil = (Number1 == Number2) && (Number1 > Number2);
        Debug.Log(hasil);

        bool hasil1 = ((1287 * 14 + 529) > (63 * 55 * 5)) && !(21 < 10);
        Debug.Log(hasil1);

        int temp = Number1;
        Number1 = Number2;
        Number2 = temp;

        Debug.Log(Number1);
        Debug.Log(Number2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
