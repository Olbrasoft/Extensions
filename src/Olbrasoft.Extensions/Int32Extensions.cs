namespace Olbrasoft.Extensions;

public static class Int32Extensions
{
    public static int ParseOrZero(string sut)
    {
        _ = int.TryParse(sut, out int result);

        return result;
    }
}