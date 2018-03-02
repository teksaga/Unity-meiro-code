using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_enemy : MonoBehaviour {
	public GameObject Enemy;
	public GameObject Prefab;
	public int count = 1;
	public List<GameObject> enemy_list = new List<GameObject>();
	void Start () {
		Prefab = Resources.Load("Prefabs/FreeVoxelGirl") as GameObject;
	}

	void Update () {
		Enemy_Create ();
	}

	void Enemy_Create(){
		System.Threading.Thread.Sleep (30000);
		//敵の生成
		Enemy = Instantiate (Prefab, new Vector3 (Random.Range (-10, 10), 3, Random.Range (-10, 10)),Quaternion.identity);
		//敵のリストの追加
		Enemy.name = Enemy.name + count.ToString();
		enemy_list.Add(Enemy);
		count++;
	}
}
