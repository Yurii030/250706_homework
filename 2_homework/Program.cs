namespace _2_homework
{
    // 마법사의 전투 준비( 상속 + 배열 + HAS-A)
    internal class Program
    {
        static void Main(string[] args)
        {
            FireWizard fireWizard = new FireWizard("Gandalf");
            fireWizard.SpellBook.AddSpell(new Spell("Fireball", 50));
            fireWizard.SpellBook.AddSpell(new Spell("Flame Strike", 70));

            IceWizard iceWizard = new IceWizard("Elsa");
            iceWizard.SpellBook.AddSpell(new Spell("Ice Spear", 40));
            iceWizard.SpellBook.AddSpell(new Spell("Blizzard", 80));

            Console.WriteLine("[CodeMagic 마법사 명단]");
            fireWizard.PrintInfo();
            Console.WriteLine();
            iceWizard.PrintInfo();
        }
    }
}
