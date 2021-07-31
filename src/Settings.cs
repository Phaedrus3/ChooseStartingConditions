using System.Reflection;
using System;
using ModSettings;

namespace ChooseStartingConditions
{
    public enum ModFunction
    {
        Disabled, Enabled
    }

    public enum BluntTraumaCause
    {
        Avalanche, CaveIn, CarCrash, PlaneCrash, Fall, Shipwreck, BearAttack, MooseAttack, WolfAttack, Attack
    }

    public enum BloodLossCause
    {
        Laceration, Shrapnel, ArrowWound, AxeWound, GunshotWound, KnifeWound, Avalanche, CaveIn, CarCrash, PlaneCrash, Fall, Shipwreck, BearAttack, MooseAttack, WolfAttack
    }

    public enum BurnsCause
    {
        Campfire, Electricity, Explosion, Fire, CarCrash, PlaneCrash
    }

    class ChooseStartingConditionsSettings : JsonModSettings
    {
        [Section("Starting Conditions Options")]

        [Name("Choose Starting Conditions")]
        [Description("Enable or Disable this mod")]
        [Choice("Disabled", "Enabled")]
        public ModFunction modFunction = ModFunction.Disabled;

        [Section("Condition")]
        [Name("Set Condition")]
        [Description("Set Condition)")]
        [Slider(1f, 100f, 100, NumberFormat = "{0:F0}%")]
        public float condition = 100f;

        [Section("Fatigue")]
        [Name("Set Fatigue")]
        [Description("Set Fatigue")]
        [Slider(0f, 100f, 101, NumberFormat = "{0:F0}%")]
        public float fatigue = 100f;

        [Section("Hunger")]
        [Name("Set Hunger")]
        [Description("Set Hunger")]
        [Slider(0f, 100f, 101, NumberFormat = "{0:F0}%")]
        public float hunger = 100f;

        [Section("Thirst")]
        [Name("Set Thirst")]
        [Description("Set Thirst")]
        [Slider(0f, 100f, 101, NumberFormat = "{0:F0}%")]
        public float thirst = 100f;

        [Section("Warmth")]
        [Name("Set Warmth")]
        [Description("Set Warmth")]
        [Slider(0f, 100f, 101, NumberFormat = "{0:F0}%")]
        public float warmth = 100f;



        [Section("Injuries")]
        [Name("Start with Injuries")]
        [Description("Start with Injuries")]
        public bool injuries = false;

        [Name("Blood Loss")]
        [Description("Number of Blood Loss Afflictions")]
        [Slider(0f, 5f, 6, NumberFormat = "{0:0}")]
        public float bloodLoss = 0f;

        [Name("     Blood Loss cause #1")]
        [Description("Cause of Blood Loss")]
        [Choice("Laceration", "Shrapnel", "Arrow Wound", "Axe Wound", "Gunshot Wound", "Knife Wound", "Avalanche", "Cave-In", "Car Crash", "Plane Crash", "Fall", "Shipwreck", "Bear Bite", "Moose Attack", "Wolf Bite")]
        public BloodLossCause bloodLossCause1 = BloodLossCause.Laceration;

        [Name("     Blood Loss location #1")]
        [Description("Location of Blood Loss")]
        [Choice("Head", "Neck", "Left Arm", "Left Hand", "Right Arm", "Right Hand", "Chest", "Stomach", "Left Leg", "Left Foot", "Right Leg", "Right Foot")]
        public AfflictionBodyArea bloodLossLocation1 = AfflictionBodyArea.Head;

        [Name("     Blood Loss cause #2")]
        [Description("Cause of Blood Loss")]
        [Choice("Laceration", "Shrapnel", "Arrow Wound", "Axe Wound", "Gunshot Wound", "Knife Wound", "Avalanche", "Cave-In", "Car Crash", "Plane Crash", "Fall", "Shipwreck", "Bear Bite", "Moose Attack", "Wolf Bite")]
        public BloodLossCause bloodLossCause2 = BloodLossCause.Laceration;

        [Name("     Blood Loss location #2")]
        [Description("Location of Blood Loss")]
        [Choice("Head", "Neck", "Left Arm", "Left Hand", "Right Arm", "Right Hand", "Chest", "Stomach", "Left Leg", "Left Foot", "Right Leg", "Right Foot")]
        public AfflictionBodyArea bloodLossLocation2 = AfflictionBodyArea.Head;

