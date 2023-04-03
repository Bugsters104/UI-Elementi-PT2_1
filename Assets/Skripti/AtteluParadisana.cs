using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject bins;
	public GameObject leftToggle;
	public GameObject rightToggle;
	public GameObject lacitis;
	public GameObject tante;
	public GameObject masina;

	public GameObject dropDown;
	public GameObject dropDownImg;	
	public Sprite[] imgArray;

	public GameObject sizeSlider;
	public void BinaAttels(bool vertiba)
	{
		bins.SetActive(vertiba);
		leftToggle.SetActive(vertiba);
		rightToggle.SetActive(vertiba);
	}
    public void rotateBinLeft()
    {
        bins.transform.eulerAngles = new Vector3(0, 0, 0);
    }
    public void rotateBinRight()
    {
        bins.transform.eulerAngles=new Vector3(0, 180, 0);
    }

    public void LacisaAttels(bool vertiba)
	{
		lacitis.SetActive(vertiba);
	}

	public void TantesAttels(bool vertiba)
	{
		tante.SetActive(vertiba);
	}

	public void MasinasAttels(bool vertiba)
	{
		masina.SetActive(vertiba);
	}
	public void dropDownChoice(int i) {
		dropDownImg.GetComponent<Image>().sprite = imgArray[i];
	}
	public void sliderChange()
	{
		float currSize=sizeSlider.GetComponent<Slider>().value;
		dropDownImg.GetComponent<Image>().transform.localScale = new Vector3(currSize, currSize, currSize);
	}

}
