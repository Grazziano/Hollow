﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu] // Facilita criação de instâncias de um objeto através do menu Assets/Create do Unity
public class Weapon : ScriptableObject {

	public int itemID; // ID para referência ao objeto
	public string weaponName; // Nome da arma para visualização
	public string description; // Descrição da arma para visualização
	public int damage; // Dano causado pela arma
	public Sprite image; // Imagem para representar visualmente a arma
	public AnimationClip animation; // Animação reproduzida ao atacar com a arma
	public string message; // Mensagem exibida ao coletar a arma
}
