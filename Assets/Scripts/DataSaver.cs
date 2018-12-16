using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSaver {

	DataManager dataManager;


	public DataSaver (DataManager _dataManager) {
		this.dataManager = _dataManager;
		DataManager.OnChangeValue += SetAllValues;
	}

	public void SetAllValues(){
		PlayerPrefs.SetInt("GoodValue", this.dataManager.GetGoodValue());
		PlayerPrefs.SetInt("EvilValue", this.dataManager.GetEvilValue());
	}
	
}
