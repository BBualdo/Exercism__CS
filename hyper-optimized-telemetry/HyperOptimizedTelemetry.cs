using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        var buffer = new byte[9];
        if (reading >= ushort.MinValue && reading <= ushort.MaxValue)
        {
            buffer[0] = 2;
            BitConverter.GetBytes((ushort)reading).CopyTo(buffer, 1); 
        } else if (reading >= short.MinValue && reading <= short.MaxValue)
        {
            buffer[0] = 256 - 2;
            BitConverter.GetBytes((short)reading).CopyTo(buffer, 1);
        } else if (reading >= int.MinValue && reading <= int.MaxValue)
        {
            buffer[0] = 256 - 4;
            BitConverter.GetBytes((int)reading).CopyTo(buffer, 1);
        } else if (reading >= uint.MinValue && reading <= uint.MaxValue)
        {
            buffer[0] = 4;
            BitConverter.GetBytes((uint)reading).CopyTo(buffer, 1);
        } 
        else
        {
            buffer[0] = 256 - 8;
            BitConverter.GetBytes(reading).CopyTo(buffer, 1);
        }

        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        var prefix = buffer[0];

        if (prefix == 2) return BitConverter.ToUInt16(buffer, 1);
        if (prefix == 256 - 2) return BitConverter.ToInt16(buffer, 1);
        if (prefix == 4) return BitConverter.ToUInt32(buffer, 1);
        if (prefix == 256 - 4) return BitConverter.ToInt32(buffer, 1);
        if (prefix == 256 - 8) return BitConverter.ToInt64(buffer, 1);
        return 0;
    }
}
