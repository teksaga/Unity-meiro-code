using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Create_Stage : MonoBehaviour {
    //配列の大きさ定義
    const int N = 49;
    //配列データの宣言
    public int [,] data = new int[N,N];
    //複製するデータ変数を作成
    public GameObject Prefab;
    public GameObject Prefab_wall;
    //複製されたobjのデータを保管
    public GameObject Clone;
    //listでデータを管理
    public List<GameObject> obj_List;
    //カウント変数
    int count = 0;
    //一回だけの読み込み
    void Start () {
	//Resoucesディレクトリからの読み込み
	Prefab = Resources.Load ("Prefabs/out_wall_obj") as GameObject;
	Prefab_wall = Resources.Load ("Prefabs/wall") as GameObject;
	//外壁の作成
	Create_Outwall ();
	//迷路データの初期化
	data_init ();
	//1250回の呼び出しで迷路を複雑化
	for(int i = 0;i < 1250;i++){
	    create_data ();
	}
	Creata_Stage ();
	//リストの初期化
	obj_List = new List<GameObject> ();
    }
    void Update () {
    }
    //外壁の作成
    void Create_Outwall(){
	for(int i = -25;i < 25;i++){
	    for(int j = 0;j < 5;j++){
		//外壁のoutput
		Clone = Instantiate (Prefab, new Vector3 (i,j,24), Quaternion.identity);
		Clone.name = Clone.name + count.ToString ();
		obj_List.Add (Clone);
		count++;
	    }
	}
	for(int i = -25;i < 25;i++){
	    for(int j = 0;j < 5;j++){
		//外壁のoutput
		Clone = Instantiate (Prefab, new Vector3 (i,j,-24), Quaternion.identity);
		Clone.name = Clone.name + count.ToString ();
		obj_List.Add (Clone);
		count++;
	    }
	}
	for(int i = -25;i < 25;i++){
	    for(int j = 0;j < 5;j++){
		//外壁のoutput
		Clone = Instantiate (Prefab, new Vector3 (24,j,i), Quaternion.identity);
		Clone.name = Clone.name + count.ToString ();
		obj_List.Add (Clone);
		count++;
	    }
	}
	for(int i = -25;i < 25;i++){
	    for(int j = 0;j < 5;j++){
		//外壁のoutput
		Clone = Instantiate (Prefab, new Vector3 (-24,j,i), Quaternion.identity);
		Clone.name = Clone.name + count.ToString ();
		obj_List.Add (Clone);
		count++;
	    }
	}
    }
    //迷路データの作成
    void create_data(){
	//適当にデータの座標値を指定
	int rnd_x = Random.Range (2,N - 2);
	int rnd_y = Random.Range (2,N - 2);
	//0~3の乱数を生成(0=>上,1=>左,2=>下,3=>右)
	int rnd_vect = Random.Range (0, 3);
	if (data[rnd_x,rnd_y] == 0) {
	    switch (rnd_vect) {
		case 0:
		    if (data[rnd_x,rnd_y - 2] == 0 && rnd_y - 2 > 0) {
			data[rnd_x,rnd_y + 1] = 1;
		    }
		    break;
		case 1:
		    if (data[rnd_x - 2,rnd_y] == 0 && rnd_x - 2 > 0) {
			data[rnd_x - 1,rnd_y] = 1;
		    }
		    break;
		case 2:
		    if (data[rnd_x,rnd_y + 2] == 0 && rnd_y + 2 < N) {
			data[rnd_x,rnd_y + 1] = 1;
		    }
		    break;
		case 3:
		    if (data[rnd_x + 2,rnd_y] == 0 && rnd_x + 2 < N) {
			data[rnd_x + 1,rnd_y] = 1;
		    }
		    break;
		default:
		    break;
	    }
	}
    }
    //迷路を作成
    void Creata_Stage(){
	for (int i = 0; i < N; i++) {
	    for (int j = 0; j < N; j++) {
		if (data [i, j] == 1	) {
		    for (int k = 0; k < 5; k++) {
			Clone = Instantiate (Prefab_wall, new Vector3 (i - 25, k, j -25), Quaternion.identity);
			Clone.name = Clone.name + count.ToString ();
			obj_List.Add (Clone);
			count++;
		    }
		}
	    }
	}
    }
    //迷路のデータを初期化
    void data_init(){
	for (int i = 0; i < N; i++) {

	    for (int j = 0; j < N; j++) {
		data [i, j] = 0;
	    }
	}
	data [47, 47] = 0;
	data [47, 46] = 0;
	data [46, 47] = 0;
	data [46, 46] = 0;
	data [0, 0] = 0;
	data [0, 1] = 0;
	data [1, 0] = 0;
	data [1, 1] = 0;
	data [2, 0] = 0;
	data [2, 1] = 0;
	data [0, 2] = 0;
	data [1, 2] = 0;
	data [2, 2] = 0;
    }
}