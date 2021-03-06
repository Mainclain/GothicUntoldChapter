﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUC.Server.Scripting.Objects.Character;
using GUC.Enumeration;
using GUC.Server.Scripts.AI.Enumeration;

namespace GUC.Server.Scripts.AI.NPC_Def.Monster
{
    public class Gobbo_Warrior : NPC
    {
        public Gobbo_Warrior()
            : base()
        {
            Name = "Goblin - Krieger";

            Strength = 75;
            Dexterity = 75;
            HPMax = 75;
            HP = 75;


            setProtection(DamageTypeIndex.DAM_INDEX_BLUNT, 75);
            setProtection(DamageTypeIndex.DAM_INDEX_EDGE, 75);
            setProtection(DamageTypeIndex.DAM_INDEX_POINT, 75);
            setProtection(DamageTypeIndex.DAM_INDEX_FIRE, 75);
            setProtection(DamageTypeIndex.DAM_INDEX_FLY, 75);

            setDamageType(DamageTypes.DAM_EDGE);

            




            this.setVisual("Gobbo.mds", "Gob_Body", 2, 0, "", 0, 0);

            this.InitNPCAI();

            this.setGuild(Guilds.MON_GOBBO);


            this.Equip(this.addItem("ItMw_1h_Bau_Mace", 1));
            WeaponMode = 1;

            CreateVob();

        }

    }


    public class Gobbo_Warrior_Visir : NPC
    {
        public Gobbo_Warrior_Visir()
            : base()
        {
            Name = "Goblin - Krieger";

            Strength = 75;
            Dexterity = 75;
            HPMax = 75;
            HP = 75;


            setProtection(DamageTypeIndex.DAM_INDEX_BLUNT, 75);
            setProtection(DamageTypeIndex.DAM_INDEX_EDGE, 75);
            setProtection(DamageTypeIndex.DAM_INDEX_POINT, 75);
            setProtection(DamageTypeIndex.DAM_INDEX_FIRE, 75);
            setProtection(DamageTypeIndex.DAM_INDEX_FLY, 75);

            setDamageType(DamageTypes.DAM_EDGE);






            this.setVisual("Gobbo.mds", "Gob_Body", 3, 0, "", 0, 0);

            this.InitNPCAI();

            this.setGuild(Guilds.MON_GOBBO);


            this.Equip(this.addItem("ItMw_1h_Bau_Mace", 1));
            WeaponMode = 1;

            CreateVob();

        }

    }
}
