using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class DataManagerTests {

    [Test]
    public void GetGoodValue_WhenDoNotChanged_Zero() {
        GameObject _go = new GameObject();
        DataManager _dataManager = _go.AddComponent<DataManager>();

        Assert.AreEqual(0, _dataManager.GetGoodValue());
    }

    [Test]
    public void GetEvilValue_WhenDoNotChanged_Zero() {
        GameObject _go = new GameObject();
        DataManager _dataManager = _go.AddComponent<DataManager>();

        Assert.AreEqual(0, _dataManager.GetEvilValue());
    }

    [Test]
    public void GetSumValues_WhenDoNotChanged_Zero() {
        GameObject _go = new GameObject();
        DataManager _dataManager = _go.AddComponent<DataManager>();

        Assert.AreEqual(0, _dataManager.GetSumValues());
    }
}
