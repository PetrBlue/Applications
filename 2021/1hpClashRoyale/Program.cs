using System;

namespace _1hpClashRoyale
{
    class Program
    {
        static void Main(string[] args)
        {

                int raketa = 0;
                int lightning = 0;
                int poison = 0;
                int earthquake = 0;
                int fireball = 0;
                int arrows = 0;
                int log = 0;
                int zap = 0;
                int freeze = 0;

                int raketamirror = 0;
                int lightningmirror = 0;
                int poisonmirror = 0;
                int earthquakemirror = 0;
                int fireballmirror = 0;
                int arrowsmirror = 0;
                int logmirror = 0;
                int zapmirror = 0;
                int freezemirror = 0;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Napiš dmg který potřebuješ.");
                Console.ForegroundColor = ConsoleColor.White;
                int dmg = int.Parse(Console.ReadLine());

                int dmgmirror = dmg;

                raketa = dmg / 446;
                dmg = dmg - raketa * 446;
                lightning = dmg / 317;
                dmg = dmg - lightning * 317;
                poison = dmg / 224;
                dmg = dmg - poison * 224;
                earthquake = dmg / 210;
                dmg = dmg - earthquake * 210;
                fireball = dmg / 207;
                dmg = dmg - fireball * 207;
                arrows = dmg / 111;
                dmg = dmg - arrows * 111;
                log = dmg / 87;
                dmg = dmg - log * 87;
                zap = dmg / 58;
                dmg = dmg - zap * 58;
                freeze = dmg / 35;
                dmg = dmg - freeze * 35;


            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Potřebuješ " + raketa + "x Raket.");
            Console.WriteLine("Potřebuješ " + lightning + "x Blesků.");
            Console.WriteLine("Potřebuješ " + poison + "x Poisonů.");
            Console.WriteLine("Potřebuješ " + earthquake + "x Earthquaků.");
            Console.WriteLine("Potřebuješ " + fireball + "x Fireballů.");
            Console.WriteLine("Potřebuješ " + arrows + "x Šípů.");
            Console.WriteLine("Potřebuješ " + log + "x Logů.");
            Console.WriteLine("Potřebuješ " + zap + "x Zapů.");
            Console.WriteLine("Potřebuješ " + freeze + "x Freezu.");
            Console.WriteLine("Zbývající dmg: " + dmg + ".");

            Console.ForegroundColor = ConsoleColor.White;

            if (dmg != 0)
            {
                raketamirror = dmgmirror / 490;
                dmgmirror = dmgmirror - raketamirror * 490;
                raketa = dmgmirror / 446;
                dmgmirror = dmgmirror - raketa * 446;
                lightningmirror = dmgmirror / 348;
                dmgmirror = dmgmirror - lightningmirror * 348;
                lightning = dmgmirror / 317;
                dmgmirror = dmgmirror - lightning * 317;
                poisonmirror = dmgmirror / 240;
                dmgmirror = dmgmirror - poisonmirror * 240;
                poison = dmgmirror / 224;
                dmgmirror = dmgmirror - poison * 224;
                earthquakemirror = dmgmirror / 231;
                dmgmirror = dmgmirror - earthquakemirror * 231;
                earthquake = dmgmirror / 210;
                dmgmirror = dmgmirror - earthquake * 210;
                fireballmirror = dmgmirror / 228;
                dmgmirror = dmgmirror - fireballmirror * 228;
                fireball = dmgmirror / 207;
                dmgmirror = dmgmirror - fireball * 207;
                arrowsmirror = dmgmirror / 123;
                dmgmirror = dmgmirror - arrowsmirror * 123;
                arrows = dmgmirror / 111;
                dmgmirror = dmgmirror - arrows * 111;
                logmirror = dmgmirror / 96;
                dmgmirror = dmgmirror - logmirror * 96;
                log = dmgmirror / 87;
                dmgmirror = dmgmirror - log * 87;
                zapmirror = dmgmirror / 63;
                dmgmirror = dmgmirror - zapmirror * 63;
                zap = dmgmirror / 58;
                dmgmirror = dmgmirror - zap * 58;
                freezemirror = dmgmirror / 38;
                dmgmirror = dmgmirror - freezemirror * 38;
                freeze = dmgmirror / 35;
                dmgmirror = dmgmirror - freeze * 35;

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine();
                Console.WriteLine("Potřebuješ " + raketamirror + "x M. Raket.");
                Console.WriteLine("Potřebuješ " + raketa + "x Raket.");
                Console.WriteLine("Potřebuješ " + lightningmirror + "x M. Blesků.");
                Console.WriteLine("Potřebuješ " + lightning + "x Blesků.");
                Console.WriteLine("Potřebuješ " + poisonmirror + "x M. Poisonů.");
                Console.WriteLine("Potřebuješ " + poison + "x Poisonů.");
                Console.WriteLine("Potřebuješ " + earthquakemirror + "x M. Earthquaků.");
                Console.WriteLine("Potřebuješ " + earthquake + "x Earthquaků.");
                Console.WriteLine("Potřebuješ " + fireballmirror + "x M. Fireballů.");
                Console.WriteLine("Potřebuješ " + fireball + "x Fireballů.");
                Console.WriteLine("Potřebuješ " + arrowsmirror + "x M. Šípů.");
                Console.WriteLine("Potřebuješ " + arrows + "x Šípů.");
                Console.WriteLine("Potřebuješ " + logmirror + "x M. Logů.");
                Console.WriteLine("Potřebuješ " + log + "x Logů.");
                Console.WriteLine("Potřebuješ " + zapmirror + "x M. Zapů.");
                Console.WriteLine("Potřebuješ " + zap + "x Zapů.");
                Console.WriteLine("Potřebuješ " + freezemirror + "x M. Freezu.");
                Console.WriteLine("Potřebuješ " + freeze + "x Freezu.");
                Console.WriteLine("Zbývající dmg: " + dmgmirror + ".");

                Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
}
