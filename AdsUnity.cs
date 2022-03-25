using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize("4651951");
    }

    public static void RewardedVideo()
    {
        Advertisement.Show("Rewarded_Android");
    }

    public static void InterstitialVideo()
    {
        Advertisement.Show("Interstitial_Android");
    }
}
