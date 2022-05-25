using System;
using HarmonyLib;

namespace ChooseStartingConditions
{
    class Patches
    {
        [HarmonyPatch(typeof(StartGear), "AddAllToInventory")]
        internal class CustomStartingConditions
        {
            private static void Postfix()
            {
                if (GameManager.m_ActiveScene == "MainMenu") return;
                if (Settings.settings.modFunction == ModFunction.Disabled) return;

                GameManager.GetConditionComponent().m_CurrentHP = Settings.settings.condition;
                GameManager.GetFatigueComponent().m_CurrentFatigue = 100f - Settings.settings.fatigue;
                GameManager.GetHungerComponent().m_CurrentReserveCalories = Settings.settings.hunger / 100f * GameManager.GetHungerComponent().m_MaxReserveCalories;
                GameManager.GetThirstComponent().m_CurrentThirst = 100f - Settings.settings.thirst;
                GameManager.GetFreezingComponent().m_CurrentFreezing = 100f - Settings.settings.warmth;

                if (Settings.settings.injuries)
                {
                    String[] bluntTraumaCause = new String[10] { "Avalanche", "Cave-In", "Car Crash", "Plane Crash", "GAMEPLAY_Fall", "Shipwreck", "GAMEPLAY_BearBite", "GAMEPLAY_MooseStompAttack", "GAMEPLAY_WolfBite", "Attack" };
                    String[] bloodLossCause = new String[15] { "Laceration", "Shrapnel", "Arrow Wound", "Axe Wound", "Gunshot Wound", "Knife Wound", "Avalanche", "Cave-In", "Car Crash", "Plane Crash", "GAMEPLAY_Fall", "Shipwreck", "GAMEPLAY_BearBite", "GAMEPLAY_MooseStompAttack", "GAMEPLAY_WolfBite" };
                    String[] burnsCause = new String[6] { "GAMEPLAY_Campfire", "GAMEPLAY_Electricity", "Explosion", "Fire", "Car Crash", "Plane Crash" };

                    if (Settings.settings.bloodLoss != 0)
                    {
                        String[] cause = new String[5] { bloodLossCause[(int)Settings.settings.bloodLossCause1], bloodLossCause[(int)Settings.settings.bloodLossCause2], bloodLossCause[(int)Settings.settings.bloodLossCause3], bloodLossCause[(int)Settings.settings.bloodLossCause4], bloodLossCause[(int)Settings.settings.bloodLossCause5] };
                        AfflictionBodyArea[] location = new AfflictionBodyArea[] { Settings.settings.bloodLossLocation1, Settings.settings.bloodLossLocation2, Settings.settings.bloodLossLocation3, Settings.settings.bloodLossLocation4, Settings.settings.bloodLossLocation5 };
                        for (int i = 0; i < Settings.settings.bloodLoss; i++)
                        {
                            GameManager.GetBloodLossComponent().BloodLossStartOverrideArea(location[i], cause[i], true, AfflictionOptions.PlayFX | AfflictionOptions.DoAutoSave);
                            GameManager.GetInfectionRiskComponent().InfectionRiskStart(cause[i], location[i], true, false);
                        }
                    }

                    if (Settings.settings.brokenRibs != 0)
                    {
                        for (int i = 0; i < Settings.settings.brokenRibs; i++)
                        {
                            GameManager.GetBrokenRibComponent().BrokenRibStart(bluntTraumaCause[(int)Settings.settings.brokenRibCause], true, false, false);
                        }
                    }

                    if (Settings.settings.burns)
                    {
                        GameManager.GetBurnsComponent().BurnsStart(burnsCause[(int)Settings.settings.burnsCause], true, false);
                    }

                    if (Settings.settings.frostbite != 0)
                    {
                        int[] location = new int[] { (int)Settings.settings.frostbite1, (int)Settings.settings.frostbite2, (int)Settings.settings.frostbite3, (int)Settings.settings.frostbite4, (int)Settings.settings.frostbite5 };
                        for (int i = 0; i < Settings.settings.frostbite; i++)
                        {
                            GameManager.GetFrostbiteComponent().FrostbiteStart(location[i], true, false);
                        }
                    }

                    if (Settings.settings.sprainedAnkles != 0)
                    {
                        for (int i = 0; i < Settings.settings.sprainedAnkles; i++)
                        {
                            GameManager.GetSprainedAnkleComponent().SprainedAnkleStart(bluntTraumaCause[(int)Settings.settings.sprainedAnkleCause], AfflictionOptions.PlayFX | AfflictionOptions.DoAutoSave | AfflictionOptions.DisplayIcon | AfflictionOptions.Stumble);
                        }
                    }

                    if (Settings.settings.sprainedWrists != 0)
                    {
                        for (int i = 0; i < Settings.settings.sprainedWrists; i++)
                        {
                            GameManager.GetSprainedWristComponent().SprainedWristStart(bluntTraumaCause[(int)Settings.settings.sprainedWristCause], AfflictionOptions.PlayFX | AfflictionOptions.DoAutoSave | AfflictionOptions.DisplayIcon | AfflictionOptions.Stumble);
                        }
                    }
                }

                if (Settings.settings.illnesses)
                {
                    if (Settings.settings.cabinFever)
                    {
                        GameManager.GetCabinFeverComponent().CabinFeverStart(true, false);
                    }
                    if (Settings.settings.dysentery)
                    {
                        GameManager.GetDysenteryComponent().DysenteryStart(true, false);
                    }
                    if (Settings.settings.foodPoisoning)
                    {
                        GameManager.GetFoodPoisoningComponent().FoodPoisoningStart("GAMEPLAY_TaintedFood", true, false);
                    }
                    if (Settings.settings.hypothermia)
                    {
                        GameManager.GetHypothermiaComponent().HypothermiaStart("GAMEPLAY_ColdWeather", true, false);
                    }
                    if (Settings.settings.infection)
                    {
                        GameManager.GetInfectionComponent().InfectionStart("GAMEPLAY_ColdWeather", 6, true, false);
                    }
                    if (Settings.settings.parasites)
                    {
                        GameManager.GetIntestinalParasitesComponent().IntestinalParasitesStart(false);
                    }
                }
            }
        }
    }
}
