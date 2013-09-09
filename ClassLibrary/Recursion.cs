using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;


namespace ClassLibrary
{


    class Recursion
    {

        #region 9.1
        //A child is running up a staircase with n steps, and can hop either 1 step, 2 steps, or
        //3 steps at a time. Implement a method to count how many possible ways the child
        //can run up the stairs.
        public class pointR
        {
            int x;
            int y;
            public pointR(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }


        public int CountWays(int n)
        {
            if (n < 0)
            {
                return 0;
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                return CountWays(n - 1) + CountWays(n - 2) +
                CountWays(n - 3);
            }
        }


        public int CountWaysDP(int n, int[] map)
        {
            if (n < 0)
            {
                return 0;
            }
            else if (n == 0)
            {
                return 1;
            }
            else if (map[n] > -1)
            {
                return map[n];
            }
            else
            {
                map[n] = CountWaysDP(n - 1, map) +
                CountWaysDP(n - 2, map) +
                CountWaysDP(n - 3, map);
                return map[n];
            }
        }
        # endregion

        #region 9.2
        //Imagine a robot sitting on the upper left comer of an X by Ygrid. The robot can only
        //move in two directions: right and down. How many possible paths are there for the
        //robot to go from (0, 0) to (X, Y) ?

        //FOLLOW UP
        //Imagine certain spots are "off limits," such that the robot cannot step on them.
        //Design an algorithm to find a path for the robot from the top left to the bottom right.

        public Boolean getPath(int x, int y, ArrayList path)
        {
            pointR point = new pointR(x, y);
            path.Add(point);

            if (x == 0 && y == 0) return true;
            bool succ = false;

            if (x >= 1) { succ = getPath(x - 1, y, path); }
            if (y >= 1) { succ = getPath(x, y - 1, path); }

            if (succ) { path.Add(point); }

            return succ;

        }


        public Boolean getPathDynamtic(int x, int y, ArrayList path, Hashtable cache)
        {
            if (cache == null) { cache = new Hashtable(); }
            pointR point = new pointR(x, y);

            if (!cache.Contains(point))
            {
                return (bool)cache[point];
            }

            if (x == 0 && y == 0) return true;
            bool succ = false;

            if (x >= 1) { succ = getPathDynamtic(x - 1, y, path, cache); }
            if (y >= 1) { succ = getPathDynamtic(x, y - 1, path, cache); }

            if (succ)
            {

                path.Add(point);
            }

            cache.Add(point, succ);

            return succ;

        }// end function
        #endregion

        #region 9.3
        // A magic index in an array A[l.. .n-l] is defined to be an index such that A[i] =
        //i. Given a sorted array of distinct integers, write a method to find a magic index, if
        // one exists, in array A.
        //FOLLOW UP
        // What if the values are not distinct

        // if the element is distinct 
        public int magicFasDistinct(int[] data, int end, int start)
        {
            if (end < start || start < 0 || end > data.Length - 1) return -1;
            int med = (start + end) / 2;
            if (data[med] == med) { return med; }
            if (med > data[med])
            {
                // go to right side 
                return magicFasDistinct(data, (med + 1), end);

            }
            else
            {

                return magicFasDistinct(data, start, (med - 1));
            }



        }

        //-10,-5.2,2,2,3,4,7,9,12,13
        // 0, 1, 2,3,4,5,6,7,8,9,10 

        // if the element is not distinct 
        public int magicFast(int[] data, int end, int start)
        {
            if (end < start || start < 0 || end > data.Length - 1) return -1;

            int med_index = (start + end) / 2;
            int med_value = data[med_index];
            if (med_index == med_value) { return med_index; }

            // search left side
            int left_index = Math.Min(med_index - 1, med_value);

            int left = magicFast(data, start, left_index);
            if (left > 0) return left;

            // search right side
            int right_index = Math.Max(med_index + 1, med_value);
            int right = magicFast(data, right_index, end);

            return right;

        }
        #endregion

        #region 9.4

        //9.4 Write a method to return all subsets of a set.

        //Solution #1:  Recuris

        ArrayList GetSubsets(int[] set, int index = 0)
        {
            ArrayList allsubsets;
            //if (index >= set.Length) return null;

            if (index == set.Length)
            { // Base case - add empty set
                allsubsets = new ArrayList();
                allsubsets.Add(new ArrayList()); // Empty set
            }
            else
            {
                allsubsets = GetSubsets(set, index + 1);
                int item = set[index];
                ArrayList moresubsets = new ArrayList();
                foreach (ArrayList i in allsubsets)
                {
                    ArrayList newsubset = new ArrayList();
                    newsubset.AddRange(i);
                    newsubset.Add(item);
                    moresubsets.Add(newsubset);
                }
                allsubsets.AddRange(moresubsets);
            }
            return allsubsets;
        }
        //Solution #2: Combinatorics
        //1) the element is in the set (the "yes" state) or 
        //2) the element is not in the set (the "no" state).

        //        ArrayList getSubsets2(ArrayList set) {
        //        ArrayList allsubsets = new ArrayList ();
        //        int max = 1 « set.Capacity(); /* Compute 2An */
        //5 for (int k = 0; k < max; k++) {
        //6 ArrayList<Integer> subset = convert!ntToSet(kj set);
        //7 allsubsets.add(subset);
        //8 }
        //9 return allsubsets;
        //10 }

        #region second solution

