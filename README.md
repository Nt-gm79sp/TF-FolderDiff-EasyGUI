# TF-FolderDiff-EasyGUI

### 调用Visual Studio文件夹比对功能的简易工具

Visual Studio 自带了文件夹比对功能，可惜的是并没有放在易用的地方，需要在设置中启用Team Foundation Server，或者使用命令行调用TF.exe。
本程序便是一个生成调用参数的小工具，界面如下：

![Screenshot](https://user-images.githubusercontent.com/6905026/32622731-d036abda-c5be-11e7-8911-f0332f976d13.png)

点击运行后启动TF.exe

![TF.exe](https://user-images.githubusercontent.com/6905026/32622736-d3e3f2e2-c5be-11e7-9e7f-c27d2f6b3ac1.png)

在此窗口内双击项目即可进入Visual Studio查看详细比对。

---

此外，（当前版本）VS内置的GUI中，文件过滤器的默认参数有错误，少了分号，本程序中使用了修正后的参数。

原参数：
```
!bin\;!bld\;!ClientBin\;!Debug\;!obj\;!AppPackages\;!Release\;!TestResults\;!*.*~!*.appx!*.appxrecipe;!*.cache!*.cer!*.dbmdl!*.dll!*.docstates!*.docstates.suo;!*.err!*.exe!*.ilk!*.ipch!*.lastbuildstate!*.lce!*.ldf!*.lib!*.log!*.mdf!*.msscci!*.ncb!*.obj!*.opensdf!*.pch!*.pdb!*.pri!*.res!*.resources!*.sdf!*.suo!*.swp!*.temp!*.tfOrig*!*.tlog!*.tmp!*.trx!*.user!*.unsuccessfulbuild!*.v11.suo!*.vcxproj.user!*.vsix!*.vsmdi!*.vspscc!*.vssettings!*.vssscc!*.wrn!*.xap;!.metadata\
```

修正后的参数：
```
!bin\;!bld\;!ClientBin\;!Debug\;!obj\;!AppPackages\;!Release\;!TestResults\;!*.*~;!*.appx;!*.appxrecipe;!*.cache;!*.cer;!*.dbmdl;!*.dll;!*.docstates;!*.docstates.suo;!*.err;!*.exe;!*.ilk;!*.ipch;!*.lastbuildstate;!*.lce;!*.ldf;!*.lib;!*.log;!*.mdf;!*.msscci;!*.ncb;!*.obj;!*.opensdf;!*.pch;!*.pdb;!*.pri;!*.res;!*.resources;!*.sdf;!*.suo;!*.swp;!*.temp;!*.tfOrig*;!*.tlog;!*.tmp;!*.trx;!*.user;!*.unsuccessfulbuild;!*.v11.suo;!*.vcxproj.user;!*.vsix;!*.vsmdi;!*.vspscc;!*.vssettings;!*.vssscc;!*.wrn;!*.xap;!.metadata\
```

Love Visual Studio!