        [Name("     Blood Loss cause #3")]
        [Description("Cause of Blood Loss")]
        [Choice("Laceration", "Shrapnel", "Arrow Wound", "Axe Wound", "Gunshot Wound", "Knife Wound", "Avalanche", "Cave-In", "Car Crash", "Plane Crash", "Fall", "Shipwreck", "Bear Bite", "Moose Attack", "Wolf Bite")]
        public BloodLossCause bloodLossCause3 = BloodLossCause.Laceration;

        [Name("     Blood Loss location #3")]
        [Description("Location of Blood Loss")]
        [Choice("Head", "Neck", "Left Arm", "Left Hand", "Right Arm", "Right Hand", "Chest", "Stomach", "Left Leg", "Left Foot", "Right Leg", "Right Foot")]
        public AfflictionBodyArea bloodLossLocation3 = AfflictionBodyArea.Head;

        [Name("     Blood Loss cause #4")]
        [Description("Cause of Blood Loss")]
        [Choice("Laceration", "Shrapnel", "Arrow Wound", "Axe Wound", "Gunshot Wound", "Knife Wound", "Avalanche", "Cave-In", "Car Crash", "Plane Crash", "Fall", "Shipwreck", "Bear Bite", "Moose Attack", "Wolf Bite")]
        public BloodLossCause bloodLossCause4 = BloodLossCause.Laceration;

        [Name("     Blood Loss location #4")]
        [Description("Location of Blood Loss")]
        [Choice("Head", "Neck", "Left Arm", "Left Hand", "Right Arm", "Right Hand", "Chest", "Stomach", "Left Leg", "Left Foot", "Right Leg", "Right Foot")]
        public AfflictionBodyArea bloodLossLocation4 = AfflictionBodyArea.Head;

        [Name("     Blood Loss cause #5")]
        [Description("Cause of Blood Loss")]
        [Choice("Laceration", "Shrapnel", "Arrow Wound", "Axe Wound", "Gunshot Wound", "Knife Wound", "Avalanche", "Cave-In", "Car Crash", "Plane Crash", "Fall", "Shipwreck", "Bear Bite", "Moose Attack", "Wolf Bite")]
        public BloodLossCause bloodLossCause5 = BloodLossCause.Laceration;

        [Name("     Blood Loss location #5")]
        [Description("Location of Blood Loss")]
        [Choice("Head", "Neck", "Left Arm", "Left Hand", "Right Arm", "Right Hand", "Chest", "Stomach", "Left Leg", "Left Foot", "Right Leg", "Right Foot")]
        public AfflictionBodyArea bloodLossLocation5 = AfflictionBodyArea.Head;



        [Name("Broken Ribs")]
        [Description("Number of Broken Ribs")]
        [Slider(0f, 24f, 25, NumberFormat = "{0:0}")]
        public float brokenRibs = 0f;

        [Name("     Cause of Broken Ribs")]
        [Description("Cause of Broken Ribs")]
        [Choice("Avalanche", "Cave-In", "Car Crash", "Plane Crash", "Fall", "Shipwreck", "Bear Bite", "Moose Attack", "Wolf Bite", "Attack")]
        public BluntTraumaCause brokenRibCause = BluntTraumaCause.Avalanche;


        [Name("Burns")]
        [Description("Start with Burns")]
        public bool burns = false;

        [Name("     Cause of Burns")]
        [Description("Cause of Burns")]
        [Choice("Campfire", "Electricity", "Explosion", "Fire", "Car Crash", "Plane Crash")]
        public BurnsCause burnsCause = BurnsCause.Campfire;


        [Name("Frostbite")]
        [Description("Number of Frostbite afflictions")]
        [Slider(0f, 5f, 6, NumberFormat = "{0:0}")]
        public float frostbite = 0f;

        [Name("     Frostbite location #1")]
        [Description("Location of Frostbite")]
        [Choice("Head", "Neck", "Left Arm", "Left Hand", "Right Arm", "Right Hand", "Chest", "Stomach", "Left Leg", "Left Foot", "Right Leg", "Right Foot")]
        public AfflictionBodyArea frostbite1 = AfflictionBodyArea.Head;

        [Name("     Frostbite location #2")]
        [Description("Location of Frostbite")]
        [Choice("Head", "Neck", "Left Arm", "Left Hand", "Right Arm", "Right Hand", "Chest", "Stomach", "Left Leg", "Left Foot", "Right Leg", "Right Foot")]
        public AfflictionBodyArea frostbite2 = AfflictionBodyArea.Head;