        public ArrayList GetSubsets2(ArrayList set)
        {
            ArrayList allsubsets = new ArrayList();
            int max = 1 << set.Capacity; /* Compute 2^n */
            for (int k = 0; k < max; k++)
            {
                ArrayList subset = convertIntToSet(k, set);
                allsubsets.Add(subset);
            }
            return allsubsets;
        }

        private ArrayList convertIntToSet(int x, ArrayList set)
        {
            ArrayList subset = new ArrayList();
            int index = 0;

            for (int k = x; k > 0; k = k >> 1)
            {
                if ((k & 1) == 1)
                {
                    subset.Add(set[index]);
                }
                index++;
            }
            return subset;
        }

        #endregion
        #endregion

        #region 9.6

        //    Implement an algorithm to print all valid (i.e., properly opened and closed) combinations of n-pairs of parentheses.
        #region  first solution

        public HashSet<string> generateParens(int remaining)
        {
            HashSet<string> set = new HashSet<String>();
            if (remaining == 0)
            {
                set.Add("");
            }
            else
            {
                HashSet<string> prev = generateParens(remaining - 1);

                foreach (string str in prev)
                {


                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == '(')
                        {
                            String s = insertInside(str, i);
                            /* Add s to set if it's not already in there. Note:
                            * HashSet automatically checks for duplicates before
                            * adding, so an explicit check is not necessary. */
                            set.Add(s);
                        }
                    }
                    if (!set.Contains("()" + str))
                    {
                        set.Add("()" + str);
                    }
                }
            }
            return set;
        }

        private String insertInside(String str, int leftlndex)
        {
            String left = str.Substring(0, leftlndex + 1);
            String right = str.Substring(leftlndex + 1);
            return left + "()" + right;
        }

        #endregion


        #endregion

        #region 9.7
        // have issure about the two conditions
        // 1. if (screen[x, y] == ocolor)
        // 2.  if (screen[x, y] == ncolor) 



        //Implement the "paint fill" function that one might see on many image editing
        //programs. That is, given a screen (represented by a two-dimensional array of colors),
        //a point, and a new color, fill in the surrounding area until the color changes from the
        //original color

        private bool PaintColor(Color[,] screen, int x, int y, Color ocolor, Color ncolor)
        {
            if (
                  (x >= 0 && x >= screen.GetLength(0))
                    ||
                  (y > 0 && y >= screen.GetLength(1))
                )
            {
                return false;
            }

            if (screen[x, y] == ocolor)
            {

                screen[x, y] = ncolor;
                // left 
                PaintColor(screen, x - 1, y, ocolor, ncolor);
                //right
                PaintColor(screen, x + 1, y, ocolor, ncolor);
                //upper
                PaintColor(screen, x, y - 1, ocolor, ncolor);
                //down
                PaintColor(screen, x, y + 1, ocolor, ncolor);

            }

            return true;
        }


        public bool PaintColor(Color[,] screen, int x, int y, Color ncolor)
        {
            if (screen[x, y] == ncolor)
            {
                return false;
            }
            else
            {
                return PaintColor(screen, x, y, ncolor);
            }

        }



        #endregion

        #region 9.8

        // Given an infinite number of quarters (25 cents), dimes (10 cents), nickels (5 cents)
        // and pennies (1 cent), write code to calculate the number of ways of representing n
        // cents

        // we need make sure what is the first one( 25, 10,5 or 1) 

        public int makeChange(int n, int denom)
        {
            int next_denom = 0;

            switch (denom)
            {
                case 25:
                    next_denom = 10;
                    break;
                case 10:
                    next_denom = 5;
                    break;
                case 5:
                    next_denom = 1;
                    break;
                case 1:
                    return 1;
            }

            int ways = 0;
            for (int i = 0; i * denom <= n; i++)
            {
                ways += makeChange(n - i * denom, next_denom);
                Console.WriteLine(denom.ToString());

            }
            return ways;
        }


        #endregion

        #region 9.9

        //  Write an algorithm to prim all ways of arranging eight queens on an 8x8 chess
        //board so that none of them share the same row, column or diagonal. In this case,
        //"diagonal" means all diagonals, not just the two that bisect the board.


      

        public void PlaceQueens(int grid_size, int row, int[] columns,ref ArrayList results)
        {
            if (row == grid_size)
            {
                results.Add(columns.Clone());  
            }
            else 
            { // Found valid placement
               
                for (int col = 0; col < grid_size; col++)
                {
                    if (checkValid(columns, row, col))
                    { 
                        columns[row] = col; // Place queen
                        PlaceQueens(grid_size,row + 1,columns,ref results);
                    }
                }
            }

            
        }

        /* Check if (rowl, columnl) is a valid spot for a queen by checking
        * if there is a queen in the same column or diagonal. We don't
        * need to check it for queens in the same row because the calling
        * placeQueen only attempts to place one queen at a time. We know
        * this row is empty. */
        private bool checkValid(int[] columns, int row1, int column1)
        {
            for (int row2 = 0; row2 < row1; row2++)
            {
                int column2 = columns[row2];
                /* Check if (row2, column2) invalidates (rowl, columnl) as a queen spot. */

                /* Check if rows have a queen in the same column */
                if (column1 == column2)
                {
                    return false;
                }  

                /* Check diagonals: if the distance between the columns equals the distance between the rows, then they're in the
                same diagonal. */
                int columnDistance = Math.Abs(column2 - column1);

                /* rowl > row2, so no need for abs */
                int rowDistance = row1 - row2;
                if (columnDistance == rowDistance)
                {
                    return false;
                } // end if 
            }// end for
            return true;

        }

        #endregion

    }
}

