﻿namespace Arclight.Shared.Command.Convert
{
    public interface ICommandParameterConverter
    {
        bool TryConvert(string parameter, out object result);
    }
}
