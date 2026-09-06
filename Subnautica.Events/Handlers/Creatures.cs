namespace Subnautica.Events.Handlers
{
    using Subnautica.Events.EventArgs;

    using static Subnautica.API.Extensions.EventExtensions;

    public class Creatures
    {
        /**
         *
         * Enabled İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CreatureEnabledEventArgs> Enabled;

        /**
         *
         * Enabled Olayı 
         *
         
         *
         */
        public static void OnEnabled(CreatureEnabledEventArgs ev) => Enabled.CustomInvoke(ev);

        /**
         *
         * Disabled İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CreatureDisabledEventArgs> Disabled;

        /**
         *
         * Disabled Olayı 
         *
         
         *
         */
        public static void OnDisabled(CreatureDisabledEventArgs ev) => Disabled.CustomInvoke(ev);

        /**
         *
         * Freezing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CreatureFreezingEventArgs> Freezing;

        /**
         *
         * Freezing Olayı 
         *
         
         *
         */
        public static void OnFreezing(CreatureFreezingEventArgs ev) => Freezing.CustomInvoke(ev);

        /**
         *
         * MeleeAttacking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CreatureMeleeAttackingEventArgs> MeleeAttacking;

        /**
         *
         * MeleeAttacking Olayı 
         *
         
         *
         */
        public static void OnMeleeAttacking(CreatureMeleeAttackingEventArgs ev) => MeleeAttacking.CustomInvoke(ev);
        
        /**
         *
         * CreatureAttackLastTargetStopped İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CreatureAttackLastTargetStoppedEventArgs> CreatureAttackLastTargetStopped;

        /**
         *
         * CreatureAttackLastTargetStopped Olayı 
         *
         
         *
         */
        public static void OnCreatureAttackLastTargetStopped(CreatureAttackLastTargetStoppedEventArgs ev) => CreatureAttackLastTargetStopped.CustomInvoke(ev);

        /**
         *
         * LeviathanMeleeAttacking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CreatureLeviathanMeleeAttackingEventArgs> LeviathanMeleeAttacking;

        /**
         *
         * LeviathanMeleeAttacking Olayı 
         *
         
         *
         */
        public static void OnLeviathanMeleeAttacking(CreatureLeviathanMeleeAttackingEventArgs ev) => LeviathanMeleeAttacking.CustomInvoke(ev);

        /**
         *
         * CreatureAttackLastTargetStarting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CreatureAttackLastTargetStartingEventArgs> CreatureAttackLastTargetStarting;

        /**
         *
         * CreatureAttackLastTargetStarting Olayı 
         *
         
         *
         */
        public static void OnCreatureAttackLastTargetStarting(CreatureAttackLastTargetStartingEventArgs ev) => CreatureAttackLastTargetStarting.CustomInvoke(ev);

        /**
         *
         * CallSoundTriggering İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CreatureCallSoundTriggeringEventArgs> CallSoundTriggering;

        /**
         *
         * CallSoundTriggering Olayı 
         *
         
         *
         */
        public static void OnCallSoundTriggering(CreatureCallSoundTriggeringEventArgs ev) => CallSoundTriggering.CustomInvoke(ev);

        /**
         *
         * GlowWhaleSFXTriggered İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<GlowWhaleSFXTriggeredEventArgs> GlowWhaleSFXTriggered;

        /**
         *
         * GlowWhaleSFXTriggered Olayı 
         *
         
         *
         */
        public static void OnGlowWhaleSFXTriggered(GlowWhaleSFXTriggeredEventArgs ev) => GlowWhaleSFXTriggered.CustomInvoke(ev);

        /**
         *
         * GlowWhaleRideStarting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<GlowWhaleRideStartingEventArgs> GlowWhaleRideStarting;

        /**
         *
         * GlowWhaleRideStarting Olayı 
         *
         
         *
         */
        public static void OnGlowWhaleRideStarting(GlowWhaleRideStartingEventArgs ev) => GlowWhaleRideStarting.CustomInvoke(ev);

        /**
         *
         * GlowWhaleRideStoped İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<GlowWhaleRideStopedEventArgs> GlowWhaleRideStoped;

        /**
         *
         * GlowWhaleRideStoped Olayı 
         *
         
         *
         */
        public static void OnGlowWhaleRideStoped(GlowWhaleRideStopedEventArgs ev) => GlowWhaleRideStoped.CustomInvoke(ev);

        /**
         *
         * GlowWhaleEyeCinematicStarting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<GlowWhaleEyeCinematicStartingEventArgs> GlowWhaleEyeCinematicStarting;

        /**
         *
         * GlowWhaleEyeCinematicStarting Olayı 
         *
         
         *
         */
        public static void OnGlowWhaleEyeCinematicStarting(GlowWhaleEyeCinematicStartingEventArgs ev) => GlowWhaleEyeCinematicStarting.CustomInvoke(ev);

        /**
         *
         * AnimationChanged İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CreatureAnimationChangedEventArgs> AnimationChanged;

        /**
         *
         * AnimationChanged Olayı 
         *
         
         *
         */
        public static void OnAnimationChanged(CreatureAnimationChangedEventArgs ev) => AnimationChanged.CustomInvoke(ev);

        /**
         *
         * CrashFishInflating İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CrashFishInflatingEventArgs> CrashFishInflating;

        /**
         *
         * CrashFishInflating Olayı 
         *
         
         *
         */
        public static void OnCrashFishInflating(CrashFishInflatingEventArgs ev) => CrashFishInflating.CustomInvoke(ev);

        /**
         *
         * LilyPaddlerHypnotizeStarting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<LilyPaddlerHypnotizeStartingEventArgs> LilyPaddlerHypnotizeStarting;

        /**
         *
         * LilyPaddlerHypnotizeStarting Olayı 
         *
         
         *
         */
        public static void OnLilyPaddlerHypnotizeStarting(LilyPaddlerHypnotizeStartingEventArgs ev) => LilyPaddlerHypnotizeStarting.CustomInvoke(ev);
    }
}
