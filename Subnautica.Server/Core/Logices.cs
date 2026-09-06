namespace Subnautica.Server.Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Timers;

    using Subnautica.API.Extensions;
    using Subnautica.API.Features;
    using Subnautica.Server.Abstracts;

    using UnityEngine;

    public class Logices : MonoBehaviour
    {
        /**
         *
         * UpdateList değerini barındırır.
         *
         
         *
         */
        private List<BaseLogic> StartList { get; set; } = new List<BaseLogic>();

        /**
         *
         * UpdateList değerini barındırır.
         *
         
         *
         */
        private List<BaseLogic> UpdateList { get; set; } = new List<BaseLogic>();

        /**
         *
         * AsyncUpdateList değerini barındırır.
         *
         
         *
         */
        private List<BaseLogic> AsyncUpdateList { get; set; } = new List<BaseLogic>();

        /**
         *
         * FixedUpdateList değerini barındırır.
         *
         
         *
         */
        private List<BaseLogic> FixedUpdateList { get; set; } = new List<BaseLogic>();

        /**
         *
         * UnscaledFixedUpdateList değerini barındırır.
         *
         
         *
         */
        private List<BaseLogic> UnscaledFixedUpdateList { get; set; } = new List<BaseLogic>();

        /**
         *
         * UnscaledFixedRealTime değerini barındırır.
         *
         
         *
         */
        private WaitForSecondsRealtime UnscaledFixedRealTime { get; set; } = new WaitForSecondsRealtime(0.1f);

        /**
         *
         * Zamanlayıcıyı barındırır.
         *
         
         *
         */
        private Timer Timer { get; set; }


        /**
         *
         * Sınıf uyandığında tetiklenir.
         *
         
         *
         */
        public void Awake()
        {
            this.hideFlags = HideFlags.HideAndDontSave;

            this.Timer = new Timer();
            this.Timer.Elapsed += this.OnAsyncUpdate;
            this.Timer.Interval = 250;
            this.Timer.Start();

            DontDestroyOnLoad(this);

            foreach (var property in this.GetType().GetProperties())
            {
                var logic = property.GetValue(this, null) as BaseLogic;
                if (logic != null)
                {
                    var assemblyType = logic.GetType();
                    if (assemblyType.GetMethod("OnStart").IsOverride())
                    {
                        this.StartList.Add(logic);
                    }

                    if (assemblyType.GetMethod("OnUpdate").IsOverride())
                    {
                        this.UpdateList.Add(logic);
                    }

                    if (assemblyType.GetMethod("OnAsyncUpdate").IsOverride())
                    {
                        this.AsyncUpdateList.Add(logic);
                    }

                    if (assemblyType.GetMethod("OnFixedUpdate").IsOverride())
                    {
                        this.FixedUpdateList.Add(logic);
                    }

                    if (assemblyType.GetMethod("OnUnscaledFixedUpdate").IsOverride())
                    {
                        this.UnscaledFixedUpdateList.Add(logic);
                    }
                }
            }

            this.StartCoroutine(this.UnscaledFixedUpdate());
        }

        /**
         *
         * Her belirli bir sürede bir tetiklenir.
         *
         
         *
         */
        private void OnAsyncUpdate(object sender, ElapsedEventArgs e)
        {
            try
            {
                foreach (var logic in this.AsyncUpdateList)
                {
                    logic.OnAsyncUpdate();
                }
            }
            catch (Exception ex)
            {
                Log.Info($"Logices.Timer_Elapsed Exception: {ex}");
            }
        }

        /**
         *
         * Sınıf başlatıldığında tetiklenir.
         *
         
         *
         */
        public void Start()
        {
            try
            {
                foreach (var logic in this.StartList)
                {
                    logic.OnStart();
                }
            }
            catch (Exception e)
            {
                Log.Info($"Logices.Start Exception: {e}");
            }
        }

        /**
         *
         * Her karede tetiklenir.
         *
         
         *
         */
        public void Update()
        {
            try
            {
                foreach (var logic in this.UpdateList)
                {
                    logic.OnUpdate(Time.deltaTime);
                }
            }
            catch (Exception e)
            {
                Log.Info($"Logices.Update Exception: {e}");
            }
        }

        /**
         *
         * Her sabit karede tetiklenir.
         *
         
         *
         */
        public void FixedUpdate()
        {
            try
            {
                foreach (var logic in this.FixedUpdateList)
                {
                    logic.OnFixedUpdate(Time.fixedDeltaTime);
                }
            }
            catch (Exception e)
            {
                Log.Info($"Logices.FixedUpdate Exception: {e}");
            }
        }

        /**
         *
         * Her oyundan bağımsız sabit karede tetiklenir.
         *
         
         *
         */
        public IEnumerator UnscaledFixedUpdate()
        {
            while (true)
            {
                yield return this.UnscaledFixedRealTime;

                try
                {
                    foreach (var logic in this.UnscaledFixedUpdateList)
                    {
                        logic.OnUnscaledFixedUpdate(Time.fixedUnscaledDeltaTime);
                    }
                }
                catch (Exception e)
                {
                    Log.Info($"Logices.FixedUpdate Exception: {e}");
                }
            }
        }

        /**
         *
         * Sınıfı temizler.
         *
         
         *
         */
        public void OnDestroy()
        {
            this.StartList.Clear();
            this.UpdateList.Clear();
            this.AsyncUpdateList.Clear();
            this.FixedUpdateList.Clear();
            this.UnscaledFixedUpdateList.Clear();

            this.Timer.Dispose();
            this.Timer                     = null;
            this.Storage                   = null;
            this.AutoSave                  = null;
            this.World                     = null;
            this.Interact                  = null;
            this.CreatureWatcher           = null;
            this.EnergyTransmission        = null;
            this.PowerConsumer             = null;
            this.BaseHullStrength          = null;
            this.WorldStreamer             = null;
            this.EntityWatcher             = null;
            this.VehicleEnergyTransmission = null;
            this.EnergyMixinTransmission   = null;
            this.SeaTruckAquarium          = null;
            this.Bed                       = null;
            this.Bench                     = null;
            this.Jukebox                   = null;
            this.BatteryCharger            = null;
            this.CoffeeVendingMachine      = null;
            this.Fridge                    = null;
            this.FiltrationMachine         = null;
            this.SpotLight                 = null;
            this.TechLight                 = null;
            this.Crafter                   = null;
            this.Hoverpad                  = null;
            this.Moonpool                  = null;
            this.BaseMapRoom               = null;
            this.StoryTrigger              = null;
            this.PlayerJoin                = null;
            this.Weather                   = null;
            this.Timing                    = null;
            this.ServerApi                 = null;
            this.VoidLeviathan             = null;
            this.BaseWaterPark             = null;
        }

        /**
        *
        * Storage sınıfını barındırır.
        *
        
        *
        */
        public Logic.Storage Storage { get; set; } = new Logic.Storage();

        /**
         *
         * AutoSave sınıfını barındırır.
         *
         
         *
         */
        public Logic.AutoSave AutoSave { get; set; } = new Logic.AutoSave();

        /**
         *
         * World sınıfını barındırır.
         *
         
         *
         */
        public Logic.World World { get; set; } = new Logic.World();

        /**
         *
         * Interact sınıfını barındırır.
         *
         
         *
         */
        public Logic.Interact Interact { get; set; } = new Logic.Interact();

        /**
         *
         * Interact sınıfını barındırır.
         *
         
         *
         */
        public Logic.CreatureWatcher CreatureWatcher { get; set; } = new Logic.CreatureWatcher();

        /**
         *
         * EnergyTransmission sınıfını barındırır.
         *
         
         *
         */
        public Logic.EnergyTransmission EnergyTransmission { get; set; } = new Logic.EnergyTransmission();

        /**
         *
         * PowerConsumer sınıfını barındırır.
         *
         
         *
         */
        public Logic.PowerConsumer PowerConsumer { get; set; } = new Logic.PowerConsumer();

        /**
         *
         * BaseHullStrength sınıfını barındırır.
         *
         
         *
         */
        public Logic.BaseHullStrength BaseHullStrength { get; set; } = new Logic.BaseHullStrength();

        /**
         *
         * WorldStreamer sınıfını barındırır.
         *
         
         *
         */
        public Logic.WorldStreamer WorldStreamer { get; set; } = new Logic.WorldStreamer();

        /**
         *
         * EntityWatcher sınıfını barındırır.
         *
         
         *
         */
        public Logic.EntityWatcher EntityWatcher { get; set; } = new Logic.EntityWatcher();

        /**
         *
         * VehicleEnergyTransmission sınıfını barındırır.
         *
         
         *
         */
        public Logic.VehicleEnergyTransmission VehicleEnergyTransmission { get; set; } = new Logic.VehicleEnergyTransmission();

        /**
         *
         * EnergyMixinTransmission sınıfını barındırır.
         *
         
         *
         */
        public Logic.EnergyMixinTransmission EnergyMixinTransmission { get; set; } = new Logic.EnergyMixinTransmission();

        /**
         *
         * SeaTruckAquarium sınıfını barındırır.
         *
         
         *
         */
        public Logic.SeaTruckAquarium SeaTruckAquarium { get; set; } = new Logic.SeaTruckAquarium();

        /**
         *
         * Bed sınıfını barındırır.
         *
         
         *
         */
        public Logic.Furnitures.Bed Bed { get; set; } = new Logic.Furnitures.Bed();

        /**
         *
         * Bench sınıfını barındırır.
         *
         
         *
         */
        public Logic.Furnitures.Bench Bench { get; set; } = new Logic.Furnitures.Bench();

        /**
         *
         * Jukebox sınıfını barındırır.
         *
         
         *
         */
        public Logic.Furnitures.Jukebox Jukebox { get; set; } = new Logic.Furnitures.Jukebox();

        /**
         *
         * BatteryCharger sınıfını barındırır.
         *
         
         *
         */
        public Logic.Furnitures.BatteryCharger BatteryCharger { get; set; } = new Logic.Furnitures.BatteryCharger();

        /**
         *
         * CoffeeVendingMachine sınıfını barındırır.
         *
         
         *
         */
        public Logic.Furnitures.CoffeeVendingMachine CoffeeVendingMachine { get; set; } = new Logic.Furnitures.CoffeeVendingMachine();

        /**
         *
         * Fridge sınıfını barındırır.
         *
         
         *
         */
        public Logic.Furnitures.Fridge Fridge { get; set; } = new Logic.Furnitures.Fridge();

        /**
         *
         * FiltrationMachine sınıfını barındırır.
         *
         
         *
         */
        public Logic.Furnitures.FiltrationMachine FiltrationMachine { get; set; } = new Logic.Furnitures.FiltrationMachine();

        /**
         *
         * BaseWaterPark sınıfını barındırır.
         *
         
         *
         */
        public Logic.Furnitures.BaseWaterPark BaseWaterPark { get; set; } = new Logic.Furnitures.BaseWaterPark();

        /**
         *
         * SpotLight sınıfını barındırır.
         *
         
         *
         */
        public Logic.Furnitures.SpotLight SpotLight { get; set; } = new Logic.Furnitures.SpotLight();

        /**
         *
         * TechLight sınıfını barındırır.
         *
         
         *
         */
        public Logic.Furnitures.TechLight TechLight { get; set; } = new Logic.Furnitures.TechLight();

        /**
         *
         * Crafter sınıfını barındırır.
         *
         
         *
         */
        public Logic.Furnitures.Crafter Crafter { get; set; } = new Logic.Furnitures.Crafter();

        /**
         *
         * Hoverpad sınıfını barındırır.
         *
         
         *
         */
        public Logic.Furnitures.Hoverpad Hoverpad { get; set; } = new Logic.Furnitures.Hoverpad();

        /**
         *
         * Moonpool sınıfını barındırır.
         *
         
         *
         */
        public Logic.Furnitures.Moonpool Moonpool { get; set; } = new Logic.Furnitures.Moonpool();

        /**
         *
         * BaseMapRoom sınıfını barındırır.
         *
         
         *
         */
        public Logic.Furnitures.BaseMapRoom BaseMapRoom { get; set; } = new Logic.Furnitures.BaseMapRoom();

        /**
         *
         * StoryTrigger sınıfını barındırır.
         *
         
         *
         */
        public Logic.StoryTrigger StoryTrigger { get; set; } = new Logic.StoryTrigger();

        /**
         *
         * PlayerJoin sınıfını barındırır.
         *
         
         *
         */
        public Logic.PlayerJoin PlayerJoin { get; set; } = new Logic.PlayerJoin();

        /**
         *
         * Weather sınıfını barındırır.
         *
         
         *
         */
        public Logic.Weather Weather { get; set; } = new Logic.Weather();

        /**
         *
         * Timing sınıfını barındırır.
         *
         
         *
         */
        public Logic.Timing Timing { get; set; } = new Logic.Timing();

        /**
         *
         * ServerApi sınıfını barındırır.
         *
         
         *
         */
        public Logic.ServerApi ServerApi { get; set; } = new Logic.ServerApi();

        /**
         *
         * VoidLeviathan sınıfını barındırır.
         *
         
         *
         */
        public Logic.VoidLeviathan VoidLeviathan { get; set; } = new Logic.VoidLeviathan();
    }
}