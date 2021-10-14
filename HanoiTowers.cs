using System;
using System.Collections.Generic;

namespace TowersOfHanoiEnumerator
{
    /// <summary>
    /// Static class TowerOfHanoi.
    /// </summary>
    public static class HanoiTowers
    {
        public static IEnumerable<(Tower from, Tower to)>GetMoves(int disks)
        {
            if (disks < 1 || disks > 30)
            {
                throw new ArgumentException("Count if disks should me more than 0 and less or equal 30");
            }

            return GetMovesRecursive(disks, Tower.From, Tower.Buffer, Tower.To);
        }

        private static IEnumerable<(Tower from, Tower to)> GetMovesRecursive(int disks, Tower from, Tower buffer, Tower to)
        {
            if (disks == 1)
            {
                yield return (from, to);
                yield break;
            }

            foreach (var a in GetMovesRecursive(disks - 1, from, to, buffer))
            {
                yield return a;
            }

            yield return (from, to);
            foreach (var a in GetMovesRecursive(disks - 1, buffer, from, to))
            {
                yield return a;
            }
        }
    }
}
