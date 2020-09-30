using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGUI : MonoBehaviour
{

  /*Approaching*/
    //Pictograms
    public Texture2D A_Humanoid1;
    public Texture2D A_Humanoid2;
    public Texture2D A_Traffic1;
    public Texture2D A_Traffic2;
    public Texture2D A_Vehical1;
    public Texture2D A_Vehical2;
    //Text Signs
    public Texture2D A_SingleWord1;
    public Texture2D A_SingleWord2;
    public Texture2D A_SingleWord3;
    public Texture2D A_SingleWord4;
    public Texture2D A_Sentence1;
    public Texture2D A_Sentence2;
    public Texture2D A_Sentence3;
    public Texture2D A_Sentence4;

    /*Stop & Yield*/
      //Pictograms
      public Texture2D SY_Humanoid1;
      public Texture2D SY_Humanoid2;
      public Texture2D SY_Traffic1;
      public Texture2D SY_Traffic2;
      public Texture2D SY_Vehical1;
      public Texture2D SY_Vehical2;
      //Text Signs
      public Texture2D SY_SingleWord1;
      public Texture2D SY_SingleWord2;
      public Texture2D SY_SingleWord3;
      public Texture2D SY_SingleWord4;
      public Texture2D SY_Sentence1;
      public Texture2D SY_Sentence2;
      public Texture2D SY_Sentence3;
      public Texture2D SY_Sentence4;

    /*Re-starting*/
      //Pictograms
      public Texture2D R_Humanoid1;
      public Texture2D R_Humanoid2;
      public Texture2D R_Traffic1;
      public Texture2D R_Traffic2;
      public Texture2D R_Vehical1;
      public Texture2D R_Vehical2;
      //Text Signs
      public Texture2D R_SingleWord1;
      public Texture2D R_SingleWord2;
      public Texture2D R_SingleWord3;
      public Texture2D R_SingleWord4;
      public Texture2D R_Sentence1;
      public Texture2D R_Sentence2;
      public Texture2D R_Sentence3;
      public Texture2D R_Sentence4;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI(){
      // GUI.Box(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50,400,90), "Select Interface");

      //page 1 Approach
      if(GUI.Button( new Rect (100,100, 100, 50), A_Humanoid1)){
        print("humanoid1");

      }


    }
}
