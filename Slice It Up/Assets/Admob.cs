using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class Admob : MonoBehaviour
{
	private BannerView adBanner;

	private string idApp, idBanner;


	void Start()
	{
		idApp = "ca-app-pub-1077507983327830~4415848075";
		idBanner = "ca-app-pub-3940256099942544/6300978111";

		MobileAds.Initialize(idApp);

		RequestBannerAd();
	}



	#region Banner Methods --------------------------------------------------

	public void RequestBannerAd()
	{
		adBanner = new BannerView(idBanner, AdSize.Banner, AdPosition.Bottom);
		AdRequest request = AdRequestBuild();
		adBanner.LoadAd(request);
	}

	public void DestroyBannerAd()
	{
		if (adBanner != null)
			adBanner.Destroy();
	}

	#endregion


	//------------------------------------------------------------------------
	AdRequest AdRequestBuild()
	{
		return new AdRequest.Builder().Build();
	}

	void OnDestroy()
	{
		DestroyBannerAd();
	}
}
