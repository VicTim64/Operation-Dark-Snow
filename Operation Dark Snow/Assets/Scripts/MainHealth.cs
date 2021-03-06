﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainHealth : MonoBehaviour {
//	public  death;
	public Image currentHealthbar;
	public Text ratioText;

	private float hitpoint = 150;
	private float maxHitpoint = 150;

	private void Start()
	{
		UpdateHealthbar ();

	}
	private void UpdateHealthbar()
	{
		float ratio = hitpoint / maxHitpoint;
		currentHealthbar.rectTransform.localScale = new Vector3 (ratio, 1, 1);
		ratioText.text = (ratio * 100).ToString ("0") + "%";
	}
	private void TakeDamage(float damage)
	{
		hitpoint -= damage;
		if (hitpoint < 0) {
			hitpoint = 0;
			Destroy (gameObject);
	//		death.SetActive (true);
		}
		UpdateHealthbar();
	}
	private void HealDamage (float heal)
	{
		hitpoint += heal;
		if (hitpoint > maxHitpoint) {
			hitpoint = maxHitpoint;
			//		death.SetActive (true);
			UpdateHealthbar ();
		}
	}
}
