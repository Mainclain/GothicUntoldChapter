﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUC.Server.Scripting.Objects;
using GUC.Server.Scripting.Objects.Character;

namespace GUC.Server.Scripts.Items.Amulet
{
    public class ITAM_STRG_01 : AbstractAmulets
    {
        static ITAM_STRG_01 ii;
        public static ITAM_STRG_01 get()
        {
            if (ii == null)
                ii = new ITAM_STRG_01();
            return ii;
        }


        protected ITAM_STRG_01()
            : base("ITAM_STRG_01")
        {
            Visual = "ItAm_Strg_01.3ds";
            Description = "Amulett der Kraft";

            OnEquip += new Scripting.Events.NPCEquipEventHandler(equip);
            OnUnEquip += new Scripting.Events.NPCEquipEventHandler(unequip);
            CreateItemInstance();
        }

        protected void equip(NPCProto npc, Item item)
        {
            npc.Strength += 10;
        }

        protected void unequip(NPCProto npc, Item item)
        {
            npc.Strength -= 10;
        }
    }
}
