using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataManager : MonoBehaviour {

	[SerializeField]
	private TextMeshProUGUI goodText, evilText, totalText;


	private int goodValue = 0; // How many times you were a Good Coder
	private int evilValue = 0; // How many times you made a Code Sin

	//Return the Sum of Good and Evil values of the Programmer
	private int totalValues { get { return this.goodValue + this.evilValue; } }

	public delegate void ChangeValueAction();
	public static event ChangeValueAction OnChangeValue;

	private DataSaver dataSaver;
	private DataLoader dataLoader;


	void Start () {
		dataSaver = new DataSaver(this);
		dataLoader = new DataLoader();

		LoadData();
	}

	public int GetGoodValue(){
		return this.goodValue;
	}
	public int GetEvilValue(){
		return this.evilValue;
	}

	public int GetSumValues(){
		return this.totalValues;
	}

	public void AddEvil(){
		this.evilValue++;

		Refresh();
	}

	public void AddGood(){
		this.goodValue++;
		Refresh();
	}

	private void SetEvil(int _value){

		this.evilValue=_value;
		Refresh();
	}

	private void SetGood(int _value){

		this.goodValue=_value;
		Refresh();
	}

	private void Refresh(){
		goodText.text = this.GetGoodValue().ToString();
		evilText.text = this.GetEvilValue().ToString();
		dataSaver.SetAllValues();
	}

	private void LoadData(){
		LoadGoodValue();
		LoadEvilValue();
	}

	private void LoadGoodValue(){
		this.SetGood(this.dataLoader.LoadGoodValue());
	}

	private void LoadEvilValue(){
		this.SetEvil(this.dataLoader.LoadEvilValue());

	}
}
