using UnityEngine;

namespace Bits
{
    public class Test
    {
        public void TestLong()
        {
            Debug.LogFormat("LongBitsSize :{0}", BitsOperation.LongBitsSize);

            long LongRect = 0;
            for (int i = 0; i < BitsOperation.LongBitsSize; i++)
            {
                bool isChoose = BitsOperation.IsChoose(LongRect, i);
                LongRect = BitsOperation.Choose(LongRect, i);
                bool isChoose2 = BitsOperation.IsChoose(LongRect, i);
                Debug.LogFormat("i:{0} , LongRect:{1}  {2} {3} ", i, LongRect, isChoose, isChoose2);
            }

            for (int i = BitsOperation.LongBitsSize - 1; i >= 0; i--)
            {
                bool isChoose = BitsOperation.IsChoose(LongRect, i);
                LongRect = BitsOperation.UnChoose(LongRect, i);
                bool isChoose2 = BitsOperation.IsChoose(LongRect, i);
                Debug.LogFormat("i:{0} , LongRect:{1}  {2} {3} ", i, LongRect, isChoose, isChoose2);
            }
        }

        public void TestInt()
        {
            Debug.LogFormat("IntBitsSize :{0}", BitsOperation.IntBitsSize);

            int IntRect = 0;
            for (int i = 0; i < BitsOperation.IntBitsSize; i++)
            {
                bool isChoose = BitsOperation.IsChoose(IntRect, i);
                IntRect = BitsOperation.Choose(IntRect, i);
                bool isChoose2 = BitsOperation.IsChoose(IntRect, i);
                Debug.LogFormat("i:{0} , IntRect:{1}  {2} {3} ", i, IntRect, isChoose, isChoose2);
            }

            for (int i = BitsOperation.IntBitsSize - 1; i >= 0; i--)
            {
                bool isChoose = BitsOperation.IsChoose(IntRect, i);
                IntRect = BitsOperation.UnChoose(IntRect, i);
                bool isChoose2 = BitsOperation.IsChoose(IntRect, i);
                Debug.LogFormat("i:{0} , IntRect:{1}  {2} {3} ", i, IntRect, isChoose, isChoose2);
            }
        }

        public void TestShort()
        {
            Debug.LogFormat("ShortBitsSize :{0}", BitsOperation.ShortBitsSize);

            short ShortRect = 0;
            for (int i = 0; i < BitsOperation.ShortBitsSize; i++)
            {
                bool isChoose = BitsOperation.IsChoose(ShortRect, i);
                ShortRect = BitsOperation.Choose(ShortRect, i);
                bool isChoose2 = BitsOperation.IsChoose(ShortRect, i);
                Debug.LogFormat("i:{0} , ShortRect:{1}  {2} {3} ", i, ShortRect, isChoose, isChoose2);
            }

            for (int i = BitsOperation.ShortBitsSize - 1; i >= 0; i--)
            {
                bool isChoose = BitsOperation.IsChoose(ShortRect, i);
                ShortRect = BitsOperation.UnChoose(ShortRect, i);
                bool isChoose2 = BitsOperation.IsChoose(ShortRect, i);
                Debug.LogFormat("i:{0} , IntRect:{1}  {2} {3} ", i, ShortRect, isChoose, isChoose2);
            }
        }

        public void TestByte()
        {
            Debug.LogFormat("ByteBitsSize :{0}", BitsOperation.ByteBitsSize);
            byte ByteRect = 0;
            for (int i = 0; i < BitsOperation.ByteBitsSize; i++)
            {
                bool isChoose = BitsOperation.IsChoose(ByteRect, i);
                ByteRect = BitsOperation.Choose(ByteRect, i);
                bool isChoose2 = BitsOperation.IsChoose(ByteRect, i);
                Debug.LogFormat("i:{0} , ByteRect:{1}  {2} {3} ", i, ByteRect, isChoose, isChoose2);
            }

            for (int i = BitsOperation.ByteBitsSize - 1; i >= 0; i--)
            {
                bool isChoose = BitsOperation.IsChoose(ByteRect, i);
                ByteRect = BitsOperation.UnChoose(ByteRect, i);
                bool isChoose2 = BitsOperation.IsChoose(ByteRect, i);
                Debug.LogFormat("i:{0} , ByteRect:{1}  {2} {3} ", i, ByteRect, isChoose, isChoose2);
            }
        }
    }
}