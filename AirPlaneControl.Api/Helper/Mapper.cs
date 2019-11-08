using System;
using AutoMapper;

namespace AirPlaneControl.Api.Helper
{
    public static class Mapper
    {
        public static TDestination Map<TDestination>(object source)
        {
            return Mapper.Map<TDestination>(source);
        }

        public static TDestination Map<TSource, TDestination>(TSource source)
        {
            return Map<TSource, TDestination>(source);
        }

        public static TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return Mapper.Map<TSource, TDestination>(source, destination);
        }

        public static void Initialize(Action<IMapperConfigurationExpression> action)
        {
            Mapper.Initialize(action);
        }
    }
}
