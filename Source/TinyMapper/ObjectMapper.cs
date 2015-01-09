﻿using TinyMapper.Builders;

namespace TinyMapper
{
    internal sealed class ObjectMapper
    {
        public static void CreateMapper<TSource, TTarget>()
        {
            IDynamicAssembly assembly = DynamicAssemblyBuilder.Get();
            TargetTypeBuilder targetTypeBuilder = assembly.GetTypeBuilder();
            targetTypeBuilder.Build(typeof(TSource), typeof(TTarget));

            assembly.Save();
        }
    }
}
