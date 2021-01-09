using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemLabelBehaviour : MonoBehaviour {

    public Text Label;
    public GameObject can;
    private GameObject _pinPoint;
    private GameObject _model;
    private GameObject _modelDM;
    private Vector3 onPiece;
    private bool labelSetActive = false;

    public void Awake()
    {
        onPiece = new Vector3(0, 0.02f, 0);
    }
    public void Update()
    {
        if(_pinPoint != null) 
        {
            can.transform.position = _pinPoint.transform.position + onPiece;
            can.transform.rotation = _pinPoint.transform.rotation;
        }
    }

    public void UpdatePositionAndLabel(GameObject pinPoint, GameObject model, GameObject modelDM, string label = "")
    {
        if(labelSetActive == false)
        {
            Label.text = label;
            _pinPoint = pinPoint;
            _pinPoint.SetActive(false);
            labelSetActive = true;
            _model = model;
            _modelDM = modelDM;
        }
        else 
        {
            _pinPoint.SetActive(true);
            _model.SetActive(false);
            _modelDM.SetActive(true);
            _pinPoint = pinPoint;
            _pinPoint.SetActive(false);
            _model = model;
            _modelDM = modelDM;
            Label.text = label;
        }
    }
    private void OnMouseDown()
    {
        _pinPoint.SetActive(true);
        _model.SetActive(false);
        _modelDM.SetActive(true);
        can.SetActive(false);
        labelSetActive = false;
    }
}
