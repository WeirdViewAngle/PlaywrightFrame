namespace PlaywriteFramework.Utils.Enums
{    
    public class EnumProvider<T> where T : Enum
    {
        public static IEnumerable<T> GetEnum()
        {
            foreach (T variant in Enum.GetValues(typeof(T)))
            {
                yield return variant;
            }
        }
    }

    public class EnumProvider<T, E> where T : Enum where E : Enum
    {
        public static IEnumerable<TestCaseData> GetEnum()
        {
            foreach (T t in Enum.GetValues(typeof(T)))
            {
                foreach (E e in Enum.GetValues(typeof(E)))
                {
                    yield return new TestCaseData(t, e);
                }
            }
        }
    }
}
