﻿using Eneca.SpacesManager.Commands;
using Nice3point.Revit.Toolkit.External;
using System.Reflection;

namespace Eneca.SpacesManager;
[UsedImplicitly]
public class Application : ExternalApplication
{
    public static Application ThisApp;

    public Application()
    {
        ThisApp = this;
    }

    public override void OnStartup()
    {
        var panel = Application.CreatePanel("Panel name", "Eneca");

        var showButton = panel.AddPushButton<TestCommand>("Spaces Manager");
        showButton.SetImage("/Eneca.SpacesManager;component/Resources/Icons/RibbonIcon16.png");
        showButton.SetLargeImage("/Eneca.SpacesManager;component/Resources/Icons/RibbonIcon32.png");
    }
}