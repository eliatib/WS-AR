using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickElementBehaviour : MonoBehaviour
{
    public ItemLabelBehaviour itemLab;
    public string pieceName;
    public GameObject model;
    public GameObject modelDM;
    public GameObject can;
    private void OnMouseDown()
    {
        model.SetActive(true);
        modelDM.SetActive(false);
        can.SetActive(true);
        itemLab.UpdatePositionAndLabel(this.gameObject,model,modelDM,pieceName);
    }
}
