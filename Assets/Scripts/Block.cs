using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //config params
    [SerializeField] AudioClip blockBreakSound;
    [SerializeField] GameObject sparkles;
    [SerializeField] Sprite[] damageSprites;

    //cached references
    Level level;
    GameStatus myGame;

    //state variables
    [SerializeField] int timesHit; // Just to see in the editor for debug purposes. 

    private void Start()
    {
        CountBreakableBlocks();
    }

    private void CountBreakableBlocks()
    {
        if (tag == "Breakable")
        {
            level = FindObjectOfType<Level>();
            level.CountBlocks();
        }
    }

    private void OnCollisionEnter2D()
    {
        timesHit++;
        int maxHits = damageSprites.Length + 1;
        if (tag == "Breakable" && timesHit==maxHits)
        {
            Destroy(gameObject);
            BreakAudio();
            level.DestroyBlocks();
            AddingScore();
            TriggerVFX();
        }
        else if(tag == "Breakable" && timesHit<maxHits)
        {
            ShowBlockDamage();
            TriggerVFX();
        }
       
    }

    private void ShowBlockDamage()
    {
        int damageLevel = timesHit - 1;
        if(damageSprites[damageLevel]!=null)
        {
            GetComponent<SpriteRenderer>().sprite = damageSprites[damageLevel];
        }
        else
        {
            Debug.LogError(gameObject.name + "'s Block Sprite is missing");
        }
        
    }

    private void AddingScore()
    {
        FindObjectOfType<GameStatus>().AddToScore();
    }

    private void BreakAudio()
    {
        AudioSource.PlayClipAtPoint(blockBreakSound, Camera.main.transform.position);
    }

    private void TriggerVFX()
    {
        GameObject newSparklez = Instantiate(sparkles, transform.position, transform.rotation);
        Destroy(newSparklez, 1f);
    }
}
