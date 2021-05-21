using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            List<List<int>> intreval = new List<List<int>>();
            intreval.Add(new List<int>{1,4,2});
            intreval.Add(new List<int> { 2,4,1});
            intreval.Add(new List<int> { 3,6,5});


            //List<List<int>> intreval2 = new List<List<int>>();
            //intreval2.Add(new List<int> { 2, 3 });
            //intreval2.Add(new List<int> { 5, 7 });
            //intreval.Add(new List<int> { 8, 12 });

            //List<int> newinterval = new List<int>() { 4, 10 };
            //sol.Merge(intreval);
            // sol.Insert(intreval, newinterval);
            //sol.Intersect(intreval, intreval2);
            sol.findmaxcpuload(intreval);
        }

        class Solution
        {
            public List<List<int>> Merge(List<List<int>> interval)
            {
                if (interval.Count == 0)
                    return new List<List<int>>();

                var output = new List<List<int>>();
                var currentmerged_interval = new List<int>();

                interval = interval.OrderBy(x => x[0]).ToList();//2,4 5,9 6,7
                currentmerged_interval = interval[0];
                output.Add(currentmerged_interval);


                foreach (var intr in interval)
                {
                    if (currentmerged_interval[1] >= intr[0])
                    {
                        currentmerged_interval[1] = Math.Max(currentmerged_interval[1], intr[1]);
                    }
                    else
                    {
                        currentmerged_interval = intr;
                        output.Add(currentmerged_interval);
                    }
                }

                return output;
            }

            public List<List<int>> Insert(List<List<int>> interval, List<int> newnintreval)
            {
                if (interval.Count == 0 || newnintreval.Count == 0)
                    return interval;

                var output = new List<List<int>>();
                var currentmerged_interval = new List<int>();
                int cnt = 0;

                // interval = interval.OrderBy(x => x[0]).ToList();//2,4 5,9 6,7


                for (int i = 0; i < interval.Count; i++)
                {
                    var schedule = interval[i];
                    if (schedule[1] <= newnintreval[0])
                        output.Add(schedule);
                    else
                    {
                        cnt = i;
                        break;
                    }
                }
                currentmerged_interval = newnintreval;
                output.Add(currentmerged_interval);
                for (int j = cnt; j < interval.Count; j++)
                {
                    var intr = interval[j];
                    if (currentmerged_interval[1] >= intr[0])
                    {
                        currentmerged_interval[1] = Math.Max(currentmerged_interval[1], intr[1]);
                    }
                    else
                    {
                        currentmerged_interval = intr;
                        output.Add(currentmerged_interval);
                    }
                }

                return output;
            }

            public List<List<int>> Intersect(List<List<int>> arr1, List<List<int>> arr2)
            {
                var output = new List<List<int>>();
                int i = 0, j = 0;
                while (i < arr1.Count && j < arr2.Count)
                {
                    var result = new List<int>();
                    var arrayone = arr1[i]; var arraytwo = arr2[j];
                    if ((arraytwo[0] <= arrayone[1] && arraytwo[0] >= arrayone[0]) || (arrayone[0] <= arraytwo[1] && arrayone[0] >= arraytwo[0]))
                    {
                        result.Add(Math.Max(arrayone[0], arraytwo[0]));
                        result.Add(Math.Min(arrayone[1], arraytwo[1]));
                        output.Add(result);
                    }
                    if (arrayone[1] < arraytwo[1])
                        i++;
                    else
                        j++;

                }



                return output;
            }
            public int MinMeetingRooms(int[][] intervals)
            {
                if (intervals.Length == 0)
                    return 0;
                int[] start_time = new int[intervals.Length];
                int[] end_time = new int[intervals.Length];

                for (int i = 0; i < intervals.Length; i++)
                {
                    start_time[i] = intervals[i][0];
                    end_time[i] = intervals[i][1];
                }

                Array.Sort(start_time);
                Array.Sort(end_time);

                int count = 1, j = 0;
                for (int i = 1; i < start_time.Length; i++)
                {
                    if (start_time[i] < end_time[j])
                        count++;
                    else
                        j++;
                }

                return count;
            }

            public int findmaxcpuload(List<List<int>> jobs)
            {
                if (jobs.Count == 1)
                    return jobs[0][2];

                int max_cpu = 0;
                jobs.Sort((x, y) => x[0].CompareTo(y[0]));
                var merge_output = new List<int[]>();
                var current_merge = jobs[0];
               max_cpu = current_merge[2];

                for(int i=1;i<jobs.Count;i++)
                {
                    var job = jobs[i];
                    if(current_merge[1]>=job[0])
                    {
                        Math.Max(current_merge[1], job[1]);
                        current_merge[2] = current_merge[2] + job[2];
                        
                    }
                    else
                    {
                        current_merge = job;
                    }
                    max_cpu = Math.Max(max_cpu, current_merge[2]);

                }


                return max_cpu;


            }
        }
    }
}
