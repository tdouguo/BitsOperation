using System;
using UnityEngine;

namespace Bits
{
    /// <summary>
    /// short | Int16 位运算 2个字节 1个字节8位 理论存储2*8=16
    ///     因最后一位运算会超出最大值 所以只能存储最大-1
    /// </summary>
    public static partial class BitsOperation
    {
        public const int ShortBitsSize = sizeof(short) * 8 - 1;

        /// <summary>
        /// 设置内容
        /// </summary>
        /// <param name="map"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static short Choose(short map, int index)
        {
            if (index < 0 || index >= ShortBitsSize)
            {
                Debug.LogErrorFormat("BitsOperation.Choose ,error 越界 map:{0} index:{1}", map, index);
                return map;
            }

            map |= (short) (1 << index);
            return map;
        }

        /// <summary>
        /// 取消设置内容
        /// </summary>
        /// <param name="map"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static short UnChoose(short map, int index)
        {
            if (index < 0 || index >= ShortBitsSize)
            {
                Debug.LogErrorFormat("BitsOperation.Choose ,error 越界 map:{0} index:{1}", map, index);
                return map;
            }

            map &= (short) ~(1 << index);
            return map;
        }

        /// <summary>
        /// 是否已经被设置内容
        /// </summary>
        /// <param name="map"></param>
        /// <param name="index"></param>
        /// <returns>true=已占用 false没有被占用</returns>
        public static bool IsChoose(short map, int index)
        {
            if (index < 0 || index >= ShortBitsSize)
            {
                Debug.LogErrorFormat("BitsOperation.Choose ,error 越界 map:{0} index:{1}", map, index);
                return true;
            }

            int isHave = map & (short) (1 << index);
            return isHave != 0;
        }
    }
}