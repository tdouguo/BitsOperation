namespace Bits
{
    public static partial class BitsOperation
    {
        /// <summary>
        /// 转换x,y 到一维内索引下标, 按照矩形的宽
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int ConvertPos2Index(int width, int height, int x, int y)
        {
            int value = -1;
            if (x < 0 || y < 0 || x >= width || y >= height)
                value = -1;
            else
            {
                value = y * width + x;
            }

            return value;
        }

        /// <summary>
        /// 转换索引
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="index"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void ConvertIndex2Pos(int width, int height, int index, out int x, out int y)
        {
            if (index < 0 || index > width * height)
            {
                x = -1;
                y = -1;
            }
            else
            {
                x = index % width;
                y = index / height;
            }
        }
    }
}