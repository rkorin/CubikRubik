using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubikRubik
{
    class Program
    {
        const string etalon = "gggggggggpppppppppbbbbbbbbbrrrrrrrrrwwwwwwwwwyyyyyyyyy";
        static void Main(string[] args)
        {

            var turn_r = new int[]
            {
                0,1,11,3,4,14,6,7,17,
                9,10,20,12,13,23,15,16,26,
                18,19,29,21,22,32,24,25,35,
                27,28,2,30,31,5,33,34,8,
                36,37,38,39,40,41,42,43,44,
                51,48,45,52,49,46,53,50,47
            };
            var turn_R = new int[]
            {
                0,1,29,3,4,32,6,7,35,
                9,10,2,12,13,5,15,16,8,
                18,19,11,21,22,14,24,25,17,
                27,28,20,30,31,23,33,34,26,
                36,37,38,39,40,41,42,43,44,
                47,50,53,46,49,52,45,48,51
            };
            var turn_l = new int[]
            {
                9,1,2,12,4,5,15,7,8,
                18,10,11,21,13,14,24,16,17,
                27,19,20,30,22,23,33,25,26,
                0,28,29,3,31,32,6,34,35,
                38,41,44,37,40,43,36,39,42,
                45,46,47,48,49,50,51,52,53
            };
            var turn_L = new int[]
            {
                27,1,2,30,4,5,33,7,8,
                0,10,11,3,13,14,6,16,17,
                9,19,20,12,22,23,15,25,26,
                18,28,29,21,31,32,24,34,35,
                42,39,36,43,40,37,44,41,38,
                45,46,47,48,49,50,51,52,53
            };


            var turn_t = new int[]
            {
                6,3,0,7,4,1,8,5,2,
                51,48,45,12,13,14,15,16,17,
                18,19,20,21,22,23,24,25,26,
                27,28,29,30,31,32,44,41,38,
                36,37,9,39,40,10,42,43,11,
                33,46,47,34,49,50,35,52,53
            };
            var turn_T = new int[]
            {
                2,5,8,1,4,7,0,3,6,
                38,41,44,12,13,14,15,16,17,
                18,19,20,21,22,23,24,25,26,
                27,28,29,30,31,32,45,48,51,
                36,37,35,39,40,34,42,43,33,
                11,46,47,10,49,50,9,52,53
            };

            var turn_b = new int[]
          {
                0,1,2,3,4,5,6,7,8,
                9,10,11,12,13,14,53,50,47,
                20,23,26,19,22,25,18,21,24,
                42,39,36,30,31,32,33,34,35,
                15,37,39,16,40,41,17,43,44,
                45,46,27,48,49,28,51,52,29
          };
            var turn_B = new int[]
          {
                0,1,2,3,4,5,6,7,8,
                9,10,11,12,13,14,36,39,42,
                24,21,18,25,22,19,26,23,20,
                47,50,53,30,31,32,33,34,35,
                27,37,38,28,40,41,29,43,44,
                45,46,17,48,49,16,51,52,15
          };


            var turn_1 = new int[]
         {
                9,10,11,12,13,14,15,16,17,
                18,19,20,21,22,23,24,25,26,
                27,28,29,30,31,32,33,34,35,
                0,1,2,3,4,5,6,7,8,
                38,41,44,37,40,43,36,39,42,
                51,48,45,52,49,46,53,50,47
         };
            var turn_2 = new int[]
        {
            27,28,29,30,31,32,33,34,35,
            0,1,2,3,4,5,6,7,8,
                9,10,11,12,13,14,15,16,17,
                18,19,20,21,22,23,24,25,26,
                42,39,36,43,40,37,44,41,38,
                47,50,53,46,49,52,45,48,51
        };
            var turn_3 = new int[]
      {
            45,46,47,48,49,50,51,52,53,
            11,14,17,10,13,16,9,12,15,
                44,43,42,41,40,39,38,37,36,
                33,30,27,34,31,28,35,32,29,
                0,1,2,3,4,5,6,7,8,
               26,25,24,23,22,21,20,19,18
      };
            var turn_4 = new int[]
    {
            36,37,38,39,40,41,42,43,44,
            15,12,9,16,13,10,17,14,11,
                53,52,51,50,49,48,47,46,45,
                29,32,35,28,31,34,27,30,33,
                26,25,24,23,22,21,20,19,18,
               0,1,2,3,4,5,6,7,8
    };

            var turn__pif_paf = generate_turns(
                turn_r, turn_t, turn_R, turn_T
                );

            var s = etalon;

            //s = apply(s, turn__pif_paf);
            //s = apply(s, turn__pif_paf);
            //s = apply(s, turn__pif_paf);
            //s = apply(s, turn__pif_paf);
            //s = apply(s, turn__pif_paf);
            //s = apply(s, turn__pif_paf);

            //s = apply(s, turn_3);
            //s = apply(s, turn_3);
            //s = apply(s, turn_4);
            //s = apply(s, turn_4);

            //s = apply(s, turn_B);
            //s = apply(s, turn_t);
            //s = apply(s, turn_r);
            //s = apply(s, turn_T);
            //s = apply(s, turn_R);

            //draw(s);
            //Console.ReadLine();

            Dictionary<string, int[]> turns = new Dictionary<string, int[]>
            {
                {"r",turn_r },{"R",turn_R },
                {"l",turn_l },{"L",turn_L },
                {"t",turn_t },{"T",turn_T },
                {"b",turn_b },{"B",turn_B },
                    {"tu",turn_1 },{"td",turn_2 },
                {"tl",turn_3 },{"tr",turn_4 }
            };
            Dictionary<string, int[]> turns1 = new Dictionary<string, int[]>
            {
                {"tu",turn_1 },{"td",turn_2 },
                {"tl",turn_3 },{"tr",turn_4 }
            };
            Dictionary<string, int[]> turns_pifpaf = new Dictionary<string, int[]>
            {
                {"r",turn_r },{"R",turn_R },
                {"l",turn_l },{"L",turn_L },
                {"t",turn_t },{"T",turn_T },
                {"b",turn_b },{"B",turn_B }, {"tu",turn_1 },{"td",turn_2 },
                {"tl",turn_3 },{"tr",turn_4 }, {"pifpaf", turn__pif_paf }
            };

            Random r = new Random();
            List<string> l = turns.Keys.ToList();
            for (var i = 0; i < 100; ++i)
            {
                var key = l[r.Next(12)];
                Console.Write(key);
                Console.Write('-');
                s = apply(s, turns[key]);
            }

            draw(s);
            Dictionary<string, string> all_positions;
            string all_turns;
            var res = solve(s, turns1, new Dictionary<int, char> { { 4, 'g' }, { 4 + 9, 'p' } });
            s = res.Item1;
            all_turns = res.Item2;
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            draw(s);

            res = solve(s, turns, new Dictionary<int, char> {
                { 4, 'g' }, { 4 + 9, 'p' }, { 1, 'g' }, { 34, 'r' } });
            s = res.Item1;
            all_turns += res.Item2;
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            draw(s);


            res = solve(s, turns, new Dictionary<int, char> {
                { 4, 'g' }, { 4 + 9, 'p' }, { 1, 'g' }, { 34, 'r' },
                { 5, 'g' }, { 48, 'y' }});
            s = res.Item1;
            all_turns += res.Item2;
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            draw(s);

            res = solve(s, turns, new Dictionary<int, char> {
                { 4, 'g' }, { 4 + 9, 'p' }, { 1, 'g' }, { 34, 'r' },
                { 5, 'g' }, { 48, 'y' },
                { 3, 'g' }, { 41, 'w' }});
            s = res.Item1;
            all_turns += res.Item2;
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            draw(s);

            res = solve(s, turns, new Dictionary<int, char> {
                { 4, 'g' }, { 4 + 9, 'p' }, { 1, 'g' }, { 34, 'r' },
                { 5, 'g' }, { 48, 'y' },
                { 3, 'g' }, { 41, 'w' },
                { 7, 'g' }, { 10, 'p' }});
            s = res.Item1;
            all_turns += res.Item2;
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            draw(s);

            res = solve(s, turns_pifpaf, new Dictionary<int, char> {
                { 4, 'g' }, { 4 + 9, 'p' }, { 1, 'g' }, { 34, 'r' },
                { 5, 'g' }, { 48, 'y' },
                { 3, 'g' }, { 41, 'w' },
                { 7, 'g' }, { 10, 'p' },
                { 0, 'g' }, { 33, 'r' }, { 38, 'w' }});
            s = res.Item1;
            all_turns += res.Item2;
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            draw(s);

            res = solve(s, turns_pifpaf, new Dictionary<int, char> {
                { 4, 'g' }, { 4 + 9, 'p' }, { 1, 'g' }, { 34, 'r' },
                { 5, 'g' }, { 48, 'y' },
                { 3, 'g' }, { 41, 'w' },
                { 7, 'g' }, { 10, 'p' },
                { 0, 'g' }, { 33, 'r' }, { 38, 'w' },
                { 2, 'g' }, { 35, 'r' }, { 45, 'y' }});
            s = res.Item1;
            all_turns += res.Item2;
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            draw(s);


            res = solve(s, turns_pifpaf, new Dictionary<int, char> {
                { 4, 'g' }, { 4 + 9, 'p' }, { 1, 'g' }, { 34, 'r' },
                { 5, 'g' }, { 48, 'y' },
                { 3, 'g' }, { 41, 'w' },
                { 7, 'g' }, { 10, 'p' },
                { 0, 'g' }, { 33, 'r' }, { 38, 'w' },
                { 2, 'g' }, { 35, 'r' }, { 45, 'y' },
                { 6, 'g' }, { 9, 'p' }, { 44, 'w' }
            });
            s = res.Item1;
            all_turns += res.Item2;
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            draw(s);

            Console.WriteLine(all_turns);
            Console.ReadLine();
        }

        private static int[] generate_turns(params int[][] masks)
        {
            int[] res = new int[54];
            for (var i = 0; i < 54; ++i)
                res[i] = i;
            foreach (var mask in masks)
            {
                int[] res2 = new int[54];
                for (var i = 0; i < 54; ++i)
                    res2[i] = res[mask[i]];
                res = res2;
            }
            return res;
        }

        private static Tuple<string, string> solve(string s, Dictionary<string, int[]> turns1,
            Dictionary<int, char> template)
        {
            var all_positions = new Dictionary<string, string>();
            all_positions[s] = "";
            while (true)
            {
                generate_turns(turns1, all_positions);
                var founded = all_positions.Keys.Where(w =>
                {
                    foreach (var t in template)
                        if (w[t.Key] != t.Value)
                            return false;
                    return true;
                }).FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(founded))
                {
                    return new Tuple<string, string>(founded, all_positions[founded]);
                }
            }
            return null;
        }

        private static void generate_turns(Dictionary<string, int[]> turns, Dictionary<string, string> all_positions)
        {
            var new_positions = new Dictionary<string, string>();
            foreach (var turn in turns)
            {
                foreach (var position in all_positions)
                {
                    var new_pos = apply(position.Key, turn.Value);
                    if (all_positions.ContainsKey(new_pos))
                        continue;
                    new_positions[new_pos] = position.Value + "-" + turn.Key;
                }
            }
            foreach (var np in new_positions)
                all_positions[np.Key] = np.Value;
        }

        private static void draw(string s)
        {
            int n = 9 * 15;
            List<char> m = new List<char>();
            for (var i = 0; i < n; ++i) m.Add(' ');
            d9(m, 3, 0, s.Substring(0, 9));
            d9(m, 3, 3, s.Substring(9, 9));
            d9(m, 3, 6, s.Substring(18, 9));
            d9(m, 3, 9, s.Substring(27, 9));
            d9(m, 0, 9, s.Substring(36, 9));
            d9(m, 6, 9, s.Substring(45, 9));

            Console.WriteLine();
            for (int y = 0; y < 12; ++y)
            {
                for (int x = 0; x < 9; ++x)
                {
                    Console.Write(" ");
                    Console.Write(m[y * 9 + x]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
        }

        private static void d9(List<char> m, int X, int Y, string v3)
        {
            int i = 0;
            for (int y = 0; y < 3; ++y)
                for (int x = 0; x < 3; ++x)
                    set(m, X + x, Y + y, v3[i++]);
        }

        private static void set(List<char> m, int X, int Y, char v3)
        {
            m[Y * 9 + X] = v3;
        }

        private static string apply(string s, int[] v)
        {

            StringBuilder sb = new StringBuilder(s);
            for (var i = 0; i <= 53; ++i)
                sb[i] = s[v[i]];

            List<char> t = new List<char>();
            t.Add(sb[4]);
            t.Add(sb[4 + 9]);
            t.Add(sb[4 + 18]);
            t.Add(sb[4 + 27]);
            t.Add(sb[4 + 36]);
            t.Add(sb[4 + 45]);
            if (t.Distinct().Count() != 6)
            {
                System.Diagnostics.Debugger.Break();
            }


            return sb.ToString();
        }
    }
}
