using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            int[] array = new int[] { 1,1,3,4 };
            S.solution(array,2);
        }
        class Solution
        {
            public bool solution(int[] A, int K)
            {
                int n = A.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    if (A[i] + 1 < A[i + 1])
                        return false;
                }
                if (A[0] != 1 && A[n - 1] != K)
                    return false;
                else
                    return true;
            }
        }
        public class Evaluator
        {
            Extractor extractor = null;
            Stack<Exression> stack = null;
            public Evaluator()
            {
                stack = new Stack<Exression>();
                extractor = new Extractor();
            }

            public string Evaluate(string expression)
            {
                foreach (Exression exp in extractor.Extract(expression))
                    stack.Push(exp);

                Exression result = EvaluateExpression();
                return result.Format();
            }

            private Exression EvaluateExpression()
            {
                return null;
            }
        }

        abstract class Exression
        {
            public string Value;
            public abstract string Format();
        }

        class Operator : Exression
        {
            public Operator(string name) { this.Value = name; }

            public override string Format()
            {
                throw new NotImplementedException();
            }
        }

        class Whole : Exression
        {
            public Whole(string val) { this.Value = val; }

            public override string Format()
            {
                throw new NotImplementedException();
            }
        }
        class Franction : Exression
        {
            public Franction(string val) { this.Value = val; }

            public override string Format()
            {
                throw new NotImplementedException();
            }
        }
        class MixedFranction : Exression
        {
            public MixedFranction(string val) { this.Value = val; }

            public override string Format()
            {
                throw new NotImplementedException();
            }
        }

        interface IExtractor
        {
            IList<Exression> Extract(string expression);
        }
        class Extractor : IExtractor
        {
            System.Text.RegularExpressions.Regex rgExp = new System.Text.RegularExpressions.Regex(@"[+-/*_\d]+");
            HashSet<string> ops = new HashSet<string>(new string[] { "+", "-", "*", "/" });
            public IList<Exression> Extract(string expression)
            {
                IList<Exression> expressions = new List<Exression>();
                foreach (System.Text.RegularExpressions.Match m in rgExp.Matches(expression))
                {
                    if (ops.Contains(m.Value))
                        expressions.Add(new Operator(m.Value));
                    else if (m.Value.IndexOf("_") > -1 && m.Value.IndexOf("/") > -1)
                        expressions.Add(new MixedFranction(m.Value));
                    else if (m.Value.IndexOf("/") > -1)
                        expressions.Add(new Franction(m.Value));
                    else
                        expressions.Add(new Whole(m.Value));
                }

                return expressions;
            }
        }


        //class Solution
        //{
        //    public int solution(int[] A)
        //    {
        //        // write your code in C# 6.0 with .NET 4.5 (Mono)
        //        var dict = new Dictionary<int, int>();
        //       // int[] ends = new int[A.Length - 1];
        //        int sum = 0;
        //        int max = 0, maxval = int.MinValue;
        //        int retval = 0;
        //        for(int i=0;i<A.Length-1;i++)
        //        {
        //            sum = A[i]+A[i+1];
        //            // ends[i + 1] = ends[i];
        //            if (dict.ContainsKey(sum))
        //            {
        //                dict[sum]++;
        //            }
        //            else
        //                dict.Add(sum, 1);


        //        }
        //       var order_dict = dict.OrderByDescending(x => x.Value).ToList();
        //        foreach(var pair in order_dict)
        //        {
        //            retval = pair.Value;
        //            break;
        //        }
        //        return retval;


        //    }
        //}

    }
}
