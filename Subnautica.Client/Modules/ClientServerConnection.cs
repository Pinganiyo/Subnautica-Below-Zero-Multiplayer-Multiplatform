namespace Subnautica.Client.Modules
{
    using Subnautica.API.Enums;
    using Subnautica.API.Extensions;
    using Subnautica.API.Features;
    using Subnautica.Events.EventArgs;

    using System;
    using System.Collections.Generic;
    using System.Text;

    using TMPro;

    using UnityEngine.UI;

    public static class ClientServerConnection
    {
        /**
         *
         * Oyun içi menü açılırken tetiklenir.
         *
         
         *
         */
        public static void OnInGameMenuOpened(InGameMenuOpenedEventArgs ev)
        {
            if (Network.IsMultiplayerActive)
            {
                IngameMenu.main.saveButton.gameObject.SetActive(Network.IsHost);
                if (Network.IsHost)
                {
                    IngameMenu.main.saveButton.interactable = true;
                }

                if (IngameMenu.main.maxSecondsToBeRecentlySaved != 900000)
                {
                    IngameMenu.main.maxSecondsToBeRecentlySaved = 900000f;
                }
            }
            else
            {
                IngameMenu.main.saveButton.gameObject.SetActive(true);
                IngameMenu.main.maxSecondsToBeRecentlySaved = 120f;
            }
        }

        /**
         *
         * Oyun içi menüde Kaydet tıklandığında tetiklenir.
         *
         */
        public static void OnInGameMenuSaveGame(InGameMenuSaveGameEventArgs ev)
        {
            if (Network.IsMultiplayerActive)
            {
                ev.IsHandled = true;

                if (Network.IsHost)
                {
                    bool saved = Core.NetworkServer.SaveGame();
                    if (saved)
                    {
                        string msg = Language.main != null ? Language.main.Get("GameSaved") : "Game Saved.";
                        if (string.IsNullOrEmpty(msg))
                        {
                            msg = "Game Saved.";
                        }

                        ErrorMessage.AddMessage(msg);
                    }
                }
            }
        }

        /**
         *
         * Oyun içi menü kapandıktan sonra tetiklenir.
         *
         
         *
         */
        public static void OnInGameMenuClosed(InGameMenuClosedEventArgs ev)
        {/*
            if (ZeroGame.IsCurrentMultiplayerGame && !ZeroGame.IsMultiplayerConnectionActive)
            {
                ZeroGame.FreezeGame();
            }*/
        }

        /**
         *
         * Arka planda çalışma ayarı değişirken tetiklenir.
         *
         
         *
         */
        public static void OnSettingsRunInBackgroundChanging(SettingsRunInBackgroundChangingEventArgs ev)
        {
            if (Network.IsMultiplayerActive)
            {
                ev.IsAllowed = false;
            }
        }

        /**
         *
         * Ayarlardaki pda oyun duraklatma seçeneği değiştiğinde tetiklenir.
         *
         
         *
         */
        public static void OnSettingsPdaGamePauseChanging(SettingsPdaGamePauseChangingEventArgs ev)
        {
            if (Network.IsMultiplayerActive)
            {
                ev.IsAllowed = false;
            }
        }
    }
}