        [Name("     Frostbite location #3")]
        [Description("Location of Frostbite")]
        [Choice("Head", "Neck", "Left Arm", "Left Hand", "Right Arm", "Right Hand", "Chest", "Stomach", "Left Leg", "Left Foot", "Right Leg", "Right Foot")]
        public AfflictionBodyArea frostbite3 = AfflictionBodyArea.Head;

        [Name("     Frostbite location #4")]
        [Description("Location of Frostbite")]
        [Choice("Head", "Neck", "Left Arm", "Left Hand", "Right Arm", "Right Hand", "Chest", "Stomach", "Left Leg", "Left Foot", "Right Leg", "Right Foot")]
        public AfflictionBodyArea frostbite4 = AfflictionBodyArea.Head;

        [Name("     Frostbite location #5")]
        [Description("Location of Frostbite")]
        [Choice("Head", "Neck", "Left Arm", "Left Hand", "Right Arm", "Right Hand", "Chest", "Stomach", "Left Leg", "Left Foot", "Right Leg", "Right Foot")]
        public AfflictionBodyArea frostbite5 = AfflictionBodyArea.Head;


        [Name("Sprained Ankle")]
        [Description("Number of Sprained Ankles")]
        [Slider(0f, 2f, 3, NumberFormat = "{0:0}")]
        public float sprainedAnkles = 0f;

        [Name("     Cause of Sprain")]
        [Description("Cause of Sprain")]
        [Choice("Avalanche", "Cave-In", "Car Crash", "Plane Crash", "Fall", "Shipwreck", "Bear Bite", "Moose Attack", "Wolf Bite", "Attack")]
        public BluntTraumaCause sprainedAnkleCause = BluntTraumaCause.Avalanche;

        [Name("Sprained Wrist")]
        [Description("Number of Sprained Wrists")]
        [Slider(0f, 2f, 3, NumberFormat = "{0:0}")]
        public float sprainedWrists = 0f;

        [Name("     Cause of Sprain")]
        [Description("Cause of Sprain")]
        [Choice("Avalanche", "Cave-In", "Car Crash", "Plane Crash", "Fall", "Shipwreck", "Bear Bite", "Moose Attack", "Wolf Bite", "Attack")]
        public BluntTraumaCause sprainedWristCause = BluntTraumaCause.Avalanche;


        [Section("Illnesses")]
        [Name("Start with Illnesses")]
        [Description("Start with Illnesses")]
        public bool illnesses = false;

        [Name("Cabin Fever")]
        [Description("Start with Cabin Fever")]
        public bool cabinFever = false;

        [Name("Dysentery")]
        [Description("Start with Dysentery")]
        public bool dysentery = false;

        [Name("Food Poisoning")]
        [Description("Start with Food Poisoning")]
        public bool foodPoisoning = false;

        [Name("Hypothermia")]
        [Description("Start with Hypothermia")]
        public bool hypothermia = false;

        [Name("Infection")]
        [Description("Start with an Infection")]
        public bool infection = false;

