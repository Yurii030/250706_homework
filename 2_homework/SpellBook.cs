using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _2_homework
{
    internal class SpellBook 
    {
        Spell[] spells = new Spell[3];
        private int index = 0;
        public void AddSpell(Spell spell)
        {
            // 3보다 작은지
            if (index < spells.Length)
            {
                spells[index] = spell; // 해당 인덱스에  마법추가
                index++;
            }

        }
        public void PrintSpells()
        {
            // 하나씩 꺼내서 프린트
            foreach (Spell spell in spells)
            {
                if (spell != null)
                {
                    spell.PrintInfo();
                }
            }
        }
    }
}
