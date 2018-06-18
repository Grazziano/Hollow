﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	private Animator anim; // Gerencia as animações de ataque
	private int damage; // Dano causado pelo ataque aos inimigos

	// Inicialização
	void Start () {
		anim = GetComponent<Animator>(); // Inicializa o gerenciador de animações
	}

	// Método chamado para executar uma animação
	public void PlayAnimation(AnimationClip clip){
		anim.Play(clip.name);
	}

	// Seta o dano do ataque
	public void SetDamage(int damageValue){
		damage = damageValue;
	}

	// Retorna o dano do ataque
	public int GetDamage() {
		return damage;
	}

	// Método que causa dano ao inimigo quando este entrar em contato com o ataque
	private void OnTriggerEnter2D(Collider2D other) {
		Enemy enemy = other.GetComponent<Enemy>();
		if (enemy != null)
			enemy.TakeDamage(damage);
	}
}