        [Name("Intestinal Parasites")]
        [Description("Start with Intestinal Parasites")]
        public bool parasites = false;

        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == nameof(modFunction) || 
                field.Name == nameof(injuries) || 
                field.Name == nameof(bloodLoss) || field.Name == nameof(brokenRibs) || field.Name == nameof(burns) || field.Name == nameof(frostbite) || 
                field.Name == nameof(sprainedAnkles) || field.Name == nameof(sprainedWrists) ||
                field.Name == nameof(illnesses)
                )
            {
                RefreshFields();
            }
        }

        internal void RefreshFields()
        {
            // stats
            SetFieldVisible(nameof(condition), Settings.settings.modFunction != ModFunction.Disabled);
            SetFieldVisible(nameof(fatigue), Settings.settings.modFunction != ModFunction.Disabled);
            SetFieldVisible(nameof(hunger), Settings.settings.modFunction != ModFunction.Disabled);
            SetFieldVisible(nameof(thirst), Settings.settings.modFunction != ModFunction.Disabled);
            SetFieldVisible(nameof(warmth), Settings.settings.modFunction != ModFunction.Disabled);

            // injuries
            SetFieldVisible(nameof(injuries), Settings.settings.modFunction != ModFunction.Disabled);
            
            SetFieldVisible(nameof(bloodLoss), Settings.settings.modFunction != ModFunction.Disabled && injuries);
            SetFieldVisible(nameof(bloodLossCause1), Settings.settings.modFunction != ModFunction.Disabled && injuries && bloodLoss >= 1);
            SetFieldVisible(nameof(bloodLossLocation1), Settings.settings.modFunction != ModFunction.Disabled && injuries && bloodLoss  >= 1);
            SetFieldVisible(nameof(bloodLossCause2), Settings.settings.modFunction != ModFunction.Disabled && injuries && bloodLoss >= 2);
            SetFieldVisible(nameof(bloodLossLocation2), Settings.settings.modFunction != ModFunction.Disabled && injuries && bloodLoss >= 2);
            SetFieldVisible(nameof(bloodLossCause3), Settings.settings.modFunction != ModFunction.Disabled && injuries && bloodLoss >= 3);
            SetFieldVisible(nameof(bloodLossLocation3), Settings.settings.modFunction != ModFunction.Disabled && injuries && bloodLoss >= 3);
            SetFieldVisible(nameof(bloodLossCause4), Settings.settings.modFunction != ModFunction.Disabled && injuries && bloodLoss >= 4);
            SetFieldVisible(nameof(bloodLossLocation4), Settings.settings.modFunction != ModFunction.Disabled && injuries && bloodLoss >= 4);
            SetFieldVisible(nameof(bloodLossCause5), Settings.settings.modFunction != ModFunction.Disabled && injuries && bloodLoss == 5);
            SetFieldVisible(nameof(bloodLossLocation5), Settings.settings.modFunction != ModFunction.Disabled && injuries && bloodLoss == 5);

            SetFieldVisible(nameof(brokenRibs), Settings.settings.modFunction != ModFunction.Disabled && injuries);
            SetFieldVisible(nameof(brokenRibCause), Settings.settings.modFunction != ModFunction.Disabled && injuries && brokenRibs > 0);

            SetFieldVisible(nameof(burns), Settings.settings.modFunction != ModFunction.Disabled && injuries);
            SetFieldVisible(nameof(burnsCause), Settings.settings.modFunction != ModFunction.Disabled && injuries && burns);

            SetFieldVisible(nameof(frostbite), Settings.settings.modFunction != ModFunction.Disabled && injuries);
            SetFieldVisible(nameof(frostbite1), Settings.settings.modFunction != ModFunction.Disabled && injuries && frostbite >= 1);
            SetFieldVisible(nameof(frostbite2), Settings.settings.modFunction != ModFunction.Disabled && injuries && frostbite >= 2);
            SetFieldVisible(nameof(frostbite3), Settings.settings.modFunction != ModFunction.Disabled && injuries && frostbite >= 3);
            SetFieldVisible(nameof(frostbite4), Settings.settings.modFunction != ModFunction.Disabled && injuries && frostbite >= 4);
            SetFieldVisible(nameof(frostbite5), Settings.settings.modFunction != ModFunction.Disabled && injuries && frostbite == 5);

            SetFieldVisible(nameof(sprainedAnkles), Settings.settings.modFunction != ModFunction.Disabled && injuries);
            SetFieldVisible(nameof(sprainedAnkleCause), Settings.settings.modFunction != ModFunction.Disabled && injuries && sprainedAnkles != 0);

            SetFieldVisible(nameof(sprainedWrists), Settings.settings.modFunction != ModFunction.Disabled && injuries);
            SetFieldVisible(nameof(sprainedWristCause), Settings.settings.modFunction != ModFunction.Disabled && injuries && sprainedWrists != 0);

            // illnesses
            SetFieldVisible(nameof(illnesses), Settings.settings.modFunction != ModFunction.Disabled);

            SetFieldVisible(nameof(cabinFever), Settings.settings.modFunction != ModFunction.Disabled && illnesses);
            SetFieldVisible(nameof(dysentery), Settings.settings.modFunction != ModFunction.Disabled && illnesses);
            SetFieldVisible(nameof(foodPoisoning), Settings.settings.modFunction != ModFunction.Disabled && illnesses);
            SetFieldVisible(nameof(hypothermia), Settings.settings.modFunction != ModFunction.Disabled && illnesses);
            SetFieldVisible(nameof(infection), Settings.settings.modFunction != ModFunction.Disabled && illnesses);
            SetFieldVisible(nameof(parasites), Settings.settings.modFunction != ModFunction.Disabled && illnesses);
        }

    }

    internal static class Settings
    {
        public static ChooseStartingConditionsSettings settings;
        public static void OnLoad()
        {
            settings = new ChooseStartingConditionsSettings();
            settings.AddToModSettings("Choose Starting Conditions");
            settings.RefreshFields();
        }
    }
}
