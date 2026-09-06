namespace Subnautica.Server.Logic
{
    using System.Collections.Generic;
    using System.Linq;

    using Core;

    using Subnautica.API.Features;
    using Subnautica.Server.Abstracts;

    using UnityEngine;

    using ServerModel = Subnautica.Network.Models.Server;

    public class Weather : BaseLogic
    {
        /**
         *
         * Hava durumlarını barındırır.
         *
         
         *
         */
        public HashSet<WeatherItem> WeatherTimeLines { get; set; } = new HashSet<WeatherItem>();

        /**
         *
         * Hava durumlarını barındırır.
         *
         
         *
         */
        public List<string> ActivatedScripts { get; set; } = new List<string>();

        /**
         *
         * Timing nesnesini barındırır.
         *
         
         *
         */
        public StopwatchItem Timing { get; set; } = new StopwatchItem(1000f);

        /**
         *
         * IsLoaded değerini barındırır.
         *
         
         *
         */
        public bool IsLoaded { get; set; }

        /**
         *
         * Her sabit tick'den sonra tetiklenir.
         *
         
         *
         */
        public override void OnUnscaledFixedUpdate(float fixedDeltaTime)
        {
            if (this.IsLoaded)
            {
                if (this.Timing.IsFinished())
                {
                    this.Timing.Restart();

                    foreach (var weather in this.WeatherTimeLines)
                    {
                        if (weather.IsProfile)
                        {
                            this.AdvanceProfileSimulation(weather);
                        }
                    }
                }
            }
            else
            {
                this.LoadAllProfileAndScripts();
            }
        }

        /**
         *
         * Profilleri yükler.
         *
         
         *
         */
        private bool LoadAllProfileAndScripts()
        {
            if (WeatherManager.main == null || WeatherManager.main.allWeatherProfiles == null || WeatherManager.main.allWeatherProfiles.Length <= 0)
            {
                return false;
            }

            this.IsLoaded = true;

            foreach (var profile in WeatherManager.main.allWeatherProfiles)
            {
                if (this.WeatherTimeLines.Add(new WeatherItem(profile)))
                {
                    this.ExtendWeatherTimeline(profile.name);
                }
            }

            foreach (var script in WeatherManager.main.allWeatherEventDatas)
            {
                this.WeatherTimeLines.Add(new WeatherItem(script));
            }

            this.OnFixedUpdate(0f);
            return true;
        }

        /**
         *
         * Profil için gelişmiş simülasyon yapar.
         *
         
         *
         */
        public bool AdvanceProfileSimulation(WeatherItem weather)
        {
            weather.Timeline.CullExpiredNodes();

            if (weather.Timeline.Nodes.Count <= 5)
            {
                this.ExtendWeatherTimeline(weather.ProfileId);
            }

            var headNode = weather.Timeline.GetHeadNode();
            if (weather.CurrentEvent != null && weather.CurrentEvent.GetWeatherId() == headNode.GetWeatherId())
            {
                return false;
            }

            weather.CurrentEvent = new WeatherEvent(headNode);

            this.OnWeatherChanged(weather.ProfileId);
            return true;
        }

        /**
         *
         * Hava durumu değişince tetiklenir.
         *
         
         *
         */
        public void OnWeatherChanged(string profileId)
        {
            this.SendWeatherToClients(profileId);
        }

        /**
         *
         * Oyunculara hava durumu bilgilerini gönderir.
         *
         
         *
         */
        public bool SendWeatherToClients(string profileId)
        {
            foreach (var player in Server.Instance.GetPlayers())
            {
                if (player.WeatherProfileId == profileId)
                {
                    this.SendWeatherToClient(player);
                }
            }

            return true;
        }

        /**
         *
         * Oyunculara hava durumu bilgilerini gönderir.
         *
         
         *
         */
        public bool SendWeatherToClient(AuthorizationProfile profile)
        {
            var weather = this.GetWeatherItem(profile.WeatherProfileId);
            if (weather == null)
            {
                return false;
            }

            profile.SendPacket(this.GetWeatherPacket(weather));
            return true;
        }

        /**
         *
         * Hava durumu paketini döner.
         *
         
         *
         */
        private ServerModel.WeatherChangedArgs GetWeatherPacket(WeatherItem item)
        {
            return new ServerModel.WeatherChangedArgs()
            {
                DangerLevel             = item.CurrentEvent.GetDangerLevel(),
                StartTime               = item.CurrentEvent.startTime,
                Duration                = item.CurrentEvent.duration,
                WindDir                 = item.CurrentEvent.parameters.windDir,
                WindSpeed               = item.CurrentEvent.parameters.windSpeed,
                FogDensity              = item.CurrentEvent.parameters.fogDensity,
                FogHeight               = item.CurrentEvent.parameters.fogHeight,
                SmokinessIntensity      = item.CurrentEvent.parameters.smokinessIntensity,
                SnowIntensity           = item.CurrentEvent.parameters.snowIntensity,
                CloudCoverage           = item.CurrentEvent.parameters.cloudCoverage,
                RainIntensity           = item.CurrentEvent.parameters.rainIntensity,
                HailIntensity           = item.CurrentEvent.parameters.hailIntensity,
                MeteorIntensity         = item.CurrentEvent.parameters.meteorIntensity,
                LightningIntensity      = item.CurrentEvent.parameters.lightningIntensity,
                Temperature             = item.CurrentEvent.parameters.temperature,
                AuroraBorealisIntensity = item.CurrentEvent.parameters.auroraBorealisIntensity,
                IsProfile               = item.IsProfile,
            };
        }

        /**
         *
         * Tüm hava durumunu ayarlar.
         *
         
         *
         */
        private bool ExtendWeatherTimeline(string profileId)
        {
            var weather = this.GetWeatherItem(profileId);
            if (weather == null)
            {
                return false;
            }

            var timeSeconds = 1200f - weather.Timeline.GetCurrentDuration();
            if (timeSeconds > 0f)
            {
                weather.Timeline.Populate(weather.Profile, weather.CurrentEvent == null || weather.CurrentEvent.weatherSet == null ? WeatherDangerLevel.None : weather.CurrentEvent.weatherSet.dangerLevel, timeSeconds);               
            }

            return true;
        }

        /**
         *
         * Hava durumu nesnesini döner.
         *
         
         *
         */
        private WeatherItem GetWeatherItem(string profileId)
        {
            return this.WeatherTimeLines.FirstOrDefault(q => q.ProfileId == profileId);
        }
    }

    public class WeatherItem 
    {
        /**
         *
         * ProfileId değerini barındırır.
         *
         
         *
         */
        public string ProfileId { get; set; }

        /**
         *
         * IsProfile değerini barındırır.
         *
         
         *
         */
        public bool IsProfile { get; set; }

        /**
         *
         * Profile değerini barındırır.
         *
         
         *
         */
        public WeatherProfile Profile { get; set; }

        /**
         *
         * Timeline değerini barındırır.
         *
         
         *
         */
        public WeatherTimeline Timeline { get; set; }

        /**
         *
         * CurrentEvent değerini barındırır.
         *
         
         *
         */
        public WeatherEvent CurrentEvent { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public WeatherItem(WeatherProfile profile)
        {
            this.ProfileId = profile.name;
            this.Profile   = profile;
            this.Timeline  = new WeatherTimeline();
            this.IsProfile = true;
        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public WeatherItem(WeatherEventData eventData)
        {
            this.ProfileId    = eventData.weatherId;
            this.Profile      = null;
            this.Timeline     = null;
            this.CurrentEvent = new WeatherEvent(eventData, null, Time.time, float.MaxValue);
            this.IsProfile    = false;
        }
    }
}
