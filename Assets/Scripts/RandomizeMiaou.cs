using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomizeMiaou : MonoBehaviour
{

    public List<Image> images;
    public List<Sprite> sprites;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var image in images)
        {
            image.sprite = sprites[Random.Range(0, sprites.Count)];

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
