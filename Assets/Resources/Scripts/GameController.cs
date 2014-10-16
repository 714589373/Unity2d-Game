﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : Singleton<GameController> {
	public int level;
	public Player player;
	public int score;
	public List<Resource> resources = new List<Resource>();
	public List<Cell> Cells = new List<Cell>();
	public List<Enemy> Enemies = new List<Enemy>(); //populate this list each time you create an enemy.
	public List<Building> Buildings = new List<Building>(); //populate this list each time you create a building.
	public List<Canon> Canons = new List<Canon>(); //populate this list each time you create a building.
	public List<Defence> Defences = new List<Defence>(); //populate this list each time you create a building.
	public GameObject spawnerLayer;
	Sprite Sprite;

	void Start(){
		spawnerLayer = new GameObject("Spawns");		
	}
}
