﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUC.Server.Scripting.Objects;
using GUC.Server.Scripting.Objects.Character;

namespace GUC.Server.Scripts.Items.Rings
{
    public class ITRI_DEX_02 : AbstractRings
    {
        static ITRI_DEX_02 ii;
        public static ITRI_DEX_02 get()
        {
            if (ii == null)
                ii = new ITRI_DEX_02();
            return ii;
        }


        protected ITRI_DEX_02()
            : base("ITRI_DEX_02")
        {
            Visual = "ItRi_Dex_02.3ds";
            Description = "Ring der Geschicklichkeit";

            OnEquip += new Scripting.Events.NPCEquipEventHandler(equip);
            OnUnEquip += new Scripting.Events.NPCEquipEventHandler(unequip);
            CreateItemInstance();
        }

        protected void equip(NPCProto npc, Item item)
        {
            npc.Dexterity += 5;
        }

        protected void unequip(NPCProto npc, Item item)
        {
            npc.Dexterity -= 5;
        }
    }
}
