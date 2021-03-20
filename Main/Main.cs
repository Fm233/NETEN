using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class Main : MonoBehaviour
{
    public UseSaveLevel useSaveLevel;
    public DBLevel dBLevel;
    public UseLoadLevel useLoadLevel;
    public UseCreateNote useCreateNote;
    public DBNote dBNote;
    public UseDeleteNote useDeleteNote;
    public UseAbortLevel useAbortLevel;
    public OutCreateNote outCreateNote;
    public FacNote facNote;
    public OutDeleteNote outDeleteNote;
    public OutJukeTime outJukeTime;
    public OutCam outCam;
    public InCreateNote inCreateNote;
    public InDeleteNote inDeleteNote;
    public UseInitSong useInitSong;
    public DBSong dBSong;
    public UseSetSong useSetSong;
    public UseLatencyReset useLatencyReset;
    public DSLatency dSLatency;
    public UseLatency useLatency;
    public UseJukeTime useJukeTime;
    public OutMap outMap;
    public InMenuEdit inMenuEdit;
    public ConMenuState conMenuState;
    public InMenuExitEdit inMenuExitEdit;
    public InMenuLatency inMenuLatency;
    public InMenuGame inMenuGame;
    public InMenuExitLatency inMenuExitLatency;
    public InMenuExitGame inMenuExitGame;
    public ConMenuExitGame conMenuExitGame;
    public OutMenu outMenu;
    public ConMenuExitEdit conMenuExitEdit;
    public ConMenuExitLatency conMenuExitLatency;
    public ConMenuLatency conMenuLatency;
    public ConMenuGame conMenuGame;
    public ConMenuEdit conMenuEdit;
    public OutLatency outLatency;
    public OutGame outGame;
    public OutEdit outEdit;
    public InNet inNet;
    public OutNet outNet;
    public UseNoteKiller useNoteKiller;
    public InJukeMove inJukeMove;
    public OutJukebox outJukebox;
    public InJukebox inJukebox;
    public InJukeSpeed inJukeSpeed;
    public ConAbortLevel conAbortLevel;
    public InSaveLevel inSaveLevel;
    public ConLoadLevel conLoadLevel;
    public InInit inInit;
    public ConSetSong conSetSong;
    public OutSetSong outSetSong;
    public OutInitSong outInitSong;
    public InLatency inLatency;
    public InLatencyReset inLatencyReset;
    public OutLatencyDisplay outLatencyDisplay;
    public InJukeTime inJukeTime;
    public UseHP useHP;
    public OutHP outHP;
    public OutFail outFail;
    public OutClear outClear;
    public InWin inWin;
    public OutWin outWin;
    public Updater updater;
    void Start()
    {
        // Instantiate
        useSaveLevel = new UseSaveLevel();
        dBLevel = new DBLevel();
        useLoadLevel = new UseLoadLevel();
        useCreateNote = new UseCreateNote();
        dBNote = new DBNote();
        useDeleteNote = new UseDeleteNote();
        useAbortLevel = new UseAbortLevel();
        useInitSong = new UseInitSong();
        dBSong = new DBSong();
        useSetSong = new UseSetSong();
        useLatencyReset = new UseLatencyReset();
        dSLatency = new DSLatency();
        useLatency = new UseLatency();
        useJukeTime = new UseJukeTime();
        conMenuState = new ConMenuState();
        conMenuExitGame = new ConMenuExitGame();
        conMenuExitEdit = new ConMenuExitEdit();
        conMenuExitLatency = new ConMenuExitLatency();
        conMenuLatency = new ConMenuLatency();
        conMenuGame = new ConMenuGame();
        conMenuEdit = new ConMenuEdit();
        useNoteKiller = new UseNoteKiller();
        conAbortLevel = new ConAbortLevel();
        conLoadLevel = new ConLoadLevel();
        conSetSong = new ConSetSong();
        useHP = new UseHP();
        
        // Update
        updater.AddIMB(useSaveLevel);
        updater.AddIMB(useLoadLevel);
        updater.AddIMB(useCreateNote);
        updater.AddIMB(useDeleteNote);
        updater.AddIMB(useAbortLevel);
        updater.AddIMB(useInitSong);
        updater.AddIMB(useSetSong);
        updater.AddIMB(useLatencyReset);
        updater.AddIMB(useLatency);
        updater.AddIMB(useJukeTime);
        updater.AddIMB(conMenuState);
        updater.AddIMB(conMenuExitGame);
        updater.AddIMB(conMenuExitEdit);
        updater.AddIMB(conMenuExitLatency);
        updater.AddIMB(conMenuLatency);
        updater.AddIMB(conMenuGame);
        updater.AddIMB(conMenuEdit);
        updater.AddIMB(useNoteKiller);
        updater.AddIMB(conAbortLevel);
        updater.AddIMB(conLoadLevel);
        updater.AddIMB(conSetSong);
        updater.AddIMB(useHP);
        
        // Connect
        useSaveLevel.modelCrtLevelAction += dBLevel.ReceiveModelCrtLevel;
        useLoadLevel.modelGetLevelAction += dBLevel.ReceiveModelGetLevel;
        useCreateNote.modelCrtNoteAction += dBNote.ReceiveModelCrtNote;
        useDeleteNote.modelDelNoteAction += dBNote.ReceiveModelDelNote;
        useAbortLevel.modelDelNoteAction += dBNote.ReceiveModelDelNote;
        useSaveLevel.modelGetNoteAction += dBNote.ReceiveModelGetNote;
        outCreateNote.modelCrtInsNoteAction += facNote.ReceiveModelCrtInsNote;
        outDeleteNote.modelDelInsNoteAction += facNote.ReceiveModelDelInsNote;
        outJukeTime.modelOutJukeTimeAction += outCam.ReceiveModelOutJukeTime;
        outJukeTime.modelOutJukeTimeAction += inCreateNote.ReceiveModelOutJukeTime;
        outJukeTime.modelOutJukeTimeAction += inDeleteNote.ReceiveModelOutJukeTime;
        useInitSong.modelCrtSongAction += dBSong.ReceiveModelCrtSong;
        useSetSong.modelGetSongAction += dBSong.ReceiveModelGetSong;
        useLatencyReset.modelSetLatencyAction += dSLatency.ReceiveModelSetLatency;
        useLatency.modelSetLatencyAction += dSLatency.ReceiveModelSetLatency;
        useLatency.modelGetLatencyAction += dSLatency.ReceiveModelGetLatency;
        useLoadLevel.modelGetLatencyAction += dSLatency.ReceiveModelGetLatency;
        useJukeTime.modelGetLatencyAction += dSLatency.ReceiveModelGetLatency;
        useCreateNote.noteAction += outCreateNote.ReceiveNote;
        outMap.noteAction += outCreateNote.ReceiveNote;
        inMenuEdit.menuStateAction += conMenuState.ReceiveMenuState;
        inMenuExitEdit.menuStateAction += conMenuState.ReceiveMenuState;
        inMenuLatency.menuStateAction += conMenuState.ReceiveMenuState;
        inMenuGame.menuStateAction += conMenuState.ReceiveMenuState;
        inMenuExitLatency.menuStateAction += conMenuState.ReceiveMenuState;
        inMenuExitGame.menuStateAction += conMenuState.ReceiveMenuState;
        conMenuExitGame.modelOutMenuAction += outMenu.ReceiveModelOutMenu;
        conMenuExitEdit.modelOutMenuAction += outMenu.ReceiveModelOutMenu;
        conMenuExitLatency.modelOutMenuAction += outMenu.ReceiveModelOutMenu;
        conMenuLatency.modelOutMenuAction += outMenu.ReceiveModelOutMenu;
        conMenuGame.modelOutMenuAction += outMenu.ReceiveModelOutMenu;
        conMenuEdit.modelOutMenuAction += outMenu.ReceiveModelOutMenu;
        conMenuExitLatency.modelOutLatencyAction += outLatency.ReceiveModelOutLatency;
        conMenuLatency.modelOutLatencyAction += outLatency.ReceiveModelOutLatency;
        conMenuGame.modelOutGameAction += outGame.ReceiveModelOutGame;
        conMenuExitGame.modelOutGameAction += outGame.ReceiveModelOutGame;
        conMenuExitEdit.modelOutEditAction += outEdit.ReceiveModelOutEdit;
        conMenuEdit.modelOutEditAction += outEdit.ReceiveModelOutEdit;
        inNet.modelInNetAction += outNet.ReceiveModelInNet;
        inNet.modelInNetAction += useNoteKiller.ReceiveModelInNet;
        inJukeMove.modelInJukeMoveToOutJukeboxAction += outJukebox.ReceiveModelInJukeMoveToOutJukebox;
        inJukebox.jukeOpAction += outJukebox.ReceiveJukeOp;
        inJukeSpeed.modelInJukeSpeedToOutJukeboxAction += outJukebox.ReceiveModelInJukeSpeedToOutJukebox;
        useLoadLevel.loadLevelAssetAction += outMap.ReceiveLoadLevelAsset;
        useDeleteNote.modelUseDeleteNoteToOutDeleteNoteAction += outDeleteNote.ReceiveModelUseDeleteNoteToOutDeleteNote;
        conAbortLevel.modelConAbortLevelToUseAbortLevelAction += useAbortLevel.ReceiveModelConAbortLevelToUseAbortLevel;
        inSaveLevel.modelInSaveLevelToUseSaveLevelAction += useSaveLevel.ReceiveModelInSaveLevelToUseSaveLevel;
        conLoadLevel.modelConLoadLevelToUseLoadLevelAction += useLoadLevel.ReceiveModelConLoadLevelToUseLoadLevel;
        inDeleteNote.modelInDeleteNoteToUseDeleteNoteAction += useDeleteNote.ReceiveModelInDeleteNoteToUseDeleteNote;
        inCreateNote.noteAction += useCreateNote.ReceiveNote;
        inInit.modelInInitToUseInitSongAction += useInitSong.ReceiveModelInInitToUseInitSong;
        conSetSong.modelConSetSongToUseSetSongAction += useSetSong.ReceiveModelConSetSongToUseSetSong;
        useSetSong.modelUseSetSongToOutSetSongAction += outSetSong.ReceiveModelUseSetSongToOutSetSong;
        useInitSong.modelUseInitSongToOutInitSongAction += outInitSong.ReceiveModelUseInitSongToOutInitSong;
        inLatency.modelInLatencyToUseLatencyAction += useLatency.ReceiveModelInLatencyToUseLatency;
        inLatencyReset.modelInLatencyResetToUseLatencyResetAction += useLatencyReset.ReceiveModelInLatencyResetToUseLatencyReset;
        useLatency.modelUseLatencyToOutLatencyDisplayAction += outLatencyDisplay.ReceiveModelUseLatencyToOutLatencyDisplay;
        useLatencyReset.modelUseLatencyResetToOutLatencyDisplayAction += outLatencyDisplay.ReceiveModelUseLatencyResetToOutLatencyDisplay;
        inMenuEdit.modelInMenuEditToConMenuEditAction += conMenuEdit.ReceiveModelInMenuEditToConMenuEdit;
        conMenuEdit.modelConMenuEditToConSetSongAction += conSetSong.ReceiveModelConMenuEditToConSetSong;
        inMenuExitEdit.modelInMenuExitEditToConMenuExitEditAction += conMenuExitEdit.ReceiveModelInMenuExitEditToConMenuExitEdit;
        inMenuGame.modelInMenuGameToConMenuGameAction += conMenuGame.ReceiveModelInMenuGameToConMenuGame;
        conMenuGame.modelConMenuGameToConLoadLevelAction += conLoadLevel.ReceiveModelConMenuGameToConLoadLevel;
        inMenuLatency.modelInMenuLatencyToConMenuLatencyAction += conMenuLatency.ReceiveModelInMenuLatencyToConMenuLatency;
        inMenuExitGame.modelInMenuExitGameToConMenuExitGameAction += conMenuExitGame.ReceiveModelInMenuExitGameToConMenuExitGame;
        conMenuExitEdit.modelConMenuExitEditToConAbortLevelAction += conAbortLevel.ReceiveModelConMenuExitEditToConAbortLevel;
        inMenuExitLatency.modelInMenuExitLatencyToConMenuExitLatencyAction += conMenuExitLatency.ReceiveModelInMenuExitLatencyToConMenuExitLatency;
        inJukeTime.modelInJukeTimeToUseJukeTimeAction += useJukeTime.ReceiveModelInJukeTimeToUseJukeTime;
        useJukeTime.modelUseJukeTimeToOutJukeTimeAction += outJukeTime.ReceiveModelUseJukeTimeToOutJukeTime;
        conLoadLevel.modelConLoadLevelToConSetSongAction += conSetSong.ReceiveModelConLoadLevelToConSetSong;
        useLoadLevel.modelUseLoadLevelToUseNoteKillerAction += useNoteKiller.ReceiveModelUseLoadLevelToUseNoteKiller;
        useNoteKiller.modelUseNoteKillerToUseHPAction += useHP.ReceiveModelUseNoteKillerToUseHP;
        useHP.modelUseHPToOutHPAction += outHP.ReceiveModelUseHPToOutHP;
        useHP.modelUseHPToOutFailAction += outFail.ReceiveModelUseHPToOutFail;
        useAbortLevel.modelOutClearAction += outClear.ReceiveModelOutClear;
        conMenuExitGame.modelOutClearAction += outClear.ReceiveModelOutClear;
        inWin.modelInWinToOutWinAction += outWin.ReceiveModelInWinToOutWin;
        outSetSong.modelOutSetSongAction += outJukebox.ReceiveModelOutSetSong;
        conMenuState.menuStateAction += outCam.ReceiveMenuState;
        conMenuState.menuStateAction += inNet.ReceiveMenuState;
        conMenuState.menuStateAction += inWin.ReceiveMenuState;
        outJukebox.timeInfAction += inJukeTime.ReceiveTimeInf;
        outJukebox.timeInfAction += inWin.ReceiveTimeInf;
        outJukebox.timeInfAction += inLatency.ReceiveTimeInf;
    }
}
