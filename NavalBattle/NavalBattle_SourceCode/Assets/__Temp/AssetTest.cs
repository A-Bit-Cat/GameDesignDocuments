using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YooAsset;
//using YooAsset.Manage;

public class AssetTest : MonoBehaviour
{
    private const string PackageName = "GameAsset";
    private const string PackageServerUrl = "http://apex.best1.top/GameAsset/";
    private const string PrefabName = "marble";

    private void Start()
    {
        // 初始化 YooAsset 系统
        YooAssets.Initialize();

        // 创建资源包
        var package = YooAssets.CreatePackage(PackageName);

        // 设置资源包的服务器地址
        //package.SetServerUrl(PackageServerUrl);

    }
}

/*
        if (playMode == EPlayMode.HostPlayMode)
        {
            string defaultHostServer = GetHostServerURL();
            string fallbackHostServer = GetHostServerURL();
            var createParameters = new HostPlayModeParameters();
            createParameters.DecryptionServices = new FileStreamDecryption();
            createParameters.BuildinQueryServices = new GameQueryServices();
            createParameters.RemoteServices = new RemoteServices(defaultHostServer, fallbackHostServer);
            initializationOperation = package.InitializeAsync(createParameters);
        }
*/