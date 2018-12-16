using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader {

	public DataLoader(){

    }

    public int LoadGoodValue(){
        return PlayerPrefs.GetInt("GoodValue", 0);
    }
    
    public int LoadEvilValue(){
        return PlayerPrefs.GetInt("EvilValue", 0);
    }
	
}
