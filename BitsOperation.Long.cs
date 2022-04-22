using UnityEngine;

namespace Bits
{
    /// <summary>
    /// long | Int64 位运算 8个字节 1个字节8位 理论存储8*8=64
    ///     因最后一位运算会超出最大值 所以只能存储最大-1
    /// </summary>
    public static partial class BitsOperation
    {
        public const int LongBitsSize = sizeof(long) * 8 - 1;

        /// <summary>
        /// 设置内容
        /// </summary>
        /// <param name="map"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static long Choose(long map, int index)
        {
            if (index < 0 || index >= LongBitsSize)
            {
                Debug.LogErrorFormat("BitsOperation.Choose ,error 越界 map:{0} index:{1}", map, index);
                return map;
            }

            map |= (1L << index);
            return map;
        }

        /// <summary>
        /// 取消设置内容
        /// </summary>
        /// <param name="map"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static long UnChoose(long map, int index)
        {
            if (index < 0 || index >= LongBitsSize)
            {
                Debug.LogErrorFormat("BitsOperation.UnChoose ,error 越界 map:{0} index:{1}", map, index);
                return map;
            }

            map &= ~(1L << index);
            return map;
        }

        /// <summary>
        /// 是否已经被设置内容
        /// </summary>
        /// <param name="map"></param>
        /// <param name="index"></param>
        /// <returns>true=已占用 false没有被占用</returns>
        public static bool IsChoose(long map, int index)
        {
            if (index < 0 || index >= LongBitsSize)
            {
                Debug.LogErrorFormat("BitsOperation.IsChoose ,error 越界 map:{0} index:{1}", map, index);
                return true;
            }

            long isHave = map & (1L << index);
            return isHave != 0;
        }
    }
}