﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGold : MonoBehaviour {

	public int gold;
	
	private void OnTriggerEnter2D(Collider2D other){
		// Verifica se foi o personagem que entrou em contato com o objeto
		Player player = other.GetComponent<Player>();
		if (player != null) {
			FindObjectOfType<UIManager>().SetMessage("Adquiriu " + gold + " de Ouro!");
			player.gold += gold;
			Destroy(gameObject); // Remove o objeto do mapa
		}
	}
}
