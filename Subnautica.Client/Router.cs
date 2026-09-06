namespace Subnautica.Client
{
    using Subnautica.Client.Modules;
    using Subnautica.Events.EventArgs;

    using Initial         = Subnautica.Client.Synchronizations.InitialSync;
    using Encyclopedia    = Subnautica.Client.Synchronizations.Processors.Encyclopedia;
    using Inventory       = Subnautica.Client.Synchronizations.Processors.Inventory;
    using Player          = Subnautica.Client.Synchronizations.Processors.Player;
    using Technology      = Subnautica.Client.Synchronizations.Processors.Technology;
    using Building        = Subnautica.Client.Synchronizations.Processors.Building;
    using PDA             = Subnautica.Client.Synchronizations.Processors.PDA;
    using World           = Subnautica.Client.Synchronizations.Processors.World;
    using Metadata        = Subnautica.Client.Synchronizations.Processors.Metadata;
    using General         = Subnautica.Client.Synchronizations.Processors.General;
    using Items           = Subnautica.Client.Synchronizations.Processors.Items;
    using Vehicle         = Subnautica.Client.Synchronizations.Processors.Vehicle;
    using Creatures       = Subnautica.Client.Synchronizations.Processors.Creatures;
    using WorldEntities   = Subnautica.Client.Synchronizations.Processors.WorldEntities;
    using Story           = Subnautica.Client.Synchronizations.Processors.Story;
    using DynamicEntities = Subnautica.Client.Synchronizations.Processors.WorldEntities.DynamicEntities;

    public class Router
    {
        /**
         *
         * Eklenti aktifleştiğinde tetiklenir.
         *
         
         *
         */
        public void OnPluginEnabled()
        {
            InviteCodeModule.OnPluginEnabled();
            MainProcess.OnPluginEnabled();
            DiscordRichPresence.OnPluginEnabled();
        }

        /**
         *
         * Oyun içi menü açılırken tetiklenir.
         *
         
         *
         */
        public void OnInGameMenuOpened(InGameMenuOpenedEventArgs ev)
        {
            InviteCodeModule.OnInGameMenuOpened(ev);
            ClientServerConnection.OnInGameMenuOpened(ev);
        }

        /**
         *
         * Oyun içi menüde Kaydet tıklandığında tetiklenir.
         *
         */
        public void OnInGameMenuSaveGame(InGameMenuSaveGameEventArgs ev)
        {
            ClientServerConnection.OnInGameMenuSaveGame(ev);
        }

        /**
         *
         * Oyun içi menü kapandıktan sonra tetiklenir.
         *
         
         *
         */
        public void OnInGameMenuClosed(InGameMenuClosedEventArgs ev)
        {
            ClientServerConnection.OnInGameMenuClosed(ev);
        }

        /**
         *
         * Arka planda çalışma ayarı değişirken tetiklenir.
         *
         
         *
         */
        public void OnSettingsRunInBackgroundChanging(SettingsRunInBackgroundChangingEventArgs ev)
        {
            ClientServerConnection.OnSettingsRunInBackgroundChanging(ev);
        }

        /**
         *
         * Sahne yüklendiğinde tetiklenir.
         *
         
         *
         */
        public void OnSceneLoaded(SceneLoadedEventArgs ev)
        {
            InviteCodeModule.OnSceneLoaded(ev);
            DiscordRichPresence.OnSceneLoaded(ev);
            MainProcess.OnSceneLoaded(ev);
            MultiplayerMainMenu.OnSceneLoaded(ev);
        }

        /**
         *
         * Ana menü kayıtlı oyunları sil iptal onay butonu tetiklenmesi.
         *
         
         *
         */
        public void OnMenuSaveCancelDeleteButtonClicking(MenuSaveCancelDeleteButtonClickingEventArgs ev)
        {
            MultiplayerMainMenu.OnMenuSaveCancelDeleteButtonClicking(ev);
        }

        /**
         *
         * Ana menü kayıtlı oyunu başlat tetiklemesi
         *
         
         *
         */
        public void OnMenuSaveLoadButtonClicking(MenuSaveLoadButtonClickingEventArgs ev)
        {
            MultiplayerMainMenu.OnMenuSaveLoadButtonClicking(ev);
        }

        /**
         *
         * Ana menü kayıtlı oyunları sil butonu tetiklenmesi.
         *
         
         *
         */
        public void OnMenuSaveDeleteButtonClicking(MenuSaveDeleteButtonClickingEventArgs ev)
        {
            MultiplayerMainMenu.OnMenuSaveDeleteButtonClicking(ev);
        }

        /**
         *
         * Ana menü kayıtlı oyun buton bilgileri tetiklenir.
         *
         
         *
         */
        public void OnMenuSaveUpdateLoadedButtonState(MenuSaveUpdateLoadedButtonStateEventArgs ev)
        {
            MultiplayerMainMenu.OnMenuSaveUpdateLoadedButtonState(ev);
        }

        /**
         *
         * Ansiklopedi taraması yapıldığında tetiklenir.
         *
         
         *
         */
        public void OnEncyclopediaAdded(EncyclopediaAddedEventArgs ev)
        {
            Encyclopedia.AddedProcessor.OnEncyclopediaAdded(ev);
        }

        /**
         *
         * Bir eşya veya bina eşya taslağı oluşturulduğunda saniyede ortalama 60 kez tetiklenir.
         *
         
         *
         */
        public void OnConstructingGhostMoved(ConstructionGhostMovedEventArgs ev)
        {
            Building.GhostMovedProcessor.OnConstructingGhostMoved(ev);
        }

        /**
         *
         * Hayalet yapı kurulmaya çalışıldığında tetiklenir.
         *
         
         *
         */
        public void OnConstructingGhostTryPlacing(ConstructionGhostTryPlacingEventArgs ev)
        {
            Building.GhostTryPlacingProcessor.OnConstructingGhostTryPlacing(ev);
        }

        /**
         *
         * Oyuncu verileri tetiklendikten sonra çalışır
         *
         
         *
         */
        public void OnPlayerUpdated(PlayerUpdatedEventArgs ev)
        {
            Player.UpdatedProcessor.OnPlayerUpdated(ev);
        }

        /**
         *
         * Teknoloji taraması tamamlandığında tetiklenir.
         *
         
         *
         */
        public void OnTechnologyAdded(TechnologyAddedEventArgs ev)
        {
            Technology.AddedProcessor.OnTechnologyAdded(ev);
        }

        /**
         *
         * Teknoloji parçası taraması tamamlandığında tetiklenir.
         *
         
         *
         */
        public void OnTechnologyFragmentAdded(TechnologyFragmentAddedEventArgs ev)
        {
            Technology.FragmentAddedProcessor.OnTechnologyFragmentAdded(ev);
        }

        /**
         *
         * Ayarlardaki pda oyun duraklatma seçeneği değiştiğinde tetiklenir.
         *
         
         *
         */
        public void OnSettingsPdaGamePauseChanging(SettingsPdaGamePauseChangingEventArgs ev)
        {
            ClientServerConnection.OnSettingsPdaGamePauseChanging(ev);
        }

        /**
         *
         * Yapı inşaa değeri değiştiğinde tetiklenir.
         *
         
         *
         */
        public void OnConstructingAmountChanged(ConstructionAmountChangedEventArgs ev)
        {
            Building.AmountChangedProcessor.OnConstructingAmountChanged(ev);
        }

        /**
         *
         * Yapı inşaası tamamlandığında tetiklenir.
         *
         
         *
         */
        public void OnConstructingCompleted(ConstructionCompletedEventArgs ev)
        {
            Building.CompletedProcessor.OnConstructingCompleted(ev);
            Building.ConstructionSyncedProcessor.OnConstructingCompleted(ev);
        }

        /**
         *
         * Yapı yıkıldığında tetiklenir.
         *
         
         *
         */
        public void OnConstructingRemoved(ConstructionRemovedEventArgs ev)
        {
            Building.RemovedProcessor.OnConstructingRemoved(ev);
            Building.ConstructionSyncedProcessor.OnConstructingRemoved(ev);
        }

        /**
         *
         * Oyuncu'nun envanterine bir eşya geldiğinde tetiklenir.
         *
         
         *
         */
        public void OnInventoryItemAdded(InventoryItemAddedEventArgs ev)
        {
            Inventory.ItemProcessor.OnInventoryItemAdded(ev);
        }

        /**
         *
         * Oyuncu'nun envanterinden bir eşya kaldırıldığında tetiklenir.
         *
         
         *
         */
        public void OnInventoryItemRemoved(InventoryItemRemovedEventArgs ev)
        {
            Inventory.ItemProcessor.OnInventoryItemRemoved(ev);
        }

        /**
         *
         * Oyuncu istatistikleri alındığında tetiklenir.
         *
         
         *
         */
        public void OnPlayerStatsUpdated(PlayerStatsUpdatedEventArgs ev)
        {
            Player.StatsProcessor.OnPlayerStatsUpdated(ev);
        }

        /**
         *
         * Oyuncu elindeki nesnenin enerjisi değiştiğinde tetiklenir.
         *
         
         *
         */
        public void OnToolBatteryEnergyChanged(ToolBatteryEnergyChangedEventArgs ev)
        {
            Player.ToolEnergyProcessor.OnToolBatteryEnergyChanged(ev);
        }

        /**
         *
         * Komut kullanıldığında tetiklenir.
         *
         
         *
         */
        public void OnUsingCommand(PlayerUsingCommandEventArgs ev)
        {
            Player.ConsoleCommandProcessor.OnUsingCommand(ev);
        }

        /**
         *
         * Oyuncunun yeniden doğma noktası değişince tetiklenir.
         *
         
         *
         */
        public void OnPlayerRespawnPointChanged(PlayerRespawnPointChangedEventArgs ev)
        {
            Player.RespawnPointProcessor.OnPlayerRespawnPointChanged(ev);
        }

        /**
         *
         * Oyuncu istatistikleri alındığında tetiklenir.
         *
         
         *
         */
        public void OnPingVisibilityChanged(PlayerPingVisibilityChangedEventArgs ev)
        {
            PDA.NotificationProcessor.OnPingVisibilityChanged(ev);
        }

        /**
         *
         * Oyuncu istatistikleri alındığında tetiklenir.
         *
         
         *
         */
        public void OnPingColorChanged(PlayerPingColorChangedEventArgs ev)
        {
            PDA.NotificationProcessor.OnPingColorChanged(ev);
        }

        /**
         *
         * Oyuncu ana menüye gittiğinde tetiklenir.
         *
         
         *
         */
        public void OnQuittingToMainMenu(QuittingToMainMenuEventArgs ev)
        {
            InviteCodeModule.OnQuittingToMainMenu(ev);
            MainProcess.OnQuittingToMainMenu(ev);
        }

        /**
         *
         * Oyuncu oyundan çıkarken tetiklenir.
         *
         
         *
         */
        public void OnQuitting()
        {
            MainProcess.OnQuitting();
        }

        /**
         *
         * Oyuncu bir eşyayı kuşandığında tetiklenir.
         *
         
         *
         */
        public void OnEquipmentEquiped()
        {
            Inventory.EquipmentProcessor.OnProcessEquipment();
        }

        /**
         *
         * Oyuncu bir eşyayı üzerinden çıkardığında tetiklenir.
         *
         
         *
         */
        public void OnEquipmentUnequiped()
        {
            Inventory.EquipmentProcessor.OnProcessEquipment();
        }

        /**
         *
         * Oyuncu bir eşyayı slotlara atadığında tetiklenir.
         *
         
         *
         */
        public void OnQuickSlotBinded()
        {
            Inventory.QuickSlotProcessor.OnProcessQuickSlot();
        }

        /**
         *
         * Oyuncu bir eşyayı slotlardan kaldırdığında tetiklenir.
         *
         
         *
         */
        public void OnQuickSlotUnbinded()
        {
            Inventory.QuickSlotProcessor.OnProcessQuickSlot();
        }

        /**
         *
         * Oyuncu bir eşyayı slotlardan kaldırdığında tetiklenir.
         *
         
         *
         */
        public void OnQuickSlotActiveChanged(QuickSlotActiveChangedEventArgs ev)
        {
            Inventory.QuickSlotProcessor.OnProcessQuickSlot();
        }

        /**
         *
         * Tarama tamamlandığında tetiklenir.
         *
         
         *
         */
        public void OnScannerCompleted(ScannerCompletedEventArgs ev)
        {
            Technology.ScannerCompletedProcessor.OnScannerCompleted(ev);
        }

        /**
         *
         * Yeni pin eklendiğinde tetiklenir.
         *
         
         *
         */
        public void OnItemPinAdded()
        {
            Inventory.ItemPinProcessor.OnProcessPin();
        }

        /**
         *
         * Pin kaldırıldığında tetiklenir.
         *
         
         *
         */
        public void OnItemPinRemoved()
        {
            Inventory.ItemPinProcessor.OnProcessPin();
        }

        /**
         *
         * Pin taşındığında tetiklenir.
         *
         
         *
         */
        public void OnItemPinMoved()
        {
            Inventory.ItemPinProcessor.OnProcessPin();
        }

        /**
         *
         * PDA log kaydı eklenince tetiklenir.
         *
         
         *
         */
        public void OnPDALogAdded(PDALogAddedEventArgs ev)
        {
            PDA.LogAddedProcessor.OnPDALogAdded(ev);
        }
        
        /**
         *
         * PDA'dan bildirim kaldırılınca/eklenince tetiklenir.
         *
         
         *
         */
        public void OnNotificationToggle(NotificationToggleEventArgs ev)
        {
            PDA.NotificationProcessor.OnNotificationToggle(ev);
        }

        /**
         *
         * Teknoloji analiz edildiğinde tetiklenir.
         *
         
         *
         */
        public void OnTechAnalyzeAdded(TechAnalyzeAddedEventArgs ev)
        {
            PDA.TechAnalyzeAddedProcessor.OnTechAnalyzeAdded(ev);
        }

        /**
         *
         * Yapı inşaası ilk kaldırma işlemi olduğunda tetiklenir.
         *
         
         *
         */
        public void OnDeconstructionBegin(DeconstructionBeginEventArgs ev)
        {
            Building.DeconstructionBeginProcessor.OnDeconstructionBegin(ev);
        }

        /**
         *
         * Mobilya inşaası ilk kaldırma işlemi olduğunda tetiklenir.
         *
         
         *
         */
        public void OnFurnitureDeconstructionBegin(FurnitureDeconstructionBeginEventArgs ev)
        {
            Building.FurnitureDeconstructionBeginProcessor.OnFurnitureDeconstructionBegin(ev);
        }

        /**
         *
         * Tuvalet kapağı açılıp/kapandığında tetiklenir.
         *
         
         *
         */
        public void OnToiletSwitchToggle(ToiletSwitchToggleEventArgs ev)
        {
            Metadata.ToiletProcessor.OnToiletSwitchToggle(ev);
        }

        /**
         *
         * Oyuncak aktif/pasif olduğunda tetiklenir.
         *
         
         *
         */
        public void OnEmmanuelPendulumSwitchToggle(EmmanuelPendulumSwitchToggleEventArgs ev)
        {
            Metadata.EmmanuelPendulumProcessor.OnEmmanuelPendulumSwitchToggle(ev);
        }

        /**
         *
         * Terapi nesnesi aktif/pasif olduğunda tetiklenir.
         *
         
         *
         */
        public void OnAromatherapyLampSwitchToggle(AromatherapyLampSwitchToggleEventArgs ev)
        {
            Metadata.AromatherapyProcessor.OnAromatherapyLampSwitchToggle(ev);
        }

        /**
         *
         * Ocak nesnesi aktif/pasif olduğunda tetiklenir.
         *
         
         *
         */
        public void OnSmallStoveSwitchToggle(SmallStoveSwitchToggleEventArgs ev)
        {
            Metadata.SmallStoveProcessor.OnSmallStoveSwitchToggle(ev);
        }

        /**
         *
         * Lavabo nesnesi aktif/pasif olduğunda tetiklenir.
         *
         
         *
         */
        public void OnSinkSwitchToggle(SinkSwitchToggleEventArgs ev)
        {
            Metadata.SinkProcessor.OnSinkSwitchToggle(ev);
        }

        /**
         *
         * Banyo nesnesi aktif/pasif olduğunda tetiklenir.
         *
         
         *
         */
        public void OnShowerSwitchToggle(ShowerSwitchToggleEventArgs ev)
        {
            Metadata.ShowerProcessor.OnShowerSwitchToggle(ev);
        }

        /**
         *
         * Kardan adam yok edilirken tetiklenir.
         *
         
         *
         */
        public void OnSnowmanDestroying(SnowmanDestroyingEventArgs ev)
        {
            Metadata.SnowmanProcessor.OnSnowmanDestroying(ev);
            World.StaticEntityProcessor.OnSnowmanDestroying(ev);
        }

        /**
         *
         * Tabela da veri değişimi olduğunda tetiklenir.
         *
         
         *
         */
        public void OnSignDataChanged(SignDataChangedEventArgs ev)
        {
            Metadata.SignProcessor.OnSignDataChanged(ev);
            Items.DeployableStorageProcessor.OnSignDataChanged(ev);
            Vehicle.SeaTruckStorageModuleProcessor.OnSignDataChanged(ev);
            Vehicle.SeaTruckFabricatorModuleProcessor.OnSignDataChanged(ev);
        }

        /**
         *
         * Resim çervesine resim eklenirken tetiklenir.
         *
         
         *
         */
        public void OnPictureFrameImageSelecting(PictureFrameImageSelectingEventArgs ev)
        {
            Metadata.PictureFrameProcessor.OnPictureFrameImageSelecting(ev);
        }

        /**
         *
         * Yatağı kullanabilirlik durumunda tetiklenir.
         *
         
         *
         */
        public void OnBedIsCanSleepChecking(BedIsCanSleepCheckingEventArgs ev)
        {
            Metadata.BedProcessor.OnBedIsCanSleepChecking(ev);
        }

        /**
         *
         * Kullanıcı yatağa tıkladığında tetiklenir.
         *
         
         *
         */
        public void OnBedEnterInUseMode(BedEnterInUseModeEventArgs ev)
        {
            Metadata.BedProcessor.OnBedEnterInUseMode(ev);
            Vehicle.SeaTruckSleeperModuleProcessor.OnBedEnterInUseMode(ev);
        }

        /**
         *
         * Kullanıcı yatak'dan kalktığında tetiklenir.
         *
         
         *
         */
        public void OnBedExitInUseMode(BedExitInUseModeEventArgs ev)
        {
            Metadata.BedProcessor.OnBedExitInUseMode(ev);
            Vehicle.SeaTruckSleeperModuleProcessor.OnBedExitInUseMode(ev);
        }

        /**
         *
         * Şarkı kutusunda veri değişimi olduğunda tetiklenir.
         *
         
         *
         */
        public void OnJukeboxUsed(JukeboxUsedEventArgs ev)
        {
            Metadata.JukeboxProcessor.OnJukeboxUsed(ev);
            Vehicle.SeaTruckSleeperModuleProcessor.OnJukeboxUsed(ev);
        }

        /**
         *
         * Şarkı diski açıldığında tetiklenir.
         *
         
         *
         */
        public void OnJukeboxDiskAdded(JukeboxDiskAddedEventArgs ev)
        {
            PDA.JukeboxDiskAddedProcessor.OnJukeboxDiskAdded(ev);
        }

        /**
         *
         * Fabricator nesnesinden bir eşya alındığında tetiklenir.
         *
         
         *
         */
        public void OnCrafterItemPickup(CrafterItemPickupEventArgs ev)
        {
            Metadata.CrafterProcessor.OnCrafterItemPickup(ev);
        }

        /**
         *
         * Fabricator nesnesi kapandığında tetiklenir.
         *
         
         *
         */
        public void OnCrafterClosed(CrafterClosedEventArgs ev)
        {
            Metadata.CrafterProcessor.OnCrafterClosed(ev);
        }

        /**
         *
         * Fabricator nesnesinde üretim başladığında tetiklenir.
         *
         
         *
         */
        public void OnCrafterBegin(CrafterBeginEventArgs ev)
        {
            Metadata.CrafterProcessor.OnCrafterBegin(ev);
        }

        /**
         *
         * Fabricator nesnesinde üretim sona erdiğinde tetiklenir.
         *
         
         *
         */
        public void OnCrafterEnded(CrafterEndedEventArgs ev)
        {
            Metadata.CrafterProcessor.OnCrafterEnded(ev);
        }

        /**
         *
         * Oturma animasyonu başladığında tetiklenir.
         *
         
         *
         */
        public void OnBenchSitdown(BenchSitdownEventArgs ev)
        {
            Metadata.BenchProcessor.OnBenchSitdown(ev);
        }

        /**
         *
         * Kalkma animasyonu başladığında tetiklenir.
         *
         
         *
         */
        public void OnBenchStandup(BenchStandupEventArgs ev)
        {
            Metadata.BenchProcessor.OnBenchStandup(ev);
        }

        /**
         *
         * Spotlight oluştuktan sonra tetiklenir.
         *
         
         *
         */
        public void OnSpotLightInitialized(SpotLightInitializedEventArgs ev)
        {
            Metadata.SpotLightProcessor.OnSpotLightInitialized(ev);
        }

        /**
         *
         * Techlight oluştuktan sonra tetiklenir.
         *
         
         *
         */
        public void OnTechLightInitialized(TechLightInitializedEventArgs ev)
        {
            Metadata.TechlightProcessor.OnTechLightInitialized(ev);
        }

        /**
         *
         * Map Room tarama başlatılırken tetiklenir.
         *
         
         *
         */
        public void OnBaseMapRoomScanStarting(BaseMapRoomScanStartingEventArgs ev)
        {
            Metadata.BaseMapRoomProcessor.OnBaseMapRoomScanStarting(ev);
        }

        /**
         *
         * Map Room tarama iptal edilirken tetiklenir.
         *
         
         *
         */
        public void OnBaseMapRoomScanStopping(BaseMapRoomScanStoppingEventArgs ev)
        {
            Metadata.BaseMapRoomProcessor.OnBaseMapRoomScanStopping(ev);
        }

        /**
         *
         * Kamera değiştiğinde tetiklenir.
         *
         
         *
         */
        public void OnBaseMapRoomCameraChanging(MapRoomCameraChangingEventArgs ev)
        {
            Metadata.BaseMapRoomProcessor.OnBaseMapRoomCameraChanging(ev);
        }

        /**
         *
         * Yeni kaynak keşfedildiğinde tetiklenir.
         *
         
         *
         */
        public void OnBaseMapRoomResourceDiscovering(BaseMapRoomResourceDiscoveringEventArgs ev)
        {
            General.ResourceDiscoverProcessor.OnBaseMapRoomResourceDiscovering(ev);
        }

        /**
         *
         * Harita odası başlatıldığında tetiklenir.
         *
         
         *
         */
        public void OnBaseMapRoomInitialized(BaseMapRoomInitializedEventArgs ev)
        {
            General.ResourceDiscoverProcessor.OnBaseMapRoomInitialized(ev);
        }

        /**
         *
         * Expansion -> Seatruck ayrılma tamamlandığında tetiklenir.
         *
         
         *
         */
        public void OnBaseMoonpoolExpansionUndockingTimelineCompleting(BaseMoonpoolExpansionUndockingTimelineCompletingEventArgs ev)
        {
            Metadata.MoonpoolProcessor.OnBaseMoonpoolExpansionUndockingTimelineCompleting(ev);
        }

        /**
         *
         * Expansion -> Seatruck yanaşma tamamlanırken tetiklenir.
         *
         
         *
         */
        public void OnBaseMoonpoolExpansionDockingTimelineCompleting(BaseMoonpoolExpansionDockingTimelineCompletingEventArgs ev)
        {
            Metadata.MoonpoolProcessor.OnBaseMoonpoolExpansionDockingTimelineCompleting(ev);
        }

        /**
         *
         * Expansion -> Seatruck kuyruk kenetlenme işlemi tamamlanırken tetiklenir.
         *
         
         *
         */
        public void OnBaseMoonpoolExpansionDockTail(BaseMoonpoolExpansionDockTailEventArgs ev)
        {
            Metadata.MoonpoolProcessor.OnBaseMoonpoolExpansionDockTail(ev);
        }

        /**
         *
         * Expansion -> Seatruck kuyruk ayrılma işlemi tamamlanırken tetiklenir.
         *
         
         *
         */
        public void OnBaseMoonpoolExpansionUndockTail(BaseMoonpoolExpansionUndockTailEventArgs ev)
        {
            Metadata.MoonpoolProcessor.OnBaseMoonpoolExpansionUndockTail(ev);
        }

        /**
         *
         * Oyuncu üse girdiğinde tetiklenir.
         *
         
         *
         */
        public void OnPlayerBaseEntered(PlayerBaseEnteredEventArgs ev)
        {
            Player.SubrootToggleProcessor.OnPlayerBaseEntered(ev);
        }

        /**
         *
         * Oyuncu üs'den ayrıldığında tetiklenir.
         *
         
         *
         */
        public void OnPlayerBaseExited(PlayerBaseExitedEventArgs ev)
        {
            Player.SubrootToggleProcessor.OnPlayerBaseExited(ev);
        }

        /**
         *
         * Resim çerçevesi tıklanırken tetiklenir.
         *
         
         *
         */
        public void OnPictureFrameOpening(PictureFrameOpeningEventArgs ev)
        {
            Metadata.PictureFrameProcessor.OnPictureFrameOpening(ev);
        }

        /**
         *
         * Fabricator nesnesi açıldığında tetiklenir.
         *
         
         *
         */
        public void OnCrafterOpening(CrafterOpeningEventArgs ev)
        {
            Metadata.CrafterProcessor.OnCrafterOpening(ev);
        }

        /**
         *
         * Şarj cihazına tıklanınca tetiklenir.
         *
         
         *
         */
        public void OnChargerOpening(ChargerOpeningEventArgs ev)
        {
            Metadata.ChargerProcessor.OnChargerOpening(ev);
        }

        /**
         *
         * Depolama Açılırken tetiklenir.
         *
         
         *
         */
        public void OnStorageOpening(StorageOpeningEventArgs ev)
        {
            General.StorageOpenProcessor.OnStorageOpening(ev);
        }

        /**
         *
         * Depolamaya eşya eklenirken tetiklenir.
         *
         
         *
         */
        public void OnStorageItemAdding(StorageItemAddingEventArgs ev)
        {
            General.LifepodProcessor.OnStorageItemAdding(ev);
            Metadata.StorageProcessor.OnStorageItemAdding(ev);
            Metadata.AquariumProcessor.OnStorageItemAdding(ev);
            Metadata.BioReactorProcessor.OnStorageItemAdding(ev);
            Metadata.FridgeProcessor.OnStorageItemAdding(ev);
            Metadata.BaseMapRoomProcessor.OnStorageItemAdding(ev);
            Items.DeployableStorageProcessor.OnStorageItemAdding(ev);
            Items.SpyPenguinProcessor.OnStorageItemAdding(ev);
            Vehicle.SeaTruckFabricatorModuleProcessor.OnStorageItemAdding(ev);
            Vehicle.SeaTruckStorageModuleProcessor.OnStorageItemAdding(ev);
            Vehicle.SeaTruckAquariumModuleProcessor.OnStorageItemAdding(ev);
            Vehicle.ExosuitStorageProcessor.OnStorageItemAdding(ev);

            // Old Storage System
            Metadata.FiltrationMachineProcessor.OnStorageItemAdding(ev);
            Metadata.CoffeeVendingMachineProcessor.OnStorageItemAdding(ev);
        }

        /**
         *
         * Depolama'dan eşya kaldırıldırken tetiklenir.
         *
         
         *
         */
        public void OnStorageItemRemoving(StorageItemRemovingEventArgs ev)
        {
            General.LifepodProcessor.OnStorageItemRemoving(ev);
            Metadata.StorageProcessor.OnStorageItemRemoving(ev);
            Metadata.AquariumProcessor.OnStorageItemRemoving(ev);
            Metadata.FridgeProcessor.OnStorageItemRemoving(ev);
            Metadata.BaseMapRoomProcessor.OnStorageItemRemoving(ev);
            Items.DeployableStorageProcessor.OnStorageItemRemoving(ev);
            Items.SpyPenguinProcessor.OnStorageItemRemoving(ev);
            Vehicle.SeaTruckFabricatorModuleProcessor.OnStorageItemRemoving(ev);
            Vehicle.SeaTruckStorageModuleProcessor.OnStorageItemRemoving(ev);
            Vehicle.SeaTruckAquariumModuleProcessor.OnStorageItemRemoving(ev);
            Vehicle.ExosuitStorageProcessor.OnStorageItemRemoving(ev);

            // Old Storage System
            Metadata.FiltrationMachineProcessor.OnStorageItemRemoving(ev);
            Metadata.CoffeeVendingMachineProcessor.OnStorageItemRemoving(ev);
        }

        /**
         *
         * Nükleer Depolamaya eşya eklendiğinde tetiklenir.
         *
         
         *
         */
        public void OnNuclearReactorItemAdded(NuclearReactorItemAddedEventArgs ev)
        {
            Metadata.NuclearReactorProcessor.OnNuclearReactorItemAdded(ev);
        }

        /**
         *
         * Nükleer Depolamadan eşya kaldırıldığında tetiklenir.
         *
         
         *
         */
        public void OnNuclearReactorItemRemoved(NuclearReactorItemRemovedEventArgs ev)
        {
            Metadata.NuclearReactorProcessor.OnNuclearReactorItemRemoved(ev);
        }

        /**
         *
         * Tabela seçildiğinde tetiklenir.
         *
         
         *
         */
        public void OnSignSelect(SignSelectEventArgs ev)
        {
            Metadata.SignProcessor.OnSignSelect(ev);
            Items.DeployableStorageProcessor.OnSignSelect(ev);
            Vehicle.SeaTruckStorageModuleProcessor.OnSignSelect(ev);
            Vehicle.SeaTruckFabricatorModuleProcessor.OnSignSelect(ev);
        }

        /**
         *
         * Tabela seçimi kaldırıldığında tetiklenir.
         *
         
         *
         */
        public void OnSignDeselect(SignDeselectEventArgs ev)
        {
            General.InteractProcessor.OnSignDeselect(ev);
        }

        /**
         *
         * PDA kapatıldığında tetiklenir.
         *
         
         *
         */
        public void OnClosing(PDAClosingEventArgs ev)
        {
            Metadata.ChargerProcessor.OnClosing(ev);
            General.InteractProcessor.OnClosing(ev);
        }

        /**
         *
         * Şarj cihazına pil eklendiğinde tetiklenir.
         *
         
         *
         */
        public void OnChargerItemAdded(ChargerItemAddedEventArgs ev)
        {
            Metadata.ChargerProcessor.OnChargerItemAdded(ev);
        }

        /**
         *
         * Şarj cihazın'dan pil kaldırılınca tetiklenir.
         *
         
         *
         */
        public void OnChargerItemRemoved(ChargerItemRemovedEventArgs ev)
        {
            Metadata.ChargerProcessor.OnChargerItemRemoved(ev);
        }

        /**
         *
         * Hoverbike inşaa edilirken tetiklenir.
         *
         
         *
         */
        public void OnHoverpadHoverbikeSpawning(HoverpadHoverbikeSpawningEventArgs ev)
        {
            Metadata.HoverpadProcessor.OnHoverpadHoverbikeSpawning(ev);
        }

        /**
         *
         * Bir eşya geri dönüştürüldüğünde tetiklenir.
         *
         
         *
         */
        public void OnRecyclotronRecycle(RecyclotronRecycleEventArgs ev)
        {
            Metadata.RecyclotronProcessor.OnRecyclotronRecycle(ev);
        }

        /**
         *
         * Saksıya bitki eklenince tetiklenir.
         *
         
         *
         */
        public void OnPlanterItemAdded(PlanterItemAddedEventArgs ev)
        {
            Metadata.PlanterProcessor.OnPlanterItemAdded(ev);
        }

        /**
         *
         * Saksı büyüdüğünde tetiklenir.
         *
         
         *
         */
        public void OnPlanterProgressCompleted(PlanterProgressCompletedEventArgs ev)
        {
            Metadata.PlanterProcessor.OnPlanterProgressCompleted(ev);
        }

        /**
         *
         * Saksı'daki toplanabilir bitki büyüdüğünde tetiklenir.
         *
         
         *
         */
        public void OnPlanterGrowned(PlanterGrownedEventArgs ev)
        {
            Metadata.PlanterProcessor.OnPlanterGrowned(ev);
        }

        /**
         *
         * Bölme kapısı açılırken tetiklenir.
         *
         
         *
         */
        public void OnBulkheadOpening(BulkheadOpeningEventArgs ev)
        {
            Metadata.BulkheadProcessor.OnBulkheadOpening(ev);
            WorldEntities.BulkheadDoorProcessor.OnBulkheadOpening(ev);
        }

        /**
         *
         * Bölme kapısı kapanırken tetiklenir.
         *
         
         *
         */
        public void OnBulkheadClosing(BulkheadClosingEventArgs ev)
        {
            Metadata.BulkheadProcessor.OnBulkheadClosing(ev);
            WorldEntities.BulkheadDoorProcessor.OnBulkheadClosing(ev);
        }

        /**
         *
         * Termal zambak alanı kontrol edilirken tetiklenir.
         *
         
         *
         */
        public void OnThermalLilyRangeChecking(ThermalLilyRangeCheckingEventArgs ev)
        {
            WorldEntities.ThermalLilyProcessor.OnThermalLilyRangeChecking(ev);
        }

        /**
         *
         * Termal zambak açısı kontrol edilirken tetiklenir.
         *
         
         *
         */
        public void OnThermalLilyAnimationAnglesChecking(ThermalLilyAnimationAnglesCheckingEventArgs ev)
        {
            WorldEntities.ThermalLilyProcessor.OnThermalLilyAnimationAnglesChecking(ev);
        }

        /**
         *
         * Oksijen bitkisine tıklandığında tetiklenir.
         *
         
         *
         */
        public void OnOxygenPlantClicking(OxygenPlantClickingEventArgs ev)
        {
            WorldEntities.OxygenPlantProcessor.OnOxygenPlantClicking(ev);
        }

        /**
         *
         * Işınlayıcı terminali aktif edilirken tetiklenir.
         *
         
         *
         */
        public void OnTeleporterTerminalActivating(TeleporterTerminalActivatingEventArgs ev)
        {
            World.PrecursorTeleporterProcessor.OnTeleporterTerminalActivating(ev);
        }

        /**
         *
         * Işınlayıcı başlatılırken tetiklenir.
         *
         
         *
         */
        public void OnTeleporterInitialized(TeleporterInitializedEventArgs ev)
        {
            World.PrecursorTeleporterProcessor.OnTeleporterInitialized(ev);
        }

        /**
         *
         * Oyuncu ışınlanma başladıktan sonra tetiklenir.
         *
         
         *
         */
        public void OnPrecursorTeleporterUsed()
        {
            World.PrecursorTeleporterProcessor.OnPrecursorTeleporterUsed();
        }

        /**
         *
         * Oyuncu ışınlanma tamamlandıktan sonra tetiklenir.
         *
         
         *
         */
        public void OnPrecursorTeleportationCompleted()
        {
            World.PrecursorTeleporterProcessor.OnPrecursorTeleportationCompleted();
        }

        /**
         *
         * Asansör başlatıldığında tetiklenir.
         *
         
         *
         */
        public void OnElevatorInitialized(ElevatorInitializedEventArgs ev)
        {
            MultiplayerElevator.OnElevatorInitialized(ev);
        }

        /**
         *
         * Nesne spawn olurken tetiklenir.
         *
         
         *
         */
        public void OnEntitySpawning(EntitySpawningEventArgs ev)
        {
            World.EntitySpawnProcessor.OnEntitySpawning(ev);
            World.EntitySlotSpawnProcessor.OnEntitySpawning(ev);
            General.LifepodProcessor.OnEntitySpawning(ev);
        }

        /**
         *
         * Nesne Slotu doğarken tetiklenir.
         *
         
         *
         */
        public void OnEntitySlotSpawning(EntitySlotSpawningEventArgs ev)
        {
            World.EntitySlotSpawnProcessor.OnEntitySlotSpawning(ev);
        }

        /**
         *
         * Nesne spawn olduktan sonra tetiklenir.
         *
         
         *
         */
        public void OnEntitySpawned(EntitySpawnedEventArgs ev)
        {
            World.EntitySpawnProcessor.OnEntitySpawned(ev);
            World.EntitySlotSpawnProcessor.OnEntitySpawned(ev);
            World.BrinicleProcessor.OnEntitySpawned(ev);
            Metadata.CrafterProcessor.OnEntitySpawned(ev);
        }

        /**
         *
         * Bıçak kullanıldığında tetiklenir.
         *
         
         *
         */
        public void OnKnifeUsing(KnifeUsingEventArgs ev)
        {
            Items.KnifeProcessor.OnKnifeUsing(ev);
        }

        /**
         *
         * Dünya yüklenirken tetiklenir.
         *
         
         *
         */
        public void OnWorldLoading(WorldLoadingEventArgs ev)
        {
            Initial.WorldProcessor.OnWorldLoading(ev);
        }

        /**
         *
         * Cell yüklendikten sonra tetiklenir.
         *
         
         *
         */
        public void OnCellLoading(CellLoadingEventArgs ev)
        {
            World.CellProcessor.OnCellLoading(ev);
        }

        /**
         *
         * Cell kaldırılırken tetiklenir.
         *
         
         *
         */
        public void OnCellUnLoading(CellUnLoadingEventArgs ev)
        {
            World.CellProcessor.OnCellUnLoading(ev);
        }

        /**
         *
         * Dünya yüklendiğinde tetiklenir.
         *
         
         *
         */
        public void OnWorldLoaded(WorldLoadedEventArgs ev)
        {
            Initial.WorldProcessor.OnWorldLoaded(ev);
            PingLatency.OnWorldLoaded();
        }

        /**
         *
         * Oyuncu nesne taraması tamamlandığında tetiklenir.
         *
         
         *
         */
        public void OnEntityScannerCompleted(EntityScannerCompletedEventArgs ev)
        {
            World.EntityScannerProcessor.OnEntityScannerCompleted(ev);
        }

        /**
         *
         * Alterra pda nesnesi aldıktan sonra tetiklenir.
         *
         
         *
         */
        public void OnAlterraPdaPickedUp(AlterraPdaPickedUpEventArgs ev)
        {
            World.StaticEntityProcessor.OnAlterraPdaPickedUp(ev);
        }

        /**
         *
         * Müzik nesnesi alındığında tetiklenir.
         *
         
         *
         */
        public void OnJukeboxDiskPickedUp(JukeboxDiskPickedUpEventArgs ev)
        {
            World.StaticEntityProcessor.OnJukeboxDiskPickedUp(ev);
        }

        /**
         *
         * Oyuncu yerden eşya aldığında tetiklenir.
         *
         
         *
         */
        public void OnPlayerItemPickedUp(PlayerItemPickedUpEventArgs ev)
        {
            World.StaticEntityProcessor.OnPlayerItemPickedUp(ev);
            World.EntitySlotSpawnProcessor.OnPlayerItemPickedUp(ev);
            World.CosmeticItemProcessor.OnPlayerItemPickedUp(ev);
            Player.ItemPickupProcessor.OnPlayerItemPickedUp(ev);
            Items.PipeSurfaceFloaterProcessor.OnPlayerItemPickedUp(ev);
            Metadata.BaseMapRoomProcessor.OnPlayerItemPickedUp(ev);
        }

        /**
         *
         * Oyuncu bir nesneyi tararken tetiklenir.
         *
         
         *
         */
        public void OnScannerUsing(ScannerUsingEventArgs ev)
        {
            Items.ScannerProcessor.OnScannerUsing(ev);
        }

        /**
         *
         * Drone camera denize bırakılırken tetiklenir.
         *
         
         *
         */
        public void OnDroneCameraDeploying(DroneCameraDeployingEventArgs ev)
        {
            Items.MapRoomCameraProcessor.OnDroneCameraDeploying(ev);
        }

        /**
         *
         * Boru yüzey yüzdürücü bırakılırken tetiklenir.
         *
         
         *
         */
        public void OnPipeSurfaceFloaterDeploying(PipeSurfaceFloaterDeployingEventArgs ev)
        {
            Items.PipeSurfaceFloaterProcessor.OnPipeSurfaceFloaterDeploying(ev);
        }

        /**
         *
         * Boru bırakılırken tetiklenir.
         *
         
         *
         */
        public void OnOxygenPipePlacing(OxygenPipePlacingEventArgs ev)
        {
            Items.PipeSurfaceFloaterProcessor.OnOxygenPipePlacing(ev);
        }

        /**
         *
         * Bir araç veya yapı tamir edilirken tetiklenir.
         *
         
         *
         */
        public void OnWelding(WeldingEventArgs ev)
        {
            World.WelderProcessor.OnWelding(ev);
        }

        /**
         *
         * Tedarik sandığı açıldığında tetiklenir.
         *
         
         *
         */
        public void OnSupplyCrateOpened(SupplyCrateOpenedEventArgs ev)
        {
            WorldEntities.SupplyCrateProcessor.OnSupplyCrateOpened(ev);
        }

        /**
         *
         * Veri kutusundan tasarım alındığında tetiklenir.
         *
         
         *
         */
        public void OnDataboxItemPickedUp(DataboxItemPickedUpEventArgs ev)
        {
            WorldEntities.DataboxProcessor.OnDataboxItemPickedUp(ev);
        }

        /**
         *
         * Bir nesne hasar aldığında tetiklenir.
         *
         
         *
         */
        public void OnTakeDamaging(TakeDamagingEventArgs ev)
        {
            WorldEntities.DestroyableEntityProcessor.OnTakeDamaging(ev);
            WorldEntities.DestroyableDynamicEntityProcessor.OnTakeDamaging(ev);
            Metadata.PlanterProcessor.OnTakeDamaging(ev);
            Building.BaseHullStrengthProcessor.OnTakeDamaging(ev);
            Building.HealthProcessor.OnTakeDamaging(ev);
            Creatures.HealthProcessor.OnTakeDamaging(ev);
            Vehicle.HealthProcessor.OnTakeDamaging(ev);
            World.BrinicleProcessor.OnTakeDamaging(ev);
        }

        /**
         *
         * Bitki hasat değildiğinde tetiklenir.
         *
         
         *
         */
        public void OnFruitHarvesting(FruitHarvestingEventArgs ev)
        {
            Metadata.PlanterProcessor.OnFruitHarvesting(ev);
            WorldEntities.FruitHarvestProcessor.OnFruitHarvesting(ev);
        }

        /**
         *
         * Bitki hasat değildiğinde tetiklenir.
         *
         
         *
         */
        public void OnGrownPlantHarvesting(GrownPlantHarvestingEventArgs ev)
        {
            Metadata.PlanterProcessor.OnGrownPlantHarvesting(ev);
        }

        /**
         *
         * Oyuncu Animasyonu değiştiğinde tetiklenir.
         *
         
         *
         */
        public void OnPlayerAnimationChanged(PlayerAnimationChangedEventArgs ev)
        {
            Player.AnimationChangedProcessor.OnPlayerAnimationChanged(ev);
        }

        /**
         *
         * Oyuncu bir nesneyi bırakırken tetiklenir.
         *
         
         *
         */
        public void OnPlayerItemDroping(PlayerItemDropingEventArgs ev)
        {
            Player.ItemDropProcessor.OnPlayerItemDroping(ev);
            Metadata.BaseWaterParkProcessor.OnPlayerItemDroping(ev);
        }

        /**
         *
         * Oyuncu ekranı tamamen karardığında tetiklenir.
         *
         
         *
         */
        public void OnSleepScreenStartingCompleted()
        {
            Metadata.BedProcessor.OnSleepScreenStartingCompleted();
        }

        /**
         *
         * Oyuncu ekranı aydınlanma başlatıldığında tetiklenir.
         *
         
         *
         */
        public void OnSleepScreenStopingStarted()
        {
            Metadata.BedProcessor.OnSleepScreenStopingStarted();
        }

        /**
         *
         * Intro kontrolü yapılırken tetiklenir.
         *
         
         *
         */
        public void OnIntroChecking(IntroCheckingEventArgs ev)
        {
            General.IntroProcessor.OnIntroChecking(ev);
        }

        /**
         *
         * Lifepod bölgesi seçilirken tetiklenir.
         *
         
         *
         */
        public void OnLifepodZoneSelecting(LifepodZoneSelectingEventArgs ev)
        {
            General.LifepodProcessor.OnLifepodZoneSelecting(ev);
        }

        /**
         *
         * Lifepod spawnlanma için kontrol eder.
         *
         
         *
         */
        public void OnLifepodZoneCheck(LifepodZoneCheckEventArgs ev)
        {
            General.LifepodProcessor.OnLifepodZoneCheck(ev);
        }

        /**
         *
         * Lifepod enterpolasyon işleminde tetiklenir.
         *
         
         *
         */
        public void OnLifepodInterpolation(LifepodInterpolationEventArgs ev)
        {
            General.LifepodProcessor.OnLifepodInterpolation(ev);
        }

        /**
         *
         * Oyuncu bir araca binmeye yada inmeye çalıştığında tetiklenir.
         *
         
         *
         */
        public void OnUseableDiveHatchClicking(UseableDiveHatchClickingEventArgs ev)
        {
            Player.UseableDiveHatchProcessor.OnUseableDiveHatchClicking(ev);
        }

        /**
         *
         * Oyuncu bir araca bindiğinde tetiklenir.
         *
         
         *
         */
        public void OnEnteredInterior(PlayerEnteredInteriorEventArgs ev)
        {
            Player.InteriorToggleProcessor.OnEnteredInterior(ev);
        }

        /**
         *
         * Oyuncu bir araçtan indiğinde tetiklenir.
         *
         
         *
         */
        public void OnExitedInterior(PlayerExitedInteriorEventArgs ev)
        {
            Player.InteriorToggleProcessor.OnExitedInterior(ev);
        }

        /**
         *
         * Üs dayanıklılığı düştüğünde tetiklenir.
         *
         
         *
         */
        public void OnBaseHullStrengthCrushing(BaseHullStrengthCrushingEventArgs ev)
        {
            Building.BaseHullStrengthProcessor.OnBaseHullStrengthCrushing(ev);
        }

        /**
         *
         * Renk değiştirme paleti seçimden çıktığında tetiklenir.
         *
         
         *
         */
        public void OnSubNameInputDeselected(SubNameInputDeselectedEventArgs ev)
        {
            Metadata.BaseControlRoomProcessor.OnSubNameInputDeselected(ev);
            Metadata.HoverpadProcessor.OnSubNameInputDeselected(ev);
            Metadata.MoonpoolProcessor.OnSubNameInputDeselected(ev);
        }

        /**
         *
         * Renk değiştirme paleti seçildiğinde tetiklenir.
         *
         
         *
         */
        public void OnSubNameInputSelecting(SubNameInputSelectingEventArgs ev)
        {
            Metadata.BaseControlRoomProcessor.OnSubNameInputSelecting(ev);
            Metadata.HoverpadProcessor.OnSubNameInputSelecting(ev);
            Metadata.MoonpoolProcessor.OnSubNameInputSelecting(ev);
        }

        /**
         *
         * Kontrol odasındaki mini haritaya tıklanınca tetiklenir.
         *
         
         *
         */
        public void OnBaseControlRoomMinimapUsing(BaseControlRoomMinimapUsingEventArgs ev)
        {
            Metadata.BaseControlRoomProcessor.OnBaseControlRoomMinimapUsing(ev);
        }

        /**
         *
         * Kontrol odasındaki mini haritadan ayrılınca tetiklenir.
         *
         
         *
         */
        public void OnBaseControlRoomMinimapExiting(BaseControlRoomMinimapExitingEventArgs ev)
        {
            Metadata.BaseControlRoomProcessor.OnBaseControlRoomMinimapExiting(ev);
        }

        /**
         *
         * Kontrol odasındaki mini harita hücresine basıldığında tetiklenir.
         *
         
         *
         */
        public void OnBaseControlRoomCellPowerChanging(BaseControlRoomCellPowerChangingEventArgs ev)
        {
            Metadata.BaseControlRoomProcessor.OnBaseControlRoomCellPowerChanging(ev);
        }

        /**
         *
         * Kontrol odasındaki mini harita hareket ettiğinde tetiklenir.
         *
         
         *
         */
        public void OnBaseControlRoomMinimapMoving(BaseControlRoomMinimapMovingEventArgs ev)
        {
            Metadata.BaseControlRoomProcessor.OnBaseControlRoomMinimapMoving(ev);
        }

        /**
         *
         * Constructor bırakılırken tetiklenir.
         *
         
         *
         */
        public void OnConstructorDeploying(ConstructorDeployingEventArgs ev)
        {
            Items.ConstructorProcessor.OnConstructorDeploying(ev);
        }

        /**
         *
         * Constructor menüyü açtığında/kapattığında tetiklenir.
         *
         
         *
         */
        public void OnConstructorEngageToggle(ConstructorEngageToggleEventArgs ev)
        {
            Items.ConstructorProcessor.OnConstructorEngageToggle(ev);
        }

        /**
         *
         * Bir araç yapılmaya çalışıldığında tetiklenir.
         *
         
         *
         */
        public void OnConstructorCrafting(ConstructorCraftingEventArgs ev)
        {
            Items.ConstructorProcessor.OnConstructorCrafting(ev);
        }

        /**
         *
         * Oyuncu merdivene tırmanmaya çalışılınca tetiklenir.
         *
         
         *
         */
        public void OnPlayerClimbing(PlayerClimbingEventArgs ev)
        {
            Player.ClimbProcessor.OnPlayerClimbing(ev);
        }

        /**
         *
         * Yükseltme konsoluna tıklanınca tetiklenir.
         *
         
         *
         */
        public void OnUpgradeConsoleOpening(UpgradeConsoleOpeningEventArgs ev)
        {
            Vehicle.UpgradeConsoleProcessor.OnUpgradeConsoleOpening(ev);
        }

        /**
         *
         * Yükseltme konsoluna modül eklenince tetiklenir.
         *
         
         *
         */
        public void OnUpgradeConsoleModuleAdded(UpgradeConsoleModuleAddedEventArgs ev)
        {
            Vehicle.UpgradeConsoleProcessor.OnUpgradeConsoleModuleAdded(ev);
        }

        /**
         *
         * Yükseltme konsolundan modül kaldırılınca tetiklenir.
         *
         
         *
         */
        public void OnUpgradeConsoleModuleRemoved(UpgradeConsoleModuleRemovedEventArgs ev)
        {
            Vehicle.UpgradeConsoleProcessor.OnUpgradeConsoleModuleRemoved(ev);
        }

        /**
         *
         * Hoverbike, pad üzerine takılınca tetiklenir.
         *
         
         *
         */
        public void OnHoverpadDocking(HoverpadDockingEventArgs ev)
        {
            Metadata.HoverpadProcessor.OnHoverpadDocking(ev);
        }

        /**
         *
         * Hoverbike, pad üzerinden ayrılınca tetiklenir.
         *
         
         *
         */
        public void OnHoverpadUnDocking(HoverpadUnDockingEventArgs ev)
        {
            Metadata.HoverpadProcessor.OnHoverpadUnDocking(ev);
        }

        /**
         *
         * Hoverbike yakınına gelince veya ayrılınca tetiklenir.
         *
         
         *
         */
        public void OnHoverpadShowroomTriggering(HoverpadShowroomTriggeringEventArgs ev)
        {
            Metadata.HoverpadProcessor.OnHoverpadShowroomTriggering(ev);
        }

        /**
         *
         * Araca binerken tetiklenir.
         *
         
         *
         */
        public void OnVehicleEntering(VehicleEnteringEventArgs ev)
        {
            Vehicle.EnterProcessor.OnVehicleEntering(ev);
        }

        /**
         *
         * Araçtan inerken tetiklenir.
         *
         
         *
         */
        public void OnVehicleExited(VehicleExitedEventArgs ev)
        {
            Vehicle.ExitProcessor.OnVehicleExited(ev);
        }

        /**
         *
         * Araç konumu güncellendiğinde tetiklenir.
         *
         
         *
         */
        public void OnVehicleUpdated(VehicleUpdatedEventArgs ev)
        {
            Vehicle.UpdatedProcessor.OnVehicleUpdated(ev);
        }

        /**
         *
         * Oyuncu öldüğünde tetiklenir.
         *
         
         *
         */
        public void OnPlayerDead(PlayerDeadEventArgs ev)
        {
            Player.DeadProcessor.OnPlayerDead(ev);
        }

        /**
         *
         * Oyuncu doğduğunda tetiklenir.
         *
         
         *
         */
        public void OnPlayerSpawned()
        {
            Player.SpawnProcessor.OnPlayerSpawned();
        }

        /**
         *
         * Hoverbike bırakıldığında tetiklenir.
         *
         
         *
         */
        public void OnHoverbikeDeploying(HoverbikeDeployingEventArgs ev)
        {
            Items.HoverbikeProcessor.OnHoverbikeDeploying(ev);
        }

        /**
         *
         * Pil yerleştirildiğinde/çıkarıldığında tetiklenir.
         *
         
         *
         */
        public void OnEnergyMixinSelecting(EnergyMixinSelectingEventArgs ev)
        {
            Vehicle.BatteryProcessor.OnEnergyMixinSelecting(ev);
        }

        /**
         *
         * Pil yerleştirilme alanına tetiklenir.
         *
         
         *
         */
        public void OnEnergyMixinClicking(EnergyMixinClickingEventArgs ev)
        {
            Vehicle.BatteryProcessor.OnEnergyMixinClicking(ev);
        }

        /**
         *
         * Exosuit ile zıplandığında tetiklenir.
         *
         
         *
         */
        public void OnExosuitJumping(ExosuitJumpingEventArgs ev)
        {
            Vehicle.ExosuitJumpProcessor.OnExosuitJumping(ev);
        }

        /**
         *
         * Pil yerleştirilme kapatıldığında tetiklenir.
         *
         
         *
         */
        public void OnEnergyMixinClosed(EnergyMixinClosedEventArgs ev)
        {
            General.InteractProcessor.OnEnergyMixinClosed(ev);
        }

        /**
         *
         * Su geçirmez depoyu bıraktığında tetiklenir.
         *
         
         *
         */
        public void OnDeployableStorageDeploying(DeployableStorageDeployingEventArgs ev)
        {
            Items.DeployableStorageProcessor.OnDeployableStorageDeploying(ev);
        }

        /**
         *
         * Led ışığı yere konulduğunda tetiklenir.
         *
         
         *
         */
        public void OnLEDLightDeploying(LEDLightDeployingEventArgs ev)
        {
            Items.LEDLightProcessor.OnLEDLightDeploying(ev);
        }

        /**
         *
         * Beacon yere konulduğunda tetiklenir.
         *
         
         *
         */
        public void OnBeaconDeploying(BeaconDeployingEventArgs ev)
        {
            Items.BeaconProcessor.OnBeaconDeploying(ev);
        }
        
        /**
         *
         * Beacon adı değişince tetiklenir.
         *
         
         *
         */
        public void OnBeaconLabelChanged(BeaconLabelChangedEventArgs ev)
        {
            Items.BeaconProcessor.OnBeaconLabelChanged(ev);
        }
        
        /**
         *
         * Spy Penguin bırakıldığında tetiklenir.
         *
         
         *
         */
        public void OnSpyPenguinDeploying(SpyPenguinDeployingEventArgs ev)
        {
            Items.SpyPenguinProcessor.OnSpyPenguinDeploying(ev);
        }
        
        /**
         *
         * Spy Penguin bir nesne aldığında tetiklenir.
         *
         
         *
         */
        public void OnSpyPenguinItemPickedUp(SpyPenguinItemPickedUpEventArgs ev)
        {
            Items.SpyPenguinProcessor.OnSpyPenguinItemPickedUp(ev);
        }
        
        /**
         *
         * Spy Penguin kar avcısından kar kürkü alırken tetiklenir.
         *
         
         *
         */
        public void OnSpyPenguinSnowStalkerInteracting(SpyPenguinSnowStalkerInteractingEventArgs ev)
        {
            Items.SpyPenguinProcessor.OnSpyPenguinSnowStalkerInteracting(ev);
        }

        /**
         *
         * Spy Penguin bir animasyon halinde iken tetiklenir.
         *
         
         *
         */
        public void OnSpyPenguinItemGrabing(SpyPenguinItemGrabingEventArgs ev)
        {
            Vehicle.UpdatedProcessor.OnSpyPenguinItemGrabing(ev);
        }

        /**
         *
         * İşaret fişeti yere konulduğunda tetiklenir.
         *
         
         *
         */
        public void OnFlareDeploying(FlareDeployingEventArgs ev)
        {
            Items.FlareProcessor.OnFlareDeploying(ev);
        }
        
        /**
         *
         * Thumper yere konulurken tetiklenir.
         *
         
         *
         */
        public void OnThumperDeploying(ThumperDeployingEventArgs ev)
        {
            Items.ThumperProcessor.OnThumperDeploying(ev);
        }
        
        /**
         *
         * Işınlanma işlemi başladığında tetiklenir.
         *
         
         *
         */
        public void OnTeleportationToolUsed(TeleportationToolUsedEventArgs ev)
        {
            Items.TeleportationToolProcessor.OnTeleportationToolUsed(ev);
        }
        /**
         *
         * Araç ışıkları yanıp/söndüğünde tetiklenir.
         *
         
         *
         */
        public void OnVehicleLightChanged(LightChangedEventArgs ev)
        {
            Vehicle.LightProcessor.OnVehicleLightChanged(ev);
        }
        
        /**
         *
         * Araca binerken tetiklenir.
         *
         
         *
         */
        public void OnVehicleInteriorToggle(VehicleInteriorToggleEventArgs ev)
        {
            Vehicle.InteriorProcessor.OnVehicleInteriorToggle(ev);
        }
        
        /**
         *
         * Seatruck modülü bağlanırken/ayrılırken tetiklenir.
         *
         
         *
         */
        public void OnSeaTruckConnecting(SeaTruckConnectingEventArgs ev)
        {
            Vehicle.SeaTruckConnectionProcessor.OnSeaTruckConnecting(ev);
        }
        
        /**
         *
         * SeaTruck modül bağlantı kesme animasyonunda tetiklenir.
         *
         
         *
         */
        public void OnSeaTruckDetaching(SeaTruckDetachingEventArgs ev)
        {
            Vehicle.SeaTruckConnectionProcessor.OnSeaTruckDetaching(ev);
        }
        
        /**
         *
         * Exosuit ile yerden nesne alındığında tetiklenir.
         *
         
         *
         */
        public void OnExosuitItemPickedUp(ExosuitItemPickedUpEventArgs ev)
        {
            Vehicle.ExosuitStorageProcessor.OnExosuitItemPickedUp(ev);
        }
        
        /**
         *
         * Exosuit ile maden kazarken tetiklenir.
         *
         
         *
         */
        public void OnExosuitDrilling(ExosuitDrillingEventArgs ev)
        {
            Vehicle.ExosuitDrillProcessor.OnExosuitDrilling(ev);
        }
        
        /**
         *
         * SeaTruck/Exosuit rıhtıma yanaşırken tetiklenir.
         *
         
         *
         */
        public void OnVehicleDocking(VehicleDockingEventArgs ev)
        {
            Metadata.MoonpoolProcessor.OnVehicleDocking(ev);
            Vehicle.SeaTruckDockingModuleProcessor.OnVehicleDocking(ev);
        }
        
        /**
         *
         * SeaTruck/Exosuit rıhtımdan ayrılırken tetiklenir.
         *
         
         *
         */
        public void OnVehicleUndocking(VehicleUndockingEventArgs ev)
        {
            Metadata.MoonpoolProcessor.OnVehicleUndocking(ev);
            Vehicle.SeaTruckDockingModuleProcessor.OnVehicleUndocking(ev);
        }
        
        /**
         *
         * SeaTruck Resim çerçevesi açılırken tetiklenir.
         *
         
         *
         */
        public void OnSeaTruckPictureFrameOpening(SeaTruckPictureFrameOpeningEventArgs ev)
        {
            Vehicle.SeaTruckSleeperModuleProcessor.OnSeaTruckPictureFrameOpening(ev);
        }
        
        /**
         *
         * SeaTruck Resim çerçevesi resim seçilirken tetiklenir.
         *
         
         *
         */
        public void OnSeaTruckPictureFrameImageSelecting(SeaTruckPictureFrameImageSelectingEventArgs ev)
        {
            Vehicle.SeaTruckSleeperModuleProcessor.OnSeaTruckPictureFrameImageSelecting(ev);
        }
        
        /**
         *
         * MapRoomCamera yanaşırken tetiklenir.
         *
         
         *
         */
        public void OnMapRoomCameraDocking(MapRoomCameraDockingEventArgs ev)
        {
            Metadata.BaseMapRoomProcessor.OnMapRoomCameraDocking(ev);
        }
        
        /**
         *
         * SeaTruck modülü başlatılırken tetiklenir.
         *
         
         *
         */
        public void OnSeaTruckModuleInitialized(SeaTruckModuleInitializedEventArgs ev)
        {
            Vehicle.SeaTruckSleeperModuleProcessor.OnSeaTruckModuleInitialized(ev);
            Vehicle.SeaTruckDockingModuleProcessor.OnSeaTruckModuleInitialized(ev);
        }
        
        /**
         *
         * Kaynak kırıldığında tetiklenir.
         *
         
         *
         */
        public void OnBreakableResourceBreaking(BreakableResourceBreakingEventArgs ev)
        {
            World.EntitySlotSpawnProcessor.OnBreakableResourceBreaking(ev);
        }
        
        /**
         *
         * Köprü sol konsola tıklanınca tetiklenir.
         *
         
         *
         */
        public void OnBridgeFluidClicking(BridgeFluidClickingEventArgs ev)
        {
            Story.BridgeProcessor.OnBridgeFluidClicking(ev);
        }
        
        /**
         *
         * Koprü terminaline tıklanırken tetiklenir.
         *
         
         *
         */
        public void OnBridgeTerminalClicking(BridgeTerminalClickingEventArgs ev)
        {
            Story.BridgeProcessor.OnBridgeTerminalClicking(ev);
        }
        
        /**
         *
         * Koprü spawn olduğunda tetiklenir.
         *
         
         *
         */
        public void OnBridgeInitialized(BridgeInitializedEventArgs ev)
        {
            Story.BridgeProcessor.OnBridgeInitialized(ev);
        }
        
        /**
         *
         * Radyo kulesi test modülü takılırken tetiklenir.
         *
         
         *
         */
        public void OnRadioTowerTOMUsing(RadioTowerTOMUsingEventArgs ev)
        {
            Story.RadioTowerProcessor.OnRadioTowerTOMUsing(ev);
        }

        /**
         *
         * Hedef tetiklenirken tetiklenir.
         *
         
         *
         */
        public void OnStoryGoalTriggering(StoryGoalTriggeringEventArgs ev)
        {
            Story.TriggerProcessor.OnStoryGoalTriggering(ev);
        }
        
        /**
         *
         * Hikaye sinyali spawnlanırken tetiklenir.
         *
         
         *
         */
        public void OnStorySignalSpawning(StorySignalSpawningEventArgs ev)
        {
            Story.SignalProcessor.OnStorySignalSpawning(ev);
        }
        
        /**
         *
         * Hikaye cinematic tetiklenirken tetiklenir.
         *
         
         *
         */
        public void OnCinematicTriggering(CinematicTriggeringEventArgs ev)
        {
            Story.CinematicProcessor.OnCinematicTriggering(ev);
        }
        
        /**
         *
         * Hikaye çağrısı kabul/red edildiğinde tetiklenir.
         *
         
         *
         */
        public void OnStoryCalling(StoryCallingEventArgs ev)
        {
            Story.CallProcessor.OnStoryCalling(ev);
        }
        
        /**
         *
         * Terminal tıklanırken tetiklenir.
         *
         
         *
         */
        public void OnStoryHandClicking(StoryHandClickingEventArgs ev)
        {
            Story.InteractProcessor.OnStoryHandClicking(ev);
        }
        
        /**
         *
         * Cinematic başladığında tetiklenir.
         *
         
         *
         */
        public void OnStoryCinematicStarted(StoryCinematicStartedEventArgs ev)
        {
            Story.PlayerVisibilityProcessor.OnStoryCinematicStarted(ev);
        }
        
        /**
         *
         * Cinematic bittiğinde tetiklenir.
         *
         
         *
         */
        public void OnStoryCinematicCompleted(StoryCinematicCompletedEventArgs ev)
        {
            Story.PlayerVisibilityProcessor.OnStoryCinematicCompleted(ev);
        }
        
        /**
         *
         * MobileExtractorMachine başlatıldığında tetiklenir.
         *
         
         *
         */
        public void OnMobileExtractorMachineInitialized()
        {
            Story.FrozenCreatureProcessor.OnMobileExtractorMachineInitialized();
        }
        
        /**
         *
         * anti virüs örneği eklenirken tetiklenir.
         *
         
         *
         */
        public void OnMobileExtractorMachineSampleAdding(MobileExtractorMachineSampleAddingEventArgs ev)
        {
            Story.FrozenCreatureProcessor.OnMobileExtractorMachineSampleAdding(ev);
        }

        /**
         *
         * Konsola tıklanınca tetiklenir.
         *
         
         *
         */
        public void OnMobileExtractorConsoleUsing(MobileExtractorConsoleUsingEventArgs ev)
        {
            Story.FrozenCreatureProcessor.OnMobileExtractorConsoleUsing(ev);
        }

        /**
         *
         * Kalkan üssüne girildiğinde tetiklenir.
         *
         
         *
         */
        public void OnShieldBaseEnterTriggering(ShieldBaseEnterTriggeringEventArgs ev)
        {
            Story.ShieldBaseProcessor.OnShieldBaseEnterTriggering(ev);
        }

        /**
         *
         * Kesici kullanılırken tetiklenir.
         *
         
         *
         */
        public void OnLaserCutterUsing(LaserCutterEventArgs ev)
        {
            WorldEntities.LaserCutterProcessor.OnLaserCutterUsing(ev);
        }
        
        /**
         *
         * Mühürlü bir nesne başlatılırken tetiklenir.
         *
         
         *
         */
        public void OnSealedInitialized(SealedInitializedEventArgs ev)
        {
            WorldEntities.LaserCutterProcessor.OnSealedInitialized(ev);
        }

        /**
         *
         * Asansöre tıklandığında tetiklenir.
         *
         
         *
         */
        public void OnElevatorCalling(ElevatorCallingEventArgs ev)
        {
            WorldEntities.ElevatorProcessor.OnElevatorCalling(ev);
        }

        /**
         *
         * Bir nesne yok edildiğinde içinden başka nesne çıkarken tetiklenir.
         *
         
         *
         */
        public void OnSpawnOnKilling(SpawnOnKillingEventArgs ev)
        {
            World.SpawnOnKillProcessor.OnSpawnOnKilling(ev);
        }

        /**
         *
         * Hava durumu profili değiştiğinde tetiklenir.
         *
         
         *
         */
        public void OnWeatherProfileChanged(WeatherProfileChangedEventArgs ev)
        {
            World.WeatherProcessor.OnWeatherProfileChanged(ev);
        }

        /**
         *
         * Basınç hasarı alınınca tetiklenir.
         *
         
         *
         */
        public void OnCrushDamaging(CrushDamagingEventArgs ev)
        {
            Vehicle.HealthProcessor.OnCrushDamaging(ev);
        }

        /**
         *
         * Kozmetik dünyaya yerleştirilirken tetiklenir.
         *
         
         *
         */
        public void OnCosmeticItemPlacing(CosmeticItemPlacingEventArgs ev)
        {
            World.CosmeticItemProcessor.OnCosmeticItemPlacing(ev);
        }

        /**
         *
         * Oyuncu donduğunda tetiklenir.
         *
         
         *
         */
        public void OnPlayerFreezed(PlayerFreezedEventArgs ev)
        {
            Player.FreezeProcessor.OnPlayerFreezed(ev);
        }

        /**
         *
         * Oyuncu donma sona erdiğinde tetiklenir.
         *
         
         *
         */
        public void OnPlayerUnfreezed()
        {
            Player.FreezeProcessor.OnPlayerUnfreezed();
        }

        /**
         *
         * Balık animasyonu değiştiğinde tetiklenir.
         *
         
         *
         */
        public void OnCreatureAnimationChanged(CreatureAnimationChangedEventArgs ev)
        {
            Creatures.AnimationChangedProcessor.OnCreatureAnimationChanged(ev);
        }

        /**
         *
         * Balina sürme başlarken tetiklenir.
         *
         
         *
         */
        public void OnGlowWhaleRideStarting(GlowWhaleRideStartingEventArgs ev)
        {
            Creatures.GlowWhaleProcessor.OnGlowWhaleRideStarting(ev);
        }

        /**
         *
         * Balina sürme sona erdiğinde tetiklenir.
         *
         
         *
         */
        public void OnGlowWhaleRideStoped(GlowWhaleRideStopedEventArgs ev)
        {
            Creatures.GlowWhaleProcessor.OnGlowWhaleRideStoped(ev);
        }

        /**
         *
         * Balina göz animasyonu başlarken tetiklenir.
         *
         
         *
         */
        public void OnGlowWhaleEyeCinematicStarting(GlowWhaleEyeCinematicStartingEventArgs ev)
        {
            Creatures.GlowWhaleProcessor.OnGlowWhaleEyeCinematicStarting(ev);
        }

        /**
         *
         * Balina SFX tetiklendiğine çalışır.
         *
         
         *
         */
        public void OnGlowWhaleSFXTriggered(GlowWhaleSFXTriggeredEventArgs ev)
        {
            Creatures.GlowWhaleProcessor.OnGlowWhaleSFXTriggered(ev);
        }

        /**
         *
         * CrashFish patlarken tetiklenir.
         *
         
         *
         */
        public void OnCrashFishInflating(CrashFishInflatingEventArgs ev)
        {
            Creatures.CrashFishProcessor.OnCrashFishInflating(ev);
        }

        /**
         *
         * Hipnoz başlarken tetiklenir.
         *
         
         *
         */
        public void OnLilyPaddlerHypnotizeStarting(LilyPaddlerHypnotizeStartingEventArgs ev)
        {
            Creatures.LilyPaddlerProcessor.OnLilyPaddlerHypnotizeStarting(ev);
        }

        /**
         *
         * Balık donarken tetiklenir.
         *
         
         *
         */
        public void OnFreezing(CreatureFreezingEventArgs ev)
        {
            Creatures.FreezeProcessor.OnFreezing(ev);
        }

        /**
         *
         * Yaratık bazı sesler oynarken tetiklenir.
         *
         
         *
         */
        public void OnCallSoundTriggering(CreatureCallSoundTriggeringEventArgs ev)
        {
            Creatures.CallSoundProcessor.OnCallSoundTriggering(ev);
        }

        /**
         *
         * Yaratık en sonki hedefine saldırı başlatırken tetiklenir.
         *
         
         *
         */
        public void OnCreatureAttackLastTargetStarting(CreatureAttackLastTargetStartingEventArgs ev)
        {
            Creatures.AttackLastTargetProcessor.OnCreatureAttackLastTargetStarting(ev);
        }

        /**
         *
         * Yaratık en sonki hedefine saldırı başlatma sona erdiğinde tetiklenir.
         *
         
         *
         */
        public void OnCreatureAttackLastTargetStopped(CreatureAttackLastTargetStoppedEventArgs ev)
        {
            Creatures.AttackLastTargetProcessor.OnCreatureAttackLastTargetStopped(ev);
        }

        /**
         *
         * Leviathan bir nesne ile temasa geçtiğinde (saldırdığında) tetiklenir.
         *
         
         *
         */
        public void OnLeviathanMeleeAttacking(CreatureLeviathanMeleeAttackingEventArgs ev)
        {
            Creatures.LeviathanMeleeAttackProcessor.OnLeviathanMeleeAttacking(ev);
        }

        /**
         *
         * Yaratık bir nesne ile temasa geçtiğinde (saldırdığında) tetiklenir.
         *
         
         *
         */
        public void OnMeleeAttacking(CreatureMeleeAttackingEventArgs ev)
        {
            Creatures.MeleeAttackProcessor.OnMeleeAttacking(ev);
        }

        /**
         *
         * Yaratık etkinleştiğinde tetiklenir.
         *
         
         *
         */
        public void OnCreatureEnabled(CreatureEnabledEventArgs ev)
        {
            Creatures.VoidLeviathanProcessor.OnCreatureEnabled(ev);
        }

        /**
         *
         * Yaratık pasifleştiğinde tetiklenir.
         *
         
         *
         */
        public void OnCreatureDisabled(CreatureDisabledEventArgs ev)
        {
            Creatures.VoidLeviathanProcessor.OnCreatureDisabled(ev);
        }
    }
}