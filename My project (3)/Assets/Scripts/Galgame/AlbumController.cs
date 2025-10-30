using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class AlbumController : MonoBehaviour
{
    // 图片容器的路径
    public string containerPath = "Canvas/PackagePanle/Center/Scroll View/Viewport/Content";
    
    // 要加载的图片名称列表（在Resources文件夹中的名称）
    public List<string> imageNames = new List<string> { "bbl", "cd", "sl", "海滩" };
    
    void Start()
    {
        // 加载并显示图片
        LoadAndShowImages();
    }
    
    void LoadAndShowImages()
    {
        // 获取图片容器
        GameObject content = GameObject.Find(containerPath);
        if (content == null)
        {
            Debug.LogError("找不到图片容器: " + containerPath);
            return;
        }
        
        // 查找容器中的所有PackageUIItem
        List<GameObject> imageContainers = new List<GameObject>();
        for (int i = 0; i < content.transform.childCount; i++)
        {
            GameObject child = content.transform.GetChild(i).gameObject;
            if (child.name.Contains("PackageUIItem"))
            {
                imageContainers.Add(child);
            }
        }
        
        if (imageContainers.Count == 0)
        {
            Debug.LogWarning("在容器中找不到PackageUIItem");
            return;
        }
        
        // 加载并显示图片
        for (int i = 0; i < imageNames.Count && i < imageContainers.Count; i++)
        {
            Sprite sprite = Resources.Load<Sprite>(imageNames[i]);
            if (sprite != null)
            {
                // 查找PackageUIItem下的Image组件（假设图片显示在名为"Draw"的子对象中）
                Image imageComponent = imageContainers[i].transform.Find("Draw")?.GetComponent<Image>();
                if (imageComponent != null)
                {
                    imageComponent.sprite = sprite;
                    imageComponent.preserveAspect = true;
                }
                else
                {
                    Debug.LogWarning("在" + imageContainers[i].name + "中找不到Image组件");
                }
            }
            else
            {
                Debug.LogWarning("无法加载图片: " + imageNames[i]);
            }
        }
    }
}