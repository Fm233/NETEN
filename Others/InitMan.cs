#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;
public class InitMan : Editor
{
    [MenuItem("InitMan/Init")]
    public static void Init()
    {
        // Create classes
        GameObject mainObject = new GameObject();
        mainObject.name = "Main";
        Main main = mainObject.AddComponent<Main>();
        GameObject updater = new GameObject();
        updater.name = "Updater";
        main.updater = updater.AddComponent<Updater>();
        GameObject outJukebox = new GameObject();
        outJukebox.name = "OutJukebox";
        main.outJukebox = outJukebox.AddComponent<OutJukebox>();
        GameObject outCreateNote = new GameObject();
        outCreateNote.name = "OutCreateNote";
        main.outCreateNote = outCreateNote.AddComponent<OutCreateNote>();
        GameObject facNote = new GameObject();
        facNote.name = "FacNote";
        main.facNote = facNote.AddComponent<FacNote>();
        GameObject outDeleteNote = new GameObject();
        outDeleteNote.name = "OutDeleteNote";
        main.outDeleteNote = outDeleteNote.AddComponent<OutDeleteNote>();
        GameObject outJukeTime = new GameObject();
        outJukeTime.name = "OutJukeTime";
        main.outJukeTime = outJukeTime.AddComponent<OutJukeTime>();
        GameObject outCam = new GameObject();
        outCam.name = "OutCam";
        main.outCam = outCam.AddComponent<OutCam>();
        GameObject outMap = new GameObject();
        outMap.name = "OutMap";
        main.outMap = outMap.AddComponent<OutMap>();
        GameObject inNet = new GameObject();
        inNet.name = "InNet";
        main.inNet = inNet.AddComponent<InNet>();
        GameObject outNet = new GameObject();
        outNet.name = "OutNet";
        main.outNet = outNet.AddComponent<OutNet>();
        GameObject inJukeMove = new GameObject();
        inJukeMove.name = "InJukeMove";
        main.inJukeMove = inJukeMove.AddComponent<InJukeMove>();
        GameObject inJukebox = new GameObject();
        inJukebox.name = "InJukebox";
        main.inJukebox = inJukebox.AddComponent<InJukebox>();
        GameObject inJukeSpeed = new GameObject();
        inJukeSpeed.name = "InJukeSpeed";
        main.inJukeSpeed = inJukeSpeed.AddComponent<InJukeSpeed>();
        GameObject inCreateNote = new GameObject();
        inCreateNote.name = "InCreateNote";
        main.inCreateNote = inCreateNote.AddComponent<InCreateNote>();
        GameObject inDeleteNote = new GameObject();
        inDeleteNote.name = "InDeleteNote";
        main.inDeleteNote = inDeleteNote.AddComponent<InDeleteNote>();
        GameObject inSaveLevel = new GameObject();
        inSaveLevel.name = "InSaveLevel";
        main.inSaveLevel = inSaveLevel.AddComponent<InSaveLevel>();
        GameObject outSetSong = new GameObject();
        outSetSong.name = "OutSetSong";
        main.outSetSong = outSetSong.AddComponent<OutSetSong>();
        GameObject inInit = new GameObject();
        inInit.name = "InInit";
        main.inInit = inInit.AddComponent<InInit>();
        GameObject outInitSong = new GameObject();
        outInitSong.name = "OutInitSong";
        main.outInitSong = outInitSong.AddComponent<OutInitSong>();
        GameObject outClear = new GameObject();
        outClear.name = "OutClear";
        main.outClear = outClear.AddComponent<OutClear>();
        GameObject inLatency = new GameObject();
        inLatency.name = "InLatency";
        main.inLatency = inLatency.AddComponent<InLatency>();
        GameObject inLatencyReset = new GameObject();
        inLatencyReset.name = "InLatencyReset";
        main.inLatencyReset = inLatencyReset.AddComponent<InLatencyReset>();
        GameObject outLatency = new GameObject();
        outLatency.name = "OutLatency";
        main.outLatency = outLatency.AddComponent<OutLatency>();
        GameObject inHP = new GameObject();
        inHP.name = "InHP";
        main.inHP = inHP.AddComponent<InHP>();
        GameObject outHP = new GameObject();
        outHP.name = "OutHP";
        main.outHP = outHP.AddComponent<OutHP>();
        GameObject outFail = new GameObject();
        outFail.name = "OutFail";
        main.outFail = outFail.AddComponent<OutFail>();
        GameObject outWin = new GameObject();
        outWin.name = "OutWin";
        main.outWin = outWin.AddComponent<OutWin>();
        GameObject inMenuEdit = new GameObject();
        inMenuEdit.name = "InMenuEdit";
        main.inMenuEdit = inMenuEdit.AddComponent<InMenuEdit>();
        GameObject outEdit = new GameObject();
        outEdit.name = "OutEdit";
        main.outEdit = outEdit.AddComponent<OutEdit>();
        GameObject inMenuExitEdit = new GameObject();
        inMenuExitEdit.name = "InMenuExitEdit";
        main.inMenuExitEdit = inMenuExitEdit.AddComponent<InMenuExitEdit>();
        GameObject outMenu = new GameObject();
        outMenu.name = "OutMenu";
        main.outMenu = outMenu.AddComponent<OutMenu>();
        GameObject outGame = new GameObject();
        outGame.name = "OutGame";
        main.outGame = outGame.AddComponent<OutGame>();
        GameObject inMenuGame = new GameObject();
        inMenuGame.name = "InMenuGame";
        main.inMenuGame = inMenuGame.AddComponent<InMenuGame>();
        GameObject inMenuLatency = new GameObject();
        inMenuLatency.name = "InMenuLatency";
        main.inMenuLatency = inMenuLatency.AddComponent<InMenuLatency>();
        GameObject inMenuExitLatency = new GameObject();
        inMenuExitLatency.name = "InMenuExitLatency";
        main.inMenuExitLatency = inMenuExitLatency.AddComponent<InMenuExitLatency>();
        GameObject inMenuExitGame = new GameObject();
        inMenuExitGame.name = "InMenuExitGame";
        main.inMenuExitGame = inMenuExitGame.AddComponent<InMenuExitGame>();
        GameObject inWin = new GameObject();
        inWin.name = "InWin";
        main.inWin = inWin.AddComponent<InWin>();
        GameObject inJukeTime = new GameObject();
        inJukeTime.name = "InJukeTime";
        main.inJukeTime = inJukeTime.AddComponent<InJukeTime>();
        
        // Link factories
        main.facNote.inHP = main.inHP;
    }
}
#endif
