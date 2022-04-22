using UnityEngine;

namespace Bits
{
    /// <summary>
    /// byte 位运算 可存储8位
    /// </summary>
    public static partial class BitsOperation
    {
        public const int ByteBitsSize = sizeof(byte) * 8;

        /// <summary>
        /// 设置内容
        /// </summary>
        /// <param name="map"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static byte Choose(byte map, int index)
        {
            if (index < 0 || index > ByteBitsSize)
            {
                Debug.LogErrorFormat("BitsOperation.Choose ,error 越界 map:{0} index:{1}", map, index);
                return map;
            }

            map |= (byte) (1 << index);
            return map;
        }

        /// <summary>
        /// 取消设置内容
        /// </summary>
        /// <param name="map"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static byte UnChoose(byte map, int index)
        {
            if (index < 0 || index > ByteBitsSize)
            {
                Debug.LogErrorFormat("BitsOperation.UnChoose ,error 越界 map:{0} index:{1}", map, index);
                return map;
            }


            map &= (byte) ~(1 << index);
            return map;
        }

        /// <summary>
        /// 是否已经被设置内容
        /// </summary>
        /// <param name="map"></param>
        /// <param name="index"></param>
        /// <returns>true=已占用 false没有被占用</returns>
        public static bool IsChoose(byte map, int index)
        {
            if (index < 0 || index > ByteBitsSize)
            {
                Debug.LogErrorFormat("BitsOperation.IsChoose ,error 越界 map:{0} index:{1}", map, index);
                return true;
            }

            int isHave = map & (byte) (1 << index);
            return isHave != 0;
        }
    }
}