
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode] // これを追加
public class CloudGenerator : MonoBehaviour
{
    public GameObject prefab;

    Vector3[,] cloudData =
    {
        {new Vector3(-1.1f, 15.5f, 0f), new Vector3(0.6f, 1f, 1f)},
        {new Vector3(1f, 16.6f, 0f), new Vector3(1f, 1f, 1f)},
        {new Vector3(-1.6f, 13.0f, 0f), new Vector3(0.7f, 1f, 1f)},
        {new Vector3(1.4f, 13.2f, 0f), new Vector3(1f, 1f, 1f)},
        {new Vector3(-1f, 11f, 0f), new Vector3(0.8f, 1f, 1f)},
        {new Vector3(1.1f, 9f, 0f), new Vector3(0.9f, 1f, 1f)},
        {new Vector3(-1.6f, 7.7f, 0f), new Vector3(1f, 1f, 1f)},
        {new Vector3(1.6f, 6.4f, 0f), new Vector3(1f, 1f, 1f)},
        {new Vector3(-0.1f, 4.2f, 0f), new Vector3(1f, 1f, 1f)},
        {new Vector3(1.4f, 2.5f, 0f), new Vector3(1f, 1f, 1f)},
        {new Vector3(-1.6f, 1.8f, 0f), new Vector3(1f, 1f, 1f)},
        {new Vector3(-0.2f, -0.7f, 0f), new Vector3(1f, 1f, 1f)},
        {new Vector3(1.6f, -2.1f, 0f), new Vector3(1f, 1f, 1f)},
        {new Vector3(-1.6f, -2.8f, 0f), new Vector3(1f, 1f, 1f)},
        {new Vector3(-1.55f, -5.1f, 0f), new Vector3(1.1f, 1f, 1f)},
        {new Vector3(0f, -5.1f, 0f), new Vector3(1.1f, 1f, 1f)},
        {new Vector3(1.55f, -5.1f, 0f), new Vector3(1.1f, 1f, 1f)},
    };

    void Start()
    {
        // エディタ上ですでに生成されていたら何もしない
        if (!Application.isPlaying && transform.childCount > 0)
        {
            return;
        }

        // 生成処理
        for (int i = 0; i < cloudData.GetLength(0); i++)
        {
            GameObject go = Instantiate(prefab, transform); // 親をこのGameObjectに
            go.transform.localPosition = cloudData[i, 0];
            go.transform.localScale = cloudData[i, 1];
            go.name = "Cloud_" + i;
        }

        // プレイ中だけ自身を破棄（エディタでは残しておく）
        if (Application.isPlaying)
        {
            //Destroy(gameObject);
        }
    }
}
